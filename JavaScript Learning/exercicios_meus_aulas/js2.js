// Dada uma variável do tipo string, mostrar cada uma das letras numa linha diferente, mas por ordem inversa.

let nome = "Francisca Loureiro";
for (let pos = nome.length - 1; pos >= 0; pos--) {
  console.log(nome.charAt(pos));
}

// Inverter a string (muito ineficiente).
let nomeInvertido = nome.split("").reverse().join("");
console.log(nomeInvertido);

// Inverter a string (outra alternativa).
let nomeInvertido2 = "";
for (let pos = nome.length - 1; pos >= 0; pos--) {
  nomeInvertido2 += nome.charAt(pos);
}
console.log(nomeInvertido2);

// Inverter a string (outra alternativa).
let nomeInvertido3 = "";
for (let pos = 0; pos < nome.length; pos++) {
  nomeInvertido3 = nome.charAt(pos) + nomeInvertido3;
}
console.log(nomeInvertido3);

//console.log(typeof nomevariaável) // mostra o tipo de dados da variável
// Jogo do adivinha o número. 3 tentativas para acertar no número.
//Math.random() // devolve números entre 0 e 9
//Math.random() * 10+1 //devolve números entre 1 e 10
//ceil, floor e round: 3 formas de arredondar números

let numeroAdivinhar = Math.floor(Math.random() * 10 + 1);
console.log(numeroAdivinhar);
let numeroTentativas = 3;
do {
  let numero = prompt("Introduza um número entre 1 e 10.");
  //console.log(numero)
  if (numero !== null) {
    numero = numero.trim(); //trim tira os espaços do início e do fim
    if (numero !== "" && !isNaN(numero)) {
      let numero2 = Number(numero); //converter string para número
      if (numero2 >= 1 && numero2 <= 10) {
        if (numeroAdivinhar === numero2) {
          alert("Acertou no número");
          break;
        } else {
          alert("Falhou!");
          numeroTentativas--;
        }
      } else {
        alert("Introduza entre 1 e 10!");
      }
    } else {
      alert("Tem de introduzir um número!");
    }
  } else {
    break;
  }
} while (numeroTentativas > 0);
{
  alert("Jogo terminado!");
}
