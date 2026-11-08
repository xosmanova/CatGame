using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Task11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        int num;
        int count = 0;

      
        string img = Directory.Exists(@"C:\Users\Student\Desktop\img")
            ? @"C:\Users\Student\Desktop\img\"
            : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img") + "\\";

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            Random r = new Random();
            num = r.Next(1, 7);

          
            pictureBox1.ImageLocation = img + "sual.png";
            pictureBox2.ImageLocation = img + "sual.png";
            pictureBox3.ImageLocation = img + "sual.png";
            pictureBox4.ImageLocation = img + "sual.png";
            pictureBox5.ImageLocation = img + "sual.png";
            pictureBox6.ImageLocation = img + "sual.png";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox1.ImageLocation = img + "bomb.png";
                try
                {
                    SoundPlayer s = new SoundPlayer(img + "bomb.wav");
                    s.Play();
                }
                catch
                {
                    SystemSounds.Beep.Play();
                }
                MessageBox.Show("Oyun bitdi");
            }
            else
            {
                pictureBox1.ImageLocation = img + "cat.png";
                pictureBox1.Enabled = false;
                count++;
                label2.Text = count.ToString();

                if (count == 5)
                {
                    MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                    count = 0;
                    label2.Text = "0";
                    Random r = new Random();
                    num = r.Next(1, 7);

                    pictureBox1.ImageLocation = img + "sual.png";
                    pictureBox2.ImageLocation = img + "sual.png";
                    pictureBox3.ImageLocation = img + "sual.png";
                    pictureBox4.ImageLocation = img + "sual.png";
                    pictureBox5.ImageLocation = img + "sual.png";
                    pictureBox6.ImageLocation = img + "sual.png";

                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (num == 2)
            {
                pictureBox2.ImageLocation = img + "bomb.png";
                try
                {
                    SoundPlayer s = new SoundPlayer(img + "bomb.wav");
                    s.Play();
                }
                catch
                {
                    SystemSounds.Beep.Play();
                }
                MessageBox.Show("Oyun bitdi");
            }
            else
            {
                pictureBox2.ImageLocation = img + "cat.png";
                pictureBox2.Enabled = false;
                count++;
                label2.Text = count.ToString();

                if (count == 5)
                {
                    MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                    count = 0;
                    label2.Text = "0";
                    Random r = new Random();
                    num = r.Next(1, 7);

                    pictureBox1.ImageLocation = img + "sual.png";
                    pictureBox2.ImageLocation = img + "sual.png";
                    pictureBox3.ImageLocation = img + "sual.png";
                    pictureBox4.ImageLocation = img + "sual.png";
                    pictureBox5.ImageLocation = img + "sual.png";
                    pictureBox6.ImageLocation = img + "sual.png";

                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (num == 3)
            {
                pictureBox3.ImageLocation = img + "bomb.png";
                try
                {
                    SoundPlayer s = new SoundPlayer(img + "bomb.wav");
                    s.Play();
                }
                catch
                {
                    SystemSounds.Beep.Play();
                }
                MessageBox.Show("Oyun bitdi");
            }
            else
            {
                pictureBox3.ImageLocation = img + "cat.png";
                pictureBox3.Enabled = false;
                count++;
                label2.Text = count.ToString();

                if (count == 5)
                {
                    MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                    count = 0;
                    label2.Text = "0";
                    Random r = new Random();
                    num = r.Next(1, 7);

                    pictureBox1.ImageLocation = img + "sual.png";
                    pictureBox2.ImageLocation = img + "sual.png";
                    pictureBox3.ImageLocation = img + "sual.png";
                    pictureBox4.ImageLocation = img + "sual.png";
                    pictureBox5.ImageLocation = img + "sual.png";
                    pictureBox6.ImageLocation = img + "sual.png";

                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (num == 4)
            {
                pictureBox4.ImageLocation = img + "bomb.png";
                try
                {
                    SoundPlayer s = new SoundPlayer(img + "bomb.wav");
                    s.Play();
                }
                catch
                {
                    SystemSounds.Beep.Play();
                }
                MessageBox.Show("Oyun bitdi");
            }
            else
            {
                pictureBox4.ImageLocation = img + "cat.png";
                pictureBox4.Enabled = false;
                count++;
                label2.Text = count.ToString();

                if (count == 5)
                {
                    MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                    count = 0;
                    label2.Text = "0";
                    Random r = new Random();
                    num = r.Next(1, 7);

                    pictureBox1.ImageLocation = img + "sual.png";
                    pictureBox2.ImageLocation = img + "sual.png";
                    pictureBox3.ImageLocation = img + "sual.png";
                    pictureBox4.ImageLocation = img + "sual.png";
                    pictureBox5.ImageLocation = img + "sual.png";
                    pictureBox6.ImageLocation = img + "sual.png";

                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (num == 5)
            {
                pictureBox5.ImageLocation = img + "bomb.png";
                try
                {
                    SoundPlayer s = new SoundPlayer(img + "bomb.wav");
                    s.Play();
                }
                catch
                {
                    SystemSounds.Beep.Play();
                }
                MessageBox.Show("Oyun bitdi");
            }
            else
            {
                pictureBox5.ImageLocation = img + "cat.png";
                pictureBox5.Enabled = false;
                count++;
                label2.Text = count.ToString();

                if (count == 5)
                {
                    MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                    count = 0;
                    label2.Text = "0";
                    Random r = new Random();
                    num = r.Next(1, 7);

                    pictureBox1.ImageLocation = img + "sual.png";
                    pictureBox2.ImageLocation = img + "sual.png";
                    pictureBox3.ImageLocation = img + "sual.png";
                    pictureBox4.ImageLocation = img + "sual.png";
                    pictureBox5.ImageLocation = img + "sual.png";
                    pictureBox6.ImageLocation = img + "sual.png";

                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (num == 6)
            {
                pictureBox6.ImageLocation = img + "bomb.png";
                try
                {
                    SoundPlayer s = new SoundPlayer(img + "bomb.wav");
                    s.Play();
                }
                catch
                {
                    SystemSounds.Beep.Play();
                }
                MessageBox.Show("Oyun bitdi");
            }
            else
            {
                pictureBox6.ImageLocation = img + "cat.png";
                pictureBox6.Enabled = false;
                count++;
                label2.Text = count.ToString();

                if (count == 5)
                {
                    MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın");
                    count = 0;
                    label2.Text = "0";
                    Random r = new Random();
                    num = r.Next(1, 7);

                    pictureBox1.ImageLocation = img + "sual.png";
                    pictureBox2.ImageLocation = img + "sual.png";
                    pictureBox3.ImageLocation = img + "sual.png";
                    pictureBox4.ImageLocation = img + "sual.png";
                    pictureBox5.ImageLocation = img + "sual.png";
                    pictureBox6.ImageLocation = img + "sual.png";

                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                }
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            label2.Text = "0";
            Random r = new Random();
            num = r.Next(1, 7);

            pictureBox1.ImageLocation = img + "sual.png";
            pictureBox2.ImageLocation = img + "sual.png";
            pictureBox3.ImageLocation = img + "sual.png";
            pictureBox4.ImageLocation = img + "sual.png";
            pictureBox5.ImageLocation = img + "sual.png";
            pictureBox6.ImageLocation = img + "sual.png";

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
        }
    }
}
