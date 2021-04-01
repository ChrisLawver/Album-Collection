export default function Artist(artist){

    if(artist.albums == null){
        artist.albums = [];
    }

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

        <section class = "addAlbum">
            <label>Album Name: </label>
            <input type = "text" id = "newAlbumName" placeholder = "Album Name"/>
            <br>
            <label>Album Art: </label>
            <input type = "text" id = "newAlbumImage" placeholder = "Image URL"/>
            <br>
            <button class = "albumAddButton" id = "${artist.id}">Add Album</button>
        </section>

        `
       }