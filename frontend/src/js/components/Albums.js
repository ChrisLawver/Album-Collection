export default function Albums(albums){
    return `
        <h1>Albums</h1>
        <ol>

        ${albums.map(album =>{
            return `
            <li>
            <h4 class="album_name" id="${album.id}">${album.name}</h4>
            <button class = "btnDeleteAlbum" id = "${album.id}">Delete Album</button>
            </li>
            `
        }).join('')}

        </ol>

        <section class = "addAlbum">
        <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <label>Album Name: </label>
            <input type = "text" id = "newAlbumName" placeholder = "Album Name"/>
            <br>
            <label>Album Art: </label>
            <input type = "text" id = "newAlbumImage" placeholder = "Image URL"/>
            <br>
            <br>
            <select id = "artists">
            </select>
            <br>
            <button class = "albumAddButton">Add Album</button>
            <br>
            <br>
            <br>
            <br>
            </section>

        `
       }