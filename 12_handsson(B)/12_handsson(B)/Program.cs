using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;


namespace _12_handsson_B_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.WritedataForEachCode(typeof(Song));
            Console.Read();
        }
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is StereoDiscAttribute)
                {
                    StereoDiscAttribute a = (StereoDiscAttribute)attr;
                    Console.WriteLine(a.SongName);
                    Console.WriteLine(a.Language);
                    Console.WriteLine(a.Lyrics);
                }
            }
            Console.WriteLine("---------------------------------");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is StereoDiscAttribute)
                    {
                        StereoDiscAttribute a = (StereoDiscAttribute)attrItem;
                        System.Console.WriteLine(a.SongName);
                        Console.WriteLine(a.Language);
                        Console.WriteLine(a.Lyrics);
                    }
                }
            }
        }
    }
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class StereoDiscAttribute : Attribute
    {
        
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;

        
        public StereoDiscAttribute(string positionalString)
        {
            this.positionalString = positionalString;

            // TODO: Implement code here


        }

        public string PositionalString
        {
            get { return positionalString; }
        }

        // This is a named argument
        public int NamedInt { get; set; }
        //songname,language,lyrics properties
        public string SongName { get; set; }
        public string Language { get; set; }
        public string Lyrics { get; set; }
    }
    public class Song
    {
        
        [StereoDisc("Name", SongName = "cheapthrilss")]
        public string SongID { get; set; }
        [StereoDisc("Name", Language = "English")]
        public string LanguageID { get; set; }
        [StereoDisc("Name", Lyrics = "dont know...")]
        public string LyricsID { get; set; }
        [StereoDisc("Name", SongName = "cheapthrilss")]
        public Song(string id, string lid, string lyrid)
        {
            SongID = id;
            LanguageID = lid;
            LyricsID = lyrid;
        }
    }
}