// Mobile media query
let servicesLoc = document.querySelector(".services");
let reviewsLoc = document.querySelector(".reviews");
let leftCol = document.querySelector(".left-col");
let servicesMediaLoc = document.querySelector(".about-us");
let reviewsMediaLoc = document.querySelector(".author");

const mobileMediaQuery = window.matchMedia('(max-width: 1000px)');

function handleMobileChange(e) {
    if (mobileMediaQuery.matches) {
        servicesMediaLoc.after(servicesLoc);
        reviewsMediaLoc.after(reviewsLoc);
    } else {
        leftCol.appendChild(servicesLoc);
        leftCol.appendChild(reviewsLoc);
    }
}

mobileMediaQuery.addEventListener("change", handleMobileChange);

handleMobileChange(mobileMediaQuery); // Initial check