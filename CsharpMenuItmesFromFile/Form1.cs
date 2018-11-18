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

namespace CsharpMenuItmesFromFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = nameFromTXTfile("textForLabel.txt", 1);
            label2.Text = CMDFromTXTfile("textForLabel.txt", 1);
        }

        public string nameFromTXTfile(string filename,int lineToRead)
        {
            try
            {   // Open the text file using a stream reader.
                
                    // Read the stream to a string, and write the string to the console.
                    String line= File.ReadLines(filename).Skip(lineToRead-1).Take(1).First();
                    string output = line.Split(';')[0];
                    return output.ToString();

            }
            catch (Exception e)
            {
               string output = "problem with file "+ filename;
                MessageBox.Show(e.Message, output);
                return output;
            }
            
        }

        public string CMDFromTXTfile(string filename, int lineToRead)
        {
            try
            {   // Open the text file using a stream reader.

                // Read the stream to a string, and write the string to the console.
                String line = File.ReadLines(filename).Skip(lineToRead - 1).Take(1).First();
                string output = line.Split(';')[1];
                return output.ToString();

            }
            catch (Exception e)
            {
                string output = "problem with file " + filename;
                MessageBox.Show(e.Message, output);
                return output;
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
