let ano = 1999;

if (ano % 4 == 0 && ano % 100 != 0) {
  console.log("é ano bisexto");
} else if (ano % 4 == 0 && ano % 100 == 0 && ano % 400 == 0) {
  console.log("é ano bisexto2 ");
} else {
  console.log("Não é bisexto");
}

let ano2 = 2004;

if ((ano2 % 4 == 0 && ano2 % 100 != 0) || ano2 % 400 == 0) {
  console.log("é ano bisexto");
} else {
  console.log("Não é bisexto");
}
