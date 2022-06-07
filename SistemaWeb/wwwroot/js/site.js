// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//const callToActionBtns = document.querySelectorAll(".nav-link");

//callToActionBtns.forEach((btn) => {
//    btn.addEventListener("click", (e) => {
//        callToActionBtns.forEach(f => f != e.target ? f.classList.remove('menu-activo') : '')
//        e.target.classList.toggle("menu-activo");
//    });
//});

const cards = document.getElementsByClassName("card");
for (let i = 0; i < cards.length; i++) {
    const card = cards[i];
    card.addEventListener("mouseover", function () {
        card.classList.add("shadow");
    })
    card.addEventListener("mouseleave", function () {
        card.classList.remove("shadow");
    })
}
