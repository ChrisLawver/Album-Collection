export default function Artists(artists){
    return `
        <h1>Artists</h1>
        <ol>
            ${artists.map(artist =>{
                return `
                    <li>
                        ${artist.name}
                    </li>
                `
            })}
        </ol>
    `
        }