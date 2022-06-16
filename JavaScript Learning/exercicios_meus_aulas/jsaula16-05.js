console.log("Início");
fetch("https://jsonplaceholder.typicode.com/posts")
  .then((response) => response.json())
  .then((data) => {
    console.log(data);
    mostraTabela(data);
  });
console.log("Fim");

//Fetch API - para fazer pedido assincronos atraves do protocolo HTPP
// A fetch API é baseada em Promises
// Fetch API - para fazer pedidos assíncronos através do protocolo HTTP
// A Fetch API é baseada em promises.
console.log("Início");
fetch("https://jsonplaceholder.typicode.com/posts")
  //fetch('https://jsonplaceholder.typicode.com/posts?_start=0&_limit=10')
  .then((response) => response.json())
  .then((data) => {
    console.log(data);
    mostraTabela(data);
  });
console.log("Fim");

//Construir a tabela
function mostraTabela(lista) {
  let conteudo = "";
  //lista = lista.slice(0,10);
  // for (let pos=0; pos<10; pos++) {
  for (let pos = 0; pos < lista.length; pos++) {
    let linha = `<tr>`;
    linha += `<td>${lista[pos].userId}</td>`;
    linha += `<td>${lista[pos].title}</td>`;
    linha += `<td>${lista[pos].body}</td>`;
    linha += `</tr>`;
    conteudo += linha;
  }
  document.querySelector("#tabelaDados tbody").innerHTML = conteudo;
  document.querySelector("#totalPosts").textContent = lista.length;
}

//Pesquisa
document.querySelector("#pesquisa").addEventListener("input", function () {
  let termoPesquisa = document.querySelector("#pesquisa").value;
  fetch("https://jsonplaceholder.typicode.com/posts?body_like=" + termoPesquisa)
    .then((response) => response.json())
    .then((dados) => {
      mostraTabela(dados);
    });
});

//Filtro
// evento chamado change que é do select
document.querySelector("#userid").addEventListener("change", function () {
  //console.log(this.value);
  let valorSelecionado = Number(this.value);
  if (valorSelecionado !== "") {
    console.log(this.value);
    // fetch("https://jsonplaceholder.typicode.com/posts")
    //   .then((response) => response.json())
    //   .then((dados) => {
    //     let arrayTemp = dados.filter(
    //       (post) => post.userId === valorSelecionado
    //     );
    //     mostraTabela(arrayTemp);
    //   });
    fetch(
      "https://jsonplaceholder.typicode.com/posts?userId=${valorSelecionado}"
    )
      .then((response) => response.json())
      .then((dados) => {
        // let arrayTemp = dados.filter(
        //   (post) => post.userId === valorSelecionado
        // );
        mostraTabela(dados);
      });
  }
});

function filtra_pesquisa() {
  let termoPesquisa = document.querySelector("#pesquisa").value;
  let valorSelecionado = Number(document.querySelector("#userid").value);
  let parametros = "";
  if (termoPesquisa !== "") {
    if (valorSelecionado !== "") {
      parametros += `?userId=${valorSelecionado}&body_like=${termoPesquisa}`;
    } else {
      parametros += `?body_like=${termoPesquisa}`;
    }
  } else {
    if (valorSelecionado !== "") {
      parametros += `?body_like=${valorSelecionado}`;
    }
  }
  fetch(`https://jsonplaceholder.typicode.com/posts?${parametros}`)
    .then((response) => response.json())
    .then((dados) => {
      mostraTabela(dados);
    });
}
