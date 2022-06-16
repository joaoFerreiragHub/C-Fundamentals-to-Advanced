let frase = "isto é uma frase para o exxercicio";
let arr = [];

function converteParaArr(frase, arr) {
  arr = frase.split(" ");

  return arr.length;
}

console.log(converteParaArr(frase));

// function converteParaArr(frase, arr) {
//   arr = frase.split(" ");

//   return arr;
// }
// console.log(converteParaArr(frase));
