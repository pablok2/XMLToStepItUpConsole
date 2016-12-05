using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XMLToStepItUpConsole
{
    enum ScoreType
    {
        WordsSong,
        Classical,
        Violin,
        Chopin
    };

    class XMLDumping
    {
        public static void DumpXMLValues(string XMLFileUrl)
        {
            XmlTextReader reader = new XmlTextReader(XMLFileUrl);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
        }

        public static Scorepartwise FromXmlString(string xmlString)
        {
            var reader = new StringReader(xmlString);
            var serializer = new XmlSerializer(typeof(Scorepartwise));
            var instance = serializer.Deserialize(reader) as Scorepartwise;

            return instance;
        }

        public static string ScoreToNotes(Scorepartwise scoreObj, ScoreType type)
        {
            StringBuilder sb = new StringBuilder();

            // Get the notes
            foreach (var part in scoreObj.Part)
            {
                foreach (var measure in part.Measure)
                {
                    foreach (var note in measure.Note)
                    {
                        if (note.Pitch != null)
                        {
                            if (type == ScoreType.WordsSong) // Only staff or first (treble) staff
                            {
                                if (note.Staff == null || note.Staff?.CompareTo("1") == 0)
                                {
                                    if (note.Stem?.Text.CompareTo("up") == 0) // Soprano
                                    {
                                        sb.Append(note.Pitch.Step);
                                        sb.Append(note.Pitch.Alter?.CompareTo("1") == 0 ? "b" : ""); // Sharp/Flat
                                        sb.Append(note.Pitch.Octave + ",");
                                        sb.Append(NoteTypeToNum(note.Type) + ","); // Note length
                                    }
                                }
                            }
                            else if (type == ScoreType.Classical) // Just the highest notes
                            {
                                // Different logic that I need help transcribing
                                if (note.Staff?.CompareTo("1") == 0)
                                {
                                    if (note.Voice?.CompareTo("1") == 0) // Top note
                                    {
                                        bool accidental = note.Pitch.Alter?.CompareTo("1") == 0;

                                        sb.Append(note.Pitch.Step);
                                        sb.Append(accidental ? "b" : ""); // Sharp/Flat
                                        sb.Append(note.Pitch.Octave + ",");
                                        sb.Append(NoteTypeToNum(note.Type) + ","); // Note length
                                    }
                                }
                            }
                            else if (type == ScoreType.Violin) // Violin sheet music
                            {
                                if (note.Staff?.CompareTo("1") == 0)
                                {
                                    string noteReal = string.Empty;
                                    noteReal += note.Pitch.Step;
                                    if (note.Accidental?.CompareTo("sharp") == 0 || note.Pitch.Alter?.CompareTo("1") == 0) // noteReal += note.Accidental.CompareTo("sharp") == 0 ? "s" : "";
                                        noteReal += "s";
                                    noteReal += note.Pitch.Octave;

                                    noteReal = ConvertToFlat(noteReal);

                                    sb.Append(noteReal + ",");
                                    float f = NoteTypeToNum(note.Type);
                                    if (note.Dot != null) f = f * 1.5f;
                                    sb.Append(f + ",");
                                }
                            }

                            else if (type == ScoreType.Chopin) // Violin sheet music
                            {
                                if (note.Staff?.CompareTo("1") == 0)
                                {
                                    string noteReal = string.Empty;
                                    noteReal += note.Pitch.Step;
                                    if (note.Accidental?.CompareTo("sharp") == 0 || note.Pitch.Alter?.CompareTo("1") == 0) // noteReal += note.Accidental.CompareTo("sharp") == 0 ? "s" : "";
                                        noteReal += "s";
                                    noteReal += note.Pitch.Octave;

                                    noteReal = ConvertToFlat(noteReal);

                                    sb.Append(noteReal + ",");
                                    float f = NoteTypeToNum(note.Type);
                                    if (note.Dot != null) f = f * 1.5f;
                                    sb.Append(f + ",");
                                }
                            }
                        }
                    }
                }
            }

            return sb.ToString();
        }

        static float NoteTypeToNum(string length)
        {
            if (length.CompareTo("eighth") == 0)
                return 0.125f;
            else if (length.CompareTo("quarter") == 0)
                return 0.25f;
            else if (length.CompareTo("half") == 0)
                return 0.5f;
            else if (length.CompareTo("whole") == 0)
                return 1f;
            else if (length.CompareTo("16th") == 0) // Just make 16ths = eighths for now
                return 0.125f;
            else if (length.CompareTo("32nd") == 0) // Just make 32nds = eighths for now
                return 0.125f;
            else if (length.CompareTo("64th") == 0) // Just make 64ths = eighths for now
                return 0.125f;
            else
                return 9999f;
        }

        static string ConvertToFlat(string note)
        {
            if(note.Contains("s"))
            {
                if (note.CompareTo("Cs4") == 0) note = "Db4";
                else if (note.CompareTo("Ds4") == 0) note = "Eb4";
                else if (note.CompareTo("Fs4") == 0) note = "Gb4";
                else if (note.CompareTo("Gs4") == 0) note = "Ab4";
                else if (note.CompareTo("As4") == 0) note = "Bb4";
                else if (note.CompareTo("Cs5") == 0) note = "Db5";
                else if (note.CompareTo("Ds5") == 0) note = "Eb5";
                else if (note.CompareTo("Fs5") == 0) note = "Gb5";
                else if (note.CompareTo("Gs5") == 0) note = "Ab5";
                else if (note.CompareTo("As5") == 0) note = "Bb5";
                else if (note.CompareTo("Cs6") == 0) note = "Db6";
                else if (note.CompareTo("Ds6") == 0) note = "Eb6";
                else if (note.CompareTo("Gs6") == 0) note = "Ab6";
                else if (note.CompareTo("As6") == 0) note = "Bb6";
                else if (note.CompareTo("Cs7") == 0) note = "Db7";
                else if (note.CompareTo("Ds7") == 0) note = "Eb7";
                else if (note.CompareTo("Fs7") == 0) note = "Gb7";
                else if (note.CompareTo("Gs7") == 0) note = "Ab7";
                else if (note.CompareTo("As7") == 0) note = "Bb7";
                else note = note + "OUT_OF_RANGE";
            }

            return note;
        }
    }
}
