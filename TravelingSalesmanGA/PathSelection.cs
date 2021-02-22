using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PermHelper;

namespace TravelingSalesmanGA
{
    public class PathSelection
    {
        public string MethodName;
        public int MethodID;
        public int TotalPathsFound;
        public string shortest_path_storage;
        public double ShortestDistance;
        public string ShortestPath;
        public List<string> PathsList = new List<string>();

        public Random rnd;


        public PathSelection()
        {
            this.rnd = new Random();
            this.TotalPathsFound = 0;
            this.ShortestDistance = double.MaxValue;
            this.ShortestPath = "";
            this.shortest_path_storage = "";
            GeneratePaths();
        }

        // TODO: Improve this to work for any number of data points
        // TODO: Fix to only remove mirrored paths
        public void GeneratePaths()
        {
            string[] items = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            foreach (string[] permutation in Permutation.GetPermutations<string>(items))
            {
                PathsList.Add(String.Join("", permutation));
            }
            PathsList = PathsList.OrderBy(a => Guid.NewGuid()).ToList();
        }

        public string ReturnRandomPath()
        {
            int index = rnd.Next(PathsList.Count);
            return PathsList[index];
        }

        public string ReturnShortestPathString()
        {
            char[] result_shortest = { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A' };
            for (int i = 0; i < 10; i++)
            {
                result_shortest[i] = (char)(shortest_path_storage[i] + 0x11);
            }
            return String.Join("", result_shortest);
        }

        // Swap two characters in a string
        public static void Swap(ref string toSwap, int index1, int index2)
        {
            if (index1 > toSwap.Length || index2 > toSwap.Length)
            {
                throw new IndexOutOfRangeException("Swap indices incorrect");
            }
            char[] characters = toSwap.ToCharArray();
            char i1CharTemp = characters[index1];
            characters[index1] = characters[index2];
            characters[index2] = i1CharTemp;
            toSwap = String.Join("", characters);
        }

    }
}
