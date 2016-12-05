/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace XMLToStepItUpConsole
{
    [XmlRoot(ElementName = "work")]
    public class Work
    {
        [XmlElement(ElementName = "work-number")]
        public string Worknumber { get; set; }
    }

    [XmlRoot(ElementName = "creator")]
    public class Creator
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "encoding")]
    public class Encoding
    {
        [XmlElement(ElementName = "software")]
        public List<string> Software { get; set; }
        [XmlElement(ElementName = "encoding-date")]
        public string Encodingdate { get; set; }
    }

    [XmlRoot(ElementName = "identification")]
    public class Identification
    {
        [XmlElement(ElementName = "creator")]
        public List<Creator> Creator { get; set; }
        [XmlElement(ElementName = "rights")]
        public List<string> Rights { get; set; }
        [XmlElement(ElementName = "encoding")]
        public Encoding Encoding { get; set; }
        [XmlElement(ElementName = "source")]
        public string Source { get; set; }
    }

    [XmlRoot(ElementName = "scaling")]
    public class Scaling
    {
        [XmlElement(ElementName = "millimeters")]
        public string Millimeters { get; set; }
        [XmlElement(ElementName = "tenths")]
        public string Tenths { get; set; }
    }

    [XmlRoot(ElementName = "page-margins")]
    public class Pagemargins
    {
        [XmlElement(ElementName = "left-margin")]
        public string Leftmargin { get; set; }
        [XmlElement(ElementName = "right-margin")]
        public string Rightmargin { get; set; }
        [XmlElement(ElementName = "top-margin")]
        public string Topmargin { get; set; }
        [XmlElement(ElementName = "bottom-margin")]
        public string Bottommargin { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "page-layout")]
    public class Pagelayout
    {
        [XmlElement(ElementName = "page-height")]
        public string Pageheight { get; set; }
        [XmlElement(ElementName = "page-width")]
        public string Pagewidth { get; set; }
        [XmlElement(ElementName = "page-margins")]
        public Pagemargins Pagemargins { get; set; }
    }

    [XmlRoot(ElementName = "lyric-font")]
    public class Lyricfont
    {
        [XmlAttribute(AttributeName = "font-family")]
        public string Fontfamily { get; set; }
        [XmlAttribute(AttributeName = "font-size")]
        public string Fontsize { get; set; }
    }

    [XmlRoot(ElementName = "defaults")]
    public class Defaults
    {
        [XmlElement(ElementName = "scaling")]
        public Scaling Scaling { get; set; }
        [XmlElement(ElementName = "page-layout")]
        public Pagelayout Pagelayout { get; set; }
        [XmlElement(ElementName = "lyric-font")]
        public Lyricfont Lyricfont { get; set; }
    }

    [XmlRoot(ElementName = "credit-words")]
    public class Creditwords
    {
        [XmlAttribute(AttributeName = "font-family")]
        public string Fontfamily { get; set; }
        [XmlAttribute(AttributeName = "font-size")]
        public string Fontsize { get; set; }
        [XmlAttribute(AttributeName = "default-x")]
        public string Defaultx { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlAttribute(AttributeName = "font-weight")]
        public string Fontweight { get; set; }
        [XmlAttribute(AttributeName = "font-style")]
        public string Fontstyle { get; set; }
    }

    [XmlRoot(ElementName = "credit")]
    public class Credit
    {
        [XmlElement(ElementName = "credit-words")]
        public Creditwords Creditwords { get; set; }
        [XmlAttribute(AttributeName = "page")]
        public string Page { get; set; }
    }

    [XmlRoot(ElementName = "score-instrument")]
    public class Scoreinstrument
    {
        [XmlElement(ElementName = "instrument-name")]
        public string Instrumentname { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "midi-instrument")]
    public class Midiinstrument
    {
        [XmlElement(ElementName = "midi-channel")]
        public string Midichannel { get; set; }
        [XmlElement(ElementName = "midi-program")]
        public string Midiprogram { get; set; }
        [XmlElement(ElementName = "volume")]
        public string Volume { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "score-part")]
    public class Scorepart
    {
        [XmlElement(ElementName = "part-name")]
        public string Partname { get; set; }
        [XmlElement(ElementName = "score-instrument")]
        public Scoreinstrument Scoreinstrument { get; set; }
        [XmlElement(ElementName = "midi-instrument")]
        public Midiinstrument Midiinstrument { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "part-list")]
    public class Partlist
    {
        [XmlElement(ElementName = "score-part")]
        public List<Scorepart> Scorepart { get; set; }
    }

    [XmlRoot(ElementName = "system-margins")]
    public class Systemmargins
    {
        [XmlElement(ElementName = "left-margin")]
        public string Leftmargin { get; set; }
        [XmlElement(ElementName = "right-margin")]
        public string Rightmargin { get; set; }
    }

    [XmlRoot(ElementName = "system-layout")]
    public class Systemlayout
    {
        [XmlElement(ElementName = "system-margins")]
        public Systemmargins Systemmargins { get; set; }
        [XmlElement(ElementName = "top-system-distance")]
        public string Topsystemdistance { get; set; }
        [XmlElement(ElementName = "system-distance")]
        public string Systemdistance { get; set; }
    }

    [XmlRoot(ElementName = "print")]
    public class Print
    {
        [XmlElement(ElementName = "system-layout")]
        public Systemlayout Systemlayout { get; set; }
        [XmlElement(ElementName = "measure-numbering")]
        public string Measurenumbering { get; set; }
        [XmlAttribute(AttributeName = "new-system")]
        public string Newsystem { get; set; }
        [XmlElement(ElementName = "staff-layout")]
        public Stafflayout Stafflayout { get; set; }
        [XmlAttribute(AttributeName = "new-page")]
        public string Newpage { get; set; }
    }

    [XmlRoot(ElementName = "key")]
    public class Key
    {
        [XmlElement(ElementName = "fifths")]
        public string Fifths { get; set; }
    }

    [XmlRoot(ElementName = "time")]
    public class Time
    {
        [XmlElement(ElementName = "beats")]
        public string Beats { get; set; }
        [XmlElement(ElementName = "beat-type")]
        public string Beattype { get; set; }
    }

    [XmlRoot(ElementName = "clef")]
    public class Clef
    {
        [XmlElement(ElementName = "sign")]
        public string Sign { get; set; }
        [XmlElement(ElementName = "line")]
        public string Line { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
    }

    [XmlRoot(ElementName = "staff-details")]
    public class Staffdetails
    {
        [XmlAttribute(AttributeName = "print-object")]
        public string Printobject { get; set; }
    }

    [XmlRoot(ElementName = "attributes")]
    public class Attributes
    {
        [XmlElement(ElementName = "divisions")]
        public string Divisions { get; set; }
        [XmlElement(ElementName = "key")]
        public Key Key { get; set; }
        [XmlElement(ElementName = "time")]
        public Time Time { get; set; }
        [XmlElement(ElementName = "clef")]
        public List<Clef> Clef { get; set; }
        [XmlElement(ElementName = "staff-details")]
        public Staffdetails Staffdetails { get; set; }
        [XmlElement(ElementName = "staves")]
        public string Staves { get; set; }
    }

    [XmlRoot(ElementName = "direction-type")]
    public class Directiontype
    {
        [XmlElement(ElementName = "dynamics")]
        public Dynamics Dynamics { get; set; }
        [XmlElement(ElementName = "words")]
        public Words Words { get; set; }
        [XmlElement(ElementName = "wedge")]
        public Wedge Wedge { get; set; }
    }

    [XmlRoot(ElementName = "sound")]
    public class Sound
    {
        [XmlAttribute(AttributeName = "tempo")]
        public string Tempo { get; set; }
        [XmlAttribute(AttributeName = "dynamics")]
        public string Dynamics { get; set; }
    }

    [XmlRoot(ElementName = "direction")]
    public class Direction
    {
        [XmlElement(ElementName = "direction-type")]
        public Directiontype Directiontype { get; set; }
        [XmlElement(ElementName = "sound")]
        public Sound Sound { get; set; }
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
        [XmlElement(ElementName = "staff")]
        public string Staff { get; set; }
    }

    [XmlRoot(ElementName = "dynamics")]
    public class Dynamics
    {
        [XmlElement(ElementName = "p")]
        public string P { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
        [XmlAttribute(AttributeName = "relative-x")]
        public string Relativex { get; set; }
        [XmlElement(ElementName = "mp")]
        public string Mp { get; set; }
        [XmlElement(ElementName = "mf")]
        public string Mf { get; set; }
        [XmlElement(ElementName = "f")]
        public string F { get; set; }
        [XmlElement(ElementName = "ff")]
        public string Ff { get; set; }
    }

    [XmlRoot(ElementName = "words")]
    public class Words
    {
        [XmlAttribute(AttributeName = "font-family")]
        public string Fontfamily { get; set; }
        [XmlAttribute(AttributeName = "font-size")]
        public string Fontsize { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
        [XmlAttribute(AttributeName = "relative-x")]
        public string Relativex { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlAttribute(AttributeName = "font-weight")]
        public string Fontweight { get; set; }
        [XmlAttribute(AttributeName = "font-style")]
        public string Fontstyle { get; set; }
    }

    [XmlRoot(ElementName = "pitch")]
    public class Pitch
    {
        [XmlElement(ElementName = "step")]
        public string Step { get; set; }
        [XmlElement(ElementName = "alter")]
        public string Alter { get; set; }
        [XmlElement(ElementName = "octave")]
        public string Octave { get; set; }
    }

    [XmlRoot(ElementName = "stem")]
    public class Stem
    {
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "note")]
    public class Note
    {
        [XmlElement(ElementName = "pitch")]
        public Pitch Pitch { get; set; }
        [XmlElement(ElementName = "duration")]
        public string Duration { get; set; }
        [XmlElement(ElementName = "voice")]
        public string Voice { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "stem")]
        public Stem Stem { get; set; }
        [XmlAttribute(AttributeName = "default-x")]
        public string Defaultx { get; set; }
        [XmlElement(ElementName = "notehead")]
        public Notehead Notehead { get; set; }
        [XmlElement(ElementName = "dot")]
        public string Dot { get; set; }
        [XmlElement(ElementName = "notations")]
        public Notations Notations { get; set; }
        [XmlElement(ElementName = "time-modification")]
        public Timemodification Timemodification { get; set; }
        [XmlElement(ElementName = "chord")]
        public string Chord { get; set; }
        [XmlElement(ElementName = "tie")]
        public Tie Tie { get; set; }
        [XmlElement(ElementName = "rest")]
        public string Rest { get; set; }
        [XmlElement(ElementName = "staff")]
        public string Staff { get; set; }
        [XmlElement(ElementName = "accidental")]
        public string Accidental { get; set; }
    }

    [XmlRoot(ElementName = "beam")]
    public class Beam
    {
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "arpeggiate")]
    public class Arpeggiate
    {
        [XmlAttribute(AttributeName = "relative-x")]
        public string Relativex { get; set; }
    }

    [XmlRoot(ElementName = "notehead")]
    public class Notehead
    {
        [XmlAttribute(AttributeName = "filled")]
        public string Filled { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "backup")]
    public class Backup
    {
        [XmlElement(ElementName = "duration")]
        public string Duration { get; set; }
    }

    [XmlRoot(ElementName = "forward")]
    public class Forward
    {
        [XmlElement(ElementName = "duration")]
        public string Duration { get; set; }
        [XmlElement(ElementName = "voice")]
        public string Voice { get; set; }
        [XmlElement(ElementName = "staff")]
        public string Staff { get; set; }
    }

    [XmlRoot(ElementName = "measure")]
    public class Measure
    {
        [XmlElement(ElementName = "print")]
        public Print Print { get; set; }
        [XmlElement(ElementName = "attributes")]
        public Attributes Attributes { get; set; }
        [XmlElement(ElementName = "direction")]
        public List<Direction> Direction { get; set; }
        [XmlElement(ElementName = "note")]
        public List<Note> Note { get; set; }
        [XmlElement(ElementName = "backup")]
        public List<Backup> Backup { get; set; }
        [XmlElement(ElementName = "forward")]
        public List<Forward> Forward { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlElement(ElementName = "barline")]
        public Barline Barline { get; set; }
    }

    [XmlRoot(ElementName = "pedal")]
    public class Pedal
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "line")]
        public string Line { get; set; }
        [XmlAttribute(AttributeName = "default-x")]
        public string Defaultx { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
    }

    [XmlRoot(ElementName = "accent")]
    public class Accent
    {
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
    }

    [XmlRoot(ElementName = "articulations")]
    public class Articulations
    {
        [XmlElement(ElementName = "accent")]
        public List<Accent> Accent { get; set; }
        [XmlElement(ElementName = "strong-accent")]
        public List<Strongaccent> Strongaccent { get; set; }
        [XmlElement(ElementName = "staccatissimo")]
        public Staccatissimo Staccatissimo { get; set; }
    }

    [XmlRoot(ElementName = "notations")]
    public class Notations
    {
        [XmlElement(ElementName = "articulations")]
        public Articulations Articulations { get; set; }
        [XmlElement(ElementName = "tuplet")]
        public Tuplet Tuplet { get; set; }
        [XmlElement(ElementName = "tied")]
        public Tied Tied { get; set; }
        [XmlElement(ElementName = "ornaments")]
        public Ornaments Ornaments { get; set; }
        [XmlElement(ElementName = "slur")]
        public List<Slur> Slur { get; set; }
    }

    [XmlRoot(ElementName = "time-modification")]
    public class Timemodification
    {
        [XmlElement(ElementName = "actual-notes")]
        public string Actualnotes { get; set; }
        [XmlElement(ElementName = "normal-notes")]
        public string Normalnotes { get; set; }
    }

    [XmlRoot(ElementName = "tuplet")]
    public class Tuplet
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
    }

    [XmlRoot(ElementName = "tie")]
    public class Tie
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "tied")]
    public class Tied
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "bezier-x")]
        public string Bezierx { get; set; }
        [XmlAttribute(AttributeName = "bezier-y")]
        public string Beziery { get; set; }
        [XmlAttribute(AttributeName = "default-x")]
        public string Defaultx { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
        [XmlAttribute(AttributeName = "orientation")]
        public string Orientation { get; set; }
    }

    [XmlRoot(ElementName = "strong-accent")]
    public class Strongaccent
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
    }

    [XmlRoot(ElementName = "staccatissimo")]
    public class Staccatissimo
    {
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
    }

    [XmlRoot(ElementName = "part")]
    public class Part
    {
        [XmlElement(ElementName = "measure")]
        public List<Measure> Measure { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "wedge")]
    public class Wedge
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "spread")]
        public string Spread { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
    }

    [XmlRoot(ElementName = "staff-layout")]
    public class Stafflayout
    {
        [XmlElement(ElementName = "staff-distance")]
        public string Staffdistance { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
    }

    [XmlRoot(ElementName = "trill-mark")]
    public class Trillmark
    {
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
    }

    [XmlRoot(ElementName = "ornaments")]
    public class Ornaments
    {
        [XmlElement(ElementName = "trill-mark")]
        public Trillmark Trillmark { get; set; }
    }

    [XmlRoot(ElementName = "slur")]
    public class Slur
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "default-x")]
        public string Defaultx { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
        [XmlAttribute(AttributeName = "bezier-x")]
        public string Bezierx { get; set; }
        [XmlAttribute(AttributeName = "bezier-y")]
        public string Beziery { get; set; }
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
    }

    [XmlRoot(ElementName = "staccato")]
    public class Staccato
    {
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
    }

    [XmlRoot(ElementName = "tenuto")]
    public class Tenuto
    {
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
    }

    [XmlRoot(ElementName = "barline")]
    public class Barline
    {
        [XmlElement(ElementName = "bar-style")]
        public string Barstyle { get; set; }
        [XmlAttribute(AttributeName = "location")]
        public string Location { get; set; }
    }

    [XmlRoot(ElementName = "score-partwise")]
    public class Scorepartwise
    {
        [XmlElement(ElementName = "work")]
        public Work Work { get; set; }
        [XmlElement(ElementName = "identification")]
        public Identification Identification { get; set; }
        [XmlElement(ElementName = "defaults")]
        public Defaults Defaults { get; set; }
        [XmlElement(ElementName = "credit")]
        public List<Credit> Credit { get; set; }
        [XmlElement(ElementName = "part-list")]
        public Partlist Partlist { get; set; }
        [XmlElement(ElementName = "part")]
        public List<Part> Part { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

}
