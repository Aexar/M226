using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVisualStudio
{
    class Program
    {
        const int NBCOL = 677;
        const int NBROW = 10;
        const string FILE_PATH = "C:\\Users\\richarda\\Documents\\csvFile.csv";

        static void Main(string[] args)
        {
            Random rnd = new Random();
            String newLine;

            int firstChar;
            int secondChar;

            var csvFile = new StringBuilder();
       
            for (int z = 1; z < NBROW+1; z++)
            {
                newLine = "";
                for(int i = 0; i<NBCOL; i++)
                {
                    newLine += rnd.Next(101).ToString();
                    if(i < NBCOL - 1)
                    {
                        newLine += ";";
                    }
                    Char c = (Char)( 97+ ( z - 1));
                }
                csvFile.AppendLine(newLine);
            }
            newLine = "";
            /*for (int z = 0; z < NBCOL; z++)
            {
                if (z < 26)
                {
                    Char c = (Char)(  + z);

                    // build the string
                    newLine += "=MOYENNE(" + c + "1:" + c + NBROW + ")";   // exemple : =MOYENNE(K1:K10)
                }
                else
                {
                    firstChar = (z / 26) - 1; // First character
                    secondChar = z % 26;      // Second character
                    Char cFirst = (Char)(97 + firstChar);
                    Char cSecond = (Char)(97 + secondChar);

                    // build the string
                    newLine += "=MOYENNE(" + cFirst + cSecond + "1:" + cFirst +cSecond + NBROW + ")";    // exemple : =MOYENNE(AN1:AN10)
                }
                
                if (z < NBCOL - 1)
                {
                    newLine += ";";
                }
            }*/
            Test(NBCOL);
            csvFile.AppendLine(newLine);
            // Write to the csv / create
            File.WriteAllText(FILE_PATH, csvFile.ToString());
        }

        static public void Test(int y)
        {
            

            if (y/26 >26)
            {
                int x = y - (26 * 26);
                System.Console.Write("26 : ");
                Test(x);
            }
            else if (y / 26 < 1)
            {

                System.Console.Write(y + " : ");
            }
            else if( y/26 < 26)
            {
                int test = y / 26;
                int x = y - (test * 26);
                System.Console.Write(x + " : ");
                Test(x);
            }
            
            
        }
    }
}
