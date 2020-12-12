using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_project_mz6grm.Entities
{
	public class Rectangle:Label
	{
        public Rectangle()
        {
            AutoSize = false;
            Width = 40;
            Height = 45;
            Paint += Rectangle_Paint;
        }

        private void Rectangle_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g)
        {            
            g.FillRectangle(new SolidBrush(Color.Red), 0, 0, Width, Height);
        }

        public void MoveRectangle()
        {
            Top -= 1;
        }
    }
}
