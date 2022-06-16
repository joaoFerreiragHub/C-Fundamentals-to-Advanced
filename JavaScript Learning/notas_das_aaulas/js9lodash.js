const version = _.VERSION;
console.log(version);

// trabalhar com collections
let pessoas=[
	{ nome: "Pedro Remoaldo", localidade: "Ermesinde" },
	{ nome: "Luísa Xavier", localidade: "Lisboa"},
	{ nome: "Mário Simões", localidade: "Lisboa"},
	{ nome: "Joana Castro", localidade: "Santa Maria da Feira"},
	{ nome: "Guilherme Silveira", localidade: "Lisboa"},
	{ nome: "Pedro Oliveira", localidade: "Porto"}
]

// let resultado=_.filter(pessoas, function(pessoa) { return pessoa.localidade==="Ermesinde"; });
// let resultado=_.filter(pessoas, pessoa => pessoa.localidade==="Ermesinde");
let resultado=_.filter(pessoas, { localidade: "Ermesinde" });
console.log(resultado);

// let resultado2=_.map(pessoas, function(pessoa) { return { nome: pessoa.nome.toUpperCase(), localidade: pessoa.localidade } });
let resultado2=_.map(pessoas, pessoa => ({ nome: pessoa.nome.toUpperCase(), localidade: pessoa.localidade }));
console.log(resultado2);

let resultado3=_.orderBy(pessoas,['nome'],'desc')
console.log(resultado3);

