using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSalesmanGA
{
    class GeneticAlgorithm : PathSelection
    {
        private List<string> Population;
        private List<double> Fitness;
        private const int PopulationSize = 6;
        private const double MutationProb = 0.20;
        private List<int[]> SwapList;
        private HashSet<string> possibleVals = new HashSet<string> {
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        private int FittestIndex;
        private int SecondFittestIndex;
        public GeneticAlgorithm() : base()
        {
            this.MethodName = "Genetic Algorithm";
            this.MethodID = 2;
            Population = new List<string>();
            Fitness = new List<double>();
            TotalPathsFound = PopulationSize;
            GenerateSwaps();
        }

        private void GenerateSwaps()
        {
            int[] possibleIndices = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Combinations<int> possibleSwaps = new Combinations<int>(possibleIndices, 2);
            List<int[]> masterSwapList = new List<int[]>();
            foreach (int[] combination in possibleSwaps)
            {
                masterSwapList.Add(combination);
            }

            SwapList = masterSwapList.ToList();
        }

        public void SelectInitialParents(DataSet ds)
        {
            for (int i = 0; i < PopulationSize; i++)
            {
                string RandomPath = ReturnRandomPath();
                Population.Add(RandomPath);
                Fitness.Add(ds.PathLength(RandomPath));
            }
        }

        public double FitnessFunction(DataSet ds, string path)
        {
            return ds.PathLength(path);
        }


        
        public void Crossover(string Parent1, string Parent2, ref string Child1, ref string Child2)
        {
            int length = Parent1.Length;
            if (Parent1.Length != Parent2.Length)
            {
                throw new Exception("Length of parents does not match");
            }
            // Generate random crossover point
            int CrossoverPoint = rnd.Next(0, length + 1);

            char[] p1_char = Parent1.ToCharArray();
            char[] p2_char = Parent2.ToCharArray();
            char[] p1_copy = Parent1.ToCharArray();
            char[] p2_copy = Parent2.ToCharArray();
            char tmp;

            HashSet<char> remaining_vals_p1 = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            HashSet<char> remaining_vals_p2 = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < CrossoverPoint; i++)
            {
                // Get ith character of second parent, put in p1.
                tmp = p2_char[i];
                p1_char[i] = tmp;
                remaining_vals_p1.Remove(tmp);

                // Get ith character of first parent, put in p2[i]
                tmp = p1_copy[i];
                p2_char[i] = tmp;
                remaining_vals_p2.Remove(tmp);
            }
            int j = CrossoverPoint;
            int z = CrossoverPoint;

            // Handle p1
            while (j < Parent1.Length)
            {
                tmp = p1_char[j];
                // Do the rest of the string, using hashset and other parent (check back when brain works)
                if (remaining_vals_p1.Contains(tmp))
                {
                    p1_char[z] = tmp;
                    remaining_vals_p1.Remove(tmp);
                    z++;
                    j++;
                } else
                {
                    j++;
                }
            }
            // At this point we just randomly toss in remaining values
            
            while (remaining_vals_p1.Count != 0 && z < Parent1.Length)
            {
                int next_idx = rnd.Next(remaining_vals_p1.Count);
                var next_val = remaining_vals_p1.ElementAt(next_idx);
                p1_char[z] = next_val;
                remaining_vals_p1.Remove(next_val);
                z++;
            }

            // Handle p2:
            j = CrossoverPoint;
            z = CrossoverPoint;
            while (j < Parent2.Length)
            {
                tmp = p2_char[j];
                if (remaining_vals_p2.Contains(tmp))
                {
                    p2_char[z] = tmp;
                    remaining_vals_p2.Remove(tmp);
                    z++;
                    j++;
                } else
                {
                    j++;
                }
            }

            // At this point we just randomly toss in remaining values

            while (remaining_vals_p2.Count != 0 && z < Parent2.Length)
            {
                int next_idx = rnd.Next(remaining_vals_p2.Count);
                var next_val = remaining_vals_p2.ElementAt(next_idx);
                p2_char[z] = next_val;
                remaining_vals_p1.Remove(next_val);
                z++;
            }

            Child1 = String.Join("", p1_char);
            Child2 = String.Join("", p2_char);
        }

        public void Mutation(ref string child)
        {
            double probMut = rnd.NextDouble();

            if (probMut <= MutationProb)
            {
                int idx = rnd.Next(SwapList.Count);
                int idx1 = SwapList[idx][0];
                int idx2 = SwapList[idx][1];
                Swap(ref child, idx1, idx2);
            }
        }


        public void Selection(ref string p1, ref string p2)
        {
            // Select parents with minimum path length
            // Currently uses a lot of overhead, should look into alternative datastructure
            // Yeah this is really hacky. I blame my current lack of sleep.
            FittestIndex = Fitness.IndexOf(Fitness.Min());
            double fitness_p1 = Fitness[FittestIndex];
            Fitness[FittestIndex] = double.MaxValue;
            SecondFittestIndex = Fitness.IndexOf(Fitness.Min());
            double fitness_p2 = Fitness[SecondFittestIndex];
            Fitness[FittestIndex] = fitness_p1;

            Fitness[SecondFittestIndex] = fitness_p2;

            p1 = Population[FittestIndex];
            p2 = Population[SecondFittestIndex];

        }

        public void FindShortestPath(DataManager data)
        {
            DataSet DS = data.GetCurrentDataSet();

            // Generation Counter:
            int generationCount = 0;
            // Create 4 Random Parents initially
            // Evaluate their fitness using path length
            SelectInitialParents(DS);
            string parent1 = "";
            string parent2 = "";
            string child1 = "";
            string child2 = "";
            while (generationCount < 10000)
            {
                TotalPathsFound += 2;
                // Select the two best fit parents (minimum path length)
                Selection(ref parent1, ref parent2);

                // Mate two best parents using crossover
                Crossover(parent1, parent2, ref child1, ref child2);

                // Perform random mutation on children
                Mutation(ref child1);
                Mutation(ref child2);

                // Child 1 and Child 2 are our additions to population.
                double child1_fitness = FitnessFunction(DS, child1);
                double child2_fitness = FitnessFunction(DS, child2);

                // Add child1 and child2 to Population and Fitness
                Population.Add(child1);
                Fitness.Add(child1_fitness);

                Population.Add(child2);
                Fitness.Add(child2_fitness);

                // Find two worst, remove
                int LeastFitIndex = Fitness.IndexOf(Fitness.Max());

                // Remove worst in population
                Fitness.RemoveAt(LeastFitIndex);
                Population.RemoveAt(LeastFitIndex);

                // Do it again to remove second worst in population
                LeastFitIndex = Fitness.IndexOf(Fitness.Max());
                Fitness.RemoveAt(LeastFitIndex);
                Population.RemoveAt(LeastFitIndex);

                // Repeat for x generations or until converges
                generationCount++;
            }

            // Get best:
            Selection(ref parent1, ref parent2);
            ShortestDistance = Fitness[FittestIndex];
            shortest_path_storage = Population[FittestIndex];

            ShortestPath = ReturnShortestPathString();
        }
    }
}
