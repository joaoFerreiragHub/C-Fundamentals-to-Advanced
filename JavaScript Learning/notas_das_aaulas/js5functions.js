//function declaration
function mostra() {
  console.log("Resultado da primeira função");
}

mostra();

//Function expression

let mostraTotal = function () {
  //função anonima
  console.log("Total=20");
};

mostraTotal();
let mostraTotal2 = () => console.log("Total=20"); //arrow function
mostraTotal2();
let mostraSoma = new Function("x", "y", "return x+y");
console.log(mostraSoma(5, 10));

// é equivalente
// function mostraSoma(x,y){
//   return x+y;
// }

// os parametros sao sempre passados para uma função por valor e não por referencia
function mostraSoma2(x, y) {
  //parameters / parâmetros
  return x + y;
}
console.log(mostraSoma2(5, 10)); //arguments

function mostraSoma3(x, y) {
  console.log("x=" + x, "y=" + y);
}
mostraSoma3(5, 10);
let resultado2 = mostraSoma2(5, 10) * 10;
console.log(resultado2);

function quadrado(numero) {
  // Se não passar um valor para o parametro, o parametro contera o valor" undefined";
  if (numero === undefined) {
    return null;
  }
  return numero * numero;
}
console.log(quadrado(8));
console.log(quadrado()); //NaN

function quadrado2(numero) {
  // Se não passar um valor para o parametro, o parametro contera o valor" undefined";
  // if (numero === undefined)
  // if (typeof numero === "undefined")
  // if (arguments.length === 0) {
  //   return null;
  // }
  return numero * numero || null;
}
console.log(quadrado2());
console.log(quadrado2(5));

function soma4(valor1, valor2) {
  return valor1 + valor2;
}

console.log(soma4(5, 6));

function soma4() {
  let sum = 0;
  if (arguments.length < 2) {
    return null;
  }
  for (let pos = 0; pos < arguments.length; pos++) {
    sum += arguments[pos];
  }
  return sum;
}

console.log(soma4(5, 6, 4));

// mais moderno
function soma5(...valores) {
  //...valores rest parameters
  let sum = 0;
  if (valores.length < 2) {
    return null;
  }
  for (let pos = 0; pos < valores.length; pos++) {
    sum += valores[pos];
  }
  return sum;
}

console.log(soma5(1, 2, 3));

//Scope
//Global Scope

let var1 = "Pedro";
console.log(var1);
function testeScopeGlobal() {
  console.log(var1); //Pedro
}
testeScopeGlobal();

// Local Scope variaveis definidas dentro de funções

function testeScopeGlobal2() {
  let var2 = "Remoaldo";
  console.log(var2); //Remoaldo
}
//console.log(var2); //var2 is not defined

function testeScopeGlobal3() {
  var3 = "Braga"; // Sem let passa a ser variavel global
  console.log(var3); //Braga
}
testeScopeGlobal3();
console.log(var3); //Braga

let var4 = 23;
function testeScopeGlobal4() {
  let var4 = 35;
  console.log(var4); //35
}
testeScopeGlobal4();
console.log(var4); //23

//block Scope
let teste10 = 5;
if (teste10 > 10) {
  let resultado10 = true;
} else {
  let resultado10 = false;
}

console.log(resultado10);
