using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSalesmanGA
{
    public class BruteForce : PathSelection
    {
        /**
         * 
         * public string MethodName;
        public int MethodID;
        public int TotalPathsFound;
        private string shortest_path_storage;
        public double ShortestDistance;
        public string ShortestPath;
        public List<string> PathsList = new List<string>();

        private Random rnd = new Random();
         * */
        public BruteForce() : base()
        {
            this.MethodName = "Brute Force";
            this.MethodID = 0;
        }

        public void FindShortestPath(DataManager data)
        {
            DataSet DataSet = data.GetCurrentDataSet();
            foreach (string path in PathsList)
            {
                TotalPathsFound += 1;
                double GivenLength = DataSet.PathLength(path);
                if (GivenLength <= ShortestDistance)
                {
                    ShortestDistance = GivenLength;
                    shortest_path_storage = path;
                }
            }
            ShortestPath = ReturnShortestPathString();
        }
    }
}
