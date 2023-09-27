// Freecodecamp Basic Algorithm Scripting
<<<<<<< HEAD
// Tehtävä 1 - Muuntaa celsius-arvon Fahrenheiteiksi
=======
// Tehtï¿½vï¿½ 1

>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function convertCtoF(celsius) {
    let fahrenheit = celsius * 9 / 5 + 32;
    return fahrenheit;
}
//console.log(convertCtoF(30));
<<<<<<< HEAD
// Tehtävä 2 - kääntää merkkijonon väärinpäin
=======
// Tehtï¿½vï¿½ 2

>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function reverseString(str) {
    var temp = "";
    for (var i = str.length - 1; i >= 0; i--) {
        temp += str[i];
    }
    str = temp;
    return str;
}
//console.log(reverseString("hello"));
<<<<<<< HEAD
// Tehtävä 3 - Laskee annetun luvun kertoimen
=======
// Tehtï¿½vï¿½ 3

>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function factorialize(num) {
    var temp = 1;
    for (var i = 1; i <= num; i++) {
        temp *= i;
    }
    num = temp;
    return num;
}
//console.log(factorialize(5));
<<<<<<< HEAD
// Tehtävä 4 - etsii merkkijonon pisimmän sanan
=======

// Tehtï¿½vï¿½ 4
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function findLongestWordLength(str) {
    var temp = "";
    str = str.split(' ');
    for (var i = 1; i < str.length; i++) {
        if (str[i].length > str[i - 1].length && str[i].length > temp.length) {
            temp = str[i];
        }
        else if (str[i - 1] > temp.length) {
            temp = str[i - 1];
        }
    }
    str = temp;
    return str.length;
}
//console.log(findLongestWordLength("The quick brown fox jumped over the lazy dog"));
<<<<<<< HEAD
// Tehtävä 5 - Etsii taulukoista isoimman luvun
// ja tallentaa ne uuteen taulukkoon
=======
// Tehtï¿½vï¿½ 5
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function largestOfFour(arr) {
    const results = [];
    for (let i = 0; i < arr.length; i++) {
        let largestNumber = arr[i][0];
        for (let j = 1; j < arr[i].length; j++) {
            if (arr[i][j] > largestNumber) {
                largestNumber = arr[i][j];
            }
        }
        results[i] = largestNumber;
    }
    return results;
}
//console.log(largestOfFour([[4, 5, 1, 3], [13, 27, 18, 26], [32, 35, 37, 39], [1000, 1001, 857, 1]]));
<<<<<<< HEAD
// Tehtävä 6 - tarkistaa, loppuuko merkkijono
// annettuun merkkijonoon
=======
// Tehtï¿½vï¿½ 6
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function confirmEnding(str, target) {
    if (str.substring(str.length - target.length, str.length) == target) {
        str = true;
    }
    else {
        str = false;
    }
    return str;
}
<<<<<<< HEAD
//console.log(confirmEnding("Bastian", "an"));
// Tehtävä 7 - toistaa merkkijonon niin monta
// kertaa, kun on annettu
=======

//console.log(confirmEnding("Bastian", "on"));
// Tehtï¿½vï¿½ 7
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function repeatStringNumTimes(str, num) {
    var temp = "";
    for (var i = 0; i < num; i++) {
        temp += str;
    }
    str = temp;
    return str;
}
//console.log(repeatStringNumTimes("abc", 3));
// Tehtävä 8 - Lyhentää merkkijonon, mikäli
// lyhyempi kuin annettu arvo, muutoin palauttaa
// Koko merkkijonon
function truncateString(str, num) {
    if (str.length > num) {
        str = str.substring(0, num) + "...";
    }
    return str;
}
console.log(truncateString("A-tisket a-tasket A green and yellow basket", 48));

<<<<<<< HEAD
/*Tehtävä 9 - Palauttaa ensimmäisen elementin, 
 joka vastaa funktion true-arvoa */
=======
//console.log(repeatStringNumTimes("abc", 0));
// TehtÃ¤vÃ¤ 8
function truncateString(str, num) {
  if(str.length > num)
  {
    str = str.substring(0, num) + "...";
  }
  else
  {
    str = str;
  }
  return str;
}

//truncateString("A-tisket a-tasket A green and yellow basket", 8);
//TehtÃ¤vÃ¤ 9
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function findElement(arr, func) {
    let num = 0;
    for (var i = 0; i < arr.length; i++) {
        num = arr[i];
        if (func(num)) {
            num = arr[i];
            i = arr.length;
        }
        else {
            num = undefined;
        }
    }
    return num;
}
//console.log(findElement([1, 2, 3, 4], num => num % 2 === 0));
/*Tehtävä 10 - tarkistaa, onko annettu merkkijono 
 boolean-tyyppiä */

