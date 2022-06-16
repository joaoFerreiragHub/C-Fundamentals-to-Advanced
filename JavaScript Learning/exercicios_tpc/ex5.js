let frase = " Frase com espaços no início e no fim ";
let regex = /^\s+|\s+$/g;
//Metodo 1
console.log(frase.replace(regex, "")); //regex

//Metodo 2
console.log(frase.substring(1, frase.length - 1));

//Metodo 3
console.log(frase.slice(1, -1));

//Nao funciona
console.log(frase.trimStart());
console.log(frase.trimEnd());
