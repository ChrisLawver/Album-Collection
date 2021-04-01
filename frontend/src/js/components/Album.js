export default function Album(album){

    if(album.songs == null){
        album.songs = [];
    }
    
    return `
        <h1>${album.name}</h1>
        <h2>${album.artist.name}</h2>
        <img src=${album.image} alt=${album.name}>
        <ol>
        ${album.songs.map(song =>{
            return `
                <li>
                    ${song.title}
                </li>
            `
        }).join('')}
        </ol>

        <section class = "addSong">
            <label>Song Title: </label>
            <input type = "text" id = "newSongTitle" placeholder = "Song Title"/>
            <br>
            <label>Song Length: </label>
            <input type = "number" min ="1" id = "newSongLength" placeholder = "Song Length in Seconds"/>
            <br>
            <label>Link to Song: </label>
            <input type = "text" id = "newSongLink" placeholder = "Youtube URL"/>
            <br>
            <button class = "songAddButton" id = "${album.id}" >Add Song</button>
        </section>
        `




       }

