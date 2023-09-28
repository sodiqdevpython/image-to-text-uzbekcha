using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitMiracle.LibTiff.Classic;
using IronOcr;
using System.Threading;

namespace rasm_matn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xuiRadio1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        Point last_point;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last_point.X;
                this.Top += e.Y - last_point.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            last_point = new Point(e.X, e.Y);
        }

        private void xuiRadio2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void xuiRadio3_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                richTextBox1.BorderStyle = BorderStyle.None;
                //pbimg.SizeMode = PictureBoxSizeMode.Zoom;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                richTextBox1.BorderStyle = BorderStyle.FixedSingle;
                //pbimg.SizeMode = PictureBoxSizeMode.StretchImage;
                WindowState = FormWindowState.Normal;
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last_point.X;
                this.Top += e.Y - last_point.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            last_point = new Point(e.X, e.Y);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if(Opacity==1)
            {
                timer1.Stop();
            }
            Opacity += .2;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Opacity <= 0)
            {
                this.Close();
            }
            Opacity -= .2;
        }

        private void zeroitLollipopFlatButton1_Click(object sender, EventArgs e)
        {
            
        }
        //string file_name = @"";
        private void zeroitLollipopFlatButton2_Click(object sender, EventArgs e)
        {
            //file_name += $"{openFileDialog1.FileName}";
            try
            {
                openFileDialog1.Filter = @"png files|*.png|jpg files|*.jpeg|All files|*.*";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbimg.SizeMode = PictureBoxSizeMode.Zoom;
                    pbimg.Load(openFileDialog1.FileName);

                   /* file_name = $"@{openFileDialog1.FileName}"*/;
                    //var ocr = new IronTesseract();
                    //ocr.Language = OcrLanguage.Uzbek;
                    ////var inputImage = new OcrInput(file_name);
                    //var inputImage = new OcrInput(openFileDialog1.FileName);
                    //var result = ocr.Read(inputImage).Text;
                    backgroundWorker1.RunWorkerAsync();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    //richTextBox1.Text = result;
                    pbimg.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nimadir xato ketdi" + exception.Message);
            }
        }

        //private void zeroitLollipopFlatButton3_Click(object sender, EventArgs e)
        //{
            
        //    try
        //    {
        //        if (pbimg.Image != null)
        //        {

        //            //pbimg.Image = null;
        //            //var Ocr = new IronOcr.IronTesseract();
        //            //var Result = Ocr.Read(pbimg.Image);
        //            //richTextBox1.Text = Result.Text;
        //            //var Ocr = new AutoOcr();
        //            //var Result = Ocr.Read(pbimg.Image);
        //            Form2 f2 = new Form2();
        //            f2.ShowDialog();
        //            //var ocr = new IronTesseract();
        //            //ocr.Language = OcrLanguage.Uzbek;
        //            ////var inputImage = new OcrInput(file_name);
        //            //var inputImage = new OcrInput(openFileDialog1.FileName);
        //            //var result = ocr.Read(inputImage).Text;
        //            //richTextBox1.Text = result;
                    
        //        }
        //        else
        //        {
        //            MessageBox.Show(@"Rasm yuklanmagan");
        //        }
        //    }
        //    catch
        //    {

        //    }
            
        //}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            zeroitLollipopFlatButton4.Visible = true;
            zeroitLollipopFlatButton5.Visible = true;
        }

        private void zeroitLollipopFlatButton4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            MessageBox.Show("Rasmdagi matn nusxalandi");
        }

        private void zeroitLollipopFlatButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Yuklangan rasmdagi matn shu yerda ko'rinadi";
            pbimg.Image = null;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var ocr = new IronTesseract();
            ocr.Language = OcrLanguage.Uzbek;
            //var inputImage = new OcrInput(file_name);
            var inputImage = new OcrInput(openFileDialog1.FileName);
            var result = ocr.Read(inputImage).Text;
            e.Result = result;
            backgroundWorker1.ReportProgress(0);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = e.Result as string;
            richTextBox1.Text = result;
            richTextBox1.ForeColor = Color.AntiqueWhite;
        }

        private void zeroitLollipopFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (pbimg.Image != null)
            {
                var imagerr = pbimg.Image;
                imagerr.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pbimg.Image = imagerr;
            }
        }
    }
}
