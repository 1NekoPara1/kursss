using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursss
{
    public class AtbashShifer
    {
        private Dictionary<char, char> russianAlphabetMapping;
        private Dictionary<char, char> englishAlphabetMapping;
        public string ChifrA(string inputText)
        {

            russianAlphabetMapping = new Dictionary<char, char>()
            {
                {'А', 'Я'}, {'Б', 'Ю'}, {'В', 'Э'}, {'Г', 'Ь'}, {'Д', 'Ы'}, {'Е', 'Ъ'}, {'Ё', 'Щ'}, {'Ж', 'Ш'}, {'З', 'Ч'}, {'И', 'Ц'},
                {'Й', 'Х'}, {'К', 'Ф'}, {'Л', 'У'}, {'М', 'Т'}, {'Н', 'С'}, {'О', 'Р'}, {'П', 'П'}, {'Р', 'О'}, {'С', 'Н'}, {'Т', 'М'},
                {'У', 'Л'}, {'Ф', 'К'}, {'Х', 'Й'}, {'Ц', 'И'}, {'Ч', 'З'}, {'Ш', 'Ж'}, {'Щ', 'Ё'}, {'Ъ', 'Е'}, {'Ы', 'Д'}, {'Ь', 'Г'},
                {'Э', 'В'}, {'Ю', 'Б'}, {'Я', 'А'},
                {'а', 'я'}, {'б', 'ю'}, {'в', 'э'}, {'г', 'ь'}, {'д', 'ы'}, {'е', 'ъ'}, {'ё', 'щ'}, {'ж', 'ш'}, {'з', 'ч'}, {'и', 'ц'},
                {'й', 'х'}, {'к', 'ф'}, {'л', 'у'}, {'м', 'т'}, {'н', 'с'}, {'о', 'р'}, {'п', 'п'}, {'р', 'о'}, {'с', 'н'}, {'т', 'м'},
                {'у', 'л'}, {'ф', 'к'}, {'х', 'й'}, {'ц', 'и'}, {'ч', 'з'}, {'ш', 'ж'}, {'щ', 'ё'}, {'ъ', 'е'}, {'ы', 'д'}, {'ь', 'г'},
                {'э', 'в'}, {'ю', 'б'}, {'я', 'а'}
            };

            englishAlphabetMapping = new Dictionary<char, char>()
            {
                {'A', 'Z'}, {'B', 'Y'}, {'C', 'X'}, {'D', 'W'}, {'E', 'V'}, {'F', 'U'}, {'G', 'T'}, {'H', 'S'}, {'I', 'R'}, {'J', 'Q'},
                {'K', 'P'}, {'L', 'O'}, {'M', 'N'}, {'N', 'M'}, {'O', 'L'}, {'P', 'K'}, {'Q', 'J'}, {'R', 'I'}, {'S', 'H'}, {'T', 'G'},
                {'U', 'F'}, {'V', 'E'}, {'W', 'D'}, {'X', 'C'}, {'Y', 'B'}, {'Z', 'A'},
                {'a', 'z'}, {'b', 'y'}, {'c', 'x'}, {'d', 'w'}, {'e', 'v'}, {'f', 'u'}, {'g', 't'}, {'h', 's'}, {'i', 'r'}, {'j', 'q'},
                {'k', 'p'}, {'l', 'o'}, {'m', 'n'}, {'n', 'm'}, {'o', 'l'}, {'p', 'k'}, {'q', 'j'}, {'r', 'i'}, {'s', 'h'}, {'t', 'g'},
                {'u', 'f'}, {'v', 'e'}, {'w', 'd'}, {'x', 'c'}, {'y', 'b'}, {'z', 'a'}
            };
            StringBuilder result = new StringBuilder();
            foreach (char c in inputText)
            {
                char encryptedChar;
                if (russianAlphabetMapping.ContainsKey(c))
                {
                    encryptedChar = russianAlphabetMapping[c];
                }
                else if (englishAlphabetMapping.ContainsKey(c))
                {
                    encryptedChar = englishAlphabetMapping[c];
                }
                else
                {
                    encryptedChar = c;
                }
                result.Append(encryptedChar);
            }
            return result.ToString();
        }
    }
}
