import Header from "./components/header";
import Footer from "./components/footer";
import Artists from "./components/Artists";
import Home from "./components/home";
import Albums from "./components/Albums";

const appDiv = document.getElementById("app");

export default() => {
    // document.getElementById('app').innerText = "Hello World!";
    setupHeader();
    setupFooter();
    navHome();
    navArtists();
    navAlbums();
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
            .then(data => appDiv.innerHTML = Artists(data))
            .catch(err => console.log(err));

    });
}

function navAlbums(){
    const albumsButton = document.querySelector(".nav_albums");
    albumsButton.addEventListener('click', function(){

        fetch("https://localhost:44313/api/album")
            .then(response => response.json())
            .then(data => appDiv.innerHTML = Albums(data))
            .catch(err => console.log(err));

    });
}