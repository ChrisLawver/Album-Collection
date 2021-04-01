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
                addArtist();
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
            .then(data => {
                appDiv.innerHTML = Artist(data);
                addAlbumByArtistId();
            })
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
                fillArtists();
                addAlbum();
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
            .then(data => {
                 appDiv.innerHTML = Album(data);
                addSongByAlbumId();
                })
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
                songButton();
                fillAlbums();
                addSong();
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

function addArtist(){
    const addArtistButton = document.querySelector(".artistAddButton");
    addArtistButton.addEventListener('click', function(){
        const artistName = document.getElementById("newArtistName").value;
        const artistRecordLabel = document.getElementById("newRecordLabel").value;
        const artistImage = document.getElementById("newArtistImage").value;
        const requestBody = {
            Name: artistName,
            RecordLabel: artistRecordLabel,
            Image: artistImage
        }

        fetch(`https://localhost:44313/api/artist`, {
             method: "POST",
             headers: {
                 "Content-Type" : "application/json"
             },
             body: JSON.stringify(requestBody)
         })
         .then(response => response.json())
         .then(artist => {
             console.log(artist);
             appDiv.innerHTML = Artist(artist);
         })
         .catch(err => console.log(err));
    })
}

function addAlbum(){
    const addAlbumButton = document.querySelector(".albumAddButton");
    addAlbumButton.addEventListener('click', function(){
        const albumName = document.getElementById("newAlbumName").value;
        const albumImage = document.getElementById("newAlbumImage").value;
        const albumArtistId = document.getElementById("artists").value;
        const requestBody = {
            Name: albumName,
            Image: albumImage,
            ArtistId: albumArtistId
        }

        fetch(`https://localhost:44313/api/album`, {
             method: "POST",
             headers: {
                 "Content-Type" : "application/json"
             },
             body: JSON.stringify(requestBody)
         })
         .then(response => response.json())
         .then(album => {
             console.log(album);
             appDiv.innerHTML = Album(album);
         })
         .catch(err => console.log(err));
    })
}

function fillArtists(){
    let dropdown = document.getElementById('artists');
    dropdown.length = 0;

    let defaultOption = document.createElement('option');
    defaultOption.text = 'Select an Artist';
    defaultOption.disabled = 'disabled';

    dropdown.add(defaultOption);
    dropdown.selectedIndex = 0;

    fetch("https://localhost:44313/api/artist")
    .then(response => response.json())
    .then(data => {
        let option;
        data.forEach(function(artist){
            option = document.createElement('option');
            option.text = artist.name;
            option.value = artist.id;
            dropdown.add(option);
        })
    })
    .catch(err => console.log(err));
}

function addSong(){
    const addSongButton = document.querySelector(".songAddButton");
    addSongButton.addEventListener('click', function(){
        const songTitle = document.getElementById("newSongTitle").value;
        const songLength = parseInt(document.getElementById("newSongLength").value);
        const songLink = document.getElementById("newSongLink").value;
        const songAlbumId = document.getElementById("albums").value;
        const requestBody = {
            Title: songTitle,
            Duration: songLength,
            Link: songLink,
            AlbumId: songAlbumId
        }

        fetch(`https://localhost:44313/api/song`, {
             method: "POST",
             headers: {
                 "Content-Type" : "application/json"
             },
             body: JSON.stringify(requestBody)
         })
         .then(response => response.json())
         .then(song => {
             console.log(song);
             appDiv.innerHTML = Song(song);
         })
         .catch(err => console.log(err));
    })
}

function fillAlbums(){
    let dropdown = document.getElementById('albums');
    dropdown.length = 0;

    let defaultOption = document.createElement('option');
    defaultOption.text = 'Select an Album';
    defaultOption.disabled = 'disabled';

    dropdown.add(defaultOption);
    dropdown.selectedIndex = 0;

    fetch("https://localhost:44313/api/album")
    .then(response => response.json())
    .then(data => {
        let option;
        data.forEach(function(album){
            option = document.createElement('option');
            option.text = album.name;
            option.value = album.id;
            dropdown.add(option);
        })
    })
    .catch(err => console.log(err));
}

function addSongByAlbumId(){
    const addSongButton = document.querySelector(".songAddButton");
    addSongButton.addEventListener('click', function(){
        const songTitle = document.getElementById("newSongTitle").value;
        const songLength = parseInt(document.getElementById("newSongLength").value);
        const songLink = document.getElementById("newSongLink").value;
        const songAlbumId = addSongButton.id;
        const requestBody = {
            Title: songTitle,
            Duration: songLength,
            Link: songLink,
            AlbumId: songAlbumId
        }

        fetch(`https://localhost:44313/api/song`, {
             method: "POST",
             headers: {
                 "Content-Type" : "application/json"
             },
             body: JSON.stringify(requestBody)
         })
         .then(response => response.json())
         .then(song => {
             console.log(song);
             appDiv.innerHTML = Song(song);
         })
         .catch(err => console.log(err));
    })
}

function addAlbumByArtistId(){
    const addAlbumButton = document.querySelector(".albumAddButton");
    addAlbumButton.addEventListener('click', function(){
        const albumName = document.getElementById("newAlbumName").value;
        const albumImage = document.getElementById("newAlbumImage").value;
        const albumArtistId = addAlbumButton.id;
        const requestBody = {
            Name: albumName,
            Image: albumImage,
            ArtistId: albumArtistId
        }

        fetch(`https://localhost:44313/api/album`, {
             method: "POST",
             headers: {
                 "Content-Type" : "application/json"
             },
             body: JSON.stringify(requestBody)
         })
         .then(response => response.json())
         .then(album => {
             console.log(album);
             appDiv.innerHTML = Album(album);
         })
         .catch(err => console.log(err));
    })
}