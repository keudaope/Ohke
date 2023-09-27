// Freecodecamp Basic Algorithm Scripting
// Teht�v� 1

function convertCtoF(celsius) {
    let fahrenheit = celsius * 9 / 5 + 32;
    return fahrenheit;
}
//console.log(convertCtoF(30));
// Teht�v� 2

function reverseString(str) {
    var temp = "";
    for (var i = str.length - 1; i >= 0; i--) {
        temp += str[i];
    }
    str = temp;
    return str;
}

//console.log(reverseString("hello"));
// Teht�v� 3

function factorialize(num) {
    var temp = 1;
    for (var i = 1; i <= num; i++) {
        temp *= i;
    }
    num = temp;
    return num;
}

//console.log(factorialize(5));

// Teht�v� 4
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
// Teht�v� 5
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
// Teht�v� 6
function confirmEnding(str, target) {
    if (str.substring(str.length - target.length, str.length) == target) {
        str = true;
    }
    else {
        str = false;
    }
    return str;
}

//console.log(confirmEnding("Bastian", "on"));
// Teht�v� 7
function repeatStringNumTimes(str, num) {
    var temp = "";
    for (var i = 0; i < num; i++) {
        temp += str;
    }
    str = temp;
    return str;
}

//console.log(repeatStringNumTimes("abc", 0));
// Tehtävä 8
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
//Tehtävä 9
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
//Tehtävä 10
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
//Tehtävä 11
function titleCase(str) {
    var temp = [];
    var splitattu = str.split(' ');
    for (var i = 0; i < splitattu.length; i++) {
        temp[i] = splitattu[i][0].toUpperCase() + splitattu[i].slice(1).toLowerCase();

    }
    str = temp.join(" ");
    return str;
}

//console.log(titleCase("sHoRt AnD sToUt"));
//Tehtävä 12
function frankenSplice(arr1, arr2, n) {
    // Tekee uuden arrayn, ei kopiota
    let localArr = arr2.slice();
    // Kohdasta n poista 0 elementtiä ja lisää ...arr1
    localArr.splice(n, 0, ...arr1);
    return localArr;
}

//console.log(frankenSplice([1, 2, 3, 4], [], 0));
//Tehtävä 13
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
// Tehtävä 14
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

//console.log(getIndexToIns([10, 20, 30, 40, 50], 35));
// Tehtävä 15
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

//console.log(mutation(["hello", "heo"]));
// Tehtävä 16
function chunkArrayInGroups(arr, size) {
    var temp = [];
    for (var i = 0; i < arr.length; i + size) {
        temp.push(arr.splice(0, size));
    }
    return temp;
}

console.log(chunkArrayInGroups([0, 1, 2, 3, 4, 5], 3));
