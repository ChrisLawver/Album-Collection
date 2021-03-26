
using album_collection.Models;
using System;
using Xunit;

namespace album_collection.Tests
{
    public class AlbumTest
    {
        Album sut;
        public AlbumTest() 
        {
            //sut = new Album(1, "The Black Album", "Metallica", "image", "Record Label"); // ADD SONGS LATER
        }

        [Fact]
        public void Album_Constructor_Sets_Id_On_Album_Model()
        {
            int result = sut.Id;
            Assert.Equal(1, result);
        }

        [Fact]
        public void Album_Constructor_Sets_Album_Title_On_Album_Model()
        {
            string result = sut.Name;
            Assert.Equal("The Black Album", result);
        }

        //[Fact]
        //public void Album_Constructor_Sets_Artist_On_Album_Model()
        //{
        //    Artist result = sut.Artist;
        //    Assert.Equal("Metallica", result);
        //}

        //[Fact]
        //public void Album_Constructor_Sets_Record_Label_On_Album_Model()
        //{
        //    string result = sut.RecordLabel;
        //    Assert.Equal("Record Label", result);
        //}

        //[Fact]
        //public void Album_Constructor_Sets_Songs_On_Album_Model()
        //{
        //    string result = sut.Songs;
        //    Assert.Equal(, result);
        //}
    }
}
