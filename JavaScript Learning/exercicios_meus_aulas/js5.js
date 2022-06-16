//let alunos = new Array(5);
//let alunos = ("Francisca", "Raquela", "Joana", "Jéssica", "Sandra"); já nao se usa
//let alunos=[];

// let alunos = ["Francisca", "Raquela", "Joana", "Jéssica", "Sandra"];
// console.log(alunos[2]);

let alunos = [];

alunos[0] = "Francisca";
alunos[1] = "Raquel";
alunos[alunos.length] = "Jéssica";
alunos[alunos.length] = "Thaissa";
console.log(alunos);

alunos.push("Francisca");
alunos.push("Raquel");
alunos.push("Jéssica");
alunos.unshift("Joana");
console.log(alunos);
console.log(alunos.slice(2, 4));

//extrair/remover o ultimo elemento de um array

let elementoRemovido = alunos.pop();
console.log(elementoRemovido);
console.log(alunos);

//extrair/remover o primeiro elemento de um array

let elementoRemovidoInicio = alunos.shift();
console.log(elementoRemovidoInicio);
console.log(alunos);

//mostrar elementos do array um por linha

for (let pos = 0; pos < alunos.length; pos++) {
  console.log(alunos[pos]);
}

for (let aluno of alunos) {
  console.log(aluno);
}

// encontrar elementos no array

// let posicao = alunos.indexOf("Thaissa");
// console - log(posicao);
// if (alunos.includes("Raquel")) {
//   //Includes devolve true ou false
//   console.log("existe");
// }

let resultado = alunos.find((elemento) => elemento.length === 7);
console.log(resultado);

let resultado2 = alunos.filter((elemento) => elemento.length === 7);
console.log(resultado2);

let resultado3 = alunos.filter((elemento) => elemento.startsWith("F"));
console.log(resultado3);

// Dado o seguinte array

let valores = [12, -8, 12, -6, -3, 23, 44];

//criar um novo array que contem apenas os valores negativos
//valoresNegativos=[-8,-6,-3]

let valoresNegativos = [];

for (let pos = 0; pos < valores.length; pos++) {
  if (valores[pos] <= 0) {
    valoresNegativos[valoresNegativos.length] = valores[pos];
  }
}
console.log(valoresNegativos);

let valoresNegativos2 = valores.filter((number) => number < 0);
console.log(valoresNegativos2);

for (let valor of valores) {
  if (valor < 0) {
    valoresNegativos.push(valor);
  }
}

console.log(valoresNegativos);