<<<<<<< HEAD
function booWho(bool) {
    if (typeof (bool) == 'boolean') {
        bool = true;
    }
    else {
        bool = false;
    }
    return bool;
}
//console.log(booWho(false));
/*Tehtävä 11 - Muuttaa tekstin siten, että sanan 
ensimmäinen kirjain on iso, loput pieniä */
=======
//console.log(findElement([1, 2, 3, 4], num => num % 2 === 0));
//TehtÃ¤vÃ¤ 10
function booWho(bool) {
  if(typeof(bool) == 'boolean')
  {
    bool = true;
  }
  else
  {
    bool = false;
  }
  return bool;
}

//console.log(booWho(false));
//TehtÃ¤vÃ¤ 11
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function titleCase(str) {
    var temp = [];
    var splitattu = str.split(' ');
    for (var i = 0; i < splitattu.length; i++) {
        temp[i] = splitattu[i][0].toUpperCase() + splitattu[i].slice(1).toLowerCase();
<<<<<<< HEAD
=======

>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
    }
    str = temp.join(" ");
    return str;
}
<<<<<<< HEAD
//console.log(titleCase("sHoRt AnD sToUt"));
//Tehtävä 12 - lisää taulukko1:n taulukko2:een
//kohtaan n.
function frankenSplice(arr1, arr2, n) {
    // Tekee uuden arrayn, ei kopiota
    let localArr = arr2.slice();
    // Kohdasta n poista 0 elementtiä ja lisää 
    //...arr1
    localArr.splice(n, 0, ...arr1);
    return localArr;
}
//console.log(frankenSplice([1, 2, 3, 4], [], 0));
//Tehtävä 13 - Poista False-arvot
function bouncer(arr) {
    const filteredArr = [];
    for (let i = 0; i < arr.length; i++) {
        if (arr[i]) {
            filteredArr.push(arr[i]);
        }
    }
    return filteredArr;
}
//console.log(bouncer([7, "ate", "", false, 9, NaN, undefined, 0, null]));
// Tehtävä 14 - kertoo kohdan taulukosta, johon
// annettu arvo sijoittuu
=======

//console.log(titleCase("sHoRt AnD sToUt"));
//TehtÃ¤vÃ¤ 12
function frankenSplice(arr1, arr2, n) {
    // Tekee uuden arrayn, ei kopiota
    let localArr = arr2.slice();
    // Kohdasta n poista 0 elementtiÃ¤ ja lisÃ¤Ã¤ ...arr1
    localArr.splice(n, 0, ...arr1);
    return localArr;
}

//console.log(frankenSplice([1, 2, 3, 4], [], 0));
//TehtÃ¤vÃ¤ 13
function bouncer(arr) {
    const filteredArr = [];
    for (let i = 0; i < arr.length; i++) {
        if (arr[i])
        {
            filteredArr.push(arr[i]);
        } 
    }
    return filteredArr;
}

//console.log(bouncer([7, "ate", "", false, 9, NaN, undefined, 0, null]));
// TehtÃ¤vÃ¤ 14
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function getIndexToIns(arr, num) {
    arr.sort();
    var temp = 0;
    for (var i = 1; i <= arr.length; i++) {
        if (num > arr[i - 1]) {
            temp++;
        }
    }
    return temp;
}
<<<<<<< HEAD
//console.log(getIndexToIns([10, 20, 30, 40, 50], 35));
// Tehtävä 15 - kertoo, löytyykö lauseesta
// annetut merkit
=======

//console.log(getIndexToIns([10, 20, 30, 40, 50], 35));
// TehtÃ¤vÃ¤ 15
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function mutation(arr) {
    var chekattava = arr[0].toLowerCase();
    var kohde = arr[1].toLowerCase();
    var laskuri = 0;
    for (var i = 0; i < kohde.length; i++) {
        if (chekattava.includes(kohde[i])) {
            laskuri++;
        }
    }
    if (kohde.length == laskuri) {
        return true;
    }
    else {
        return false;
    }
}
<<<<<<< HEAD
//console.log(mutation(["hello", "heo"]));
// Tehtävä 16 Hajoittaa taulukon annetun kokoisiksi
// taulukoiksi
=======

//console.log(mutation(["hello", "heo"]));
// TehtÃ¤vÃ¤ 16
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
function chunkArrayInGroups(arr, size) {
    var temp = [];
    for (var i = 0; i < arr.length; i + size) {
        temp.push(arr.splice(0, size));
    }
    return temp;
}
<<<<<<< HEAD
//console.log(chunkArrayInGroups([0, 1, 2, 3, 4, 5], 3));
=======

console.log(chunkArrayInGroups([0, 1, 2, 3, 4, 5], 3));
>>>>>>> 45779f11b6f7c382e52179466610ab9f10f6052d
