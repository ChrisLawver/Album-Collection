export default function Songs(songs){
    return `
        <h1>Songs</h1>
        <ol>

        ${songs.map(song =>{
            return `
            <li>
            ${song.title}
            </li>
            `
        }).join('')}

        </ol>
        `
       }