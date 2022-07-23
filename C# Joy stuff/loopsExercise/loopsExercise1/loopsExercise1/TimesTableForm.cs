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
    public partial class TimesTableForm : Form
    {
        public TimesTableForm()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            int num1, num2;
                num1=int.Parse(numTextBox.Text);
                num2 = int.Parse(finalTextBox.Text);
               //doWhileTable(num1);
               doWhileTable(num1,num2);
              }


           private void doWhileTable(int number)
           {

               int i=1;
                do
                 {
                 int  res =number* i;
                    listBox1.Items.Add( number.ToString() + " * " +  " " + i.ToString() + " = " + " " + res.ToString());
               
                   i++;
                 }
               
                while (i <= 12);

           }
        private void doWhileTable(int number, int start)
        {
                            
             // int   i=1;
                do
                 {
                     int res = number * start;
                   listBox1.Items.Add(number.ToString() + " * " + " " + start.ToString() + " = " + " " + res.ToString());

                   start++;
                 }

                while (start <= 12);
 
              }


       
      
    }
}
