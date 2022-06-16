let nomes = ["Pedro", "Mário", "João", "Filipe", "Fernando"];
let tirar = "Mário";
var spliced;

function remove_elementos(tirar) {
  var i = 0;
  while (i < nomes.length) {
    if (nomes[i] === tirar) {
      nomes.splice(i, 1);
    } else {
      ++i;
    }
  }
  return nomes;
}

console.log(remove_elementos(tirar));
