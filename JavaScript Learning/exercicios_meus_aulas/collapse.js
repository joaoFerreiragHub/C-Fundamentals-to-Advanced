let elInformacao = document.getElementsByTagName("section")[0];

// document.getElementById("btInfo").addEventListener("click", function () {
//   //atributo hidden, propriedades display e visability
//   // getElementsByTagName devolve uma node list (é um array like)
//   // elInformacao.hidden = "false";
//   // elInformacao.toggleAttribute("hidden"); Maneira facil

//   if (elInformacao.style.display === "block") {
//     elInformacao.setAttribute("hidden", "false");
//   } else {
//     elInformacao.setAttribute("hidden", "true");
//   }
// });

let coll = document
  .getElementById("btInfo")
  .addEventListener("click", function () {
    if (elInformacao.style.display === "block") {
      elInformacao.style.display = "none";
    } else {
      elInformacao.style.display = "block";
    }
  });
