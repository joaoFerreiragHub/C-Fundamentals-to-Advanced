// hipóteses: atributo hidden, propriedades display e visibility (o visibility só deve ser utilizado para position: fixed ou absolute)

// getElementsByTagName devolve uma node list (é um array-like)
let elInformacao1=document.getElementsByTagName("section")[0];
let elInformacao2=document.getElementsByTagName("section")[1];
let elInformacao3=document.getElementsByTagName("section")[2];

document.getElementById("btInfo1").addEventListener("click", function() {
    if (!elInformacao1.hasAttribute("hidden")) {
        elInformacao1.setAttribute("hidden",true);
    } else {
        elInformacao1.removeAttribute("hidden");
    }
});
document.getElementById("btInfo2").addEventListener("click", function() {
    elInformacao2.toggleAttribute("hidden");
});
document.getElementById("btInfo3").addEventListener("click", function() {
    if (elInformacao3.style.display==="block") {
        elInformacao3.style.display="none";
    } else {
        elInformacao3.style.display="block";
    }
});