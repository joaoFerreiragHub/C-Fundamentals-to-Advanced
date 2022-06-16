alert("hello world! How are you?");

//declarar a variavel e a inicializar
var nome = "Joao Ferreira";

//mudar o valor a variavel
nome = "Bill Gates";
nome = 4567;
nome = true;
console.log(nome);

let total = 3;
console.log(total);

total = 12.56;
total = 12e3;
let resultado = total * 100;
console.log(resultado);

// const cidade = "Braga";

//operadores numéricos
//+,-,*,/,%, ** (exponunenciação - 2**3=8)

let valor1 = "Joao";
let valor2 = "Ferreira";

let resultado2 = valor1 + " " + valor2;

// 12^+ 5 +"3"= 173;
//"12"+5+3=1253;
console.log(resultado2);

let resultado3 = `${valor1} ${valor2}`;
console.log(resultado3);

let tamanho3 = resultado3.length; //length - string property
console.log(tamanho3);

// regras para o nome de variaveis
// catacteres autorizados: A-Za-z0-9$_
// não pode começar por um algarismo - 1teste - erro
// minusculas difernete de maiusculas - TESTE é diferente de teste
// existem palavras reservadas
// utilizar sempre nomes de variaveis em minusculas ou em camel casing(totalProdutos) ou snake casing(total_produtos)
// nao utilizar acentos e Ç

let emMaisculas = resultado3.toUpperCase();
console.log(emMaisculas);

// for (let pos = 0; pos < emMaisculas.length; pos++) {
//   console.log(emMaisculas.charAt(pos));
//   console.log(emMaisculas[pos]);
// }
let pos = 0;
while (pos <= emMaisculas.length) {
  console.log(emMaisculas.charAt(pos));
  pos++;
}
