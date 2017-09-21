using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Boolean sci1 = false, sto1 = false, ppr1 = false;
        Boolean sci2 = false, sto2 = false, ppr2 = false;

        Boolean startkey = false;

        int round=0, score1=0 , score2=0;
        string input1, input2;


        void gamelogic()
        {

            //draw match logic
            if (sci1 == true && sci2 == true)
            {
                MessageBox.Show(" MATCH DRAW ");
                startkey = false;
                sci1 = false;
                sci2 = false;
            }
            if (ppr1 == true && ppr2 == true)
            {
                MessageBox.Show(" MATCH DRAW ");
                startkey = false;
                ppr1 = false;
                ppr2 = false;
            }
            if (sto1 == true && sto2 == true)
            {
                MessageBox.Show(" MATCH DRAW ");
                startkey = false;
                sto1 = false;
                sto2 = false;
            }


            //match win logic
            if (sci1 == true && sto2 == true)
            {
                progressBar2.Increment(10);
                startkey = false;
                sci1 = false;
                sto2 = false;
            }
            if (sci1 == true && ppr2 == true)
            {
                progressBar1.Increment(10);
                startkey = false;
                sci1 = false;
                ppr2 = false;
            }
            if (sto1 == true && ppr2 == true)
            {
                progressBar2.Increment(10);
                startkey = false;
                sto1 = false;
                ppr2 = false;
            }
            if (sto1 == true && sci2 == true)
            {
                progressBar1.Increment(10);
                startkey = false;
                sto1 = false;
                sci2 = false;
            }
            if (ppr1 == true && sto2 == true)
            {
                progressBar1.Increment(10);
                startkey = false;
                ppr1 = false;
                sto2 = false;
            }
            if (ppr1 == true && sci2 == true)
            {
                progressBar2.Increment(10);
                startkey = false;
                ppr1 = false;
                sci2 = false;
            }

            //game final win logic
            if (progressBar1.Value==progressBar1.Maximum || progressBar2.Value==progressBar2.Maximum)
            {
                if (progressBar1.Value==progressBar1.Maximum)
                {

                    MessageBox.Show("PLAYER ONE WINS THE GAME !!!");
                    startkey = false;
                    progressBar1.Increment(-100);
                    progressBar2.Increment(-100);

                }
                if (progressBar2.Value==progressBar2.Maximum)
                {
                    MessageBox.Show("PLAYER TWO WINS THE GAME !!!");
                    startkey = false;
                    progressBar1.Increment(-100);
                    progressBar2.Increment(-100);

                }
            }
        }

        void startlogic()
        {

            round = round++;
               // string mytext = i.ToString();
            textBox1.Text = "5";
            Task.Delay(1000).Wait();
            
            
            textBox1.Text = "4";
            Task.Delay(1000).Wait();
            
        
            textBox1.Text = "3";
            Task.Delay(1000).Wait();
            

            textBox1.Text = "2";
            Task.Delay(1000).Wait();
           

            textBox1.Text = "1";
            Task.Delay(1000).Wait();
            
            textBox1.Text = "GO!";
            startkey = true;


        }
            public SoundPlayer _soundplayer;
       // private object _SoundPlayer;

        public Form1()
        {
            InitializeComponent();
            _soundplayer = new SoundPlayer("C:/Users/Durgesh Reddiyar/Desktop/temp/sound.wav");
            _soundplayer.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            startlogic();
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (startkey == true) //start authentication
            {   //image logic
                if (e.KeyCode == Keys.A)
                {
                    sci1 = true;
                    pictureBox1.Image = Image.FromFile("E:\\TY SEM2\\C#\\WindowsFormsApplication1\\images\\sci.jpeg");
                    label11.Text = "scissors selected";
                }
                if (e.KeyCode == Keys.S)
                {
                    sto1 = true;
                    pictureBox1.Image = Image.FromFile("E:\\TY SEM2\\C#\\WindowsFormsApplication1\\images\\sto.jpg");
                    label11.Text = "stone selected";
                }
                if (e.KeyCode == Keys.D)
                {
                    ppr1 = true;
                    pictureBox1.Image = Image.FromFile("E:\\TY SEM2\\C#\\WindowsFormsApplication1\\images\\ppr.jpg");
                    label11.Text = "paper selected";
                }
                if (e.KeyCode == Keys.J)
                {
                    sci2 = true;
                    pictureBox2.Image = Image.FromFile("E:\\TY SEM2\\C#\\WindowsFormsApplication1\\images\\sci.jpeg");
                    label12.Text = "scissors selected";
                }
                if (e.KeyCode == Keys.K)
                {
                    sto2 = true;
                    pictureBox2.Image = Image.FromFile("E:\\TY SEM2\\C#\\WindowsFormsApplication1\\images\\sto.jpg");
                    label12.Text = "stone selected";
                }
                if (e.KeyCode == Keys.L)
                {
                    ppr2 = true;
                    pictureBox2.Image = Image.FromFile("E:\\TY SEM2\\C#\\WindowsFormsApplication1\\images\\ppr.jpg");
                    label12.Text = "paper selected";
                }
            }

            gamelogic();

           


        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
       
        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.Text="MUTE";
                _soundplayer.Play();
            }
            else
            {
                checkBox1.Text = "PLAY SOUND";
                _soundplayer.Stop();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
