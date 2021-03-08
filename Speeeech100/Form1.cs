using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.IO;
using System.Globalization;

namespace Speeeech100
{
    public partial class frmMain : Form
    {
        //Variablendeklaration
        SpeechSynthesizer Reader;
        OpenFileDialog FileDialog = new OpenFileDialog();
        FolderBrowserDialog FolderDialog = new FolderBrowserDialog();
        NAudio.Wave.WaveFileWriter WaveWriter = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Reader initialisieren
            Reader = new SpeechSynthesizer();

            //Combobox mit den auf dem System installierten Voices füllen
            foreach (var voice in Reader.GetInstalledVoices())
            {
                cmbLanguages.Items.Add(voice.VoiceInfo.Name);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Die Voice wählen
            try
            {
                Reader.SelectVoice(cmbLanguages.Text);
            }
            catch
            {
                MessageBox.Show("Wählen sie erst eine Voice/Sprache!");
                return;
            }

            //Text in rtxText wird vorgelesen
            if (rtxText.Text != "")
            {
                Reader.Dispose();
                Reader = new SpeechSynthesizer();
                Reader.SpeakAsync(rtxText.Text);
            }

            if (rtxText.Text != "")
            {
                //Geschwindigkeit der Vorlesung
                Reader.Rate = trbSpeed.Value;

                //Lautstärke der Vorlesung
                Reader.Volume = trbVolume.Value;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Vorlesung wird gestoppt
            if (Reader != null)
            {
                Reader.Dispose();
            }
        }

        private void btnBruh_Click(object sender, EventArgs e)
        {
            //Ein Bruh! wird vorgelesen
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.SpeakAsync("BRUH!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Inhalt in rtxText wird gelöscht
            rtxText.Clear();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //Pfad einer Datei wird in txtFileName hinein geschrieben
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = FileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Der Inhalt der Datei unter dem Pfad wird in rtxText hineingeschrieben
            rtxText.Text = Convert.ToString(File.ReadAllText(txtFileName.Text));
        }

        private void btnSaveAudio_Click(object sender, EventArgs e)
        {
            //Audio Speichern
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.Filter = "MP3 Files | *.mp3";
            SaveDialog.ShowDialog();
            string fname;
            fname = SaveDialog.FileName;
            Reader = new SpeechSynthesizer();
            Reader.Rate = trbSpeed.Value;
            Reader.Volume = trbVolume.Value;
            Reader.SetOutputToWaveFile(fname);
            Reader.Speak(rtxText.Text);
            Reader.SetOutputToDefaultAudioDevice();
        }
    }
}
