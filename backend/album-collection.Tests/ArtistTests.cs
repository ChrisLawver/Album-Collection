using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using album_collection.Models;

namespace album_collection.Tests
{
    public class ArtistTests
    {
        Artist sut = new Artist(1, "name", "image", "record label");

        [Fact]
        public void Artist_Constructer_Should_Set_Id()
        {
            int resultId = sut.Id;
            Assert.Equal(1, resultId);
        }

        [Fact]
        public void Artist_Constructer_Shoould_Set_Name()
        {
            string resultName = sut.Name;
            Assert.Equal("name", resultName);
        }

        [Fact]
        public void Artist_Constructer_Shoould_Set_Image()
        {
            string resultImage = sut.Image;
            Assert.Equal("image", resultImage);
        }

        [Fact]
        public void Artist_Constructer_Shoould_Set_RecordLabel ()
        {
            string resultRecordLabel = sut.RecordLabel;
            Assert.Equal("record label", resultRecordLabel);
        }
    }
}
