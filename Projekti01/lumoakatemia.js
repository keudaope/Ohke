﻿// PERUSHARJOITUKSIA
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

// Tee ohjelma, joka tarkastaa, onko annettu
// luku parillinen vai pariton
function parillinenPariton(luku) {
    if (luku % 2 == 0) {
        console.log("Luku on parillinen");
    }
    else {
        console.log("Luku on pariton");
    }
}
/*parillinenPariton(3);
parillinenPariton(6);
parillinenPariton(0);*/

// Tee ohjelma, joka tarkistaa,
// onko annettu merkki kirjain vai ei
function kirjainko(merkki) {
    if (merkki.length == 1 && merkki.match(/[a-öA-Ö]/i)) {
        console.log("Annettu merkki on kirjain");
    }
    else {
        console.log("Annettu merkki ei ole kirjain");
    }
}
/*kirjainko("g");
kirjainko(1);
kirjainko("!");
kirjainko("ä");
kirjainko("H");
kirjainko("Ö");*/

// Tee ohjelma, joka tarkastaa, onko annettu
// merkki vokaali vai konsonantti
function vokaaliKonsonantti(merkki) {
    if (merkki.match(/[aeiouyäö]/i)) {
        console.log("Annettu merkki on vokaali");
    }
    else if (merkki.match(/[bcdfghjklmnpqrstvwxz]/i)) {
        console.log("Annettu merkki on konsonantti");
    }
    else {
        console.log("Annettu merkki ei ole kumpikaan");
    }
}
/*vokaaliKonsonantti("C");
vokaaliKonsonantti("e");
vokaaliKonsonantti("?");*/

// Tee ohjelma, joka tarkastaa, onko annettu
// merkki kirjain, numero vai erikoismerkki
function kiNuEm(merkki) {
    let kirjain = /[a-öA-Ö]/i;
    let numero = /[0-9]/i;
    if (merkki.length == 1 && merkki.match(kirjain))
    {
        console.log("Merkki on kirjain");
    }
    else if (merkki.match(numero))
    {
        console.log("Merkki on numero");
    }
    else
    {
        console.log("Merkki on erikoismerkki");
    }
}
/*kiNuEm("A");
kiNuEm("6");
kiNuEm("/");*/

// Tee ohjelma, joka tarkastaa,
// onko annettu kirjain iso vai pieni
function isoPieni(merkki) {
    if (merkki.match(/[a-öA-Ö]/i) && merkki == merkki.toUpperCase()) {
        console.log("Merkki on iso kirjain");
    }
    else if (merkki.match(/[a-öA-Ö]/i) && merkki == merkki.toLowerCase()) {
        console.log("Merkki on pieni kirjain");
    }
    else {
        console.log("Merkki ei ole kirjain");
    }
}
/*isoPieni("v");
isoPieni("T");
isoPieni("?");*/

//  Tee ohjelma, joka laskee annetuista
// myynti ja ostoluvuista, saitko voittoa
// vai tappiota
function voittoTappio(myynti, osto) {
    myynti = parseInt(myynti);
    osto = parseInt(osto);
    if ((myynti - osto) > 0) {
        console.log("Sait voittoa: " + (myynti - osto));
    }
    else {
        console.log("Tappiosi oli " + (myynti - osto));
    }
}
/*voittoTappio(30, 20);
voittoTappio(20, 30);
voittoTappio(30, 30);*/

