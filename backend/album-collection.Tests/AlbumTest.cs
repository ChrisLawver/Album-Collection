
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
            sut = new Album(1, "The Black Album", 1, "image"); // ADD SONGS LATER
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
    }
}
