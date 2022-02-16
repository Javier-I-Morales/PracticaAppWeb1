

function creaPestana() {

    var name = window.location.pathname.replace("/Pages/", "").replace(".aspx", "").toLowerCase();
    var tabla = document.getElementById(name);

    document.getElementById("nav_" + name).style.color = "black";
    document.getElementById("nav_" + name).style.fontWeight= "bold";

    tabla.classList.add("pestana");
}
