//dada uma variavel do tipo string verificar se um determinado caracter existe nessa string,
//e em que posição

let nome = "Joao Ferreira";
let caracter = "e";

let existe = false; //flag
let pos;
for (pos = 0; pos < nome.length; pos++) {
  if (nome[pos] === caracter) {
    existe = true;
    break;
  }
}
if (existe) {
  alert(`Existe na posição ${pos + 1} numero de vezes ${count}`);
} else {
  alert(`Não existe!`);
}

//indexOf/lastIndexOf - devolve a posição da primeira ocorrencia, senão, devolve -1, caso não encontra.
//includes - devolve true/false
//search - funciona como o indexOf, mas permite expressões regulares(regex)

let nome2 = "Joao Ferreira";
let caracters = "e";

let existem = false; //flag
let posi;
let count = 0;
for (pos = 0; posi < nomes.length; pos++) {
  if (nome[pos] === caracter) {
    count++;
  }
}

alert(`o caractere '${caracter}' ocorre ${count} vezes.`);
