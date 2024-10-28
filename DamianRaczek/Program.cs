namespace DamianRaczek
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Display(ReadAlbumsFromFile());
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

        /**********************************************
        nazwa funkcji:          Display
        opis funkcji:           funkcja wyświetla przekazaną jako parametr listę albumów
        parametry:              list - lista albumów typu Music
        zwracany typ i opis:    brak
        autor:                  PESEL DAMIAN RACZEK
        **********************************************/

        public static void Display(List<Music> list)
        {
            foreach (Music music in list)
            {
                Console.WriteLine($"{music.Artist}\n{music.Album}\n{music.SongsNumber}\n{music.Year}\n{music.DownloadNumber}\n");
            }
        }
    }
}
