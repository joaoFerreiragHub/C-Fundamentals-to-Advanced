let arr_nums = [];
let arr_estrelas = [];

do {
  let numeros = Math.floor(Math.random() * 50) + 1;
  if (!arr_nums.includes(numeros)) {
    arr_nums.push(numeros);
  }
} while (arr_nums.length < 5);

do {
  let estrelas = Math.floor(Math.random() * 12) + 1;
  if (!arr_estrelas.includes(estrelas)) {
    arr_estrelas.push(estrelas);
  }
} while (arr_estrelas.length < 2);

let chaveFinal = arr_nums.concat(arr_estrelas).sort();
console.log(chaveFinal);
