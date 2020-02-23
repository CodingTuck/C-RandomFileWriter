using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //declare variable
            int random = 0;

            //declare streamwriter
            StreamWriter outputFile;
            

            //get the numbers from user
            int userNumber = int.Parse(numFilesTextBox.Text);

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //create the file
                outputFile = File.CreateText(saveFile.FileName);

                //create the random
                Random randomNumber = new Random();

                for (int count = 0; count < userNumber; count++)
                {
                    //get the random numbers
                    random = randomNumber.Next(1, 101);

                    //show the numbers in the file
                    outputFile.WriteLine(random);

                    //show numbers in list box
                    numListBox.Items.Add(random);

                }

                //show it has been completed
                MessageBox.Show("The numbers were written in the file" + saveFile.FileName);

                //close file
                outputFile.Close();


            }
            
            else
            {
                //show error message
                MessageBox.Show("File didn't save correctly.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear
            numFilesTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

     
    }
}
