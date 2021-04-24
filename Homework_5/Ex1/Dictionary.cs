using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] eng = new string[5];
        private string[] ukr = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; eng[0] = "book"; ukr[0] = "книга";
            key[1] = "карандаш"; eng[1] = "pencil"; ukr[1] = "олівець";
            key[2] = "солнце"; eng[2] = "sun"; ukr[2] = "сонце";
            key[3] = "яблоко"; eng[3] = "apple"; ukr[3] = "яблуко";
            key[4] = "стол"; eng[4] = "table"; ukr[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + eng[i] /*+ " - " + ukr[i]*/;

                for (int i = 0; i < ukr.Length; i++)
                {
                    if (ukr[i] == index)
                    {
                        return ukr[i] + " - " + key[i] + " - " + eng[i];
                    }
                }

                for (int i = 0; i < eng.Length; i++)
                {
                    if (eng[i] == index)
                    {
                        return eng[i] + " - " + key[i] + " - " + ukr[i];
                    }
                }

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }


        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length && index < ukr.Length)
                    return key[index] + " - " + eng[index] + " - " + ukr[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}