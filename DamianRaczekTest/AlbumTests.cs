using DamianRaczek;
using System.IO;

namespace DamianRaczekTest
{
    public class AlbumTests
    {
        [Fact]
        public void ReadAlbumsFromFile_WhenInvoked_ReturnsCorrectListOfAlbumsFromFile()
        {
            #region arrange

            List<Music> correctDataAlbumList = new List<Music>()
            {
                new Music()
                {
                    Artist = "Gorillaz",
                    Album = "\"The Now Now\"",
                    SongsNumber = 11,
                    Year = 2018,
                    DownloadNumber = 11000102,
                },
                new Music()
                {
                    Artist = "My Chemical Romance",
                    Album = "\"The Black Parade\"",
                    SongsNumber = 14,
                    Year = 2006,
                    DownloadNumber = 304666444,
                },
            };

            #endregion

            #region act

            List<Music> albums = Program.ReadAlbumsFromFile("DataTest.txt");

            #endregion

            #region assert

            for (int i = 0; i < correctDataAlbumList.Count; i++)
            {
                Assert.Equal(correctDataAlbumList[i].Album, albums[i].Album);
                Assert.Equal(correctDataAlbumList[i].Artist, albums[i].Artist);
                Assert.Equal(correctDataAlbumList[i].SongsNumber, albums[i].SongsNumber);
                Assert.Equal(correctDataAlbumList[i].Year, albums[i].Year);
                Assert.Equal(correctDataAlbumList[i].DownloadNumber, albums[i].DownloadNumber);
            }

            #endregion
        }
    }
}