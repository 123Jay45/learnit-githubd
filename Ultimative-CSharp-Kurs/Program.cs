using System;
using System.Collections;
using System.IO;

namespace Ultimative_CSharp_Kurs
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Test commit für branch TA0001-Calculation
            //Beispiel für eine Textfile streaming
            ArrayList stringlist = new ArrayList();
            string path = @"C:\tmp/Lernprojekt\Ultimative-CSharp-Kurs\Ultimative-CSharp-Kurs\Textlesen.txt";
            string temp = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while((temp=reader.ReadLine())!= null)
                {
                    stringlist.Add(temp);
                }
            }
            using (StreamWriter writer = new StreamWriter(@"C:\tmp\Lernprojekt\Ultimative-CSharp-Kurs\Ultimative-CSharp-Kurs\Textschreiben.txt"))
            {
                while (stringlist.Count > 0)
                {
                    writer.WriteLine(stringlist[0]);
                    stringlist.RemoveAt(0);
                }
            }
        }
    }
}
