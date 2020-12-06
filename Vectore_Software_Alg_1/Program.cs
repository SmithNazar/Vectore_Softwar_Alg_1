using System;

namespace Vectore_Software_Alg_1
{
    class Program
    {
        static string Encoded(string text, int rails)
        {
            string encoded = "";

            for (int i = 0; i < rails; i++) 
            {
                int step = (2 * i);
                for (int j = i; j < text.Length; j += step)
                { 
                    encoded += text[j];
                    j += 2 * rails - 2 - step ;
                    if ( step % (2 * rails - 2) != 0 && j < text.Length)
                    {
                        encoded += text[j];
                    }
                }
            }
            return encoded;
        }
        static string Decoded(string text, int rails)
        {
            string decoded = "";
            for (int i = 0; i < rails; i++)
            {
                for (int j = i; j < text.Length; j =0)
                {
                    decoded += text[j];
                }
            }
            return decoded;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Encoded("WEAREDISCOVEREDFLEEATONCE", 3));
            Console.WriteLine("WECRLTEERDSOEEFEAOCAIVDEN");
        }
    }
}
