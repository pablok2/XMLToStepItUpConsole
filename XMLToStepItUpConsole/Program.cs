using System;
using System.IO;

namespace XMLToStepItUpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri;
            ScoreType stype;

            //uri = @"E:\Pablo\xml sheet exports\dni-uhodyat-xop.xml";
            //stype = ScoreType.WordsSong;

            //uri = @"E:\Pablo\xml sheet exports\mozart-wolfgang-amadeus-marche-turque-508.xml";
            //stype = ScoreType.Classical;

            //uri = @"E:\Pablo\xml sheet exports\Violin\TheChopin.xml";
            //stype = ScoreType.Chopin;

            uri = @"E:\Pablo\xml sheet exports\Violin\TheChopin.xml";
            stype = ScoreType.Violin;

            if (!File.Exists(uri))
            {
                Console.Write("File don't exist... ");
                Console.ReadLine();
                return;
            }

            string xmlText = File.ReadAllText(uri);
            Scorepartwise scoreObj = XMLDumping.FromXmlString(xmlText);
            string notes = XMLDumping.ScoreToNotes(scoreObj, stype);

            // Output to new file
            string fileName = Path.GetFileNameWithoutExtension(uri);

            notes = notes.Remove(notes.Length - 1); // Remove the last comma and newline
            File.WriteAllText(@"E:\Pablo\music for STEPITUP\" + fileName + ".txt", notes);

            Console.Write(notes);
            Console.ReadLine();
        }        
    }
}
