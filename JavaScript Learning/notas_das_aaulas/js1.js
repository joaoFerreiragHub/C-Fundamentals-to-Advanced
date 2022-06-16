// alert("Hello World! How are you?");

// declarar a variável e a inicializá-la
var nome="Pedro Remoaldo";
// mudar o valor à variável
nome="Bill Gates"; // atribuir um valor à variável - assignment
nome=4567;
nome=true;
console.log(nome);

let total=3;
console.log(total);
total=12.56;
total=12e3;
let resultado=total*100;
console.log(resultado);

const cidade="Ermesinde";
// cidade="Porto"; // Erro: Assignment to constant variable

// operadores numéricos
// +, -, *, /, %, ** (exponenciação - 2**3 = 8)

let valor1="Pedro";
let valor2="Remoaldo";
let resultado2=valor1+" "+valor2; // + - operador de concatenação de strings
console.log(resultado2);

// 12 + 5 + 3 = 20
// 12 + 5 + "3" = 173
// "12" + 5 + 3 = 1253

// interpolation - template literals
let resultado3=`${valor1} ${valor2}`;
console.log(resultado3);
let tamanho3=resultado3.length; // length - string property
console.log(tamanho3);

// regras para o nome de variáveis:
// - caracteres autorizados: A-Za-z0-9$_
// - não pode começar por um algarismo - 1teste - erro
// - minúsculas diferente de maiúsculas - TESTE é diferente de teste
// - existem palavras reservadas - reserved keywords
// - utilizar sempre nomes de variáveis em minúsculas ou em camel casing (totalProdutos) ou snake casing (total_produtos)
// - não utilizar acentos (á) e ç

let emMaiusculas=resultado3.toUpperCase(); // minúsculas - toLowerCase()
console.log(emMaiusculas);

// let valor5=emMaiusculas.split("").join("\n");
// console.log(valor5);

// console.log(emMaiusculas.charAt(0));
// console.log(emMaiusculas.charAt(1));

// for(let pos=0; pos<emMaiusculas.length; pos++) {
//     console.log(emMaiusculas.charAt(pos));
//     // console.log(emMaiusculas[pos]);
// }

for(let letra of emMaiusculas) {
    console.log(letra);
}

// mesma coisa, mas utilizando um ciclo while
// let pos=0;
// while(pos<emMaiusculas.length) {
//     console.log(emMaiusculas.charAt(pos));
//     pos++;
// }

// pos++ / pos=pos+1 / pos+=1 / ++pos