export default function Albums(albums){
    return `
        <h1>Albums</h1>
        <ol>

        ${albums.map(album =>{
            return `
            <li>
            ${album.name}
            </li>
            `
        }).join('')}

        </ol>
        `
       }