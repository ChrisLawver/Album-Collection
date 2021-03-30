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
    public class SongController : ControllerBase
    {
        IRepository<Song> _songRepo;

        public SongController(IRepository<Song> context)
        {
            this._songRepo = context;
        }

        // GET: api/Songs
        [HttpGet]
        public IEnumerable<Song> GetSongs()
        {
            return _songRepo.GetAll();
        }

        // GET: api/Songs/5
        [HttpGet("{id}")]
        public Song GetSong(int id)
        {
            return _songRepo.GetById(id);
        }

        //// PUT: api/Albums/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public Song PutSong(int id, Song song)
        {
            if (id != song.Id)
            {
                return null;
            }

            _songRepo.Update(song);
            return song;
        }

        [HttpPost]
        public Song PostSong([FromBody] Song song)
        {
            _songRepo.Create(song);
            return song;
        }

        [HttpDelete("{id}")]
        public string DeleteSong(int id)
        {
            var song = _songRepo.GetById(id);
            _songRepo.Delete(song);
            return "Song Deleted.";
        }
    }
}
