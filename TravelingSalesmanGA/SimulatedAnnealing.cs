using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSalesmanGA
{
    class SimulatedAnnealing : PathSelection
    {
        const double InitTemp = 1000;
        const double MinTemp = 0.1;
        const double DELTA = 0.90;
        private double _temp = InitTemp;
        private int _numMutations = 0;
        private int _numPathsAccepted = 0;
        private int _iterations = 0;

        public List<int[]> SwapList;
        private List<int[]> MasterSwapList;

        public SimulatedAnnealing() : base()
        {
            this.MethodName = "Simulated Annealing";
            this.MethodID = 1;
            this.SwapList = new List<int[]>();
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
            MasterSwapList = masterSwapList.ToList();
        }

        public void FindShortestPath(DataManager data)
        {
            GenerateSwaps();
            DataSet DataSet = data.GetCurrentDataSet();

            // Select Random Initial Path
            string initialPath = ReturnRandomPath();

            // Get Weight of starting Path:
            double initialPathWeight = DataSet.PathLength(initialPath);
            string OldPath = initialPath;
            double OldPathLength = initialPathWeight;

            while (_temp > MinTemp && SwapList.Count > 0)
            {
                bool UpdatedPath = false;
                string NewPath = OldPath;

                int idx = rnd.Next(SwapList.Count);
                int idx1 = SwapList[idx][0];
                int idx2 = SwapList[idx][1];
                SwapList.RemoveAt(idx);

                Swap(ref NewPath, idx1, idx2);

                double NewPathLength = DataSet.PathLength(NewPath);
                double EProb = Math.Exp(-(NewPathLength - OldPathLength) / _temp);

                if (EProb >= 1) 
                {
                    UpdatedPath = true;
                }
                else
                {
                    double RandEProb = rnd.NextDouble();
                    if (EProb >= RandEProb)
                    {
                        UpdatedPath = true;
                        _numMutations++;
                    }
                }

                if (UpdatedPath)
                {
                    OldPathLength = NewPathLength;
                    OldPath = NewPath;
                    _temp *= DELTA;

                    SwapList = MasterSwapList;
                    _numPathsAccepted++;
                }
                _iterations++;
            }

            // Now have result
            shortest_path_storage = OldPath;
            ShortestPath = ReturnShortestPathString();
            ShortestDistance = OldPathLength;
            TotalPathsFound = _numPathsAccepted;
        }
    }
}
