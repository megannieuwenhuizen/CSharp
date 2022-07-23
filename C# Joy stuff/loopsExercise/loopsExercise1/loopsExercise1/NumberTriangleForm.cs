using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopsExercise1
{
    public partial class NumberTriangleForm : Form
    {
        public NumberTriangleForm()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++) //Nested for loop
                {
                    //listBox1.Items.Add(j);
                    Console.Write(j);
                }
               

               Console.Write("\n");
            }
            Console.ReadLine();

        }
    }
}
