﻿using System;
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

        //// PUT: api/Songs/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSong(int id, Song song)
        //{
        //    if (id != song.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(song).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SongExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Songs
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Song>> PostSong(Song song)
        //{
        //    _context.Song.Add(song);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSong", new { id = song.Id }, song);
        //}

        //// DELETE: api/Songs/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Song>> DeleteSong(int id)
        //{
        //    var song = await _context.Song.FindAsync(id);
        //    if (song == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Song.Remove(song);
        //    await _context.SaveChangesAsync();

        //    return song;
        //}

        //private bool SongExists(int id)
        //{
        //    return _context.Song.Any(e => e.Id == id);
        //}
    }
}