using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using album_collection;
using album_collection.Models;
using album_collection.Repositories;

namespace album_collection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        IRepository<Album> _albumRepo;

        public AlbumController(IRepository<Album> context)
        {
            this._albumRepo = context;
        }

        // GET: api/Albums
        [HttpGet]
        public  IEnumerable<Album> GetAlbums()
        {
            return _albumRepo.GetAll();
        }

        // GET: api/Albums/5
        [HttpGet("{id}")]
        public Album GetAlbum(int id)
        {
            var newAlbum = _albumRepo.GetById(id);
            return newAlbum;
        }

        //// PUT: api/Albums/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public Album PutAlbum(int id, Album album)
        {
            if(id != album.Id)
            {
                return null;
            }

            _albumRepo.Update(album);
            _albumRepo.LoadProxy(album, "Artist");
            return album;
        }

        [HttpPost]
        public Album PostAlbum([FromBody]Album album)
        {
            _albumRepo.Create(album);
            _albumRepo.LoadProxy(album, "Artist");

            return album;
        }

        [HttpDelete("{id}")]
        public string DeleteAlbum(int id)
        {
            var album = _albumRepo.GetById(id);
            _albumRepo.Delete(album);
            return "Album Deleted.";
        }

    }
}
