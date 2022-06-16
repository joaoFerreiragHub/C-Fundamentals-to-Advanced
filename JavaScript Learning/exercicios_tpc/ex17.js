let frase = "O filho foi visitar o pai.";
let encontrar = "o";
let count;

function palavraAEncontrar(frase, encontrar) {
  let count = 0;

  // looping through the items
  for (let i = 0; i < frase.length; i++) {
    // check if the character is at that position
    let frase_lower = frase.toLowerCase();
    if (frase_lower.charAt(i) == encontrar) {
      count += 1;
    }
  }
  return count;
}
console.log(palavraAEncontrar(frase, encontrar));
