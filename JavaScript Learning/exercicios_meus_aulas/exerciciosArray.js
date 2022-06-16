let numeros = [10, 9, 8, 2, 7, 5, 1, 3, 0];
let resultado = numeros.filter((numero) => numero < 3);
console.log(resultado);

let resultado1 = [];

function menorQue3() {
  for (let elemento of numeros) {
    if (elemento < 3) {
      resultado1.push(elemento);
    }
  }
}
menorQue3();
console.log(resultado1);

let pessoas = [
  { nome: "Pedro Remoaldo", localidade: "Ermesinde" },
  { nome: "Luísa Xavier", localidade: "Lisboa" },
  { nome: "Mário Simões", localidade: "Lisboa" },
  { nome: "Joana Castro", localidade: "Santa Maria da Feira" },
  { nome: "Guilherme Silveira", localidade: "Lisboa" },
  { nome: "Pedro Oliveira", localidade: "Ermesinde" },
];

let lisboa = pessoas.filter(function (cidade) {
  return cidade.localidade === "Lisboa";
});
console.log(lisboa);

let lisboa1 = pessoas.filter((pessoas) => pessoas.localidade === "Lisboa");
console.log(lisboa1);

let resultado2 = pessoas.map(({ nome, localidade }) => ({
  nome: nome.toUpperCase(),
  localidade: localidade.toUpperCase(),
}));
console.log(resultado2);

let pessoasMaiusculas2 = pessoas.map((pessoa) => ({
  ...pessoa,
  nome: pessoa.nome.toUpperCase(),
}));
console.log(pessoasMaiusculas2);
