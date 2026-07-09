using System;
using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder(identifier.Length);
        bool capitalizeNext = false;
        
        foreach (char c in identifier)
        {
            if(Char.IsWhiteSpace(c))
            { 
                sb.Append("_");
                continue;
            }
            if(char.IsControl(c))
            {
                sb.Append("CTRL") ;
                continue;
            }
            if (c == '-')
            {
                capitalizeNext = true;
                continue;
            }
            if (!(char.IsLetter(c)))
                continue;
            
            if (c >= 'α' && c <= 'ω')
                continue;
            
            sb.Append(capitalizeNext ? Char.ToUpper(c) : c);
            capitalizeNext = false;
        }
        return sb.ToString();
    }
}
