function mostra_interpretes(dados) {
  let conteudo = "";

  for (let pos = 0; pos < dados.length; pos++) {
    let linha = `<tr>`;
    linha += `<td>${dados[pos].id}</td>`;
    linha += `<td>${dados[pos].nome}</td>`;
    linha += `<td>${dados[pos].genero}</td>`;
    linha += `<td>${dados[pos].ano_nascimento}</td>`;
    linha += `<td>${dados[pos].tipo}</td>`;
    // linha+=`<td></td>`;
    linha += `</tr>`;
    conteudo += linha;
  }
  document.querySelector("#tabelaDados tbody").innerHTML = conteudo;
  document.querySelector("#totalInterpretes").textContent = dados.length;
}

fetch("http://localhost:3000/interpretes")
  .then((response) => {
    if (response.ok) {
      return response.json();
    } else {
      // console.log(response.status);
      // throw Error(response.statusText);
      throw Error(response.status);
    }
  })
  .then((dados) => {
    // console.log(dados);
    mostra_interpretes(dados);
  })
  .catch((erro) => {
    if (erro.message === "404") {
      window.location.href = "interpretes404.html";
    } else {
      alert("Ocorreu um erro. Por favor volte a tentar mais tarde.");
      console.log(erro);
    }
  });

fetch(`http://localhost:3000/generos`)
  .then((response) => response.json())
  .then((generos) => {
    console.log(generos);
    let conteudo = `<option value=""> -- Selecione um género musical -- </option>`;
    for (let genero of generos) {
      conteudo += `<option value="${genero}">${genero}</option>`;
    }
    document.querySelector("#genero").innerHTML = conteudo;
  });

fetch("http://localhost:3000/tipos")
  .then((response) => response.json())
  .then((tipos) => {
    // console.log(tipos);
    let opcao = document.createElement("input");
    // opcao.setAttribute("type","radio");
    // opcao.id=tipo;
    // opcao.name="tipo";
    // opcao.value=tipo;
    // document.querySelector("#listaTipos").appendChild(opcao);
    // let identificador=document.createElement("label");
    // identificador.setAttribute("for",tipo);
    // identificador.textContent=tipo;
    // document.querySelector("#listaTipos").appendChild(identificador);

    let conteudo = "";
    for (let tipo of tipos) {
      conteudo += `<input type="radio" id="${tipo}" name="tipo" value="${tipo}"> <label for="${tipo}">${tipo}</label> `;
    }
    document.querySelector("#listaTipos").innerHTML = conteudo;
  });

document.querySelector("#btRegistar").addEventListener("click", function () {
  // let formulario = document.querySelector("formRegisto");
  // const valoresForm = new FormData(formulario);
  // console.log(valoresForm);
  // console.log(valoresForm.entries());

  let cnome = document.querySelector("#nome").value;
  let cgenero = document.querySelector("#genero").value;
  let cano = document.querySelector("#ano_nascimento").value;
  let listaTipos = document.querySelectorAll("[name=tipo]");
  // let listaTipos = document.getElementByName("tipo");
  let ctipo = "";

  for (let tipo of listaTipos) {
    if (tipo.checked) {
      ctipo = tipo.value;
      break;
    }
  }

  let dados = {
    nome: cnome,
    genero: cgenero,
    ano_nascimento: cano,
    tipo: ctipo,
  };
  console.log(dados);

  fetch("http://localhost:3000/interpretes", {
    method: "POST",
    body: JSON.stringify(dados),
    headers: new Headers({
      "Content-Type": "application/json; charset=utf-8",
    }),
  })
    .then((response) => response.json())
    .then((resposta) => {
      console.log(resposta);
    });

  // ('{"nome":"Pedro","genero":"Pop"}');
});
