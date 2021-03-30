export default function Album(album){
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
        `
       }

