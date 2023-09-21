function muokkaa() {
    var teksti = document.getElementById("muokattava");
    teksti.style.fontFamily = "Courier";
    teksti.style.color = "red";
    teksti.style.fontSize = "2em";
}
function haeTiedot() {
    var etunimi = document.getElementById("etunimi").value;
    var sukunimi = document.getElementById("sukunimi").value;
    console.log("Etunimi on: " + etunimi + " ja sukunimi on: " + sukunimi);
}