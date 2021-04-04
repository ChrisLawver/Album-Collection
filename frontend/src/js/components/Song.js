export default function Song(song){
    return `
        <h1>${song.title}</h1>
        <h2 class = "album_name" id = "${song.album.id}">${song.album.name}</h2>
        <h3 class="duration">${song.duration}</h3>
        <input type = "hidden" id = "changeSongId" value = "${song.id}"/>
        <input type = "hidden" id = "changeSongLink" value = "${song.link}"/>
        <input type = "hidden" id = "changeSongAlbumId" value = "${song.albumId}"/>
        <a href=${song.link} target="_blank">Play Song</a>
        <br>
        <br>
        <button class = "btnEditSong">Update Song</button>
        <br>
        <br>
        `
       }