function koePisteet(Ma, KeFy, Ai, Ru, En) {
    var taulukko = [["Matematiikka", Ma], ["KemiaFysiikka", KeFy], ["Aidinkieli", Ai], ["Ruotsi", Ru], ["Englanti", En]];
    for (var i = 0; i < taulukko.length; i++) {
        if (taulukko[i][1] >= 90) {
            console.log(taulukko[i][0] + ": K5");
        }
        else if (taulukko[i][1] >= 80) {
            console.log(taulukko[i][0] + ": H4");
        }
        else if (taulukko[i][1] >= 70) {
            console.log(taulukko[i][0] + ": H3");
        }
        else if (taulukko[i][1] >= 60) {
            console.log(taulukko[i][0] + ": T2");
        }
        else if (taulukko[i][1] >= 50) {
            console.log(taulukko[i][0] + ": T1");
        }
        else {
            console.log(taulukko[i][0] + ": Hylätty");
        }
    }
}
/*koePisteet(55, 78, 63, 88, 94);
koePisteet(99, 45, 70, 80, 60);*/
// Tee ohjelma, joka tulostaa viikonpäivät, 
//kun annetaan vkpnumero
function viikonpaiva(nro) {
    nro = parseInt(nro);
    console.log(nro);
    switch (nro) {
        case 1:
            console.log("Maanantai");
            break;
        case 2:
            console.log("Tiistai");
            break;
        case 3:
            console.log("Keskiviikko");
            break;
        case 4:
            console.log("Torstai");
            break;
        case 5:
            console.log("Perjantai");
            break;
        case 6:
            console.log("Lauantai");
            break;
        case 7:
            console.log("Sunnuntai");
            break;
        default:
            console.log("Anna numero välillä 1-7");
            break;
    }
}
/*viikonpaiva(5);
viikonpaiva(0);
viikonpaiva(8);*/
// Tee ohjelma, joka kysyy kahta
// kokonaislukua ja tarkastaa, ovatko
// ne samat
function tarkastaKokonaisluvut(a, b) {
    try {
        // Yritetään muuntaa annetut arvot kokonaisluvuiksi.
        const lukuA = parseInt(a);
        const lukuB = parseInt(b);

        // Tarkistetaan, ovatko luvut NaN-arvoja, mikä osoittaa virheellisen muunnoksen.
        if (isNaN(lukuA) || isNaN(lukuB)) {
            throw new Error("Et antanut kokonaislukuja");
        }

        // Vertaillaan, ovatko luvut samat.
        if (lukuA === lukuB) {
            return "Antamasi luvut ovat samat.";
        } else {
            return "Antamasi luvut eivät ole samat.";
        }
    } catch (error) {
        // Jos tapahtuu virhe (esim. muunnos ei onnistu), palautetaan virheviesti.
        return error.message;
    }
}

// Esimerkkejä käytöstä:
/*console.log(tarkastaKokonaisluvut(5, 5)); // Tulostaa "Antamasi luvut ovat samat."
console.log(tarkastaKokonaisluvut(5, "kymmenen")); // Tulostaa "Et antanut kokonaislukuja"
console.log(tarkastaKokonaisluvut("3", 3)); // Tulostaa "Antamasi luvut ovat samat."*/

// Tee ohjelma, joka pyytää käyttäjältä
// ikää ja varmistaa, voiko tämä äänestää
// (18 ->)
function aanestys(ika) {
    ika = parseInt(ika);
    if (ika >= 18) {
        console.log("Voit äänestää");
    }
    else if (isNaN(ika)) {
        console.log("Et antanut numeroa");
    }
    else {
        console.log("Et voi äänestää");
    }
}
/*aanestys(19);
aanestys(5);
aanestys("viisi");*/
// Tee ohjelma, joka pyytää kuukauden
// numeroa ja tulostaa sen jälkeen
// paljonko kuukaudessa on päiviä
// (tähän soveltuu paremmin switch-case)
function kuukaudenPaivat(kknro) {
    kknro = parseInt(kknro);
    switch (kknro) {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            console.log("Kuukaudessa on 31 päivää");
            break;
        case 4:
        case 6:
        case 9:
        case 11:
            console.log("Kuukaudessa on 30 päivää");
            break;
        case 2:
            console.log("Kuukaudessa on 27/28 päivää");
    }
}
/*kuukaudenPaivat(2);
kuukaudenPaivat(6);
kuukaudenPaivat(7);*/

