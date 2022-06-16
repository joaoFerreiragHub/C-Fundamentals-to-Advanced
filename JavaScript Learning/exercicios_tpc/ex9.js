let frase = "Exemplo de uma frase com palavras";

// function longest(str) {
//   frase = frase.split(" ");
//   return frase.sort((a, b) => b.length - a.length)[0];
// }
// console.log(longest(frase).length);

function data(str) {
  var show = str.split(" ");
  show.sort(function (a, b) {
    return b.length - a.length;
  });
  return show[0];
}
let var1 = data(frase);
let var2 = data(frase).length + " Letras";
// console.log(data(frase));
// console.log(data(frase).length + " Letras");
console.log(var1, var2);
