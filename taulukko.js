function tulostaNimet() {
    var etunimi = document.getElementById("enimi").value;
    var sukunimi = document.getElementById("snimi").value;
    document.getElementById("vastaus").innerHTML = "Etunimesi on " + etunimi + " ja sukunimesi on " + sukunimi;
}