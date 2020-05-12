using System;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        int res = -1;

        if (Convert.ToInt64(c) >= 65 && Convert.ToInt64(c) <= 90)
        {
            res = (int) (Convert.ToInt64(c) - 65); 
        }

        if (Convert.ToInt64(c) >= 97 && Convert.ToInt64(c) <= 122)
        {
            res = (int) (Convert.ToInt64(c) - 97);
        }

        return res; 
    }
    
    public static char RotChar(char c, int n)
    {
        int place = LetterIndex(c);
        char res = ' '; 
        
        if (Convert.ToInt64(c) >= 65 && Convert.ToInt64(c) <= 90)
        {
            res = (char) ((place + n) % 26) ; 
        }

        if (Convert.ToInt64(c) >= 97 && Convert.ToInt64(c) <= 122)
        {
            res = (char) ((place + n ) % 26);
        }

        else
        {
            res = c;
        }

        return res; 
    }

    public static int[] Histogram(string str)
    {
        int[] tab = new[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        return tab; 
    }
    
    public static string FilterLetters(string str)
    {
        throw new NotImplementedException();
    }

    public static string Extract(string str, int start, int step)
    {
        throw new NotImplementedException();
    }
}
}
