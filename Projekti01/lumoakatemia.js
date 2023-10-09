// PERUSHARJOITUKSIA
function heiMaailma() {
    console.log("Hei maailma!");
}
//heiMaailma();

function summa(a, b) {
    console.log(a + b);
}
/*summa(2, 3);
summa(5, 7);
summa(4, 8);*/

function erotus(a, b) {
    console.log(a - b);
}
//erotus(3, 2);

function tulo(a, b) {
    console.log(a * b);
}
//tulo(3, 2);

function osamaara(a, b) {
    console.log(a / b);
}
//osamaara(3, 2);

function CtoF(celcius) {
    console.log(celcius * 9 / 5 + 32);
}
//CtoF(26);

function FtoC(fahrenheit) {
    console.log((fahrenheit-32)*5/9);
}
//FtoC(79);

function MtoKm(maili) {
    console.log(maili * 1.609);
}
//MtoKm(20);

function KmToM(kilometri) {
    console.log(kilometri / 1.609);
}
//KmToM(32);

function ItoS(tuumat) {
    console.log(tuumat * 2.54);
}
//ItoS(5);

function StoI(sentit) {
    console.log(sentit / 2.54);
}
//StoI(5);

function YtoM(yardit) {
    console.log(yardit * 0.9144);
}
//YtoM(20);

function MtoY(metrit) {
    console.log(metrit / 0.9144);
}
//MtoY(18);

function asciiToChar(ascii) {
    console.log(String.fromCharCode(ascii));
}
//asciiToChar(65);

function ympyranAla(sade) {
    console.log(sade * sade * 3.14);
}
//ympyranAla(2);

function nelionAla(sivu) {
    console.log(sivu * sivu);
}
//nelionAla(2);

function suorakulmionAla(sivu1, sivu2) {
    console.log(sivu1 * sivu2);
}
//suorakulmionAla(2, 3);

function muunnaVuosiksi(paivat) {
    let vuodet = parseInt(paivat / 365);
    let kuukaudet = parseInt((paivat % 365) / (365 / 12));
    let pvt = parseInt((paivat % 365) - kuukaudet * (365 / 12));
    console.log(paivat + " päivää on " + vuodet + " vuotta " + kuukaudet + " kuukautta ja " + pvt + " päivää.")
}
//muunnaVuosiksi(22500);

// IF-ELSE HARJOITUKSIA
// Tee ohjelma, joka etsii kahdesta luvusta suuremman
function suurempi(a, b) {
    if (a > b) {
        console.log("Suurempi luku on " + a);
    }
    else if (b > a) {
        console.log("Suurempi luku on " + b);
    }
    else {
        console.log("Luvut ovat yhtäsuuret");
    }
}
/*suurempi(3, 2);
suurempi(2, 3);
suurempi(3, 3);*/

// Tee ohjelma, joka etsii 3. luvusta suurimman
function suurinKolmesta(a, b, c) {
    if (a > b && a > c) {
        console.log("Suurin luku on " + a);
    }
    else if (b > c) {
        console.log("Suurin luku on " + b);
    }
    else {
        console.log("Suurin luku on " + c);
    }
}
/*suurinKolmesta(1, 2, 3);
suurinKolmesta(1, 3, 2);
suurinKolmesta(2, 1, 3);
suurinKolmesta(2, 3, 1);
suurinKolmesta(3, 1, 2);
suurinKolmesta(3, 1, 3);*/

function etuMerkki(luku) {
    if (luku < 0) {
        console.log("Luku on negatiivinen");
    }
    else if (luku == 0) {
        console.log("Luku on nolla");
    }
    else {
        console.log("Luku on positiivinen");
    }
}
/*etuMerkki(-7);
etuMerkki(0);
etuMerkki(23000);*/

function jaollinen(luku) {
    if (luku % 5 == 0 && luku % 11 == 0) {
        console.log("Luku on jaollinen sekä 5:llä, että 11:sta");
    }
    else if (luku % 5 == 0 || luku % 11 == 0)
    {
        console.log("Luku on jaollinen 5:llä tai 11:sta");
    }
    else {
        console.log("Luku ei ole jaollinen 5:llä tai 11:sta");
    }
}
/*jaollinen(55);
jaollinen(50);
jaollinen(44);
jaollinen(56);*/

// Tee ohjelma, joka tarkastaa, onko annettu
// vuosi karkausvuosi vai ei
function karkaus(vuosi) {
    if (vuosi % 4 == 0 && vuosi % 100 != 0) {
        console.log("Vuosi on karkausvuosi");
    }
    else if (vuosi % 400 == 0) {
        console.log("Vuosi on karkausvuosi");
    }
    else {
        console.log("Vuosi ei ole karkausvuosi");
    }
}
/*karkaus(2004);
karkaus(2000);
karkaus(2100);
karkaus(1997);*/

// Tee ohjelma, joka tarkastaa, onko annettu luku
// parillinen vai pariton
function parillinenPariton(luku) {
    if (luku % 2 == 0) {
        console.log("Luku on parillinen");
    }
    else {
        console.log("Luku on pariton");
    }
}
parillinenPariton(3);
parillinenPariton(6);