using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDMJ_Library.Tools
{
    public class HotKey
    {

        char[] w;
        int letter;
        int Clicks;
        Int16 Language;

        int NowCode;

        public HotKey(string word)
        {
            word = word.ToUpper().Replace(" ", string.Empty);
            //Проверка алфавита
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if ((c >= 'А') && (c <= 'Я'))
                    Language = 1;//Ru
                else if ((c >= 'A') && (c <= 'Z')) Language = 0;//En
            }
            //Проверка на цифры
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= '0' && word[i] <= '9')
                {
                    Exception.New("The word contains a number");
                }
            }

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

            if (Clicks == letter)
            {
                Clicks = 0;
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

            switch (Language)
            {
                case 0:
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

                case 1:
                    switch (Key)
                    {
                        case 'Ф': Code = 65; break;
                        case 'И': Code = 66; break;
                        case 'С': Code = 67; break;
                        case 'В': Code = 68; break;
                        case 'У': Code = 69; break;
                        case 'А': Code = 70; break;
                        case 'П': Code = 71; break;
                        case 'Р': Code = 72; break;
                        case 'Ш': Code = 73; break;
                        case 'О': Code = 74; break;
                        case 'Л': Code = 75; break;
                        case 'Д': Code = 76; break;
                        case 'Ь': Code = 77; break;
                        case 'Т': Code = 78; break;
                        case 'Щ': Code = 79; break;
                        case 'З': Code = 80; break;
                        case 'Й': Code = 81; break;
                        case 'К': Code = 82; break;
                        case 'Ы': Code = 83; break;
                        case 'Е': Code = 84; break;
                        case 'Г': Code = 85; break;
                        case 'М': Code = 86; break;
                        case 'Ц': Code = 87; break;
                        case 'Ч': Code = 88; break;
                        case 'Н': Code = 89; break;
                        case 'Я': Code = 90; break;
                        case 'Х': Code = 219; break;
                        case 'Ъ': Code = 221; break;
                        case 'Ж': Code = 186; break;
                        case 'Э': Code = 222; break;
                        case 'Б': Code = 188; break;
                        case 'Ю': Code = 190; break;
                        case 'Ё': Code = 192; break;
                    }
                    return Code;

                default: Exception.New("Не известный язык / Не известные символы. Используйте английский или русский язык"); break;
            }
            return Code;
        }

    }

}
