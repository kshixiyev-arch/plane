using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;


namespace plane
{
    public partial class Form1 : Form
    {
        private bool isLightOn = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void PlaySound(string soundName)
        {
            try
            {
                // Layihənin əsas papkasına tam yol tapırıq
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string soundPath = Path.Combine(projectDirectory, "Resources", soundName);

                if (File.Exists(soundPath))
                {
                    SoundPlayer player = new SoundPlayer(soundPath);
                    player.Play();
                }
                else
                {
                    MessageBox.Show("Fayl tapılmadı:\n" + soundPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Səs xətası:\n" + ex.Message);
            }
        }

        private void btnEnis_Click(object sender, EventArgs e)
        {
            PlaySound("inishazirliklari.wav");
        }

        private void btnTurbulans_Click(object sender, EventArgs e)
        {
            PlaySound("turbulans.wav");
        }

        private void btnKemerler_Click(object sender, EventArgs e)
        {
            PlaySound("kemerler.wav");
        }

        private void btnTesekkurler_Click(object sender, EventArgs e)
        {
            PlaySound("tesekkurler.wav");
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            PlaySound("beep.wav");
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            // İşıq açılıb-bağlanma səsini oxuduruq
            PlaySound("isikacmakapamasesi.wav");

            // Vəziyyəti tərsinə dəyişirik
            isLightOn = !isLightOn;

            // İşıq şəklinin (pbLight) görünməsini tənzimləyirik
            pbLight.Visible = isLightOn;

            if (isLightOn)
            {
                btnOnOff.BackColor = Color.Blue;
            }
            else
            {
                btnOnOff.BackColor = Color.DarkGray;
            }
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            pbPlane.Top -= 10;
            pbLight.Top -= 10;
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            pbPlane.Top += 10;
            pbLight.Top += 10;
        }
    }
}
