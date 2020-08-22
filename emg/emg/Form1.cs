using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.Structure;

namespace emg
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _inputimage;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;
        Image<Gray, byte> S;
        Image<Gray, byte> ımgGray;
        Image<Gray, byte> ımgInput;
        Image<Gray, byte> ımgBinarize;
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog dosya = new OpenFileDialog();
        private void button3_Click(object sender, EventArgs e)
        {
            dosya.Filter = "Resim Dosyası |*.jpg| Resim Dosyası|*.jpeg Resim Dosyası |*.png|";
            dosya.FilterIndex = 2;
            dosya.RestoreDirectory = true;
            dosya.CheckFileExists = false;
            dosya.Title = "jpg dosyasını seçiniz..";
            dosya.Multiselect = true;

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = dosya.FileName;
                string DosyaAdi = dosya.SafeFileName;

                _inputimage = new Image<Bgr, byte>(DosyaYolu);
                ımagebox2.Image = _inputimage;
            }
            //İMAGEBOX2 RESMİN ORJINALİNİ GÖSTERENNN
            //IMAGEBOX1 RESMİN GRİYE ÇEVİRİP GÖSTERDİĞİ ALAN
            //İMAGEBOX3 RESMİN BİNARY YAPILACAK ALAN
        }
        private void button1_Click(object sender, EventArgs e)
        {

            /*dosya.Filter = "Resim Dosyası |*.jpg| Resim Dosyası|*.jpeg Resim Dosyası |*.png|";  
            dosya.FilterIndex = 2;
            dosya.RestoreDirectory = true;
            dosya.CheckdosyaExists = false;
            dosya.Title = "Excel Dosyası Seçiniz..";
            dosya.Multiselect = true;

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu= dosya.FileName;
                string DosyaAdi = dosya.SafeFileName;
               
                _inputimage = new Image<Bgr, byte>(DosyaYolu);*/
            if (ımagebox2.Image == null)
            {
                MessageBox.Show("Lütfen bir resim seçiniz");
            }
            else
            {

                B = _inputimage[0];
                /* G = _inputimage[1];
                 R = _inputimage[2];


                 ımageBox1.Image = R;
                 ımageBox2.Image = G;*/
                ımageBox1.Image = B;
            }
            }

            

    private void button2_Click(object sender, EventArgs e)
    {
        if (ımageBox1.Image == null)
        {
            MessageBox.Show("Lütfen resim seçinizzz...");
              

        }
        else
        {
            histogramBox1.ClearHistogram();
            /* histogramBox2.ClearHistogram();
             histogramBox1.ClearHistogram();*/

            /*histogramBox1.GenerateHistograms(R, 256);
            histogramBox2.GenerateHistograms(G, 256);*/
            histogramBox1.GenerateHistograms(B, 256);

            /* histogramBox1.Refresh();
             histogramBox2.Refresh();*/
            histogramBox1.Refresh();

        }
    }
     
        private void button4_Click(object sender, EventArgs e)
        {


            //ımgGray = ımgInput.Convert<Gray, byte>();

            //ımageBox3.Image = ımgGray;
            if (ımageBox1.Image == null)
            {
                MessageBox.Show("İlk önce resmi gri yapmanız gerekmektedir...");
            }
            else
            {
                ımgBinarize = new Image<Gray, Byte>(B.Width, B.Height, new Gray(0));

                /*double thresold =*/
                CvInvoke.Threshold(B, ımgBinarize, 50, 255, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
                ımageBox3.Image = ımgBinarize;

            }


        }

        private void histogramBox1_Load(object sender, EventArgs e)
        {

        }
    }

      

       
    }


