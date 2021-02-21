using System;
using System.Collections.Generic;

namespace TravelingSalesmanGA
{
	public class DataSet
	{
		public int ID { get; }
		public string Name { get; }
		public int Length { get; }
		public List<List<double>> DistanceMatrix = new List<List<double>>();
		public List<Coordinate> Coordinates = new List<Coordinate>();


		public DataSet(int ID, string Name, int Length, List<Coordinate> GivenCoords)
		{
			this.ID = ID;
			this.Length = Length;
			this.Name = Name;
			this.Coordinates = GivenCoords;

			for (int i = 0; i < this.Length; i++)
			{
				DistanceMatrix.Add(new List<double> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
			}

            // Populate Distance Matrix:
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
					DistanceMatrix[i][j] = Coordinates[i].GetDistanceFrom(Coordinates[j]);
                }
            }

		}

		public double PathLength(string curPath)
        {
			double pathWeight = 0;
            for (int i = 0; i < curPath.Length - 1; i++)
            {
				pathWeight += DistanceMatrix[curPath[i] - '0'][curPath[i + 1] - '0'];
            }
			return pathWeight;
        }
	}
}

