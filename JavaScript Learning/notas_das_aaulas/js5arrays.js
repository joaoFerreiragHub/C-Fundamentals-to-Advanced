// let alunos = new Array(5);
// let alunos = new Array("Francisca","Raquel","Jéssica","Sandra","Thaissa");
// let alunos=["Francisca","Raquel","Jéssica","Sandra","Thaissa"];
// console.log(alunos[2]);
// console.log(alunos.length); // 5

let alunos=[]; // array vazio
// alunos[0]="Francisca";
// alunos[1]="Raquel";
// alunos[1]="Jéssica";
// alunos[alunos.length]="Francisca";
// alunos[alunos.length]="Raquel";
// alunos[alunos.length]="Jéssica";
alunos.push("Francisca");
alunos.push("Raquel");
alunos.push("Jéssica");
alunos.push("Sandra","Thaissa","Dafne");
alunos.unshift("Joana");
// alunos.push(34);
// alunos.push(true);
console.log(alunos);
// ['Joana', 'Francisca', 'Raquel', 'Jéssica', 'Sandra', 'Thaissa', 'Dafne']
console.log(alunos[2]); // 'Raquel'
console.log(alunos.slice(2,4)); // ['Raquel', 'Jéssica']
console.log(alunos.slice(3)); // ['Jéssica', 'Sandra', 'Thaissa', 'Dafne']
console.log(alunos.slice()); // ['Joana', 'Francisca', 'Raquel', 'Jéssica', 'Sandra', 'Thaissa', 'Dafne']
console.log(alunos.slice(0)); // ['Joana', 'Francisca', 'Raquel', 'Jéssica', 'Sandra', 'Thaissa', 'Dafne']
console.log(alunos.slice(-1)); // ['Dafne']
console.log(alunos.slice(3,-2)); // ['Jéssica', 'Sandra']

// extrair/remover o último elemento de um array
let elementoRemovido=alunos.pop();
console.log(elementoRemovido); // Dafne
console.log(alunos); // ['Joana', 'Francisca', 'Raquel', 'Jéssica', 'Sandra', 'Thaissa']

// extrair/remover o primeiro elemento de um array
let elementoRemovidoInicio=alunos.shift();
console.log(elementoRemovidoInicio); // Joana
console.log(alunos); // ['Francisca', 'Raquel', 'Jéssica', 'Sandra', 'Thaissa']

// percorrer o array (iterate)
// for (let pos=0; pos<alunos.length; pos++) {
//     console.log(alunos[pos]);
// }

for (let aluno of alunos) { // ES2015 - não funciona no Internet Explorer
    console.log(aluno);
}

// encontrar elementos no array
let posicao=alunos.indexOf("Thaissa");
console.log(posicao); // 4
if (alunos.includes("Raquel")) { // includes devolve true ou false
    console.log("Existe");
}
// Cuidado - o método find() só devolve a primeira ocorrência
let resultado=alunos.find(elemento => elemento.length===7);
console.log(resultado); // Jéssica

let resultado2=alunos.filter(elemento => elemento.length===7);
console.log(resultado2); // ['Jéssica','Thaissa']

// extrair os alunos cujo nome comece por F
let resultado3=alunos.filter(elemento => elemento.startsWith("F"));
console.log(resultado3); // ['Francisca']

// dado o seguinte array
let valores=[ 13, -8, 10, -6, -3, 23, 44 ];
// criar um novo array que contém apenas os valores negativos
// valoresNegativos=[-8,-6,-3];
let valoresNegativos = valores.filter(number => number < 0);
console.log(valoresNegativos);

let valoresNegativos2=[];
for (let valor of valores) {
    if (valor<0) {
        valoresNegativos2.push(valor);
    }
}
console.log(valoresNegativos2);
