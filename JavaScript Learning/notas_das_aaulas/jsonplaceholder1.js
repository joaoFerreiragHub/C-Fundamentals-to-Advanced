console.log("Inicio");

function mostraUser(userid) {
  console.log(userid);
  // https://jsonplaceholder.typicode.com/users?id=5
  fetch(`https://jsonplaceholder.typicode.com/users?id=${userid}`)
    .then(response => response.json())
    .then(user => {
      console.log(user);
      let conteudo="";
      // <p><strong>Username:</strong>Kamren</p>
      conteudo+=`<h2>User information</h2>`;
      conteudo+=`<p><strong>Name:</strong> ${user[0].name}</p>`;
      conteudo+=`<p><strong>Username:</strong> ${user[0].username}</p>`;
      conteudo+=`<p><strong>E-mail:</strong> ${user[0].email}</p>`;
      conteudo+=`<p><strong>Address:</strong><br>`;
      conteudo+=`${user[0].address.street}, ${user[0].address.suite}<br>`;
      conteudo+=`${user[0].address.zipcode}, ${user[0].address.city}</p>`;
      conteudo+=`<p><strong>Coordinates:</strong> ${user[0].address.geo.lat} ${user[0].address.geo.lng}</p>`;
      conteudo+=`<p><strong>Phone:</strong> ${user[0].phone}</p>`;
      conteudo+=`<p><strong>Website:</strong> ${user[0].website}</p>`;
      conteudo+=`<p><strong>Company:</strong> ${user[0].company.name}</p>`;
      document.querySelector("#userInfo").innerHTML=conteudo;
    })
  document.querySelector("#tela").style.visibility="visible";
}

function mostraTabela(lista) {
  let conteudo="";
  // lista=lista.slice(0,10);
  // for(let item of lista) {
  //     let linha=`<tr>`;
  //     linha+=`<td>${item.userId}</td>`;
  //     linha+=`<td>${item.title}</td>`;
  //     linha+=`<td>${item.body}</td>`;
  //     // linha+=`<td><i class="fa-regular fa-pen-to-square"></i> <i data-id="${utilizador.id}" class="fa-regular fa-trash-can"></i></td>`;
  //     linha+=`<td></td>`;
  //     linha+=`</tr>`;
  //     conteudo+=linha;
  // }
  // for(let pos=0;pos<10;pos++) {
  for(let pos=0;pos<lista.length;pos++) {
      let linha=`<tr>`;
      linha+=`<td><a href="javascript:void(0);" class="linksUserId" data-userid="${lista[pos].userId}">${lista[pos].userId}</a></td>`;
      linha+=`<td>${lista[pos].title}</td>`;
      linha+=`<td>${lista[pos].body}</td>`;
      // linha+=`<td><i class="fa-regular fa-pen-to-square"></i> <i data-id="${utilizador.id}" class="fa-regular fa-trash-can"></i></td>`;
      linha+=`<td></td>`;
      linha+=`</tr>`;
      conteudo+=linha;
  }
  document.querySelector("#tabelaDados tbody").innerHTML=conteudo;
  document.querypoSelector("#totalPosts").textContent=lista.length;

  // let listaLinks=document.getElementsByClassName("linksUserId");
  let listaLinks=document.querySelectorAll(".linksUserId");
  for (let link of listaLinks) {
    link.addEventListener("click",function() {
      // console.log(this.textContent);
      let userid=this.getAttribute("data-userid");
      mostraUser(userid);
    });
  }

}

// Fetch API - para fazer pedidos assíncronos através do protocolo HTTP
// A Fetch API é baseada em Promises

fetch('https://jsonplaceholder.typicode.com/posts')
// fetch('https://jsonplaceholder.typicode.com/posts?_start=0&_limit=10')
  .then(response => {
    // console.log("Total: "+response.headers.get("X-Total-Count"));
    // let totalPosts=response.headers.get("X-Total-Count");
    // document.querySelector("#totalPosts").textContent=totalPosts;
    return response.json();
  })
  .then(dados => {
      console.log(dados);
      mostraTabela(dados);
  })

