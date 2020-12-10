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
	public partial class Form1 : Form
	{
		DatabaseEntities context = new DatabaseEntities();
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{			
			var i = from x in context.LOGINs select x;
			bool van = false;

			foreach (var x in i)
			{
				if (x.Username == textBox1.Text && x.Password == textBox2.Text)
				{
					van = true;
					Analysis form2 = new Analysis();
					form2.Show();
					this.Hide();
				}
			}
			if (!van)
				MessageBox.Show("A felhasználónév, vagy a jelszó nem jó!");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Register form2 = new Register();
			form2.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
