using IRF_project_mz6grm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = IRF_project_mz6grm.Entities.Rectangle; //érdekes

namespace IRF_project_mz6grm
{
	public partial class Analysis : Form
	{
		DatabaseEntities context = new DatabaseEntities();

		private List<Rectangle> _rectangles = new List<Rectangle>();

		private RectangleFactory _factory;
		public RectangleFactory Factory
		{
			get { return _factory; }
			set { _factory = value; }
		}
		public Analysis()
		{
			InitializeComponent();

			Factory = new RectangleFactory();

			ListCountry.DisplayMember = "Country";
			ListCountry2.DisplayMember = "Country";
			SearchCountry();
			SearchCountry2();
			Charts();			
		}

		//Metódusaim:
		private void SearchCountry()
		{
			string searchValue = TextCountry.Text.ToLower();

			ListCountry.DataSource = (from x in context.Happiness15
									  where x.Country.ToLower().Contains(searchValue)
									  select x).ToList();
		}

		private void SearchPlace()
		{
			var data = from x in context.Happiness15
						   where x.Id == ((Happiness15)ListCountry.SelectedItem).Id
						   select new
						   {
							   x.Country,
							   x.Happiness_index15,
							   x.Continent
						   };

			databaseDataSetBindingSource.DataSource = data.ToList();
		}

		private void SearchCountry2()
		{
			string searchValue = TextCountry2.Text.ToLower();

			ListCountry2.DataSource = (from x in context.Happiness20
									  where x.Country.ToLower().Contains(searchValue)
									  select x).ToList();
		}

		private void SearchPlace2()
		{
			var data = from x in context.Happiness20
					   where x.Id == ((Happiness20)ListCountry2.SelectedItem).Id
					   select new
					   {
						   x.Country,
						   x.Happiness_index20,
						   x.Continent
					   };

			databaseDataSetBindingSource1.DataSource = data.ToList();
		}

		private void Charts()
		{
			chart1.ChartAreas[0].AxisX.Interval = 1; //minden adat szerepeljen
			chart2.ChartAreas[0].AxisX.Interval = 1;
			chart3.ChartAreas[0].AxisX.Interval = 0;
			chart1.ChartAreas[0].AxisY.IsStartedFromZero = false; //adatértékek jól különüljenek el
			chart2.ChartAreas[0].AxisY.IsStartedFromZero = false;
			chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false; //rácsvonalak ne látszódjanak
			chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
			chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false; 
			chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;		
			/*if(chart3.ChartAreas[0].AxisX.Name == chart3.ChartAreas[0].AxisX.Name)
			{
				chart3.ChartAreas[0].AxisY.LabelStyle.ForeColor = chart3.ChartAreas[0].AxisY.LabelStyle.ForeColor;
			}*/
		}

		private void TextCountry_TextChanged(object sender, EventArgs e)
		{
			SearchCountry();
		}

		private void ListCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
			SearchPlace();
		}

		private void Analysis_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'databaseDataSet.Happiness20' table. You can move, or remove it, as needed.
			this.happiness20TableAdapter.Fill(this.databaseDataSet.Happiness20);
			// TODO: This line of code loads data into the 'databaseDataSet.Happiness15' table. You can move, or remove it, as needed.
			this.happiness15TableAdapter.Fill(this.databaseDataSet.Happiness15);

		}

		private void TextCountry2_TextChanged(object sender, EventArgs e)
		{
			SearchCountry2();
		}

		private void ListCountry2_SelectedIndexChanged(object sender, EventArgs e)
		{
			SearchPlace2();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Conclusion form2 = new Conclusion();
			form2.Show();
		}

		private void CreateTimer_Tick(object sender, EventArgs e)
		{
			var rectangle = Factory.CreateNew();
			_rectangles.Add(rectangle);			
			rectangle.Top = +rectangle.Height;
			mainPanel15.Controls.Add(rectangle);			
		}

		private void ConveyourTimer_Tick(object sender, EventArgs e)
		{
			var maxPosition = 0;
			foreach (var rectangle in _rectangles)
			{
				rectangle.MoveRectangle();				
				if (rectangle.Top > maxPosition)
					maxPosition = rectangle.Top;
			}
			
			if (maxPosition > 1000)
			{
				var oldestRectangle = _rectangles[0];
				mainPanel15.Controls.Remove(oldestRectangle);				
				_rectangles.Remove(oldestRectangle);
			}
		}
	}
}
