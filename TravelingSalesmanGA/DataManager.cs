using System;
using System.Collections.Generic;

namespace TravelingSalesmanGA
{
	public class DataManager
	{
		public int Length { get; }
		public int CurrentDataSetID { get; set; }
		public List<DataSet> DataSetList = new List<DataSet>();

		public List<List<Coordinate>> CoordList = new List<List<Coordinate>>();
		public DataSet DataSet1, DataSet2, DataSet3;
		
		public List<Coordinate> DS1Points = new List<Coordinate>();
		public List<Coordinate> DS2Points = new List<Coordinate>();
		public List<Coordinate> DS3Points = new List<Coordinate>();

        public DataSet GetCurrentDataSet()
        {
            if (CurrentDataSetID == 0)
            {
                return DataSet1;
            }
            else if (CurrentDataSetID == 1)
            {
                return DataSet2;
            }
            else if (CurrentDataSetID == 2)
            {
                return DataSet3;
            }
            else
            {
                throw new IndexOutOfRangeException("CurrentDataSet GET FAILED...");
            }
        }


        private void add_ds1()
        {
			DS1Points.Add(new Coordinate(834, 707));
			DS1Points.Add(new Coordinate(843, 626));
			DS1Points.Add(new Coordinate(140, 733));
			DS1Points.Add(new Coordinate(109, 723));
			DS1Points.Add(new Coordinate(600, 747));
			DS1Points.Add(new Coordinate(341,  94));
			DS1Points.Add(new Coordinate(657, 197));
			DS1Points.Add(new Coordinate(842, 123));
			DS1Points.Add(new Coordinate(531, 194));
			DS1Points.Add(new Coordinate(286, 336));
        }

		private void add_ds2()
		{
            DS2Points.Add(new Coordinate(8, 377));
			DS2Points.Add(new Coordinate(450, 352));
			DS2Points.Add(new Coordinate(519, 290));
			DS2Points.Add(new Coordinate(398, 604));
			DS2Points.Add(new Coordinate(417, 496));
			DS2Points.Add(new Coordinate(57, 607 ));
			DS2Points.Add(new Coordinate(119, 4  ));
			DS2Points.Add(new Coordinate(166, 663));
			DS2Points.Add(new Coordinate(280, 622));
			DS2Points.Add(new Coordinate(531, 571));
		}

		private void add_ds3()
		{
            DS3Points.Add(new Coordinate(518, 995));
			DS3Points.Add(new Coordinate(590, 935));
			DS3Points.Add(new Coordinate(600, 985));
			DS3Points.Add(new Coordinate(151, 225));
			DS3Points.Add(new Coordinate(168, 657));
			DS3Points.Add(new Coordinate(202, 454));
			DS3Points.Add(new Coordinate(310, 717));
			DS3Points.Add(new Coordinate(425, 802));
			DS3Points.Add(new Coordinate(480, 940));
			DS3Points.Add(new Coordinate(300, 1035));
		}
		
		public void SelectDS(int index)
        {
            if (index >= Length)
            {
				throw new IndexOutOfRangeException("Don't have that many data sets");
            }
            else if (index != CurrentDataSetID)
            {
				CurrentDataSetID = index;
			}

        }
		public List<Coordinate> GetDSPoints()
        {
            switch (CurrentDataSetID)
            {
				case -1:
					return null;
				case 0:
					return DS1Points;
				case 1:
					return DS2Points;
				case 2:
					return DS3Points;
                default:
					return null;
            }
        }

		public DataManager()
		{
			CurrentDataSetID = -1;

			this.Length = 3;
			add_ds1();
			DataSet1 = new DataSet(1, "DS1", 10, DS1Points);
			add_ds2();
			DataSet2 = new DataSet(2, "DS2", 10, DS2Points);
			add_ds3();
			DataSet3 = new DataSet(3, "DS3", 10, DS3Points);

			DataSetList.Add(DataSet1);
			DataSetList.Add(DataSet2);
			DataSetList.Add(DataSet3);
		}
	}
}

