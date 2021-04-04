export default function Artists(artists){
     return `
         <h1>Artists</h1>
         <ol>

         ${artists.map(artist =>{
             return `
             <li>
             <h4 class="artist_name" id="${artist.id}">${artist.name}</h4>
             <button class = "btnDeleteArtist" id = "${artist.id}">Delete Artist</button>
             </li>
             `
         }).join('')}

         </ol>

         <section class = "addArtist">
         <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            <label>Artist Name: </label>
            <input type = "text" id = "newArtistName" placeholder = "Artist Name"/>
            <br>
            <label>Record Label: </label>
            <input type = "text" id = "newRecordLabel" placeholder = "Record Label"/>
            <br>
            <label>Artist's Picture: </label>
            <input type = "text" id = "newArtistImage" placeholder = "Image URL"/>
            <br>
            <br>
            <button class = "artistAddButton">Add Artist</button>
            <br>
            <br>
         </section>



         `

        }


