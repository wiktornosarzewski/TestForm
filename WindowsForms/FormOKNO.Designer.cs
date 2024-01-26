namespace WindowsForms
{
    partial class FormOKNO
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxL1 = new System.Windows.Forms.TextBox();
            this.textBoxL2 = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(224, 12);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxL1
            // 
            this.textBoxL1.Location = new System.Drawing.Point(12, 12);
            this.textBoxL1.Name = "textBoxL1";
            this.textBoxL1.Size = new System.Drawing.Size(100, 20);
            this.textBoxL1.TabIndex = 1;
            // 
            // textBoxL2
            // 
            this.textBoxL2.Location = new System.Drawing.Point(118, 12);
            this.textBoxL2.Name = "textBoxL2";
            this.textBoxL2.Size = new System.Drawing.Size(100, 20);
            this.textBoxL2.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 60);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(205, 160);
            this.listBox.TabIndex = 4;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(224, 70);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Co to?";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(905, 567);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // FormOKNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 567);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBoxL2);
            this.Controls.Add(this.textBoxL1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.chart);
            this.Name = "FormOKNO";
            this.Text = "Nasze okienko";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxL1;
        private System.Windows.Forms.TextBox textBoxL2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

