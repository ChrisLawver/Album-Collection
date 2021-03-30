export default function Songs(songs){
    return `
        <h1>Songs</h1>
        <ol>

        ${songs.map(song =>{
            return `
            <li>
            <h4 class="song_title" id="${song.id}">${song.title}</h4>
            </li>
            `
        }).join('')}

        </ol>
        `
       }