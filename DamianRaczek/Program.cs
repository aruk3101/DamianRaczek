using System.Data;

namespace DamianRaczek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = ReadAlbumsFromFile();
        }

        public static List<Music> ReadAlbumsFromFile()
        {
            List<Music> list = new List<Music>();
            StreamReader streamReader = new StreamReader("Data.txt");
            while(!streamReader.EndOfStream)
            {
                Music music = new Music()
                {
                    Artist = streamReader.ReadLine() ?? "",
                    Album = streamReader.ReadLine() ?? "",
                    SongsNumber = int.Parse(streamReader.ReadLine() ?? ""),
                    Year = int.Parse(streamReader.ReadLine() ?? ""),
                    DownloadNumber = int.Parse(streamReader.ReadLine() ?? "")
                };
                streamReader.ReadLine();
                list.Add(music);
            }

            return list;
        }


    }
}