// Tee ohjelma, joka muuttaa annetun
// arvon rahaksi siten, että se ottaa
// huomioon setelien arvot.
// Esim. 1295 = 500 x 2 + 100 x 2 +
// 50 x 1 + 20 x 2 + 5 x 1
function seteleiksi(amount) {
    var note1 = 0, note2 = 0, note5 = 0, note10 = 0, note20 = 0, note50 = 0, note100 = 0, note500 = 0;
    if (amount >= 500) {
        note500 = Math.floor(amount / 500);
        amount -= note500 * 500;
    }
    if (amount >= 100) {
        note100 = Math.floor(amount / 100);
        amount -= note100 * 100;
    }
    if (amount >= 50) {
        note50 = Math.floor(amount / 50);
        amount -= note50 * 50;
    }
    if (amount >= 20) {
        note20 = Math.floor(amount / 20);
        amount -= note20 * 20;
    }
    if (amount >= 10) {
        note10 = Math.floor(amount / 10);
        amount -= note10 * 10;
    }
    if (amount >= 5) {
        note5 = Math.floor(amount / 5);
        amount -= note5 * 5;
    }
    if (amount >= 2) {
        note2 = Math.floor(amount / 2);
        amount -= note2 * 2;
    }
    if(amount >= 1) {
        note1 = amount;
    }
    console.log("Total number of notes = \n");
    console.log("500 = " + note500);
    console.log("100 = " + note100);
    console.log("50 = " + note50);
    console.log("20 = " + note20);
    console.log("10 = " + note10);
    console.log("5 = " + note5);
    console.log("2 = " + note2);
    console.log("1 = " + note1);
}
/*seteleiksi(1295);
seteleiksi(1383);*/

// Tee ohjelma, joka laskee, onko
// mahdollista piirtää kolmio
// annettujen kulma - astelukujen
// perusteella
function kolmio(a, b, c) {
    if (a + b + c == 180) {
        console.log("Kolmio on mahdollinen");
    }
    else {
        console.log("Kolmio ei ole mahdollinen");
    }
}
/*kolmio(60, 60, 60);
kolmio(61, 61, 61);*/

/* S01. Tee ohjelma, laskee, paljonko 
 * joudut maksamaan takaisin, kun 
 * lainasit 5000€ kahdeksi vuodeksi 
 * 2% korolla */
function laina() {
    let maksu = 5000;
    let korko = 1.02;
    let aika = 2;
    let korkosumma;
    let maksettava = maksu;
    for (var i = 1; i <= aika; i++) {
        maksettava = (maksettava * korko);
    }
    korkosumma = maksettava - maksu;
    console.log("Joudut maksamaan "
        + maksu + " euron lainasta korkoa "
        + korkosumma + " jolloin maksettavaa tulee yhteensä "
        + maksettava);
}
//laina();

/* S02. Tee ohjelma, joka laskee 
 * annetun luvun kertoman */
function kertoma(luku) {
    let kertoma = 1;
    for (var i = 1; i <= luku; i++) {
        kertoma *= i;
    }
    console.log("Luvun " + luku + "kertoma on: " + kertoma);
}
/*kertoma(5);
kertoma(7);*/

/* S03. Tee ohjelma, joka etsii luvun 3 
 * ensimmäisen esiintymän taulukosta 
 * [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 
 * 3, 6, 8, 2, 4, 3] */

function esiintyma() {
    let taulukko = [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3];
    for (var i = 0; i < taulukko.length; i++) {
        if (taulukko[i] == 3) {
            console.log("Nro 3 on taulukon " + i + ". jäsen");
            i = taulukko.length;
        }
    }
}
//esiintyma();
/* S04. Tee ohjelma, kääntää käyttäjän 
 * antaman sanan toisinpäin (Hevonen 
 * --> nenoveH) */
function tekstinKaanto(teksti) {
    let lause = "";
    for (var i = teksti.length - 1; i >= 0; i--) {
        lause += teksti[i];
    }
    console.log(lause);
}
//tekstinKaanto("Hevonen");

/* S05. Tee ohjelma, joka etsii 
 * maksimiarvon taulukosta 
 * [6, 7, 2, 4, 3, 8, 1] */
function maksimi() {
    let taulukko = [6, 7, 2, 4, 3, 8, 1];
    let maksimi = taulukko[0];
    for (var i = 1; i < taulukko.length; i++) {
        if (taulukko[i] > maksimi) {
            maksimi = taulukko[i];
        }
    }
    console.log("Taulukon " + taulukko + " maksimiarvo on: " + maksimi);
}
//maksimi();

