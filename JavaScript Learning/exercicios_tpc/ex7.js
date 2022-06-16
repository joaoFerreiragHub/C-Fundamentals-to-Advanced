let ficheiro = true;
let extrair;
let check;

if (ficheiro.length !== 0) {
  if (typeof ficheiro === "string" || ficheiro instanceof String) {
    check = ficheiro.includes(".");
    if (check === true) {
      extrair = ficheiro.substring(ficheiro.length - 3);
    } else {
      console.log("Nao tem extensão");
    }
  } else {
    console.log("Não é uma string");
  }
} else {
  console.log("Ficheiro esta vazio");
}
console.log(extrair);
