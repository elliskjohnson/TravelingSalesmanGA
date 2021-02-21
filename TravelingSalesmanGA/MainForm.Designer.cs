
namespace TravelingSalesmanGA
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.groupBoxLegend = new System.Windows.Forms.GroupBox();
            this.listBoxPointsKey = new System.Windows.Forms.ListBox();
            this.groupBoxMethodSelector = new System.Windows.Forms.GroupBox();
            this.buttonGeneticAlgorithms = new System.Windows.Forms.Button();
            this.buttonSimulatingAnnealing = new System.Windows.Forms.Button();
            this.buttonBruteForce = new System.Windows.Forms.Button();
            this.groupDataSelection = new System.Windows.Forms.GroupBox();
            this.buttonDS3 = new System.Windows.Forms.Button();
            this.buttonDS2 = new System.Windows.Forms.Button();
            this.buttonDS1 = new System.Windows.Forms.Button();
            this.chartDisplayPoints = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxLegend.SuspendLayout();
            this.groupBoxMethodSelector.SuspendLayout();
            this.groupDataSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisplayPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxResults);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxLegend);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMethodSelector);
            this.splitContainer1.Panel1.Controls.Add(this.groupDataSelection);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartDisplayPoints);
            this.splitContainer1.Size = new System.Drawing.Size(914, 561);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Location = new System.Drawing.Point(8, 393);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(250, 156);
            this.groupBoxResults.TabIndex = 3;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results:";
            // 
            // groupBoxLegend
            // 
            this.groupBoxLegend.Controls.Add(this.listBoxPointsKey);
            this.groupBoxLegend.Location = new System.Drawing.Point(8, 208);
            this.groupBoxLegend.Name = "groupBoxLegend";
            this.groupBoxLegend.Size = new System.Drawing.Size(250, 179);
            this.groupBoxLegend.TabIndex = 2;
            this.groupBoxLegend.TabStop = false;
            this.groupBoxLegend.Text = "Current Points Key:";
            // 
            // listBoxPointsKey
            // 
            this.listBoxPointsKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPointsKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPointsKey.FormattingEnabled = true;
            this.listBoxPointsKey.Location = new System.Drawing.Point(3, 16);
            this.listBoxPointsKey.Name = "listBoxPointsKey";
            this.listBoxPointsKey.Size = new System.Drawing.Size(244, 160);
            this.listBoxPointsKey.TabIndex = 0;
            // 
            // groupBoxMethodSelector
            // 
            this.groupBoxMethodSelector.Controls.Add(this.buttonGeneticAlgorithms);
            this.groupBoxMethodSelector.Controls.Add(this.buttonSimulatingAnnealing);
            this.groupBoxMethodSelector.Controls.Add(this.buttonBruteForce);
            this.groupBoxMethodSelector.Location = new System.Drawing.Point(8, 110);
            this.groupBoxMethodSelector.Name = "groupBoxMethodSelector";
            this.groupBoxMethodSelector.Size = new System.Drawing.Size(250, 91);
            this.groupBoxMethodSelector.TabIndex = 1;
            this.groupBoxMethodSelector.TabStop = false;
            this.groupBoxMethodSelector.Text = "Select Method:";
            // 
            // buttonGeneticAlgorithms
            // 
            this.buttonGeneticAlgorithms.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGeneticAlgorithms.Location = new System.Drawing.Point(3, 62);
            this.buttonGeneticAlgorithms.Name = "buttonGeneticAlgorithms";
            this.buttonGeneticAlgorithms.Size = new System.Drawing.Size(244, 23);
            this.buttonGeneticAlgorithms.TabIndex = 2;
            this.buttonGeneticAlgorithms.Text = "Genetic Algorithm";
            this.buttonGeneticAlgorithms.UseVisualStyleBackColor = true;
            this.buttonGeneticAlgorithms.Click += new System.EventHandler(this.buttonGeneticAlgorithms_Click);
            // 
            // buttonSimulatingAnnealing
            // 
            this.buttonSimulatingAnnealing.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSimulatingAnnealing.Location = new System.Drawing.Point(3, 39);
            this.buttonSimulatingAnnealing.Name = "buttonSimulatingAnnealing";
            this.buttonSimulatingAnnealing.Size = new System.Drawing.Size(244, 23);
            this.buttonSimulatingAnnealing.TabIndex = 1;
            this.buttonSimulatingAnnealing.Text = "Simulated Annealing";
            this.buttonSimulatingAnnealing.UseVisualStyleBackColor = true;
            this.buttonSimulatingAnnealing.Click += new System.EventHandler(this.buttonSimulatingAnnealing_Click);
            // 
            // buttonBruteForce
            // 
            this.buttonBruteForce.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBruteForce.Location = new System.Drawing.Point(3, 16);
            this.buttonBruteForce.Name = "buttonBruteForce";
            this.buttonBruteForce.Size = new System.Drawing.Size(244, 23);
            this.buttonBruteForce.TabIndex = 0;
            this.buttonBruteForce.Text = "Brute Force";
            this.buttonBruteForce.UseVisualStyleBackColor = true;
            this.buttonBruteForce.Click += new System.EventHandler(this.buttonBruteForce_Click);
            // 
            // groupDataSelection
            // 
            this.groupDataSelection.Controls.Add(this.buttonDS3);
            this.groupDataSelection.Controls.Add(this.buttonDS2);
            this.groupDataSelection.Controls.Add(this.buttonDS1);
            this.groupDataSelection.Location = new System.Drawing.Point(8, 13);
            this.groupDataSelection.Name = "groupDataSelection";
            this.groupDataSelection.Size = new System.Drawing.Size(250, 90);
            this.groupDataSelection.TabIndex = 0;
            this.groupDataSelection.TabStop = false;
            this.groupDataSelection.Text = "Data Selection:";
            // 
            // buttonDS3
            // 
            this.buttonDS3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDS3.Location = new System.Drawing.Point(3, 62);
            this.buttonDS3.Name = "buttonDS3";
            this.buttonDS3.Size = new System.Drawing.Size(244, 23);
            this.buttonDS3.TabIndex = 2;
            this.buttonDS3.Text = "Data Set 3";
            this.buttonDS3.UseVisualStyleBackColor = true;
            this.buttonDS3.Click += new System.EventHandler(this.buttonDS3_Click);
            // 
            // buttonDS2
            // 
            this.buttonDS2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDS2.Location = new System.Drawing.Point(3, 39);
            this.buttonDS2.Name = "buttonDS2";
            this.buttonDS2.Size = new System.Drawing.Size(244, 23);
            this.buttonDS2.TabIndex = 1;
            this.buttonDS2.Text = "Data Set 2";
            this.buttonDS2.UseVisualStyleBackColor = true;
            this.buttonDS2.Click += new System.EventHandler(this.buttonDS2_Click);
            // 
            // buttonDS1
            // 
            this.buttonDS1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDS1.Location = new System.Drawing.Point(3, 16);
            this.buttonDS1.Name = "buttonDS1";
            this.buttonDS1.Size = new System.Drawing.Size(244, 23);
            this.buttonDS1.TabIndex = 0;
            this.buttonDS1.Text = "Data Set 1";
            this.buttonDS1.UseVisualStyleBackColor = true;
            this.buttonDS1.Click += new System.EventHandler(this.buttonDS1_Click);
            // 
            // chartDisplayPoints
            // 
            chartArea8.Name = "ChartArea1";
            this.chartDisplayPoints.ChartAreas.Add(chartArea8);
            this.chartDisplayPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.chartDisplayPoints.Legends.Add(legend8);
            this.chartDisplayPoints.Location = new System.Drawing.Point(0, 0);
            this.chartDisplayPoints.Name = "chartDisplayPoints";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartDisplayPoints.Series.Add(series8);
            this.chartDisplayPoints.Size = new System.Drawing.Size(606, 561);
            this.chartDisplayPoints.TabIndex = 0;
            this.chartDisplayPoints.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(930, 600);
            this.MinimumSize = new System.Drawing.Size(930, 600);
            this.Name = "MainForm";
            this.Text = "Ellis Johnson CS489";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxLegend.ResumeLayout(false);
            this.groupBoxMethodSelector.ResumeLayout(false);
            this.groupDataSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDisplayPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupDataSelection;
        private System.Windows.Forms.Button buttonDS3;
        private System.Windows.Forms.Button buttonDS2;
        private System.Windows.Forms.Button buttonDS1;
        private System.Windows.Forms.GroupBox groupBoxMethodSelector;
        private System.Windows.Forms.Button buttonGeneticAlgorithms;
        private System.Windows.Forms.Button buttonSimulatingAnnealing;
        private System.Windows.Forms.Button buttonBruteForce;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.GroupBox groupBoxLegend;
        private System.Windows.Forms.ListBox listBoxPointsKey;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDisplayPoints;
    }
}

