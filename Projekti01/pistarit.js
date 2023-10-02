function posNeg() {
    let luku = document.getElementById("luku").value;
    let vastaus = document.getElementById("v1");
    if (luku >= 0) {
        vastaus.innerHTML = "Luku on positiivinen";
    }
    else {
        vastaus.innerHTML = "Luku on negatiivinen";
    }
}
function viikonp() {
    let viikonpaiva = document.getElementById("vkp").value;
    viikonpaiva = parseInt(viikonpaiva);
    let vastaus = document.getElementById("v2");
    switch (viikonpaiva) {
        case 1:
            vastaus.innerHTML = "Maanantai";
            break;
        case 2:
            vastaus.innerHTML = "Tiistai";
            break;
        case 3:
            vastaus.innerHTML = "Keskiviikko";
            break;
        case 4:
            vastaus.innerHTML = "Torstai";
            break;
        case 5:
            vastaus.innerHTML = "Perjantai";
            break;
        case 6:
            vastaus.innerHTML = "Lauantai";
            break;
        case 7:
            vastaus.innerHTML = "Sunnuntai";
            break;
    }
}
function karkaus() {
    let vuosi = document.getElementById("vuosi").value;
    vuosi = parseInt(vuosi);
    let vastaus = document.getElementById("v3");
    if (vuosi % 4 == 0 && vuosi % 100 != 0) {
        vastaus.innerHTML += "Vuosi on karkausvuosi";
    }
    else if (vuosi % 400 == 0) {
        vastaus.innerHTML += "Vuosi on karkausvuosi";
    }
    else {
        vastaus.innerHTML = "Vuosi ei ole karkausvuosi";
    }
}
function keskiarvo() {
    let luku1 = document.getElementById("l1").value;
    let luku2 = document.getElementById("l2").value;
    let luku3 = document.getElementById("l3").value;
    let luku4 = document.getElementById("l4").value;
    let luku5 = document.getElementById("l5").value;
    let vastaus = document.getElementById("v4");
    luku1 = parseInt(luku1);
    luku2 = parseInt(luku2);
    luku3 = parseInt(luku3);
    luku4 = parseInt(luku4);
    luku5 = parseInt(luku5);
    let summa = luku1 + luku2 + luku3 + luku4 + luku5;
    let keskiarvo = summa / 5;
    vastaus.innerHTML = "Lukujen keskiarvo on: " + keskiarvo;
}
function kertotaulu() {
    let kerrottava = document.getElementById("kerrottava").value;
    let lause = "";
    let vastaus = document.getElementById("v5");
    kerrottava = parseInt(kerrottava);
    for (var i = 1; i <= 10; i++) {
        lause += i + " * " + kerrottava + " = " + i * kerrottava;
        lause += "<br />";
    }
    vastaus.innerHTML = lause;
} 