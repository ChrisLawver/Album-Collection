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
    public class AlbumControllerTest
    {
        AlbumController sut;
        IRepository<Album> albumRepo;
        public AlbumControllerTest()
        {
            albumRepo = Substitute.For<IRepository<Album>>();
            sut = new AlbumController(albumRepo);
        }

        [Fact]
        public void Get_Albums_Returns_A_List()
        {
            IEnumerable<Album> expectedList = new List<Album>();
            albumRepo.GetAll().Returns(expectedList);
            var result = sut.GetAlbums();
            Assert.Equal(expectedList, result);
        }

        [Fact]
        public void Get_Album_Returns_An_Artist()
        {
            var expectedArtist = new Album();
            albumRepo.GetById(1).Returns(expectedArtist);
            var result = sut.GetAlbum(1);
            Assert.Equal(expectedArtist, result);
        }
    }
}
