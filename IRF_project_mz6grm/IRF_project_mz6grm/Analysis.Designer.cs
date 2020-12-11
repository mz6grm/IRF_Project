namespace IRF_project_mz6grm
{
	partial class Analysis
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.TextCountry = new System.Windows.Forms.TextBox();
			this.ListCountry = new System.Windows.Forms.ListBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.databaseDataSet = new IRF_project_mz6grm.DatabaseDataSet();
			this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.happiness15BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.happiness15TableAdapter = new IRF_project_mz6grm.DatabaseDataSetTableAdapters.Happiness15TableAdapter();
			this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.happinessindex15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.continentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.TextCountry2 = new System.Windows.Forms.TextBox();
			this.ListCountry2 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.happiness20TableAdapter = new IRF_project_mz6grm.DatabaseDataSetTableAdapters.Happiness20TableAdapter();
			this.databaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.happiness20BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.countryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.happinessindex20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.continentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.happiness15BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.happiness20BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.happiness20BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness15BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness20BindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness15BindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness20BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness20BindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// TextCountry
			// 
			this.TextCountry.Location = new System.Drawing.Point(13, 13);
			this.TextCountry.Name = "TextCountry";
			this.TextCountry.Size = new System.Drawing.Size(142, 20);
			this.TextCountry.TabIndex = 0;
			this.TextCountry.TextChanged += new System.EventHandler(this.TextCountry_TextChanged);
			// 
			// ListCountry
			// 
			this.ListCountry.FormattingEnabled = true;
			this.ListCountry.Location = new System.Drawing.Point(13, 40);
			this.ListCountry.Name = "ListCountry";
			this.ListCountry.Size = new System.Drawing.Size(142, 251);
			this.ListCountry.TabIndex = 1;
			this.ListCountry.SelectedIndexChanged += new System.EventHandler(this.ListCountry_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryDataGridViewTextBoxColumn,
            this.happinessindex15DataGridViewTextBoxColumn,
            this.continentDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.happiness15BindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(185, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(343, 44);
			this.dataGridView1.TabIndex = 2;
			// 
			// databaseDataSet
			// 
			this.databaseDataSet.DataSetName = "DatabaseDataSet";
			this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// databaseDataSetBindingSource
			// 
			this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
			this.databaseDataSetBindingSource.Position = 0;
			// 
			// happiness15BindingSource
			// 
			this.happiness15BindingSource.DataMember = "Happiness15";
			this.happiness15BindingSource.DataSource = this.databaseDataSetBindingSource;
			// 
			// happiness15TableAdapter
			// 
			this.happiness15TableAdapter.ClearBeforeFill = true;
			// 
			// countryDataGridViewTextBoxColumn
			// 
			this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
			this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
			this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
			// 
			// happinessindex15DataGridViewTextBoxColumn
			// 
			this.happinessindex15DataGridViewTextBoxColumn.DataPropertyName = "Happiness_index15";
			this.happinessindex15DataGridViewTextBoxColumn.HeaderText = "Happiness_index";
			this.happinessindex15DataGridViewTextBoxColumn.Name = "happinessindex15DataGridViewTextBoxColumn";
			// 
			// continentDataGridViewTextBoxColumn
			// 
			this.continentDataGridViewTextBoxColumn.DataPropertyName = "Continent";
			this.continentDataGridViewTextBoxColumn.HeaderText = "Continent";
			this.continentDataGridViewTextBoxColumn.Name = "continentDataGridViewTextBoxColumn";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(305, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Data in 2015:";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryDataGridViewTextBoxColumn1,
            this.happinessindex20DataGridViewTextBoxColumn,
            this.continentDataGridViewTextBoxColumn1});
			this.dataGridView2.DataSource = this.happiness20BindingSource1;
			this.dataGridView2.Location = new System.Drawing.Point(763, 40);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(343, 44);
			this.dataGridView2.TabIndex = 4;
			// 
			// TextCountry2
			// 
			this.TextCountry2.Location = new System.Drawing.Point(1136, 13);
			this.TextCountry2.Name = "TextCountry2";
			this.TextCountry2.Size = new System.Drawing.Size(142, 20);
			this.TextCountry2.TabIndex = 5;
			this.TextCountry2.TextChanged += new System.EventHandler(this.TextCountry2_TextChanged);
			// 
			// ListCountry2
			// 
			this.ListCountry2.FormattingEnabled = true;
			this.ListCountry2.Location = new System.Drawing.Point(1136, 40);
			this.ListCountry2.Name = "ListCountry2";
			this.ListCountry2.Size = new System.Drawing.Size(142, 251);
			this.ListCountry2.TabIndex = 6;
			this.ListCountry2.SelectedIndexChanged += new System.EventHandler(this.ListCountry2_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(886, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Data in 2020:";
			// 
			// happiness20TableAdapter
			// 
			this.happiness20TableAdapter.ClearBeforeFill = true;
			// 
			// databaseDataSetBindingSource1
			// 
			this.databaseDataSetBindingSource1.DataSource = this.databaseDataSet;
			this.databaseDataSetBindingSource1.Position = 0;
			// 
			// happiness20BindingSource1
			// 
			this.happiness20BindingSource1.DataMember = "Happiness20";
			this.happiness20BindingSource1.DataSource = this.databaseDataSetBindingSource1;
			// 
			// countryDataGridViewTextBoxColumn1
			// 
			this.countryDataGridViewTextBoxColumn1.DataPropertyName = "Country";
			this.countryDataGridViewTextBoxColumn1.HeaderText = "Country";
			this.countryDataGridViewTextBoxColumn1.Name = "countryDataGridViewTextBoxColumn1";
			// 
			// happinessindex20DataGridViewTextBoxColumn
			// 
			this.happinessindex20DataGridViewTextBoxColumn.DataPropertyName = "Happiness_index20";
			this.happinessindex20DataGridViewTextBoxColumn.HeaderText = "Happiness_index";
			this.happinessindex20DataGridViewTextBoxColumn.Name = "happinessindex20DataGridViewTextBoxColumn";
			// 
			// continentDataGridViewTextBoxColumn1
			// 
			this.continentDataGridViewTextBoxColumn1.DataPropertyName = "Continent";
			this.continentDataGridViewTextBoxColumn1.HeaderText = "Continent";
			this.continentDataGridViewTextBoxColumn1.Name = "continentDataGridViewTextBoxColumn1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(856, 775);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(425, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "*The database contains of the two highest happiness score countries for each cont" +
    "inent.";
			// 
			// chart1
			// 
			chartArea7.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea7);
			this.chart1.DataSource = this.happiness15BindingSource1;
			legend7.Name = "Legend1";
			this.chart1.Legends.Add(legend7);
			this.chart1.Location = new System.Drawing.Point(13, 452);
			this.chart1.Name = "chart1";
			series7.ChartArea = "ChartArea1";
			series7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			series7.IsValueShownAsLabel = true;
			series7.IsXValueIndexed = true;
			series7.Legend = "Legend1";
			series7.Name = "Happiness15";
			series7.SmartLabelStyle.IsOverlappedHidden = false;
			series7.XValueMember = "Country";
			series7.YValueMembers = "Happiness_index15";
			this.chart1.Series.Add(series7);
			this.chart1.Size = new System.Drawing.Size(629, 300);
			this.chart1.TabIndex = 9;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			chartArea8.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea8);
			this.chart2.DataSource = this.happiness20BindingSource2;
			legend8.Name = "Legend1";
			this.chart2.Legends.Add(legend8);
			this.chart2.Location = new System.Drawing.Point(649, 452);
			this.chart2.Name = "chart2";
			series8.ChartArea = "ChartArea1";
			series8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			series8.IsValueShownAsLabel = true;
			series8.IsXValueIndexed = true;
			series8.Legend = "Legend1";
			series8.Name = "Happiness20";
			series8.SmartLabelStyle.IsOverlappedHidden = false;
			series8.XValueMember = "Country";
			series8.YValueMembers = "Happiness_index20";
			this.chart2.Series.Add(series8);
			this.chart2.Size = new System.Drawing.Size(629, 300);
			this.chart2.TabIndex = 10;
			this.chart2.Text = "chart2";
			// 
			// chart3
			// 
			chartArea9.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea9);
			this.chart3.DataSource = this.happiness20BindingSource;
			legend9.Name = "Legend1";
			this.chart3.Legends.Add(legend9);
			this.chart3.Location = new System.Drawing.Point(434, 90);
			this.chart3.Name = "chart3";
			series9.ChartArea = "ChartArea1";
			series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series9.IsXValueIndexed = true;
			series9.Legend = "Legend1";
			series9.Name = "Happiness - Continents 2020";
			series9.XValueMember = "Continent";
			series9.YValueMembers = "Happiness_index20";
			this.chart3.Series.Add(series9);
			this.chart3.Size = new System.Drawing.Size(426, 356);
			this.chart3.TabIndex = 11;
			this.chart3.Text = "chart3";
			// 
			// happiness15BindingSource1
			// 
			this.happiness15BindingSource1.DataMember = "Happiness15";
			this.happiness15BindingSource1.DataSource = this.databaseDataSet;
			// 
			// happiness20BindingSource
			// 
			this.happiness20BindingSource.DataMember = "Happiness20";
			this.happiness20BindingSource.DataSource = this.databaseDataSet;
			// 
			// happiness20BindingSource2
			// 
			this.happiness20BindingSource2.DataMember = "Happiness20";
			this.happiness20BindingSource2.DataSource = this.databaseDataSet;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(10, 423);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(381, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Visualization of Countries by their Happiness index in 2015:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(897, 423);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(381, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "Visualization of Countries by their Happiness index in 2020:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Maroon;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.ForeColor = System.Drawing.SystemColors.Info;
			this.button1.Location = new System.Drawing.Point(1136, 319);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 74);
			this.button1.TabIndex = 14;
			this.button1.Text = "Conclusion";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Analysis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1293, 797);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.chart3);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ListCountry2);
			this.Controls.Add(this.TextCountry2);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.ListCountry);
			this.Controls.Add(this.TextCountry);
			this.Name = "Analysis";
			this.Text = "Analysis";
			this.Load += new System.EventHandler(this.Analysis_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness15BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness20BindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness15BindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness20BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.happiness20BindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextCountry;
		private System.Windows.Forms.ListBox ListCountry;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
		private DatabaseDataSet databaseDataSet;
		private System.Windows.Forms.BindingSource happiness15BindingSource;
		private DatabaseDataSetTableAdapters.Happiness15TableAdapter happiness15TableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn happinessindex15DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn continentDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TextBox TextCountry2;
		private System.Windows.Forms.ListBox ListCountry2;
		private System.Windows.Forms.Label label2;
		private DatabaseDataSetTableAdapters.Happiness20TableAdapter happiness20TableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn happinessindex20DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn continentDataGridViewTextBoxColumn1;
		private System.Windows.Forms.BindingSource happiness20BindingSource1;
		private System.Windows.Forms.BindingSource databaseDataSetBindingSource1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
		private System.Windows.Forms.BindingSource happiness15BindingSource1;
		private System.Windows.Forms.BindingSource happiness20BindingSource;
		private System.Windows.Forms.BindingSource happiness20BindingSource2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
	}
}