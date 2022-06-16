// NodeList
let listaImagens=document.querySelectorAll("#galeria > img");
console.log(listaImagens);
for (let imagem of listaImagens) {
    // quando clicamos numa imagem da galeria,
    imagem.addEventListener("click",function() {
        // mostrar essa imagem em tamanho grande na modal/dialog box
        document.querySelector("#tela img").src=this.src;
        document.querySelector("#tela").style.visibility="visible";
    });
}
document.querySelector("#tela span").addEventListener("click",function() {
    document.querySelector("#tela").style.visibility="hidden";
});
