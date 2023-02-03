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

namespace Proje2
{
    public partial class Form1 : Form
    {
        bool a=true;
        int say = 0;
        string kazanan = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geliştirici: returntr.com","Tic Tac Toe");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button(object sender, EventArgs e)
        {
            Button x = (Button)sender;//birden fazla olayı tek olaya bağlamak
            if (a)
            {
                label2.Text = "O";
                x.Text = "X";
                //Sıradki oyuncu belirtmek için
            }
            else
            {
                label2.Text = "X";
                x.Text = "O";
                
            }
            a = !a; //buttonlara basıldığında X ve O ardışık gelmesi için hapmassak hep X vericek
            x.Enabled = false;//üzerine basılan butona bidaha basılmaması için
            say++;
            kazanan_oyuncu();
            

        }
        private void kazanan_oyuncu()
        {
            bool a_kazanan = false;
            // kazanan kontrolü
            //satır kontrol
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text)&&(!button1.Enabled))//button1.enabled yapmazsak tek kutu açıldığında kazanı veriyo
            {
                a_kazanan = true;
            }
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
            {
                a_kazanan = true;
            }
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
            {
                a_kazanan = true;
            }
            //sütün kontrolü
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))//button1.enabled yapmazsak tek kutu açıldığında kazanıyo verir
            {
                a_kazanan = true;
            }
            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
            {
                a_kazanan = true;
            }
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
            {
                a_kazanan = true;
            }
            //çapraz kontrol
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))//button1.enabled yapmazsak tek kutu açıldığında kazanı veriyo
            {
                a_kazanan = true;
            }
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
            {
                a_kazanan = true;
            }
            if (a_kazanan) //kazananın mesaj box ile kullanıcıya iletilmesi
            {
                butonlari_kapat();
                //string kazanan = "";
                if (a)
                    kazanan = "O";
                else
                    kazanan = "X";
                MessageBox.Show(kazanan+" Kazandı...","Tic Tac Toe");
               // Application.Restart(); denebilir

            }
            else
            {
                if (say == 9)
                {
                    Application.Restart();
                    //yenioyun
                }
            }
        }
        private void butonlari_kapat()
        {
            button1.Enabled = false;//butonları inaktifleştirmek için
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kazanan == "X")
                a = false;//sırasıyla X ve O oyuna başlar
            say = 0;//beraberlik durumunu sıfırlamak için
            button1.Enabled = true; //butonları tekrar aktifleştirmek için
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";//buttonların textini boşaltmak için
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "X";
        }

      
    }
}
