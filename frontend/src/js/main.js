import Header from "./components/header";
import Footer from "./components/footer";
import Artists from "./components/Artists";
import Home from "./components/home";
import Albums from "./components/Albums";
import Songs from "./components/Songs";
import Song from "./components/Song";
import Album from "./components/Album";
import Artist from "./components/Artist";

const appDiv = document.getElementById("app");

export default() => {
    // document.getElementById('app').innerText = "Hello World!";
    setupHeader();
    setupFooter();
    navHome();
    navArtists();
    navAlbums();
    navSongs();
    appDiv.innerHTML = Home();
}

function setupHeader(){
    const headerElement = document.querySelector(".header");
    headerElement.innerHTML = Header();
}

function setupFooter(){
    const footerElement = document.querySelector(".footer");
    footerElement.innerHTML = Footer();
}

function navHome(){
    const homeLink = document.querySelector(".nav_home");
    homeLink.addEventListener('click', function(){
        appDiv.innerHTML = Home();
    });
}

function navArtists(){
    const artistsButton = document.querySelector(".nav_artists");
    artistsButton.addEventListener('click', function(){

        fetch("https://localhost:44313/api/artist")
            .then(response => response.json())
            .then(data =>{
                appDiv.innerHTML = Artists(data);
                artistButton();
            })
            .catch(err => console.log(err));

    });
}

function artistButton(){
    const artistNameElements = document.querySelectorAll(".artist_name");
    artistNameElements.forEach(element => {
        element.addEventListener('click', function(){
            const artistId = element.id;
            fetch(`https://localhost:44313/api/artist/${artistId}`)
            .then(response => response.json())
            .then(data => appDiv.innerHTML = Artist(data))
            .catch(err => console.log(err));
        })
    })
}

function navAlbums(){
    const albumsButton = document.querySelector(".nav_albums");
    albumsButton.addEventListener('click', function(){

        fetch("https://localhost:44313/api/album")
            .then(response => response.json())
            .then(data => {
                appDiv.innerHTML = Albums(data);
                albumButton();
            })
            .catch(err => console.log(err));

    });
}

function albumButton(){
    const albumNameElements = document.querySelectorAll(".album_name");
    albumNameElements.forEach(element => {
        element.addEventListener('click', function(){
            const albumId = element.id;
            fetch(`https://localhost:44313/api/album/${albumId}`)
            .then(response => response.json())
            .then(data => appDiv.innerHTML = Album(data))
            .catch(err => console.log(err));
        })
    })
}

function navSongs(){
    const songsButton = document.querySelector(".nav_songs");
    songsButton.addEventListener('click', function(){

        fetch("https://localhost:44313/api/song")
            .then(response => response.json())
            .then(data => {
                appDiv.innerHTML = Songs(data);
                songButton()
            })
            .catch(err => console.log(err));

    });
}

function songButton(){
    const songNameElements = document.querySelectorAll(".song_title");
    songNameElements.forEach(element => {
        element.addEventListener('click', function(){
            const songId = element.id;
            fetch(`https://localhost:44313/api/song/${songId}`)
            .then(response => response.json())
            .then(data => appDiv.innerHTML = Song(data))
            .catch(err => console.log(err));
        })
    })
}