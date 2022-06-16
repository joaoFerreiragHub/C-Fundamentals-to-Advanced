//Fetch API - para fazer pedidos assincronos atraves do protocolo HTTP

// A Fetch API é baseada em Promises
console.log("Inicio");
fetch("https://jsonplaceholder.typicode.com/posts")
  .then((response) => response.json())
  .then((dados) => {
    console.log(dados);
  });
console.log("Fim");

//JSON
// "formadores": [
//   {
//     "nome": "Pedro Remoaldo",
//     "modulo": "JavaScript"
//   }
// ]

// let formadores = [
//   {
//     nome: "Pedro Remoaldo",
//     modulo: "JavaScript",
//   },
// ];
