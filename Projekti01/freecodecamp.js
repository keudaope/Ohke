// Freecodecamp Basic Algorithm Scripting
// Tehtävä 1

function convertCtoF(celsius) {
    let fahrenheit = celsius * 9 / 5 + 32;
    return fahrenheit;
}
//console.log(convertCtoF(30));
// Tehtävä 2

function reverseString(str) {
    var temp = "";
    for (var i = str.length - 1; i >= 0; i--) {
        temp += str[i];
    }
    str = temp;
    return str;
}

//console.log(reverseString("hello"));
// Tehtävä 3

function factorialize(num) {
    var temp = 1;
    for (var i = 1; i <= num; i++) {
        temp *= i;
    }
    num = temp;
    return num;
}

//console.log(factorialize(5));

// Tehtävä 4
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
// Tehtävä 5
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
// Tehtävä 6
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
// Tehtävä 7
function repeatStringNumTimes(str, num) {
    temp = "";
    for (var i = 0; i < num; i++) {
        temp += str;
    }
    str = temp;
    return str;
}

console.log(repeatStringNumTimes("abc", 0));

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