let nome = "Pedro Remoaldo";
// ^ - início da string
// $ - fim da string
// - - intervalo
// * - repetir 0 ou n vezes o "caractere" anterior
// [] - lista de caracteres autorizados
let re = /^[A-Za-z ]*$/;
if (!re.test(nome)) {
  console.log("Está incorrecto!");
} else {
  console.log("Está correcto!");
}

// validar CP
// 4 algarismos - 3 algarismos
// [0-9] é idêntico a \d
// let cp="4100-100";
// let cp="0000-000";
let cp = "1000-000";
// let re2=/^[0-9]{4}-\d{3}$/;
// let re2=/^\d{4}-\d{3}$/;
// let re2=/^[0-9]{4}-[0-9]{3}$/;
let re2 = /^[1-9][0-9]{3}-[0-9]{3}$/;
// let re2=/^[1-9][0-9][0-9][0-9]-[0-9]{3}$/;
if (!re2.test(cp)) {
  console.log("Está incorrecto!");
} else {
  console.log("Está correcto!");
}

// AA-99-99
// 99-99-AA
// 99-AA-99
// AA-99-AA

// () - agrupar
// | - ou (or)

// let matricula="AA-IO-89";
let matricula = "AA-89-IO";
let re3 =
  /^([A-Z]{2}-[0-9]{2}-[0-9]{2})|([0-9]{2}-[0-9]{2}-[A-Z]{2})|([0-9]{2}-[A-Z]{2}-[0-9]{2})|([A-Z]{2}-[0-9]{2}-[A-Z]{2})$/;

// \s - whitespace
// [0-9]{2}[\s-]{0,1}[0-9]{2}[\s-]{0,1}[A-IK-PR-VZ]{2}|[0-9]{2}[\s-]{0,1}[A-IK-PR-VZ]{2}[\s-]{0,1}[0-9]{2}|[A-IK-PR-WYZ]{2}[\s-]{0,1}[0-9]{2}[\s-]{0,1}[A-IK-PR-WYZ]{2}

// (([A-Z]{2}-\d{2}-(\d{2}|[A-Z]{2}))|(\d{2}-(\d{2}-[A-Z]{2}|[A-Z]{2}-\d{2})))

if (!re3.test(matricula)) {
  console.log("Matrícula com o formato incorrecto!");
} else {
  console.log("Matrícula com o formato correcto!");
}

// Utilizando o formato AA-99-99 validar uma matrícula sem recorrer às expressões regulares

// Números de telefone (Portugal)
let re4 = /^[1-9][0-9]{8}$/;
