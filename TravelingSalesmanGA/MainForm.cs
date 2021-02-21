using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelingSalesmanGA
{
    public partial class MainForm : Form
    {
        public DataManager DataSetManager = new DataManager();

        public MainForm()
        {
            InitializeComponent();
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
            UpdateListBox(0);
        }

        // Select Data Set 2 and Update Key Box
        private void buttonDS2_Click(object sender, EventArgs e)
        {
            DataSetManager.SelectDS(1);
            UpdateListBox(1);
        }

        // Select DataSet3 and Update Key Box
        private void buttonDS3_Click(object sender, EventArgs e)
        {
            DataSetManager.SelectDS(2);
            UpdateListBox(2);
        }




        private void buttonBruteForce_Click(object sender, EventArgs e)
        {
            if (DataSetManager.CurrentDataSetID != -1)
            {
                BruteForce BF = new BruteForce();
                BF.FindShortestPath(DataSetManager);
                groupBoxResults.Update();
            }
        }

        private void buttonSimulatingAnnealing_Click(object sender, EventArgs e)
        {
            if (DataSetManager.CurrentDataSetID != -1)
            {
                SimulatedAnnealing SA = new SimulatedAnnealing();
                SA.FindShortestPath(DataSetManager);
                groupBoxResults.Update();
            }
        }


        private void buttonGeneticAlgorithms_Click(object sender, EventArgs e)
        {
            if (DataSetManager.CurrentDataSetID != -1)
            {
                GeneticAlgorithm GA = new GeneticAlgorithm();
                GA.FindShortestPath(DataSetManager);
                groupBoxResults.Update();
            }
        }
    }
}
