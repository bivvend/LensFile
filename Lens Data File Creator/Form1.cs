using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lens_Data_File_Creator
{
    public partial class Form1 : Form
    {
        
        List<String> BodyStrings = new List<String>();

        private int NumberOfPoints = 0;
        List<Point> Points = new List<Point>();

        public Form1()
        {
            InitializeComponent();
            textBoxMat11.Text = "0";
            textBoxMat12.Text = "-1";
            textBoxMat21.Text = "1";
            textBoxMat22.Text = "0";

            textBoxRMat11.Text = "0";
            textBoxRMat12.Text = "-1";
            textBoxRMat21.Text = "1";
            textBoxRMat22.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSaveHeader_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save a header file";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*
                FileStream fs = File.Open(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);

                //write text
                for (int i = 0; i < richTextBoxHeader.Lines.Length; i++)
                {
                    writer.WriteLine(richTextBoxHeader.Lines[i]);
                }

                writer.Close();
                fs.Close();
                */

                richTextBoxHeader.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);


            }
                
            
        }

        private void buttonLoadHeader_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Header File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .txt file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBoxHeader.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception EX)
                {
                    if (EX.Message.ToLower().Contains("format is not valid"))
                    {
                        richTextBoxHeader.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }
            }

        }

        private void buttonLoadDataFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Formatted Data File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .txt file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BodyStrings.Clear();
                try
                {
                    richTextBoxBody.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception EX)
                {
                    if (EX.Message.ToLower().Contains("format is not valid"))
                    {
                        richTextBoxBody.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }

                //copy lines into data
                for (int i = 0; i < richTextBoxBody.Lines.Length; i++)
                {
                    BodyStrings.Add(richTextBoxBody.Lines[i].ToString());
                }
            }
        }

        private void buttonSaveDataAsText_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save a Body File file";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*
                FileStream fs = File.Open(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);

                //write text
                for (int i = 0; i < richTextBoxHeader.Lines.Length; i++)
                {
                    writer.WriteLine(richTextBoxHeader.Lines[i]);
                }

                writer.Close();
                fs.Close();
                */

                richTextBoxBody.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);


            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Formatted Data File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .txt file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BodyStrings.Clear();
                NumberOfPoints = 0;
                Points.Clear();

                //read raw file into text box
                try
                {
                    richTextBoxBody.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception EX)
                {
                    if (EX.Message.ToLower().Contains("format is not valid"))
                    {
                        richTextBoxBody.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                }

                //copy lines into data
                for (int i = 0; i < richTextBoxBody.Lines.Length; i++)
                {
                    BodyStrings.Add(richTextBoxBody.Lines[i].ToString());
                }

                //first line is number of points

                try
                {
                    int.TryParse(BodyStrings[0], out NumberOfPoints);

                }
                catch
                {
                    MessageBox.Show("Data format error");
                    NumberOfPoints = 0;
                }

                labelNumberOfPoints.Text = NumberOfPoints.ToString();

                //read data into Point objects

                //temporary point data
                int indexX =0;
                int indexY=0;
                float MeasuredX =0.0f;
                float MeasuredY = 0.0f;

                int StringIndex = 1;
                for (int N = 0; N < NumberOfPoints; N++)
                {
                    //convert strings to data
                    int.TryParse(BodyStrings[StringIndex + (N * 4)], out indexX);
                    int.TryParse(BodyStrings[StringIndex + (N * 4)+1], out indexY);

                    float.TryParse(BodyStrings[StringIndex + (N * 4) + 2], out MeasuredX);
                    float.TryParse(BodyStrings[StringIndex + (N * 4) + 3], out MeasuredY);

                    //create a point object

                    Points.Add(new Point(indexX, indexY, MeasuredX, MeasuredY));
                }

                //Write back points to richtextbox

                richTextBoxBody.Clear(); //clear it first so can append lines

                foreach(Point P in Points)
                {
                    richTextBoxBody.AppendText(P.indexX.ToString() +"\t" +P.indexY.ToString() +"\t" + P.MeasuredX.ToString() +"\t" + P.MeasuredY.ToString() +Environment.NewLine);

                }

            }
        
        }

        private void buttonFullFileNoRotate_Click(object sender, EventArgs e)
        {
            richTextBoxFull.Clear();
            richTextBoxFull.AppendText(richTextBoxHeader.Text + Environment.NewLine);
            richTextBoxFull.AppendText(richTextBoxBody.Text);

        }

        private void buttonSaveFullText_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save a Full text file";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                richTextBoxFull.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);


            }
        }

        private void buttonApplyRotation_Click(object sender, EventArgs e)
        {
            double Mat11 = 0.0f;  // used to rotate indices
            double Mat21 = 0.0f;
            double Mat12 = 0.0f;
            double Mat22 = 0.0f;

            double RMat11 = 0.0f;  // used to rotate data
            double RMat21 = 0.0f;
            double RMat12 = 0.0f;
            double RMat22 = 0.0f;


            int NewIndexX = 0;
            int NewIndexY = 0;

            float NewX = 0.0f;
            float NewY = 0.0f;

            //copy data from text
            double.TryParse(textBoxMat11.Text, out Mat11);
            double.TryParse(textBoxMat21.Text, out Mat21);
            double.TryParse(textBoxMat12.Text, out Mat12);
            double.TryParse(textBoxMat22.Text, out Mat22);

            double.TryParse(textBoxRMat11.Text, out RMat11);
            double.TryParse(textBoxRMat21.Text, out RMat21);
            double.TryParse(textBoxRMat12.Text, out RMat12);
            double.TryParse(textBoxRMat22.Text, out RMat22);

            //modify points
            foreach (Point P in Points)
            {
                NewX = (float)(P.MeasuredX * RMat11 + P.MeasuredY * RMat21);
                NewY = (float)(P.MeasuredX * RMat12 + P.MeasuredY * RMat22);

                NewIndexX = P.indexX * (int)Mat11 + P.indexY * (int)Mat21;
                NewIndexY = P.indexX * (int)Mat12 + P.indexY * (int)Mat22;

                //copy over new data

                P.indexX = NewIndexX;
                P.indexY = NewIndexY;
                P.MeasuredX = NewX;
                P.MeasuredY = NewY;
            }
            //Write back points to richtextbox

            richTextBoxBody.Clear(); //clear it first so can append lines

            foreach (Point P in Points)
            {
                richTextBoxBody.AppendText(P.indexX.ToString() + "\t" + P.indexY.ToString() + "\t" + P.MeasuredX.ToString() + "\t" + P.MeasuredY.ToString() + Environment.NewLine);

            }
        }

        private void CalcSkew_Click(object sender, EventArgs e)
        {
            double dotproduct = 0.0d;
            double ModA = 0.0d;
            double ModB = 0.0d;
            double Angle = 0.0d;

            if (Points.Count > 3)
            {
                // (X1-X0)*(X2-X0)  + (Y1-Y0)*(Y2-Y0)
                dotproduct = (Points[1].MeasuredX - Points[0].MeasuredX) * (Points[2].MeasuredX - Points[0].MeasuredX) + (Points[1].MeasuredY - Points[0].MeasuredY) * (Points[2].MeasuredY - Points[0].MeasuredY);
                ModA = Math.Sqrt((Points[1].MeasuredX - Points[0].MeasuredX) * (Points[1].MeasuredX - Points[0].MeasuredX) + (Points[1].MeasuredY - Points[0].MeasuredY) * (Points[1].MeasuredY - Points[0].MeasuredY));
                ModB = Math.Sqrt((Points[2].MeasuredX - Points[0].MeasuredX) * (Points[2].MeasuredX - Points[0].MeasuredX) + (Points[2].MeasuredY - Points[0].MeasuredY) * (Points[2].MeasuredY - Points[0].MeasuredY));
                Angle = (Math.Acos(dotproduct / (ModA * ModB)) - (Math.PI/2.0d) )* 1000000.0d;
                MessageBox.Show(Angle.ToString() + " micro-radians");
            }
            else
            {
                MessageBox.Show("Not enough data");
                
            }
        }

        private void buttonMirrorX_Click(object sender, EventArgs e)
        {
            

            int NewIndexX = 0;
            float NewX = 0.0f;
                        
            //modify points
            foreach (Point P in Points)
            {
                NewX = (float)(P.MeasuredX*-1.0d);


                NewIndexX = P.indexX * -1;
                

                //copy over new data

                P.indexX = NewIndexX;
                P.MeasuredX = NewX;
                
            }
            //Write back points to richtextbox

            richTextBoxBody.Clear(); //clear it first so can append lines

            foreach (Point P in Points)
            {
                richTextBoxBody.AppendText(P.indexX.ToString() + "\t" + P.indexY.ToString() + "\t" + P.MeasuredX.ToString() + "\t" + P.MeasuredY.ToString() + Environment.NewLine);

            }
        }

        private void buttonMirrorY_Click(object sender, EventArgs e)
        {
            int NewIndexY = 0;
            float NewY = 0.0f;

            //modify points
            foreach (Point P in Points)
            {
                NewY = (float)(P.MeasuredY * -1.0d);


                NewIndexY = P.indexY * -1;


                //copy over new data

                P.indexY = NewIndexY;
                P.MeasuredY = NewY;

            }
            //Write back points to richtextbox

            richTextBoxBody.Clear(); //clear it first so can append lines

            foreach (Point P in Points)
            {
                richTextBoxBody.AppendText(P.indexX.ToString() + "\t" + P.indexY.ToString() + "\t" + P.MeasuredX.ToString() + "\t" + P.MeasuredY.ToString() + Environment.NewLine);

            }
        }

        
    }
}