fetch('https://jsonplaceholder.typicode.com/users')
  .then(response => response.json())
  .then(users => {
    let selectElement=document.querySelector("#userid");
    // console.log(users);
    // let conteudo="";
    let users2=users
      .map(user => ({ id: user.id, name: user.name}))
      // .sort((a,b) => a.name.localeCompare(b.name));
      .sort((a,b) => {
        // if (a.name > b.name) return 1;
        // else if (a.name < b.name) return -1;
        return (a.name > b.name) ? 1 : -1;
      });
    for (let user of users2) {
      // conteudo+=`<option value="${user.id}">${user.name}</option>`;
      let novaOption=document.createElement("option");
      novaOption.setAttribute("value",user.id);
      novaOption.textContent=user.name;
      selectElement.appendChild(novaOption);
    }
    // document.querySelector("#userid").append(conteudo);
})

// document.querySelector("#pesquisa").addEventListener("input", function() {
//   let termoPesquisa=document.querySelector("#pesquisa").value;
//   fetch('https://jsonplaceholder.typicode.com/posts')
//     .then(response => response.json())
//     .then(dados => {
//         let arrayTemp=dados.filter(post => post.body.toUpperCase().includes(termoPesquisa.toUpperCase()));
//         mostraTabela(arrayTemp);
//     });
// });
document.querySelector("#pesquisa").addEventListener("input", function() {
  // let termoPesquisa=document.querySelector("#pesquisa").value;
  // fetch('https://jsonplaceholder.typicode.com/posts?body_like='+termoPesquisa)
  //   .then(response => response.json())
  //   .then(dados => {
  //       mostraTabela(dados);
  //   });
  filtra_pesquisa();
});

document.querySelector("#userid").addEventListener("change", function() {
  // let valorSeleccionado=Number(this.value);
  // if (valorSeleccionado!=="") {
  //   console.log(this.value);
  //   // fetch('https://jsonplaceholder.typicode.com/posts')
  //   //   .then(response => response.json())
  //   //   .then(dados => {
  //   //       let arrayTemp=dados.filter(post => post.userId===valorSeleccionado);
  //   //       mostraTabela(arrayTemp);
  //   //   });
  //   fetch(`https://jsonplaceholder.typicode.com/posts?userId=${valorSeleccionado}`)
  //     .then(response => response.json())
  //     .then(dados => {
  //         // let arrayTemp=dados.filter(post => post.userId===valorSeleccionado);
  //         mostraTabela(dados);
  //     });
  // }
  filtra_pesquisa();
});

function filtra_pesquisa() {
  let termoPesquisa=document.querySelector("#pesquisa").value;
  let valorSeleccionado=Number(document.querySelector("#userid").value);
  let parametros="";
  if (termoPesquisa!=="") {
    if (valorSeleccionado!=="") {
      parametros+=`?userId=${valorSeleccionado}&body_like=${termoPesquisa}`;
    } else {
      parametros+=`?body_like=${termoPesquisa}`;
    }
  } else {
    if (valorSeleccionado!=="") {
      parametros+=`?userId=${valorSeleccionado}`;
    }
  }
  fetch(`https://jsonplaceholder.typicode.com/posts${parametros}`)
    .then(response => response.json())
    .then(dados => {
        mostraTabela(dados);
    });
}

// JSON
// "formadores":[{"nome":"Pedro Remoaldo","modulo":"JavaScript"}
// ]

// Objecto literal de JavaScript
// let formadores= [
//     {
//         nome: "Pedro Remoaldo",
//         modulo: "JavaScript"
//     }
// ]

document.querySelector("#tela span").addEventListener("click",function() {
  document.querySelector("#tela").style.visibility="hidden";
});

console.log("Fim");