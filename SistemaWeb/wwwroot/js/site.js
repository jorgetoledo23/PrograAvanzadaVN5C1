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

const btnPDF = document.getElementById("btnPDF");
btnPDF.addEventListener("click", function () {
    //alert("asd")
    const container = document.getElementById("PDF"); //Esto es lo PDF
    console.log(container.innerHTML)
    var printWindow = window.open('', '', 'height=400,width=800');
    printWindow.document.write('<html><head><title>PDF</title>');
    printWindow.document.write('<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">')
    printWindow.document.write('<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css" integrity="sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==" crossorigin="anonymous" referrerpolicy="no-referrer" />')
    printWindow.document.write('<link href="https://fonts.googleapis.com/css?family=Raleway:500,800" rel="stylesheet">')
    printWindow.document.write('</head><body style="margin:20px;padding:20px;">');
    printWindow.document.write(container.innerHTML);
    printWindow.document.write('</body></html>');
    printWindow.document.close();
    printWindow.print();
});