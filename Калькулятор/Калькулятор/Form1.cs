using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void division_Click(object sender, EventArgs e)
        {
            double first;
            double.TryParse(firstArgument.Text, out first);
            double second;
            double.TryParse(twoArgument.Text, out second);
            Divider divider = new Divider();
            result.Text = divider.Calculate(first, second);
        }

        private void addition_Click(object sender, EventArgs e)
        {
            double first;
            double.TryParse(firstArgument.Text, out first);
            double second;
            double.TryParse(twoArgument.Text, out second);
            Adder adder=new Adder();
            result.Text = adder.Calculate(first,second);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            double first;
            double.TryParse(firstArgument.Text, out first);
            double second;
            double.TryParse(twoArgument.Text, out second);
            Multiplier multiplier = new Multiplier();
            result.Text = multiplier.Calculate(first, second);
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            double first;
            double.TryParse(firstArgument.Text, out first);
            double second;
            double.TryParse(twoArgument.Text, out second);
            Substracter substracter = new Substracter();
            result.Text = substracter.Calculate(first, second);
        }
    }
}
