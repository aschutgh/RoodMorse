using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// FIXME: Need to clean up some function names

namespace RoodMorse
{
    public partial class Form1 : Form
    {
        public Form1(Dictionary<string, string> tomorsetable, Dictionary<string, string> tolangtable)
        {
            InitializeComponent();
            ToMorseTable = tomorsetable;
            ToLangTable = tolangtable;
            Alnum = "abcedefghijklmnopqrstuvwxyz0123456789";
            Alnum = Alnum.ToUpper();
            selectedrb = radioButton2;
        }

        static Dictionary<string, string> ToMorseTable { get; set; }
        static Dictionary<string, string> ToLangTable { get; set; }
        static string Alnum { get; set; }
        private RadioButton selectedrb;

        private void CheckMorse()
        {
            
        }

        private void CheckLang()
        {

        }

        private void ToLang(string tolang)
        {
            string[] words;
            string[] sepw = new string[] { "   " };
            words = tolang.Split(sepw, StringSplitOptions.None);
            foreach(string word in words)
            {
                string[] letters;
                string[] sepl = new string[] { " " };
                letters = word.Split(sepl, StringSplitOptions.None);
                foreach(string letter in letters)
                {
                    if (ToLangTable.ContainsKey(letter))
                        textBoxMorse.AppendText(ToLangTable[letter]);
                }
                textBoxMorse.AppendText(" ");
            }
        }

        private void ToMorse(string tomorse)
        {

            foreach(char c in tomorse)
            {
                if (Alnum.Contains(c.ToString().ToUpper()))
                {
                textBoxMorse.AppendText(ToMorseTable[c.ToString()]);
                textBoxMorse.AppendText(" ");
                }
                if (c.ToString() == " ")
                    textBoxMorse.AppendText("   ");
            }
        }

        private void Translate()
        {
            if (selectedrb.Text == "Morse")
                ToMorse(textBoxLanguage.Text.ToUpper());
            if (selectedrb.Text == "Language")
                ToLang(textBoxLanguage.Text);
        }

        private void buttonConvertClick(object sender, MouseEventArgs e)
        {
            Translate();
        }

        private void buttonClearClick(object sender, MouseEventArgs e)
        {
            textBoxLanguage.Clear();
            textBoxMorse.Clear();
        }

        private void LMCheckChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                selectedrb = rb;
            }
        }
    }
}
