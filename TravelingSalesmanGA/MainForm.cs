using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TravelingSalesmanGA
{
    public partial class MainForm : Form
    {
        public DataManager DataSetManager = new DataManager();

        public MainForm()
        {
            InitializeComponent();
            this.chartDisplayPoints.Series.Add("Shortest Path");
        }

        // Update List Box With Our New Points
        private void UpdateListBox(int index)
        {
            listBoxPointsKey.Items.Clear();
            listBoxPointsKey.BeginUpdate();
            var chars = new string[] {"A:\t", "B:\t", "C:\t", "D:\t", "E:\t",
                          "F:\t", "G:\t", "H:\t", "I:\t", "J:\t"};
            var currentDataSet = DataSetManager.GetDSPoints();
            foreach (var cp in currentDataSet.Zip(chars, Tuple.Create))
            {
                listBoxPointsKey.Items.Add(cp.Item2.ToString() + cp.Item1);
            }

            listBoxPointsKey.EndUpdate();
        }

        // Select Data Set 1 and Update Key Box
        private void buttonDS1_Click(object sender, EventArgs e)
        {
            
            DataSetManager.SelectDS(0);
            UpdateChart();
            UpdateListBox(0);
        }

        // Select Data Set 2 and Update Key Box
        private void buttonDS2_Click(object sender, EventArgs e)
        {
            DataSetManager.SelectDS(1);
            UpdateChart();
            UpdateListBox(1);
        }

        // Select DataSet3 and Update Key Box
        private void buttonDS3_Click(object sender, EventArgs e)
        {
            DataSetManager.SelectDS(2);
            UpdateChart();
            UpdateListBox(2);
        }




        private void buttonBruteForce_Click(object sender, EventArgs e)
        {
            if (DataSetManager.CurrentDataSetID != -1)
            {
                BruteForce BF = new BruteForce();
                BF.FindShortestPath(DataSetManager);

                DrawPath(BF.shortest_path_storage);
                labelMethod.Text = "Method: Brute Force";
                labelShortestPathValue.Text = BF.ShortestPath;
                labelShortestDistanceValue.Text = BF.ShortestDistance.ToString();
                labelTotalPathsFoundVal.Text = BF.TotalPathsFound.ToString();
                groupBoxResults.Update();
            }
        }

        private void buttonSimulatingAnnealing_Click(object sender, EventArgs e)
        {
            if (DataSetManager.CurrentDataSetID != -1)
            {
                SimulatedAnnealing SA = new SimulatedAnnealing();
                SA.FindShortestPath(DataSetManager);

                DrawPath(SA.shortest_path_storage);

                labelMethod.Text = "Method: Simulated Annealing";
                labelShortestPathValue.Text = SA.ShortestPath;
                labelShortestDistanceValue.Text = SA.ShortestDistance.ToString();
                labelTotalPathsFoundVal.Text = SA.TotalPathsFound.ToString();
                groupBoxResults.Update();
            }
        }


        private void buttonGeneticAlgorithms_Click(object sender, EventArgs e)
        {
            if (DataSetManager.CurrentDataSetID != -1)
            {
                GeneticAlgorithm GA = new GeneticAlgorithm();
                GA.FindShortestPath(DataSetManager);

                DrawPath(GA.shortest_path_storage);
                labelMethod.Text = "Method: Genetic Algorithm";
                labelShortestPathValue.Text = GA.ShortestPath;
                labelShortestDistanceValue.Text = GA.ShortestDistance.ToString();
                labelTotalPathsFoundVal.Text = GA.TotalPathsFound.ToString();
                groupBoxResults.Update();
            }
        }

        private void UpdateChart()
        {
            this.chartDisplayPoints.Series["Shortest Path"].Points.Clear();
            this.chartDisplayPoints.Series["DataSet"].Points.Clear();
            var currentDataSet = DataSetManager.GetDSPoints();
            int i = 0;
            var chars = new string[] {"A", "B", "C", "D", "E",
                          "F", "G", "H", "I", "J"};
            foreach (var item in currentDataSet)
            {
                int idx = chartDisplayPoints.Series["DataSet"].Points.AddXY(item.x, item.y);
                chartDisplayPoints.Series["DataSet"].Points[idx].Label = chars[i++];
            }
            

        }

        private void DrawPath(string path)
        {

            this.chartDisplayPoints.Series["Shortest Path"].Points.Clear();

            var curDS = DataSetManager.GetDSPoints();

            char[] pathArr = path.ToCharArray();
            for (int i = 0; i < pathArr.Length; i++)
            {
                int cur_idx = (int)(pathArr[i] - '0');
                int x_val = curDS[cur_idx].x;
                int y_val = curDS[cur_idx].y;
                this.chartDisplayPoints.Series["Shortest Path"].Points.Add(new DataPoint(x_val, y_val));
            }
            this.chartDisplayPoints.Series["Shortest Path"].ChartType = SeriesChartType.Line;
            
        }
    }
}
