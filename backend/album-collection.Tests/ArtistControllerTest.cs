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
    public class ArtistControllerTest
    {
        ArtistController sut;
        IRepository<Artist> artistRepo;

        public ArtistControllerTest()
        {
            artistRepo = Substitute.For<IRepository<Artist>>();
            sut = new ArtistController(artistRepo);
        }

        [Fact]
        public void Get_Artists_Returns_A_List()
        {
            IEnumerable<Artist> expectedList = new List<Artist>();
            artistRepo.GetAll().Returns(expectedList);
            var result = sut.GetArtists();
            Assert.Equal(expectedList, result);
        }

        [Fact]
        public void Get_Artist_Returns_An_Artist()
        {
            var expectedAlbum = new Artist();
            artistRepo.GetById(1).Returns(expectedAlbum);
            var result = sut.GetArtist(1);
            Assert.Equal(expectedAlbum, result);
        }
    }
}
