// programação funcional
let numeros=[10, 9, 8, 2, 7, 5, 1, 3, 0];
// utilizando uma arrow function
// let resultado=numeros.filter(numero => numero<3);
// utilizando uma função anónima tradicional
// let resultado=numeros.filter(function(numero) {
//     if (numero<3) {
//         return true;
//     } else {
//         return false;
//     }
// });
let resultado=numeros.filter(function(numero) {
    return numero<3;
});
// function menorque(numero) {
//     return numero<this;
// }
// let resultado=numeros.filter(menorque, 3);
// let resultado=numeros.filter(menorque, 8);
console.log(resultado); // [2, 1, 0]

// programação imperativa/procedimental tradicional
let resultado1=[];
function menorque3() {
    // for (let pos=0; pos<numeros.length; pos++) {}
    for (let elemento of numeros) {
        if (elemento<3) {
            resultado1.push(elemento);
            console.log(elemento);
        }
    }
}
menorque3();
console.log(resultado1);

let pessoas=[
	{ nome: "Pedro Remoaldo", localidade: "Ermesinde" },
	{ nome: "Luísa Xavier", localidade: "Lisboa"},
	{ nome: "Mário Simões", localidade: "Lisboa"},
	{ nome: "Joana Castro", localidade: "Santa Maria da Feira"},
	{ nome: "Guilherme Silveira", localidade: "Lisboa"},
	{ nome: "Pedro Oliveira", localidade: "Porto"}
]

// mostrar apenas as pessoas de Lisboa
let resultado3=pessoas.filter(pessoa => pessoa.localidade==="Lisboa");
console.log(resultado3);

// mostrar apenas as pessoas cujo nome começa por P
// let resultado4=pessoas.filter(pessoa => pessoa.nome.startsWith("P"))
// let resultado4=pessoas.filter(pessoa => pessoa.nome.toUpperCase().startsWith("P"));
// let caracter="J";
// let resultado4=pessoas.filter(pessoa => pessoa.nome.toUpperCase().startsWith(caracter.toUpperCase()));
// let resultado4=pessoas.filter(pessoa => pessoa.nome.charAt(0).toUpperCase()==="P");
let resultado4=pessoas.filter(pessoa => pessoa.nome[0].toUpperCase()==="P");
console.log(resultado4);

// mostrar apenas as pessoas cujo nome começa por P e que moram no Porto
let resultado5=pessoas.filter(pessoa => pessoa.nome[0].toUpperCase()==="P" && pessoa.localidade==="Porto");
console.log(resultado5);

let resultado6=pessoas.map(
	pessoa => pessoa.nome.toUpperCase()
);
console.log(resultado6); // ['PEDRO REMOALDO', 'LUÍSA XAVIER', 'MÁRIO SIMÕES', 'JOANA CASTRO', 'GUILHERME SILVEIRA', 'PEDRO OLIVEIRA']

// { nome: "Pedro Remoaldo", localidade: "Ermesinde" },
let resultado7=pessoas.map(
	// pessoa => {
    //     return { ...pessoa, nome: pessoa.nome.toUpperCase()}
    // }
	// pessoa => ({ ...pessoa, nome: pessoa.nome.toUpperCase()})
	pessoa => ({ nome: pessoa.nome.toUpperCase(), localidade: pessoa.localidade })
);
console.log(resultado7); 

// calcular a temperatura mínima, máxima e a média das temperaturas.

let temperaturas = [12, 34, 45, 3, 8, 23, 56, 24];

// Método 1 - Utilizando JavaScript tradicional

// let soma=0;
// let minima=+Infinity; // Math.min()
// let maxima=-Infinity; // Math.max()
// for (let temperatura of temperaturas) {
//     if (temperatura<minima) minima=temperatura;
//     if (temperatura>maxima) maxima=temperatura;
//     soma+=temperatura;
// }
// console.log(`Temperatura mínima: ${minima}`);
// console.log(`Temperatura máxima: ${maxima}`);
// console.log(`Temperatura média: ${soma/temperaturas.length}`);

// Método 2 - Utilizando JavaScript mais recente e avançado

// let soma=0;
// // let minima=Math.min(12, 34, 45, 3, 8, 23, 56, 24); // 3
// // let minima=Math.min([12, 34, 45, 3, 8, 23, 56, 24]); /NaN
// let minima=Math.min(...temperaturas); // spread operator
// console.log(`Temperatura mínima: ${minima}`);
// let maxima=Math.max(...temperaturas); // spread operator
// console.log(`Temperatura maxima: ${maxima}`);
// temperaturas.forEach(temperatura => soma+=temperatura);
// console.log(`Temperatura média: ${soma/temperaturas.length}`);

// Método 3 - programação funcional

let calculaMinima = ( minima, temperatura ) => {
	if (minima<temperatura) {
		return minima;
	} else {
		return temperatura;
	}
}
let minima=temperaturas.reduce(calculaMinima);
console.log(`Temperatura minima: ${minima}`);
let calculaMaxima = ( maxima, temperatura ) => {
	if (maxima>temperatura) {
		return maxima;
	} else {
		return temperatura;
	}
}
let maxima=temperaturas.reduce(calculaMaxima);
console.log(`Temperatura maxima: ${maxima}`);
let soma = temperaturas.reduce((acumulador, temperatura) => acumulador + temperatura);
console.log(`Temperatura média: ${soma/temperaturas.length}`);
