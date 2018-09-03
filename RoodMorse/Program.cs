using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoodMorse
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Dictionary<string, string> GetToMorseTable()
        {
            Dictionary<string, string> morsetable = new Dictionary<string, string>();
            morsetable.Add("A", ".-");
            morsetable.Add("B", "-...");
            morsetable.Add("C", "-.-.");
            morsetable.Add("D", "-..");
            morsetable.Add("E", ".");
            morsetable.Add("F", "..-.");
            morsetable.Add("G", "--.");
            morsetable.Add("H", "....");
            morsetable.Add("I", "..");
            morsetable.Add("J", ".---");
            morsetable.Add("K", "-.-");
            morsetable.Add("L", ".-..");
            morsetable.Add("M","--");
            morsetable.Add("N","-.");
            morsetable.Add("O","---");
            morsetable.Add("P",".--.");
            morsetable.Add("Q", "--.-");
            morsetable.Add("R", ".-.");
            morsetable.Add("S", "...");
            morsetable.Add("T", "-");
            morsetable.Add("U", "..-");
            morsetable.Add("V", "...-");
            morsetable.Add("W", ".--");
            morsetable.Add("X", "-..-");
            morsetable.Add("Y", "-.--");
            morsetable.Add("Z", "--..");
            morsetable.Add("1", ".----");
            morsetable.Add("2", "..---");
            morsetable.Add("3", "...--");
            morsetable.Add("4", "....-");
            morsetable.Add("5", ".....");
            morsetable.Add("6", "-....");
            morsetable.Add("7", "--...");
            morsetable.Add("8", "---..");
            morsetable.Add("9", "----.");
            morsetable.Add("0", "-----");
            return morsetable;
        }


        public static Dictionary<string, string> GetToLangTable(Dictionary<string, string> mt)
        {
            Dictionary<string, string> langtable = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> kvp in mt)
            {
                langtable.Add(kvp.Value, kvp.Key);
            }
            langtable.Add("   ", " ");
            langtable.Add(" ", " ");
            langtable.Add("    ", " ");

            return langtable;
        }

        [STAThread]
        static void Main()
        {
            var ToMorseTable = GetToMorseTable();
            var ToLangTable = GetToLangTable(ToMorseTable);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(ToMorseTable, ToLangTable));
        }
    }
}