/* S06. Tee ohjelma, joka laskee 
 * keskiarvon taulukosta 
 * [6, 7, 2, 4, 3, 8, 1] 
 * ilman Math-luokan metodia */
function keskiarvo() {
    let taulukko = [6, 7, 2, 4, 3, 8, 1];
    let summa = 0;
    let keskiarvo = 0;
    for (var i = 0; i < taulukko.length; i++) {
        summa += taulukko[i];
    }
    keskiarvo = summa / taulukko.length;
    console.log("Taulukon " + taulukko + " lukujen keskiarvo on: " + keskiarvo);
}
//keskiarvo();

/* S07. Tee ohjelma, joka tekee uuden 
 * taulukon taulukosta ["a", "b", "c", 
 * "d", "e", "f"] siten, että kaikki 
 * kirjaimet ovat isoja */
function isoiksi() {
    let taulukko = ["a", "b", "c", "d", "e", "f"];
    let uusiTaulukko = [];
    for (var i = 0; i < taulukko.length; i++) {
        uusiTaulukko.push(taulukko[i].toUpperCase());
    }
    console.log(uusiTaulukko);
}
//isoiksi();

/* S08. Tee ohjelma, joka etsii 
 * seitsemännen parittoman esiintymän 
 * taulukosta [6, 7, 2, 4, 3, 8, 1, 9, 
 * 0, 3, 5, 7, 3, 6, 8, 2, 4, 3]*/
function seitsemasPariton() {
    let taulukko = [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3];
    let laskuri = 0;
    let haettuLuku;
    for (var i = 0; i < taulukko.length; i++) {
        if (taulukko[i] % 2 != 0) {
            laskuri++;
            if (laskuri == 7) {
                console.log("Taulukon " + taulukko + " seitsemäs pariton jäsen on " + taulukko[i]);
                i = taulukko.length;
            }
        }
    }
} 
//seitsemasPariton();

/* S09. Tee ohjelma, toiseksi suurimman 
 * luvun taulukosta 
 * [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 
 * 3, 6, 8, 2, 4, 3]*/
function toiseksiSuurin() {
    let taulukko = [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3];
    let suurin = taulukko[0];
    let toiSuurin = 0;
    for (var i = 1; i < taulukko.length; i++)
    {
        if (taulukko[i] > suurin)
        {
            toiSuurin = suurin;
            suurin = taulukko[i];
        }
    }
    console.log("Taulukon " + taulukko + " toiseksi suurin arvo on " + toiSuurin);
}
//toiseksiSuurin();
/* S10. Tee ohjelma, joka tulostaa 
 * sadasta luvusta kolme, kun luku on 
 * 3:lla jaollinen, viisi, kun luku on 
 * 5:llä jaollinen ja viisitoista, kun 
 * luku on sekä kolmella, että viidellä 
 * jaollinen */
function jaollinen() {
    let lause = "";
    for (var i = 1; i <= 100; i++) {
        if (i % 5 == 0 && i % 3 == 0) {
            lause += "viisitoista ";
        }
        else if (i % 5 == 0) {
            lause += "viisi ";
        }
        else if (i % 3 == 0) {
            lause += "kolme ";
        }
        else {
            lause += i + " ";
        }
    }
    console.log(lause);
}
// jaollinen();
/* S11. Tee ohjelma, joka tulostaa 
 * 10 ensimmäistä Fibonaccin numeroa 
 * (0, 1, 1, 2, 3, 5...), eli seuraava 
 * luku on kahden edellisen summa */
