let repeticoes = 4;
let texto = "Primavera";
const arr = [];

//Metodo 1
for (let i = 1; i <= 3; i++) {
  arr.push(texto);
}
arr.join("");
console.log(arr);

//Metodo 2
console.log(Array(repeticoes).join(texto));

//metodo 3

function repeatStr(texto, repeticoes) {
  var repetir = "";

  while (repeticoes > 0) {
    repetir += texto;
    repeticoes--;
  }

  return repetir;
}

console.log(repeatStr(texto, repeticoes));
