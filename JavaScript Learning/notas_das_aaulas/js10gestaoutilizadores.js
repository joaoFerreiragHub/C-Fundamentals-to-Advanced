let sectionErros=document.querySelector("#erros");
let nomeErro=document.querySelector("#erroNome");
let telefoneErro=document.querySelector("#erroTelefone");
let elTabela=document.querySelector("#tabelaDados");

let utilizadores=[
    { id: 1, nome: "Pedro Remoaldo", email: "premoaldo@gmail.com", telefone: 987654321 },
    { id: 2, nome: "Dafne Palú", email: "dafnepalu@gmail.com", telefone: 923432123 },
    { id: 3, nome: "Thaissa Silva", email: "thaissasilva@gmail.com", telefone: 964534567 }
];
// let registoCorrente=3;

function mostraTabela(arrayUtilizadores) {
    let conteudo="";
    for(let utilizador of arrayUtilizadores) {
        let linha=`<tr>`
        linha+=`<td>${utilizador.nome}</td>`;
        linha+=`<td>${utilizador.email}</td>`;
        linha+=`<td>${utilizador.telefone}</td>`;
        linha+=`<td><i class="fa-regular fa-pen-to-square"></i> <i data-id="${utilizador.id}" class="fa-regular fa-trash-can"></i></td>`;
        linha+=`</tr>`;
        conteudo+=linha;
    }
    document.querySelector("#tabelaDados tbody").innerHTML=conteudo;

    document.querySelector("#totalUtilizadores").textContent=arrayUtilizadores.length;

    let listaBotoesDelete=document.querySelectorAll("#tabelaDados .fa-trash-can");
    // quando clicar num ícone Delete
    for (let botao of listaBotoesDelete) {
        botao.addEventListener("click",function() {
            if (confirm("Confirma a eliminação do utilizador")) {
                // eliminar a respectiva linha/utilizador do array 
                let idAEliminar=Number(this.getAttribute("data-id"));
                // let arrayTemp=utilizadores.filter(utilizador => utilizador.id!==idAEliminar);
                // utilizadores=[...arrayTemp];
                // utilizadores=[...utilizadores.filter(utilizador => utilizador.id!==idAEliminar)];
                let posicaoNoArray=utilizadores.findIndex(utilizador => utilizador.id===idAEliminar);
                utilizadores.splice(posicaoNoArray,1);
                mostraTabela(utilizadores);
            }
        });
    }
}

document.querySelector("#formUtilizadores").addEventListener("submit",function(evento) {
    evento.preventDefault();
    let cnome=document.querySelector("#nome");
    let cemail=document.querySelector("#email");
    let ctelefone=document.querySelector("#telefone");

    // validação dos dados
    if (cnome.value==="" || cemail.value==="" || ctelefone.value==="") {
        sectionErros.innerHTML="<p>Todos os campos são de preenchimento obrigatório!</p>";
        // alert("Todos os campos são de preenchimento obrigatório!");
    } else {
        let totalErros=0;
        // validação do nome
        // - não pode conter algarismos
        // - mínimo de 5 caracteres
        let erNome=/^.{5,60}$/;
        if (!erNome.test(cnome.value)) {
            nomeErro.textContent="O nome tem de ter, no mínimo, 5 caracteres!";
            nomeErro.style.display="block";
            cnome.style.backgroundColor="yellow";
            totalErros++;
        } else {
            nomeErro.style.display="none";
            cnome.style.backgroundColor="white";
        }
        // validação do email
        // - expressão regular
        // regex used in type=”email” from W3C:
        // /^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/

        // validação do telefone
        // - número máximo de algarismos - Em Portugal são 9
        // - resto do mundo - 15
        let erTelefone=/^[0-9]{9}$/;
        if (!erTelefone.test(ctelefone.value)) {
            telefoneErro.textContent="O telefone tem de ter 9 algarismos!";
            telefoneErro.style.display="block";
            ctelefone.style.backgroundColor="yellow";
            totalErros++;
        } else {
            telefoneErro.style.display="none";
            ctelefone.style.backgroundColor="white";
        }
        if (totalErros===0) {
            // gerar um novo id
            // registoCorrente++;
            let calculaMaximo = (maximo,utilizador) => {
                if (maximo>utilizador.id) {
                    return maximo;
                } else {
                    return utilizador.id;
                }
            }
            let maximo=utilizadores.reduce(calculaMaximo,0)+1;

            utilizadores.push({ 
                // id: registoCorrente,
                id: maximo,
                nome: cnome.value,
                email: cemail.value,
                telefone: ctelefone.value
            });
            cnome.value="";
            cemail.value="";
            ctelefone.value="";
            cnome.focus();
            mostraTabela(utilizadores);
        }
    }
})

// document.querySelector("#formPesquisa").addEventListener("submit", function(evento) {
//     evento.preventDefault();
// input ou keyup
document.querySelector("#pesquisa").addEventListener("input", function() {
    let termoPesquisa=document.querySelector("#pesquisa").value;
    let arrayTemp=utilizadores.filter(utilizador => utilizador.nome.toUpperCase().includes(termoPesquisa.toUpperCase()));
    // if (arrayTemp.length>0) {
    if (arrayTemp.length) {
        mostraTabela(arrayTemp);
        document.querySelector("#msgPesquisa").style.display="block";
        document.querySelector("#tabelaDados").style.display="table";
        document.querySelector("#msgPesquisa").innerHTML=`Pesquisou por: <strong>'${termoPesquisa}'</strong>.`;
    } else {
        document.querySelector("#msgPesquisa").innerHTML=`Pesquisou por: ${termoPesquisa} <br><br>Não existem resultados para a pesquisa.`;
        document.querySelector("#msgPesquisa").style.display="block";
        document.querySelector("#tabelaDados").style.display="none";
    }
    // document.querySelector("#pesquisa").value="";
});

document.querySelector("#btLimpaPesquisa").addEventListener("click", function() {
    mostraTabela(utilizadores);
});

mostraTabela(utilizadores);