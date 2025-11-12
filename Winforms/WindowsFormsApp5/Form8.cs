using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Synthesis.TtsEngine;
namespace WindowsFormsApp5
{
    public partial class Form8 : Form
    {
        SpeechSynthesizer sp;
        public Form8()
        {
            InitializeComponent();
            sp = new SpeechSynthesizer();
        }
        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            sp.SpeakAsync(textBox1.Text);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            sp.Pause();   
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            sp.Resume();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string voice = comboBox1.SelectedItem.ToString();

            if (voice == "Male")
                sp.SelectVoiceByHints(VoiceGender.Male);
            else if (voice == "Female")
                sp.SelectVoiceByHints(VoiceGender.Female);

        }
    }
}
