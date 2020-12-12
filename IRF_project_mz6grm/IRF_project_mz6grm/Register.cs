using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            bool success = ValidateUsername(textBox1.Text) && ValidatePassword(textBox2.Text) && ValidateEmail(textBox3.Text) && ValidatePhoneNumber(textBox4.Text);           
            LOGIN u = new LOGIN();
            if (success)
            {
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
            else
            {
                MessageBox.Show("Valamelyik adat nem megfelelő!");
            }
            
        }

        public bool ValidateUsername(string username)
        {
            if (username.Length > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

        public bool ValidatePassword(string password)
        {          
           
            var hasNumber = new Regex(@"[0-9]+"); //van benne szám
            var hasUpperChar = new Regex(@"[A-Z]+"); //van nagybetű
            var hasMinimum8Chars = new Regex(@".{8,}"); //legalább 8 hossz

            return hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password);            
        }

        public bool ValidatePhoneNumber(string phonenumber)
        {
            if (phonenumber.Length == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
