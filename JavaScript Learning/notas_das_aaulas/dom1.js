// console.log(document.body.firstElementChild);
// console.log(document.getElementById("primeiroParagrafo"));

let elBtMudaTexto=document.getElementById("btMudaTexto");
let elPrimeiroParagrafo=document.getElementById("primeiroParagrafo");

// guardar o texto original do parágrafo numa variável
let textoOriginal=elPrimeiroParagrafo.innerHTML;
// event handler
elBtMudaTexto.onclick=function() {
    // console.log(this);
    // função anónima
    // callback
    // document.getElementById("primeiroParagrafo").textContent="Primavera";
    
    // mudar o texto do parágrafo, consoante o que está escrito no botão
    // (testar o que está escrito no botão)
    if (elBtMudaTexto.textContent==="Muda Texto") { 

        // mudar o texto do parágrafo
        elPrimeiroParagrafo.innerHTML="<strong><em>Primavera</em></strong>";
        // mudar o estilo CSS do parágrafo
        // elPrimeiroParagrafo.style.color="white";
        // background-color
        // elPrimeiroParagrafo.style.backgroundColor="#00f";

        // elPrimeiroParagrafo.className="realce";
        // elPrimeiroParagrafo.classList.add("realce");
        elPrimeiroParagrafo.classList.toggle("realce");

        // #00f, #0000ff, blue, rgb(0,0,255), rgb(0%,0%,100%), rgba(0,0,255,1), hsl, hsla

        // mudar o texto do botão
        // elBtMudaTexto.textContent="Repõe Texto";
        this.textContent="Repõe Texto";

    } else {
        elPrimeiroParagrafo.innerHTML=textoOriginal;
        // elBtMudaTexto.textContent="Muda Texto";
        this.textContent="Muda Texto";
        // elPrimeiroParagrafo.style.color="black"; // #000
        // elPrimeiroParagrafo.style.backgroundColor="#fff"; // white
        // elPrimeiroParagrafo.classList.remove("realce");
        elPrimeiroParagrafo.classList.toggle("realce");
    }
}

// event listener
// elBtMudaTexto.addEventListener("click", function() {
// });
// function teste() {
//     console.log("Teste");
// }
// elBtMudaTexto.addEventListener("click", teste);
// function teste2(valor1) {
//     console.log(valor1);
// }
// elBtMudaTexto.addEventListener("click", function() {
//     teste2(50);
// });
// function teste3() {
//     teste2(50);
// }
// elBtMudaTexto.addEventListener("click", teste3);



