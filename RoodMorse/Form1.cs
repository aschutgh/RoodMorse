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
        public Form1(Dictionary<string, string> morsetable)
        {
            InitializeComponent();
            MorseTable = morsetable;
            Alnum = "abcedefghijklmnopqrstuvwxyz0123456789";
            Alnum = Alnum.ToUpper();
        }

        static Dictionary<string, string> MorseTable { get; set; }
        static string Alnum { get; set; }

        private void CheckMorse()
        {
            
        }

        private void CheckLang()
        {

        }

        private void ToLang()
        {

        }

        private void ToMorse(string tomorse)
        {

            foreach(char c in tomorse)
            {
                if (Alnum.Contains(c.ToString().ToUpper()))
                {
                textBoxMorse.AppendText(MorseTable[c.ToString()]);
                textBoxMorse.AppendText(" ");
                //textBoxMorse.AppendText(c.ToString());
                }
            }
        }

        private void Translate()
        {
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
    }
}
