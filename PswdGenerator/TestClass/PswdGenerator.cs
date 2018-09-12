using System;
using System.Linq;
using System.Text;

namespace PswdGenerator
{
    public class PswdGen
    {
        private const int DEFAULT_MIN_PASSWORD_LENGHT = 8;
        private const int DEFAULT_MAX_PASSWORD_LENGHT = 16;
        private const string PASSWORD_CHARS_LCASE = "abcdefghijklmnopqrstuvwxyz";
        private const string PASSWORD_CHARS_UCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string PASSWORD_CHARS_NUMERIC = "0123456789";
        private const string PASSWORD_CHARS_SYMBOLS = "<>&-_@=+*/%$!:;?.^[](){}\\|'#~";

        private static Random rand = new Random();
        public static string Generate(int lenght)
        {
            return Generate(lenght, lenght);
        }

        public static string Generate(int minLenght = DEFAULT_MIN_PASSWORD_LENGHT, int maxLenght = DEFAULT_MAX_PASSWORD_LENGHT, bool forceUpperCase = false, bool forceLowerCase = false, bool forceSymbol = false, bool forceNumber = false, int minNumber = 2, int minLowerCase = 2, int minUpperCase = 2, int minSymbol = 2)
        {
            
            if (minLenght <= 0) { minLenght = DEFAULT_MIN_PASSWORD_LENGHT; }
            if (maxLenght <= 0) { maxLenght = DEFAULT_MAX_PASSWORD_LENGHT; }
            int allMinValue = minNumber + minLowerCase + minUpperCase + minSymbol;
            if (maxLenght < allMinValue) { maxLenght = allMinValue; }
            if (minLenght > maxLenght) { int tmpLenght = minLenght; minLenght = maxLenght; maxLenght = tmpLenght; }

            StringBuilder sbPasswordDictionnary = new StringBuilder();
            if (forceLowerCase) { sbPasswordDictionnary.Append(PASSWORD_CHARS_LCASE); }
            if (forceUpperCase) { sbPasswordDictionnary.Append(PASSWORD_CHARS_UCASE); }
            if (forceNumber) { sbPasswordDictionnary.Append(PASSWORD_CHARS_NUMERIC); }
            if (forceSymbol) { sbPasswordDictionnary.Append(PASSWORD_CHARS_SYMBOLS); }

            char[] password = null;

            if (minLenght < maxLenght) { password = new char[rand.Next(minLenght, maxLenght + 1)]; }
            else { password = new char[minLenght]; }
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = sbPasswordDictionnary[rand.Next(0, sbPasswordDictionnary.Length)];
                if (i > 0 && password[i] == password[i - 1]) { i--; }
                if (i != (password.Length - 1)) { continue; }
                if (forceNumber && (uint)password.Count((c) => char.IsNumber(c)) < minNumber) { i = -1; }
                if (forceLowerCase && (uint)password.Count((c) => char.IsLower(c)) < minLowerCase) { i = -1; }
                if (forceUpperCase && (uint)password.Count((c) => char.IsUpper(c)) < minUpperCase) { i = -1; }
                if (forceSymbol && (uint)password.Count((c) => char.IsUpper(c)) < minSymbol) { i = -1; }
            }

            return new string(password);
        }
    }
}
