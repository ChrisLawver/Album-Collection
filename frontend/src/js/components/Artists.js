export default function Artists(artists){
     return `
         <h1>Artists</h1>
         <ol>

         ${artists.map(artist =>{
             return `
             <li>
             <h4 class="artist_name" id="${artist.id}">${artist.name}</h4>
             </li>
             `
         }).join('')}

         </ol>
         `
        }