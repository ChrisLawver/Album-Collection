export default function Songs(songs){
    return `
        <h1>Songs</h1>
        <ol>

        ${songs.map(song =>{
            return `
            <li>
            <h4 class="song_title" id="${song.id}">${song.title}</h4>
            <button class = "btnDeleteSong" id = "${song.id}">Delete Song</button>
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
            <select id = "albums">
            </select>
            <br>
            <button class = "songAddButton">Add Song</button>
        </section>
        `
       }