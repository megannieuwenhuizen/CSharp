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
    public partial class loopingForm : Form
    {
        public loopingForm()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
             /* local variable definition */
            int a = int.Parse(numTextBox.Text);
           
            //call the method for each loop
               // whileLoopMethod(a);
            forLoopMethod(a);
 
            
        }


        private void whileLoopMethod(int number)
        {
              /* while loop execution */
            while ( number < 20)
            {
            
                listBox1.Items.Add( number);
                 number++;
            }

        }
            
        private void doWhileLoopMethod (int number)
        {

          /* do loop execution */
            do
            {
               listBox1.Items.Add(number);

                number = number + 1;

            } while (number< 20);

        
        }

        private void forLoopMethod(int number)
        {
            int a;
            /* for loop execution */
            for ( a = number; a < 20; a= a+1)
            {
               listBox1.Items.Add(a);
            }
      
        }

    

        private void timesTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimesTableForm myForm = new TimesTableForm();
            myForm.Show();
        }

        private void numberTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumberTriangleForm myform = new NumberTriangleForm();
            myform.Show();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            /* local variable definition */
            int num = int.Parse(numTextBox.Text);
            int initialNum = 1;
            int sum = 1;
            while (initialNum < num)
            {
                initialNum++;
                sum += initialNum;
             // MessageBox.Show(" + " + num);
            }
            MessageBox.Show("The sum is: " + sum, "Summation", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
        }
            
        
    }
} 

