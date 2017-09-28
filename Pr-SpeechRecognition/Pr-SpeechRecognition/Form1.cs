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
using System.Speech.Recognition;
using System.Threading;

namespace Pr_SpeechRecognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent(); btnstop.Enabled = false;
        }
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        private void btnspeak_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(txtArea.Text);
            sSynth.Speak(pBuilder);
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            btnstart.Enabled = false;
            btnstop.Enabled = true;
            Choices sList = new Choices();
            sList.Add(new string[] { "hello", "test", "it works", "how", "are", "you", "today", "i", "am", "fine", "exit", "close", "quit", "so" });
            Grammar gr = new Grammar(new GrammarBuilder(sList));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                //sRecognize.LoadGrammar(gr); new DictationGrammar()
                sRecognize.LoadGrammar(new DictationGrammar()); 
                sRecognize.SpeechRecognized += sRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
                sRecognize.Recognize();


            }

            catch
            {
                return;
            }
        }

        private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "Salir" || e.Result.Text == "salir")
            {
                Application.Exit();
            }
            else
            {
                txtArea.Text = txtArea.Text + " " + e.Result.Text.ToString();
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            sRecognize.RecognizeAsyncStop();
            btnstart.Enabled = true;
            btnstop.Enabled = false;
        }
    }
}
