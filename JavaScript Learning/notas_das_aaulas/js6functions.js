// function declaration
function mostra() {
    console.log("Resultado da primeira função");
}
mostra();

// mostraTotal(); // Cannot access 'mostraTotal' before initialization
// function expression
let mostraTotal=function() { // função anónima
    console.log("Total=20");
}
mostraTotal();

let mostraTotal2 = () => console.log("Total=20"); // arrow function
mostraTotal2();

let mostraSoma=new Function('x','y','return x+y');
console.log(mostraSoma(5,10));
// é equivalente a:
// function mostraSoma(x,y) {
//     return x+y;
// }

// os parâmetros são sempre passados para uma função por valor e não por referência
function mostraSoma2(x,y) { // parameters / parâmetros
    // let soma=x+y;
    // return soma;
    return x+y;
}
console.log(mostraSoma2(5,10)); // arguments / argumentos

function mostraSoma3(x,y) {
    console.log("x="+x,"y="+y)
}
mostraSoma3(5,10);
// let resultado3=mostraSoma3(5,10)*10; // x=5 y=10
let resultado2=mostraSoma2(5,10)*10;
console.log(resultado2);

function quadrado(numero) { // se não passar um valor para o parâmetro, o parâmetro conterá o valor "undefined"
    return numero*numero;
}
console.log(quadrado(8));
console.log(quadrado()); // NaN

function quadrado2(numero) {
    // if (numero===undefined) {
    // if (typeof numero === "undefined") {
    // if (arguments.length===0) {
    //     return null;
    // }
    // return numero*numero;
    // numero=numero | null
    // return numero*numero | null; // 0
    return numero*numero || null;
}
console.log(quadrado2());
console.log(quadrado2(5));

// function soma4(valor1,valor2) {
function soma4() {
    if (arguments.length<2) {
        return null;
    }
    // arguments - array-like que contém todos os argumentos passados para a função
    let soma=0;
    for(let pos=0; pos<arguments.length; pos++) {
        soma+=arguments[pos];
    }
    return soma;
}
console.log(soma4());
console.log(soma4(5,6));
console.log(soma4(5,6,7,8));

function soma5(...valores) { // ... - rest parameters - array-like com todos os valores passados
    if (valores.length<2) {
        return null;
    }
    let soma=0;
    for(let pos=0; pos<valores.length; pos++) {
        soma+=valores[pos];
    }
    return soma;
}
console.log(soma5());
console.log(soma5(5,6));
console.log(soma5(5,6,7,8));

// --------------------------------
// Scope
// --------------------------------

// global scope
let var1="Pedro";
console.log(var1); // Pedro
function testeScopeGlobal() {
    console.log(var1); // Pedro
}
testeScopeGlobal();
// local scope - variáveis definidas dentro de funções
function testeScopeGlobal2() {
    let var2="Remoaldo";
    console.log(var2); // Remoaldo
}
// console.log(var2); // var2 is not defined

function testeScopeGlobal3() {
    var3="Ermesinde"; // definição de uma variável global
    console.log(var3); // Ermesinde
}
testeScopeGlobal3();
console.log(var3);  // Ermesinde

let var4=23;
function testeScopeGlobal4() { // shadowing de variáveis
    let var4=35;
    console.log(var4); // 35
}
testeScopeGlobal4();
console.log(var4); // 23

// block scope
let teste10=5;
if (teste10>10) {
    let resultado10=true;
} else {
    let resultado10=false;
}
// console.log(resultado10); // resultado10 is not defined

let teste11=5;
let resultado11;
if (teste11>10) {
    resultado11=true;
} else {
    resultado11=false;
}
console.log(resultado11);

for(let contador=0;contador<10;contador++) {
    console.log(contador);
}
console.log(contador); // contador is not defined

// as variáveis definidas com var, não são block scope