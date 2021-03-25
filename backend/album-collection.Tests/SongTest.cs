using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using album_collection.Models;

namespace album_collection.Tests
{
    public class SongTest
    {

        Song sut;

        public SongTest()
        {
            sut = new Song(1, "title", 1000, "link", 1, new Album());
        }

        [Fact]
        public void Song_Constructer_Sets_Id()
        {
            int resultId = sut.Id;
            Assert.Equal(1, resultId);
        }

        [Fact]
        public void Song_Constructer_Sets_Title()
        {
            string resultTitle = sut.Title;
            Assert.Equal("title", resultTitle);
        }

        [Fact]
        public void Song_Constructer_Sets_Duration()
        {
            int resultDuration = sut.Duration;
            Assert.Equal(1000, resultDuration);
        }

        [Fact]
        public void Song_Constructer_Sets_Link()
        {
            string resultLink = sut.Link;
            Assert.Equal("link", resultLink);
        }

        [Fact]
        public void Song_Constructer_Sets_AlbumId()
        {
            int resultAlbumId = sut.AlbumId;
            Assert.Equal(1, resultAlbumId);
        }

        [Fact]
        public void Song_Constructer_Sets_Album()
        {
            Album resultAlbum = sut.Album;
            Assert.IsType<Album>(resultAlbum);
        }
    }
}
