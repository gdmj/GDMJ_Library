using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDMJ_Library
{
    public class Tools
    {
        public class HotKey
        {
            LogBox L = new LogBox();

            char[] w;
            int letter;
            bool Run;
            int Clicks;

            int NowCode;
            int LastCode;

            public HotKey(string word)
            {
                word = word.ToUpper().Replace(" ", string.Empty);
                w = new char[word.Length];
                letter = word.Length;
                for (int i = 0; i < word.Length; i++)
                    w[i] = word[i];
            }

            public bool Check(KeyEventArgs e)
            {
                NowCode = Convert.ToInt32(e.KeyCode);
                Clicks++;

                if (NowCode == GetKeyCode(w[Clicks - 1]))
                {

                }
                else
                {
                    if (NowCode == GetKeyCode(w[0]))
                    {
                        Clicks = 1;
                    }
                    else
                    {
                        Clicks = 0;
                    }
                    
                }

                LastCode = Convert.ToInt32(e.KeyCode);

                if (Clicks > letter)
                {
                    L.Log("Clicks: " + Convert.ToString(Clicks), 2);
                }

                if (Clicks == letter)
                {
                    Clicks = 0;
                    Run = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private int GetKeyCode(char Key)
            {
                int Code = 0;
                switch (Key)
                {
                    case 'A': Code = 65; break;
                    case 'B': Code = 66; break;
                    case 'C': Code = 67; break;
                    case 'D': Code = 68; break;
                    case 'E': Code = 69; break;
                    case 'F': Code = 70; break;
                    case 'G': Code = 71; break;
                    case 'H': Code = 72; break;
                    case 'I': Code = 73; break;
                    case 'J': Code = 74; break;
                    case 'K': Code = 75; break;
                    case 'L': Code = 76; break;
                    case 'M': Code = 77; break;
                    case 'N': Code = 78; break;
                    case 'O': Code = 79; break;
                    case 'P': Code = 80; break;
                    case 'Q': Code = 81; break;
                    case 'R': Code = 82; break;
                    case 'S': Code = 83; break;
                    case 'T': Code = 84; break;
                    case 'U': Code = 85; break;
                    case 'V': Code = 86; break;
                    case 'W': Code = 87; break;
                    case 'X': Code = 88; break;
                    case 'Y': Code = 89; break;
                    case 'Z': Code = 90; break;
                }
                return Code;
            }
        }
    }
}
