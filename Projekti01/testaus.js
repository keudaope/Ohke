// Taulukkotehtävät
// T01
// Luo tyhjä taulukko nimeltä 'kauppalista'
var kauppalista = [];

// Lisää ostettavia tuotteita kauppalistaan
kauppalista.push('maito');
kauppalista.push('leipä');
kauppalista.push('omenat');

// Tulosta koko kauppalista konsoliin
console.log('Kauppalista:');
for (var i = 0; i < kauppalista.length; i++) {
    console.log(kauppalista[i]);
}

// T02
const nimet1 = ["Matti", "Anna", "Eeva", "Jussi", "Liisa"];
console.log(nimet1);

// T03
const taulukko = [1, 2, 3, 4, 5];
const pituus = taulukko.length;
console.log(pituus);

//T04
const nimet2 = ["Matti", "Anna", "Eeva"];
nimet2.push("Jussi");
console.log(nimet2);

//T05
const taulukko1 = [1, 2, 3];
const taulukko2 = [4, 5, 6];
const yhdistettyTaulukko = taulukko1.concat(taulukko2);
console.log(yhdistettyTaulukko); 

//T06
const numerot1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
const parillisetNumerot = numerot1.filter(numero => numero % 2 === 0);
console.log(parillisetNumerot);

//T07
const numerot2 = [5, 2, 9, 1, 5, 8, 3];
numerot2.sort((a, b) => a - b);
console.log(numerot2);

//T08
const numerot3 = [1, 2, 3, 4, 5];
const kaannettyTaulukko = numerot3.reverse();
console.log(kaannettyTaulukko);

//T09
const nimet = ["Matti", "Anna", "Eeva"];
const merkkijono = nimet.join(", ");
console.log(merkkijono);

//T10
const numerot4 = [1, 2, 3, 4, 5];
const poistettava = 3;
const indeksi = numerot4.indexOf(poistettava);
if (indeksi !== -1) {
    numerot4.splice(indeksi, 1);
}
console.log(numerot4);

//T11
const nimet3 = ["Matti", "Anna", "Eeva"];
const etsittavaNimi = "Anna";
const indeksi3 = nimet3.indexOf(etsittavaNimi);
if (indeksi3 !== -1) {
    console.log(`Nimi "${etsittavaNimi}" löytyy indeksistä ${indeksi3}.`);
} else {
    console.log(`Nimeä "${etsittavaNimi}" ei löytynyt.`);
}

//T12
const alkuperainenTaulukko = [1, 2, 3, 4, 5];
const kopio = alkuperainenTaulukko.slice(3);
console.log(kopio);

//T13
const numerot5 = [1, 2, 3, 4, 5];
numerot5[2] = 6;
console.log(numerot5);

//T14
const numerot6 = [1, 2, 3, 4, 5];
var summa = 0;
for(var i = 0; i < taulukko.length - 1; i++)
{
    summa += numerot6[i];
}
console.log(summa);

//T15
const numerot7 = [1, 2, 3, 4, 5];
var summa = 0;
for (var i = 0; i < taulukko.length - 1; i++) {
    summa += numerot7[i];
}
var keskiarvo = summa / taulukko.length;
console.log(keskiarvo);

//T16
const alkuperainenTaulukko1 = [1, 2, 3];
const monistettuTaulukko = [...alkuperainenTaulukko1, ...alkuperainenTaulukko1, ...alkuperainenTaulukko1];
console.log(monistettuTaulukko);

//T17
const taulukko3 = [1, 2, 2, 3, 4, 4, 5];
const uniikitArvot = [...new Set(taulukko3)];
console.log(uniikitArvot);

//T18
const numerot8 = [1, 2, 3, 4, 5];
[numerot8[0], numerot8[numerot8.length - 1]] = [numerot8[numerot8.length - 1], numerot8[0]];
console.log(numerot8);

//T19
const nimet9 = ["Matti", "Anna", "Eeva"];
const isoiksiKirjaimiksi = nimet9.map(nimi => nimi.toUpperCase());
console.log(isoiksiKirjaimiksi);

//T20
const numerotx = [1, 2, 3, 4, 5];
const suuretNumerot = numerotx.filter(numero => numero > 3);
console.log(suuretNumerot);

//SL01
const teksti0 = "Minulla on tili pankissa.";
const regex0 = /kissa/;
console.log(regex0.test(teksti0));
//SL02
const teksti1 = "Poliiseja kutsutaan KISSALANpojiksi.";
const regex1 = /kissa/i;
console.log(regex1.test(teksti1));
