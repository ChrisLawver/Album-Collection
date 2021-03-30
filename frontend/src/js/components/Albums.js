export default function Albums(albums){
    return `
        <h1>Albums</h1>
        <ol>

        ${albums.map(album =>{
            return `
            <li>
            <h4 class="album_name" id="${album.id}">${album.name}</h4>
            </li>
            `
        }).join('')}

        </ol>
        `
       }