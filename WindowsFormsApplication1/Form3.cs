using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            goal1StartTime.Format = DateTimePickerFormat.Time;
            goal1StartTime.ShowUpDown = true;

            goal1EndTime.Format = DateTimePickerFormat.Time;
            goal1EndTime.ShowUpDown = true;

            goal2StartTime.Format = DateTimePickerFormat.Time;
            goal2StartTime.ShowUpDown = true;

            goal2EndTime.Format = DateTimePickerFormat.Time;
            goal2EndTime.ShowUpDown = true;

            goal3StartTime.Format = DateTimePickerFormat.Time;
            goal3StartTime.ShowUpDown = true;

            goal3EndTime.Format = DateTimePickerFormat.Time;
            goal3EndTime.ShowUpDown = true;

            goal4StartTime.Format = DateTimePickerFormat.Time;
            goal4StartTime.ShowUpDown = true;

            goal4EndTime.Format = DateTimePickerFormat.Time;
            goal4EndTime.ShowUpDown = true;

        }

        StreamReader readFile;
        StreamReader openFile;
        string fileName;


        private void WordDocViewer(string fileName)

        {
            try

            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message.ToString());
            }



        }

        private void TextToBox()
        {

            try
            {

                string numberLine;
                int count = 0;
                readFile = File.OpenText("Test.txt");
                while ((numberLine = readFile.ReadLine()) != null)
                {
                    count++;
                }

                readFile.Close();

                readFile = File.OpenText("Test.txt");

                for (int i = 0; i < count; i++)
                {
                    string line = readFile.ReadLine();
                    contract_tb.Text += line + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be read:");
                MessageBox.Show(ex.Message);

            }

        }




        private void importButton_Click(object sender, EventArgs e)
        {

            contract_tb.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                   {
                       try
                       {

                           //Create a document object

                           Document document = new Document();

                           document.LoadFromFile(openFileDialog1.FileName);

                           //Save doc file to a txt format.

                               document.SaveToFile("Test.txt", FileFormat.Txt);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("The file could not be read: " + ex.Message);
                            }
                TextToBox();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Document document = new Document();

                document.LoadFromFile("Test.txt");
                document.SaveToFile("PDFTest.pdf", FileFormat.PDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be saved: " + ex.Message);
            }
        }
    }

}

