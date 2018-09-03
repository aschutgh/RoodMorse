using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoodMorse
{
    public partial class Form1 : Form
    {
        public Form1(Dictionary<string, string> tomorsetable)
        {
            InitializeComponent();
            ToMorseTable = tomorsetable;
            Alnum = "abcedefghijklmnopqrstuvwxyz0123456789";
            Alnum = Alnum.ToUpper();
            selectedrb = radioButton1;
        }

        static Dictionary<string, string> ToMorseTable { get; set; }
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
