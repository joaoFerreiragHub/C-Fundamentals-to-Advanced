function validaExtensao(nomeFicheiro) {
  let extensoesValidas = ["xls", "doc", "bmp", "jpg"];
  let extensao = nomeFicheiro;
  let filtra = extensao.slice(-3);

  if (extensoesValidas.includes(filtra)) {
    return true;
  } else {
    return false;
  }
}

let ficheiro = "dados.xls";
console.log(validaExtensao(ficheiro));
