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
	public partial class Register : Form
	{
        DatabaseEntities context = new DatabaseEntities();
		public Register()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            LOGIN u = new LOGIN();
            u.Username = textBox1.Text;
            u.Password = textBox2.Text;
            u.Email_Address = textBox3.Text;
            u.Phone_Number = Convert.ToInt32(textBox4.Text);            

            var i = (from x in context.LOGINs select x.Username).ToList();
            if (!i.Contains(u.Username))
            {
                context.LOGINs.Add(u);
                context.SaveChanges();
                MessageBox.Show("Sikeres regisztráció!");

                this.Hide();
                Form1 login_window = new Form1();
                login_window.Show();
            }
            else
                MessageBox.Show("A felhasználónév már foglalt!");
        }
	}
}
