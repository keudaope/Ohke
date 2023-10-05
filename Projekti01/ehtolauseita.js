function jarjesta() {
    var luku1, luku2, luku3;
    luku1 = parseInt(document.getElementById('eka').value);
    luku2 = parseInt(document.getElementById('toka').value);
    luku3 = parseInt(document.getElementById('kolmas').value);
    tulostus = document.getElementById("a1");
    tulostus.innerHTML = "Annoit luvut: " + luku1 + ' ' + luku2 + ' ' + luku3 + "<br>";
    if (luku1 < luku2 && luku1 < luku3) {
        k
        if (luku2 < luku3) {
            tulostus.innerHTML += "Lukujen järjestys: " + luku1 + ' ' + luku2 + ' ' + luku3;
        }
        else {
            tulostus.innerHTML += "Lukujen järjestys: " + luku1 + ' ' + luku3 + ' ' + luku2;
        }
    }
    else if (luku2 < luku1 && luku2 < luku3) {
        if (luku1 < luku3) {
            tulostus.innerHTML += "Lukujen järjestys: " + luku2 + ' ' + luku1 + ' ' + luku3;
        }
        else {
            tulostus.innerHTML += "Lukujen järjestys: " + luku2 + ' ' + luku3 + ' ' + luku1;

        }
    }
    else if (luku3 < luku1 && luku3 < luku2) {
        if (luku1 < luku2) {
            tulostus.innerHTML += "Lukujen järjestys: " + luku3 + ' ' + luku1 + ' ' + luku2;
        }
        else {
            tulostus.innerHTML += "Lukujen järjestys: " + luku3 + ' ' + luku2 + ' ' + luku1;

        }
    }
}
function etsiSuurin() {
    var l1, l2, l3, l4, l5, suurin;
    l1 = parseInt(document.getElementById('luku1').value);
    l2 = parseInt(document.getElementById('luku2').value);
    l3 = parseInt(document.getElementById('luku3').value);
    l4 = parseInt(document.getElementById('luku4').value);
    l5 = parseInt(document.getElementById('luku5').value);
    tulostus = document.getElementById("a2");
    if (l1 < l2 && l3 < l2 && l4 < l2 && l5 < l2) {
        suurin = l2;
    }
    else if (l1 < l3 && l4 < l3 && l5 < l3) {
        suurin = l3;
    }
    else if (l1 < l4 && l5 < l4) {
        suurin = l4;
    }
    else if (l1 < l5) {
        suurin = l5;
    }
    else {
        suurin = l1;
    }
    tulostus.innerHTML = "Annoit luvut: " + l1 + ' ' + l2 + ' ' + l3 + ' ' + l4 + ' ' + l5;
    tulostus.innerHTML += "<br>Suurin niistä on: " + suurin;
}
function paritonParillinen() {
    var arvo;
    arvo = parseInt(document.getElementById('luku').value);
    tulostus = document.getElementById("a3");
    tulostus.innerHTML = "Antamasi luku: " + arvo;
    if (arvo % 2 == 0) {
        tulostus.innerHTML += "<br>Antamasi luku on parillinen";
    }
    else {
        tulostus.innerHTML += "<br>Antamasi luku on pariton";
    }
}
function ajoneuvo() {
    var age = parseInt(document.getElementById('ika').value);
    var tulostus = document.getElementById("a4");
    if (age < 16) {
        tulostus.innerHTML = "Voit ajaa polkupyörää";
    }
    else if (age < 18) {
        tulostus.innerHTML = "Voit ajaa mopoa";
    }
    else {
        tulostus.innerHTML = "Voit ajaa autoa";
    }
}
function kaanna() {
    var lang = document.getElementById('kieli').value;
    var tulostus = document.getElementById("a5");
    if (lang == 'eng') {
        tulostus.innerHTML = "Hello world!";
    }
    else if (lang == 'swe') {
        tulostus.innerHTML = "Hej världen!";
    }
    else {
        tulostus.innerHTML = "Hola Mundo!";
    }
}