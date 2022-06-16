// Regex

//[A-Z]* procura de A a Z maiuculos entre 1 e N vezes
//[A-Za-z]* procura de A a Z maiores e minusculas
// * 0 ou mais, + 1 ou mais
// ^ Inicio da string
// $ fim da string

let nome = "Joao Ferreira";
let rege = /^[A-Za-z]*$/;

if (!rege.test(nome)) {
  console.log("Está incorreto!");
} else {
  console.log("Está correcto!");
}

// Validar CP
// 4 algarismos - 3 algarismos
//[0-9] é identico a \d
let cp = "4705-176";
let cp2 = "0000-000";
let re2 = /^[1-9][0-9]{3}-\d{3}$/;
// let re2 = /^\d{4}-\d{3}$/;
// let re2 = /^[0-9]{4}-[0-9]{3}$/;
if (!re2.test(cp)) {
  console.log("Está incorreto!");
} else {
  console.log("Está correcto!");
}

//AA-99-99
//99-99-AA
//99-AA-99
//AA-99-AA

let matricula = "AA-IO-89";
let re3 =
  /^([A-Z]{2}-[0-9]{2}-[0-9]{2})|([0-9]{2}-[0-9]{2}-[A-Z]{2})|([0-9]{2}-[A-Z]{2}-[0-9]{2})|([A-Z]{2}-[0-9]{2}-[A-Z]{2})$/;

if (!re3.test(matricula)) {
  console.log("Está incorreto!");
} else {
  console.log("Está correcto!");
}

//Numeros de telefone(Portugal)

let telemovel = "919191919";
let re4 = /^[1-9][0-9]{8}]$/;
