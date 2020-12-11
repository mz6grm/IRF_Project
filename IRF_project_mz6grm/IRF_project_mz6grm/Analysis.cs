using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_project_mz6grm
{
	public partial class Analysis : Form
	{
		DatabaseEntities context = new DatabaseEntities();
		public Analysis()
		{
			InitializeComponent();
			ListCountry.DisplayMember = "Country";
			ListCountry2.DisplayMember = "Country";
			SearchCountry();
			SearchCountry2();
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
	}
}
