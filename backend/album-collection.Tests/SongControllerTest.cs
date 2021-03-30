using album_collection.Controllers;
using album_collection.Models;
using album_collection.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace album_collection.Tests
{
    public class SongControllerTest
    {
        SongController sut;
        IRepository<Song> songRepo;
        public SongControllerTest()
        {
            songRepo = Substitute.For<IRepository<Song>>();
            sut = new SongController(songRepo);
        }

        [Fact]
        public void Get_Albums_Returns_A_List()
        {
            IEnumerable<Song> expectedList = new List<Song>();
            songRepo.GetAll().Returns(expectedList);
            var result = sut.GetSongs();
            Assert.Equal(expectedList, result);
        }

        [Fact]
        public void Get_Album_Returns_An_Artist()
        {
            var expectedSong = new Song();
            songRepo.GetById(1).Returns(expectedSong);
            var result = sut.GetSong(1);
            Assert.Equal(expectedSong, result);
        }
    }
}
