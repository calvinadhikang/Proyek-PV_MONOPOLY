using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_Pv
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void panelMaps_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Resource1.Maps, 13, 13, 990, 550);
        }

        private void panelDice_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(Resource1._6, 67, 45, 60, 60);

            if (dadu == 1)
            {
                g.DrawImage(Resource1._0, 67, 45, 60, 60);
            }
            else if (dadu == 2)
            {
                g.DrawImage(Resource1._1, 67, 45, 60, 60);
            }
            else if (dadu == 3)
            {
                g.DrawImage(Resource1._2, 67, 45, 60, 60);
            }
            else if (dadu == 4)
            {
                g.DrawImage(Resource1._3, 67, 45, 60, 60);
            }
            else if (dadu == 5)
            {
                g.DrawImage(Resource1._4, 67, 45, 60, 60);
            }
            else if (dadu == 6)
            {
                g.DrawImage(Resource1._5, 67, 45, 60, 60);
            }
        }

        int dadu;
        Random rnd = new Random(); 

        private void button1_Click(object sender, EventArgs e)
        {
            dadu = rnd.Next(1, 7);
            panelDice.Invalidate();
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }
    }
}
