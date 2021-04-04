export default function Artist(artist){

    if(artist.albums == null){
        artist.albums = [];
    }

    return `
        <h1>${artist.name}</h1>
        <h2>${artist.recordLabel}</h2>
        <input type = "hidden" id = "changeArtistId" value = "${artist.id}"/>
        <input type = "hidden" id = "changeArtistImage" value = "${artist.image}"/>
        <img src=${artist.image} alt=${artist.name}>
        <br>
        <br>
        <button class = "btnEditArtist">Update Artist</button>
        <ol>
        ${artist.albums.map(album =>{
            return `
                <li>
                    <h3 class = "album_name" id = "${album.id}">${album.name}</h3>
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
            <label>Album Name: </label>
            <input type = "text" id = "newAlbumName" placeholder = "Album Name"/>
            <br>
            <label>Album Art: </label>
            <input type = "text" id = "newAlbumImage" placeholder = "Image URL"/>
            <br>
            <br>
            <button class = "albumAddButton" id = "${artist.id}">Add Album</button>
        </section>
        <br>
        <br>

        `
       }