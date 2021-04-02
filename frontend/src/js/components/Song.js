export default function Song(song){
    return `
        <h1><input type = "text" id = "changeSongTitle" value = "${song.title}"/></h1>
        <p><input type = "number" min = "1" id = "changeSongDuration" value = "${song.duration}"/></p>
        <input type = "hidden" id = "changeSongId" value = "${song.id}"/>
        <input type = "hidden" id = "changeSongLink" value = "${song.link}"/>
        <input type = "hidden" id = "changeSongAlbumId" value = "${song.albumId}"/>
        <button class = "btnEditSong">Update Song</button>
        <br>
        <h2 class = "album_name" id = "${song.album.id}">${song.album.name}</h2>
        <a href=${song.link} target="_blank">Play Song</a>
        `
       }


