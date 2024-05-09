
using System.Media;
namespace Стани_богат
{
    public partial class Form1 : Form
    {
        SoundPlayer sp = new SoundPlayer( @"C:\Users\banan\Desktop\sound 1.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            sp.Play();
            btnStart.Hide();

        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            
            sp.Play();
        }
    }
}
