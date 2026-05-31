using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ulkeler_ve_Baskentleri_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int puan = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            sayac++;
            BtnSoru.Text = "Sonraki";

            BtnA.BackColor = Color.Gray;
            BtnB.BackColor = Color.Gray;
            BtnC.BackColor = Color.Gray;
            BtnD.BackColor = Color.Gray;

            if(sayac == 1)
            {
                label1.Text = "Turkiye";
                BtnA.Text = "Adana";
                BtnB.Text = "Istanbul";
                BtnC.Text = "Ankara";
                BtnD.Text = "Izmir";
                label2.Text = "Ankara";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Ankara.jpg";
            }

            if(sayac == 2)
            {
                label1.Text = "Almanya";
                BtnA.Text = "Munih";
                BtnB.Text = "Hamburg";
                BtnC.Text = "Dresden";
                BtnD.Text = "Berlin";
                label2.Text = "Berlin";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Berlin.jpg";
            }

            if(sayac == 3)
            {
                label1.Text = "Fransa";
                BtnA.Text = "Lyon";
                BtnB.Text = "Paris";
                BtnC.Text = "Marsilya";
                BtnD.Text = "Lille";
                label2.Text = "Paris";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Paris.jpg";
            }

            if(sayac == 4)
            {
                label1.Text = "Ingiltere";
                BtnA.Text = "Londra";
                BtnB.Text = "Bristol";
                BtnC.Text = "Manchester";
                BtnD.Text = "Chelsea";
                label2.Text = "Londra";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Londra.jpg";
            }

            if(sayac == 5)
            {
                label1.Text = "Italya";
                BtnA.Text = "Milano";
                BtnB.Text = "Floransa";
                BtnC.Text = "Roma";
                BtnD.Text = "Venedik";
                label2.Text = "Roma";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Roma.jpg";

            }

            if(sayac == 6)
            {
                label1.Text = "Norvec";
                BtnA.Text = "Bergen";
                BtnB.Text = "Drammen";
                BtnC.Text = "Molde";
                BtnD.Text = "Oslo";
                label2.Text = "Oslo";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Oslo.jpg";
            }

            if(sayac == 7)
            {
                label1.Text = "Ispanya";
                BtnA.Text = "Madrid";
                BtnB.Text = "Barcelona";
                BtnC.Text = "Sevilla";
                BtnD.Text = "Granada";
                label2.Text = "Madrid";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Madrid.jpg";

            }
            if(sayac == 8)
            {
                label1.Text = "Isvicre";
                BtnA.Text = "Basel";
                BtnB.Text = "Bern";
                BtnC.Text = "Zurih";
                BtnD.Text = "Cenevre";
                label2.Text = "Bern";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Bern.jpg";

            }
            if(sayac == 9)
            {
                label1.Text = "Rusya";
                BtnA.Text = "Kazan";
                BtnB.Text = "Soci";
                BtnC.Text = "St Petersburg";
                BtnD.Text = "Moskova";
                label2.Text = "Moskova";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Moskova.jpg";
            }

            if(sayac == 10)
            {
                label1.Text = "Japonya";
                BtnA.Text = "Osaka";
                BtnB.Text = "Kyoto";
                BtnC.Text = "Tokyo";
                BtnD.Text = "Hirosima";
                label2.Text = "Tokyo";
                pictureBox1.ImageLocation = @"C:\Users\İbrahim\OneDrive\Desktop\__installer\downloaded\Tokyo.jpg";
            }
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            label3.Text = BtnA.Text;
            if(label2.Text == label3.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                BtnA.BackColor = Color.Green;
            }
            else
            {
                BtnA.BackColor = Color.Red;
            }

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            label3.Text = BtnB.Text;
            if(label2.Text == label3.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
            }

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            label3.Text = BtnC.Text;
            if(label2.Text == label3.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
            }

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            label3.Text = BtnD.Text;
            if(label2.Text == label3.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
            }

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }

        private void BtnA_Click_1(object sender, EventArgs e)
        {
            Button basilanButton = (Button)sender;
            label3.Text = basilanButton.Text;
            if (label2.Text == label3.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                BtnA.BackColor = Color.Green;
            }
            else
            {
                BtnA.BackColor = Color.Red;
            }

                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;

            }
        
        

        private void BtnSoru_Click(object sender, EventArgs e)
        {
            Button basilanButton = (Button)sender;
            label3.Text = basilanButton.Text;
        }

        private void BtnB_Click_1(object sender, EventArgs e)
        {
            Button basilanButton = (Button)sender;
            label3.Text = basilanButton.Text;
            if (label2.Text == label3.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                BtnB.BackColor = Color.Green;
            }
            else
            {
                BtnB.BackColor = Color.Red;
            }


                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }

        

        private void BtnC_Click_1(object sender, EventArgs e)
        {
            Button basilanButton = (Button)sender;
            label3.Text = basilanButton.Text;
            if (label2.Text == label3.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                BtnC.BackColor = Color.Green;
            }
            else
            {
                BtnC.BackColor = Color.Red;
            }
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }
        

        private void BtnD_Click_1(object sender, EventArgs e)
        {
            Button basilanButton = (Button)sender;
            label3.Text = basilanButton.Text;
            if (label2.Text == label3.Text)
            {
                puan = puan + 10;
                label5.Text = puan.ToString();
                BtnD.BackColor = Color.Green;
            }
            else
            {
                BtnD.BackColor = Color.Red;
            }
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }
        

        private void label4_Click(object sender, EventArgs e)
        {
            BtnA.BackColor = Color.Gray;
            BtnB.BackColor = Color.Gray;
            BtnC.BackColor = Color.Gray;
            BtnD.BackColor = Color.Gray;


        }
    }
}
