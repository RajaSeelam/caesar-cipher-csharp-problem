using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
      
        public static string Rotate(string text, int shiftKey)
        {
            string ans = "";
            for(int i=0;i<text.Length;i++)
            {
                char cipher;

                if(char.IsLetter(text[i]))
                {
                    if (char.IsUpper(text[i]))
                    {
                        cipher = (char)(((text[i] - 65 + shiftKey) % 26) + 65);
                    }
                    else
                    {
                        cipher = (char)(((text[i] - 97 + shiftKey) % 26) + 97);
                    }

                    ans = ans + cipher;

                }

                else
                {
                    ans = ans + text[i];
                }
                
             }
            return ans;
        }
        public static void Main(string[] args){
            Rotate("raja", 3);
            
        }
    }
}
