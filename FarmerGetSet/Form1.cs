using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGetSet
{
    public partial class Form1 : Form
    {
        Farmer farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30); // { NumberOfCows = 15, };  inicjalizator obiketu w przypadku gdy pola sa prywatne wyrzuci blad, należy użyć kontruktora. Pole feedMultiplier = 30 jest prywatne | inicjalizator został zastąpiony kontruktorem
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Potrzebuję {0} worków paszy do wykarmienia {1} krów", farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //farmer.BagsOfFeed = 5;
        }
    }
}
