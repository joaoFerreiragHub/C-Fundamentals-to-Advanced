let paises = [
  ["Portugal", "Lisboa"],
  ["Espanha", "Madrid"],
  ["Mali", "Bamako"],
];

console.log(paises);
console.log(paises[(1, 1)]); //"Espanha", "Madrid"
console.log(paises[1][1]); //Madrid
paises.push(["Alemanha", "Berlim"]);
console.log(paises);

paises[0].push(["Português", "Mirandês"]);
paises[1].push(["Espanhol", "Galego", "Catalão", "Basco"]);
paises[2].push(["Francês"]);
paises[3].push(["Alemão"]);
console.log(paises);

console.log(paises[0][2][1]);

//objetos literais
// pares de chave/valor (key/value pairs)
let pessoa = {
  nome: "Dafne Palu",
  cidade: "Cuiabá",
  pais: "Brasil",
};

// dot notation
console.log(pessoa.cidade);
console.log(pessoa["cidade"]);

//array de objetos
let paises2 = [
  {
    pais: "Portugal",
    capital: "Lisboa",
    linguas: ["Português", "Mirandês"],
  },
  {
    pais: "Espanha",
    capital: "Madrid",
    linguas: ["Espanhol", "Galego", "Catalão", "Basco"],
  },
];

console.log(paises2[0].linguas[1]);
// console.log(paises2[2].linguas[0]);
