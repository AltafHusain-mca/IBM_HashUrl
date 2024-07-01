using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_HashUrl
{
    public class clsHash
    {
        public string GettingHashCode(string url,string hascode,int k)
        {
            string result = "";
            int urlLength = url.Length;
            int hasArrlen = (urlLength % k == 0) ? (urlLength / k) : ((urlLength / k) + 1);
            string[] str = new string[hasArrlen];
            for(int i=0;i < hasArrlen;i++)
            {
                if (i < hasArrlen-1)
                {
                    str[i] = url.Substring(i * k, k);
                }
                else
                {
                    str[i] = url.Substring(i * k, (urlLength - (i * k)));
                }
                Console.WriteLine(str[i]);
            }
            int lenHashcode = hascode.Length;
            
            for(int j=0;j < hasArrlen;j++)
            {
                string urlSubStr = str[j];
                int sumulr = 0;
                foreach(char c in str[j].ToCharArray())
                {
                    if (c == ':')
                    {
                        sumulr = sumulr + 27;
                    }
                    else if(c == '\\')
                    {
                        sumulr = sumulr + 57;
                    }
                    else
                    {
                        sumulr = sumulr + (((int)char.ToUpper(c)) - 64);
                    }
                }
                int codenum = sumulr % lenHashcode;
                result = result + hascode.ElementAt(codenum);
            }
           
            return result;
        }
    }
}
