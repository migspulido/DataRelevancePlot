//Miguel Pulido - Systems Architect


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DataRelevancePlot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                    label1.Text = openFileDialog1.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Relevance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Relevance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
   }
}
