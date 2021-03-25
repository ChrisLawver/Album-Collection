import Header from "./components/header";
import Footer from "./components/footer";
import Home from "./components/home";

const appDiv = document.getElementById("app");

export default() => {
    // document.getElementById('app').innerText = "Hello World!";
    setupHeader();
    setupFooter();
    navHome();
    
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