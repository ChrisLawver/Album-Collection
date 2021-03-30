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
    public class ArtistController : ControllerBase
    {
        IRepository<Artist> _artistRepo;

        public ArtistController(IRepository<Artist> context)
        {
            this._artistRepo = context;
        }

        // GET: api/Artists
        [HttpGet]
        public IEnumerable<Artist> GetArtists()
        {
            return _artistRepo.GetAll();
        }

        // GET: api/Artists/5
        [HttpGet("{id}")]
        public Artist GetArtist(int id)
        {
            return _artistRepo.GetById(id);
        }

        //// PUT: api/Albums/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public Artist PutArtist(int id, Artist artist)
        {
            if (id != artist.Id)
            {
                return null;
            }

            _artistRepo.Update(artist);
            return artist;
        }

        [HttpPost]
        public Artist PostArtist([FromBody] Artist artist)
        {
            _artistRepo.Create(artist);
            return artist;
        }

        [HttpDelete("{id}")]
        public string DeleteArtist(int id)
        {
            var artist = _artistRepo.GetById(id);
            _artistRepo.Delete(artist);
            return "Artist Deleted.";
        }
    }
}
