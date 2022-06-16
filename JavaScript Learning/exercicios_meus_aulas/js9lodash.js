const version = _.VERSION;
console.log(version);

let pessoas = [
  { nome: "Pedro Remoaldo", localidade: "Ermesinde" },
  { nome: "Luísa Xavier", localidade: "Lisboa" },
  { nome: "Mário Simões", localidade: "Lisboa" },
  { nome: "Joana Castro", localidade: "Santa Maria da Feira" },
  { nome: "Guilherme Silveira", localidade: "Lisboa" },
  { nome: "Pedro Oliveira", localidade: "Porto" },
];

let resultado = _.filter(
  pessoas,
  (pessoa) => pessoa.localidade === "Ermesinde"
);

console.log(resultado);
