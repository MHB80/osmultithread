using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class play : Form
    {

        Boolean isitplaying = true;
        Boolean isitclosed = false;
        public play()
        {
            InitializeComponent();
            
        }
        public Boolean returnstatus() {
            return isitclosed;
        }

        private void play_Load(object sender, EventArgs e)
        {
            BackColor = Color.DarkCyan;
            mediaplayer.uiMode = "none";
        }

        private void playvidbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openfile.FileName);
                mediaplayer.settings.autoStart = true;
                mediaplayer.URL = openfile.FileName;

            }
        }

        private void pausebuttom_Click(object sender, EventArgs e)
        {
            if (isitplaying)
            {
                pausebuttom.Text = "Play";

                mediaplayer.Ctlcontrols.pause();

                isitplaying = false;
            }
            else
            {
                pausebuttom.Text = "pause";
                mediaplayer.Ctlcontrols.play();
                isitplaying = true;
            }
        }

        private void volup_Click(object sender, EventArgs e)
        {
            mediaplayer.settings.volume += 10;
        }

        private void voldown_Click(object sender, EventArgs e)
        {
            mediaplayer.settings.volume -= 10;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void play_FormClosed(object sender, FormClosedEventArgs e)
        {
            mediaplayer.Dispose();            
            isitclosed = true;
 
        }
    }
}