function Fibonacci() {
    let fibonacci = [];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for (var i = 2; i < 10; i++) {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    console.log(fibonacci);
}
//Fibonacci();

/* S12. Tee ohjelma, joka tarkastaa, 
 * onko annettu sana / lause palidromi 
 * (esim. aaroporaa), eli luettavissa 
 * molemmin päin */
function palidromi(lause) {
    let kaannetty = "";
    for (var i = lause.length-1; i >= 0; i--) {
        kaannetty += lause[i];
    }
    if (lause == kaannetty) {
        console.log("lause on palidromi");
    }
    else {
        console.log("lause ei ole palidromi")
    }
}
/* palidromi("aaroporaa");
palidromi("aaro");
palidromi("saippuakauppias");
palidromi("innostunut");
palidromi("innostunutsonni"); */

/* S13. Muuta edellinen Fibonacci 
 * tehtävää siten, että lasket 
 * parillisten lukujen summan */
function FibonacciParilliset() {
    let fibonacci = [];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    let summa = 0;
    for (var i = 2; i < 10; i++) {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        if (fibonacci[i] % 2 == 0) {
            summa += fibonacci[i];
        }
    }
    console.log(fibonacci);
    console.log("Parillisten summa: " + summa);
}
//FibonacciParilliset();

/* S14. Muuta edellistä tehtävää siten, 
 * että lasket parittomien lukujen 
 * summan */
function FibonacciParittomat() {
    let fibonacci = [];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    let summa = 1;
    for (var i = 2; i < 10; i++) {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        if (fibonacci[i] % 2 != 0) {
            summa += fibonacci[i];
        }
    }
    console.log(fibonacci);
    console.log("Parittomien summa: " + summa);
}
//FibonacciParittomat();

/* S15. Tee ohjelma, joka etsii kahden 
 * annetun luvun suurimman yhteisen 
 * nimittäjän */

function suurinNimittaja(a, b) {
    let pienempi, temp, suurempi;
    if (a > b) {
        pienempi = b;
        suurempi = a;
    }
    else {
        pienempi = a;
        suurempi = b;
    }
    while (pienempi > 0) {
        temp = pienempi;
        pienempi = suurempi % pienempi;
        suurempi = temp;       
    }
    console.log("Muuttujien yhteinen nimittäjä on: " + temp);
}
//suurinNimittaja(15, 45);

/* S16. Tee ohjelma, joka pyytää 
 * käyttäjältä merkkijonoa pilkulla 
 * erotettuna ja tulostaa sen ilman 
 * pilkkua esim. 
 * pilkutta(7,3,9,2,44,99,123) 
 * -->  7 3 9 2 44 99 123 */
function poistaPilkkuja(numerojono) {
    // Erotetaan numerojono pilkulla ja muunnetaan taulukoksi
    var numerot = numerojono.split(',');

    // Luodaan uusi taulukko ilman pilkkuja
    var tulostettavatNumerot = [];
    for (var i = 0; i < numerot.length; i++) {
        var numero = numerot[i].trim(); // Poistetaan mahdolliset välilyönnit
        if (!isNaN(numero)) { // Tarkistetaan, että se on numero
            tulostettavatNumerot.push(numero);
        }
    }

    // Tulostetaan numerot ilman pilkkua
    console.log(tulostettavatNumerot.join(' '));
}

// Käyttöesimerkki
/*var syote = '7,3,9,2,44,99,123';
poistaPilkkuja(syote);*/

/* Luokkatehtävät */
/* C1 ja C2. Tee Henkiloluokka, jossa on muuttujat: 
 * Etu-, sukunimi ja ikä ja tee 
 * konstructori, jonka avulla ko. tiedot 
 * voi suoraan syöttää. 
 * Tee tämän jälkeen risto-olio 
 * seuraavilla tiedoilla: 
 * Etunimi: Risto, Sukunimi: Reipas, 
 * Ikä: 10 ja tulosta sen jälkeen 
 * Riston tiedot konsoliin*/
// Luodaan Henkilo-luokka
/*class Henkilo {
    constructor(etunimi, sukunimi, ika) {
        this.etunimi = etunimi;
        this.sukunimi = sukunimi;
        this.ika = ika;
    }
}

// Luodaan Risto-olio
const risto = new Henkilo("Risto", "Reipas", 10);
risto.sukunimi = "Reippaampi";
risto.ika = 11;

// Tulostetaan Riston tiedot konsoliin
console.log("Etunimi:", risto.etunimi);
console.log("Sukunimi:", risto.sukunimi);
console.log("Ikä:", risto.ika);*/

/*  C3. Jatka edellistä tehtävää siten, 
 *  että tulostus tapahtuu luokan 
 *  funktiolla NaytaTiedot() */
// Luodaan Henkilo-luokka
/*class Henkilo {
    constructor(etunimi, sukunimi, ika) {
        this.etunimi = etunimi;
        this.sukunimi = sukunimi;
        this.ika = ika;
    }

    NaytaTiedot() {
        console.log("Etunimi:", this.etunimi);
        console.log("Sukunimi:", this.sukunimi);
        console.log("Ikä:", this.ika);
    }
}

// Luodaan Risto-olio uusilla tiedoilla
const risto = new Henkilo("Risto", "Reipas", 10);

// Käytetään NaytaTiedot-funktiota Riston tietojen tulostamiseen
risto.NaytaTiedot(); */

/* C04. Tee kuvakirja -niminen luokka, 
 * jossa privaatti muuttuja 
 * SivujenLukumäärä ja oletuskonsturi, 
 * jossa sivumääräksi määritellään 16 
 * sivua sekä konstruktori, jolla voi 
 * antaa itse sivumäärän */
/*class Kuvakirja {
    // Yksityinen muuttuja
    #SivujenLukumaara;

    // Konstruktori, jolla voi antaa itse sivumäärän
    constructor(sivumaara = 16) {
        this.#SivujenLukumaara = sivumaara;
    }

    // Metodi sivumäärän hakemiseksi
    HaeSivumaara() {
        return this.#SivujenLukumaara;
    }
}

// Luodaan Kuvakirja-olio käyttäen oletuskonstruktoria
const kuvakirjaOletus = new Kuvakirja();
console.log("Oletussivumäärä: " + kuvakirjaOletus.HaeSivumaara());

// Luodaan Kuvakirja-olio antamalla itse sivumääräksi 24
const kuvakirjaMukautettu = new Kuvakirja(24);
console.log("Mukautettu sivumäärä: " + kuvakirjaMukautettu.HaeSivumaara());*/

/* C04. Tee Elain -niminen luokka, 
 * jossa on yksi muuttuja: nimi. 
 * Tee nimelle getterit ja setterit 
 * sekä oletuskonstruktori sekä 
 * ylikuormitettu konstruktori, 
 * jossa nimen voi antaa. 
 * Tee lisäksi Syo-metodi, 
 * joka tulostaa nimen ja 'syö
 * - mumm mumm mumm'. 
 * Luo tämän jälkeen kana-niminen olio 
 * oletuskonstruktorilla ja muuta nimi 
 * sen jälkeen 'kaakattaja':ksi ja 
 * kutsu sen jälkeen Syo-metodia */
/*class Elain {
    constructor(nimi = "kana") {
        this._nimi = nimi;
    }

    // Getter nimen hakemiseksi
    get nimi() {
        return this._nimi;
    }

    // Setter nimen asettamiseksi
    set nimi(uusiNimi) {
        this._nimi = uusiNimi;
    }

    // Syö-metodi
    Syo() {
        console.log(this._nimi + " syö - mumm mumm mumm");
    }
}

// Luo kana-olio oletuskonstruktorilla
const kana = new Elain();
console.log("Olio kana, nimi: " + kana.nimi);

// Muuta kanan nimi
kana.nimi = "kaakattaja";
console.log("Kanan uusi nimi: " + kana.nimi);

// Kutsu Syo-metodia
kana.Syo();*/

/* C06. Jatka edellistä tehtävää siten, 
 * että luot Koira-luokan, joka perii 
 * Eläin -luokan (class Koira: Elain). 
 * Lisää Koira luokkaan tassut (määrä) 
 * ja turkki (väri) -muuttujat. 
 * Tee getterit, setterit, konstruktorit 
 * sekä Aantelehtii-Metodi, joka 
 * tulostaa: nimi "haukkuu", kun 
 * metodille antaa tuon stringinä. 
 * Koiralle voi antaa oletuskonstruktorissa 
 * tassujen määräksi 4 */
/*class Elain {
    constructor(nimi = "") {
        this._nimi = nimi;
    }

    // Getter nimen hakemiseksi
    get nimi() {
        return this._nimi;
    }

    // Setter nimen asettamiseksi
    set nimi(uusiNimi) {
        this._nimi = uusiNimi;
    }

    // Syö-metodi
    Syo() {
        console.log(this._nimi + " syö - mumm mumm mumm");
    }
}

class Koira extends Elain {
    constructor(nimi = "", tassut = 4, turkki = "") {
        super(nimi);
        this._tassut = tassut;
        this._turkki = turkki;
    }

    // Getter tassujen määrän hakemiseksi
    get tassut() {
        return this._tassut;
    }

    // Setter tassujen määrän asettamiseksi
    set tassut(uudetTassut) {
        this._tassut = uudetTassut;
    }

    // Getter turkin värin hakemiseksi
    get turkki() {
        return this._turkki;
    }

    // Setter turkin värin asettamiseksi
    set turkki(uusiTurkki) {
        this._turkki = uusiTurkki;
    }

    // Aantelehtii-metodi
    Aantelehtii(aani) {
        console.log(this._nimi + " " + aani);
    }
}

// Luo koira-olio oletuskonstruktorilla
const koira = new Koira("Haukkuja");
console.log("Olio koira, nimi: " + koira.nimi);
console.log("Tassujen määrä: " + koira.tassut);

// Muuta koiran nimi ja tassujen määrä
koira.nimi = "Rafu";
koira.tassut = 3;
console.log("Koiran uusi nimi: " + koira.nimi);
console.log("Tassujen uusi määrä: " + koira.tassut);*/

// Kutsu Aantelehtii-metodia
//koira.Aantelehtii("haukkuu"); // Tulostaa "Rafu haukkuu"

/* C07. Tee luokka ajoneuvo, jossa on 
 * kolme muuttujaa: merkki, malli, 
 * vuosimalli. Tee konstruktorit, 
 * getterit ja setterit luokkaan.
 * Lisää metodit aja, kiihdyta, jarruta,
 * kaynnista ja sammuta. 
 * Tee sitten luokka auto, joka perii 
 * luokan ajoneuvo. Tee sitten luokka 
 * TestiAjo, jossa luot uuden olion 
 * nimeltä mersu ja kutsut metodia aja 
 * tuolle mersu oliolle */
/*class Ajoneuvo {
    constructor(merkki, malli, vuosimalli) {
        this._merkki = merkki;
        this._malli = malli;
        this._vuosimalli = vuosimalli;
    }

    // Getterit ja setterit
    get merkki() {
        return this._merkki;
    }

    set merkki(uusiMerkki) {
        this._merkki = uusiMerkki;
    }

    get malli() {
        return this._malli;
    }

    set malli(uusiMalli) {
        this._malli = uusiMalli;
    }

    get vuosimalli() {
        return this._vuosimalli;
    }

    set vuosimalli(uusiVuosimalli) {
        this._vuosimalli = uusiVuosimalli;
    }

    aja() {
        console.log("Ajetaan ajoneuvoa: " + this._merkki + " " + this._malli);
    }

    kiihdyta() {
        console.log("Kiihdytetään ajoneuvoa: " + this._merkki + " " + this._malli);
    }

    jarruta() {
        console.log("Jarrutetaan ajoneuvoa: " + this._merkki + " " + this._malli);
    }

    kaynnista() {
        console.log("Käynnistetään ajoneuvo: " + this._merkki + " " + this._malli);
    }

    sammuta() {
        console.log("Sammutetaan ajoneuvo: " + this._merkki + " " + this._malli);
    }
}

class Auto extends Ajoneuvo {
    // Auto-luokka perii Ajoneuvo-luokan ominaisuudet
}

class TestiAjo {
    constructor() {
        // Luodaan mersu-olio Auto-luokasta
        const mersu = new Auto("Mercedes-Benz", "Sarja S", 2023);

        // Kutsutaan ajoneuvon aja-metodia
        mersu.aja();
    }
}

// Luodaan TestiAjo-olio, joka luo mersu-olion ja ajaa sen
const testiAjo = new TestiAjo();*/

/* C08. Jatka edellistä tehtävää siten, 
 * että lisäät Auto-luokkaan pyorat 
 * muuttujan ja oletuskonstruktorissa 
 * annat pyorat muuttujalle oletusarvon 
 * 4. Tee sitten luokka Moottoripyora, 
 * joka perii luokan Auto, mutta pyorat 
 * muuttujan oletusarvo on 2 */
/*class Ajoneuvo {
    constructor(merkki, malli, vuosimalli) {
        this._merkki = merkki;
        this._malli = malli;
        this._vuosimalli = vuosimalli;
    }

    aja() {
        console.log("Ajetaan ajoneuvoa: " + this._merkki + " " + this._malli);
    }

    kiihdyta() {
        console.log("Kiihdytetään ajoneuvoa: " + this._merkki + " " + this._malli);
    }

    jarruta() {
        console.log("Jarrutetaan ajoneuvoa: " + this._merkki + " " + this._malli);
    }

    kaynnista() {
        console.log("Käynnistetään ajoneuvo: " + this._merkki + " " + this._malli);
    }

    sammuta() {
        console.log("Sammutetaan ajoneuvo: " + this._merkki + " " + this._malli);
    }
}

class Auto extends Ajoneuvo {
    constructor(merkki, malli, vuosimalli, pyorat = 4) {
        super(merkki, malli, vuosimalli);
        this._pyorat = pyorat;
    }

    // ... (edellinen koodi) ...
}

class Moottoripyora extends Auto {
    constructor(merkki, malli, vuosimalli, pyorat = 2) {
        super(merkki, malli, vuosimalli, pyorat);
    }

    // ... (edellinen koodi) ...
}

class TestiAjo {
    constructor() {
        const mersu = new Auto("Mercedes-Benz", "Sarja S", 2023);
        const moottoripyora = new Moottoripyora("Harley-Davidson", "Sportster", 2023);

        mersu.aja();
        console.log(mersu._pyorat);
        moottoripyora.aja();
        console.log(moottoripyora._pyorat)
    }
}

const testiAjo = new TestiAjo();*/
/* C09. Luo luokka Pankkitili, joka 
 * sisältää yksityisen ominaisuuden 
 * saldo. Lisää metodi talleta ja nosta,
 * jotka mahdollistavat saldon 
 * tallettamisen ja nostamisen. 
 * Varmista, että saldo ei voi mennä 
 * negatiiviseksi. */
class Pankkitili {
    constructor(saldo = 0) {
        this._saldo = saldo;
    }

    // Talleta rahaa tilille
    talleta(maara) {
        if (maara > 0) {
            this._saldo += maara;
            console.log(`Talletettiin ${maara} euroa. Uusi saldo: ${this._saldo} euroa`);
        } else {
            console.log("Talletusmäärän tulee olla positiivinen.");
        }
    }

    // Nosta rahaa tililtä
    nosta(maara) {
        if (maara > 0 && maara <= this._saldo) {
            this._saldo -= maara;
            console.log(`Nostettiin ${maara} euroa. Uusi saldo: ${this._saldo} euroa`);
        } else if (maara > this._saldo) {
            console.log("Saldo ei riitä nostoon.");
        } else {
            console.log("Nostomäärän tulee olla positiivinen.");
        }
    }

    // Hae nykyinen saldo
    haeSaldo() {
        console.log(`Tilin saldo: ${this._saldo} euroa`);
    }
}

// Luodaan pankkitili
const tili = new Pankkitili(1000); // Alustetaan tili 1000 euron saldolla
tili.haeSaldo(); // Näyttää saldon

tili.talleta(500); // Talletetaan 500 euroa
tili.nosta(300); // Nostetaan 300 euroa
tili.nosta(1500); // Yrittää nostaa liikaa
tili.talleta(-200); // Yrittää tallettaa negatiivisen summan
