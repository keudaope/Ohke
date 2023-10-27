//function summa(a, b) {
//    return a + b;
//}
//let pienet = summa(3, 5);
//console.log(pienet);

//let summa2 = (a, b) => { return a + b; }
//console.log(summa2(5, 6));

//let taulu = [1, 3, 4, 5, 6, 7, 9];
//const parilliset = taulu.filter((jasen) => {
//    return jasen % 2 !== 0;
//})
//console.log(parilliset);

function readTextFile(file) {
    var rawFile = new XMLHttpRequest();
    rawFile.open("GET", file, false);
    rawFile.onreadystatechange = function () {
        if (rawFile.readyState === 4) {
            if (rawFile.status === 200 || rawFile.status == 0) {
                var allText = rawFile.responseText;
                console.log(allText);
            }
        }
    }
    rawFile.send(null);
