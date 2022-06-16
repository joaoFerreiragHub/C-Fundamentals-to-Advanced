let sectionErros = document.querySelector("#erros");
let nomeErro = document.querySelector("#erroNome");

let telefoneErro = document.querySelector("#erroTelefone");
let arrayUtilizadores = [];
let totalErros = 0;
document;
let elTabela = document
  .querySelector("#tabelaDados")

  .querySelector("#formUtilizadores")
  .addEventListener("submit", function (evento) {
    evento.preventDefault();

    let cnome = document.querySelector("#nome");
    let cemail = document.querySelector("#email");
    let ctelefone = document.querySelector("#telefone");

    //validação dos dados
    if (cnome.value === "" || cemail.value === "" || ctelefone === "") {
      sectionErros.innerHTML =
        "<p>Todos os campos são de preenchimento obrigatório!</p>";

      // alert("Todos os campos são de preenchimento obrigatório!")
    } else {
      // validação do nome:
      // - nao pode ter algarismo
      // - minimo 5 caracteres
      let erNome = /^.{5,}$/;
      if (!erNome.test(cnome.value)) {
        nomeErro.textContent = "o nome tem de ter, no mínimo, 5 caracteres!";
        nomeErro.style.display = "block";
        cnome.style.backgroundColor = "yellow";
      } else {
        nomeErro.style.display = "none";
      }
      let erTelefone = /^[0-9]{9}$/;
      if (!erTelefone.test(ctelefone.value)) {
        telefoneErro.textContent =
          "o telefone tem de ter no mínimo 9 algarismos!";
        telefoneErro.style.display = "block";
        ctelefone.style.backgroundColor = "yellow";
        totalErros++;
      } else {
        telefoneErro.style.display = "none";
      }
      // validação do email
      // - expressão regular
      // validação do telefone
      // - número máximo de algarismos -Em portugal sao 9.
      // - resto do mundo - 15 algarismos

      if (totalErros === 0) {
        arrayUtilizadores.push({
          nome: cnome.value,
          email: cemail.value,
          telefone: ctelefone.value,
        });
        cnome.value = "";
        cemail.value = "";
        ctelefone = "";
        cnome.focus();
        let conteudo = "";
        for (let utilizador of arrayUtilizadores) {
          let linha = `<td>`;
          linha += `<td>${utilizador.nome}</td>`;
          linha += `<td>${utilizador.email}</td>`;
          linha += `<td>${utilizador.telefone}</td>`;
          linha += `<td></td>`;
          linha += `</tr>`;
          conteudo += linha;
        }

        document.querySelector("#tabelaDados tbody").innerHTML = conteudo;

        document.querySelector("#totalUtilizadores").textContent =
          arrayUtilizadores.length;
      }
    }
  });

elTabela.innerHTML = conteudo;

document.querySelector("#totalUtilizadores").textContent =
  arrayUtilizadores.length;
