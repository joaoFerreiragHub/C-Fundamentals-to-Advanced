//quando clicamos numa imagem pequena da galeria,
//mostrar essa imagem em tamanho grande na modal/dialog box

let listaImagens = document.querySelectorAll("#galeria > img");
let closeBtn = document.getElementById("fechar");
console.log(listaImagens);

for (let imagem of listaImagens) {
  imagem.addEventListener("click"),
    function () {
      let source = this.src;
      console.log(source);
      document.querySelector("#tela img").src = this.src;
      document.querySelector("#tela").style.visibility = "visible";
    });
  }
      closeBtn.querySelector("#tela span").addEventListener("click", function(){
        document.querySelector("#tela").style.visibility="hidden";
     
    });

