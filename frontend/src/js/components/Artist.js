export default function Artist(artist){
    return `
        <h1>${artist.name}</h1>
        <h2>${artist.recordLabel}</h2>
        <img src=${artist.image} alt=${artist.name}>
        <ol>
        ${artist.albums.map(album =>{
            return `
                <li>
                    ${album.name}
                </li>
            `
        }).join('')}
        </ol>
        `
       }