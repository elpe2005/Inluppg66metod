using System;

namespace inluppg63metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Text("Detta är ett exempel. Texten ändras när den skrivs ut");
        }
        static void Text(string lbokstav)
        {
            bool test = true;
            for (int i = 0; i < lbokstav.Length; i++)
            {

                if (test)
                {
                    if (lbokstav[i] == ' ')
                    {
                        test = false;
                        Console.Write(" ");
                        continue;
                    }
                    else 
                    {
                        Console.Write(lbokstav.ToUpper()[i]);
                    }
                }
                if (test==false)
                {
                    if (lbokstav[i] == ' ')
                    {
                        test = true;
                        Console.Write(" ");
                        continue;
                    }
                    else
                    {
                        Console.Write(lbokstav.ToLower()[i]);
                    }
                }
            }   
        }
    }
}