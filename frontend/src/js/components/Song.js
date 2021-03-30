export default function Song(song){
    return `
        <h1>${song.title}</h1>
        <h2>${song.album.name}</h2>
        <a href=${song.link}>Play Song</a>
        <p>${song.duration}</p>
        `
       }


