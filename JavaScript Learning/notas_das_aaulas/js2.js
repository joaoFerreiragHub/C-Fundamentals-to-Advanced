// Dada uma variável do tipo string
let nome = "Pedro Remoaldo";

// Mostrar cada uma das letras numa linha diferente, mas por ordem inversa

// for(let pos=nome.length-1; pos>=0; pos--) {
//     console.log(nome.charAt(pos));
//     // console.log(emMaiusculas[pos]);
// }

let teste; // undefined
console.log(teste);
teste = 23;

console.log(nome[nome.length]); // undefined

// Inverter a string

let nomeInvertido = ""; // "" - empty string
for (let pos = nome.length - 1; pos >= 0; pos--) {
    nomeInvertido += nome.charAt(pos);
    // nomeInvertido=nomeInvertido+nome.charAt(pos);
}
console.log(nomeInvertido);
// odlaomeR ordeP

let nomeInvertido2 = "";
for (let pos = 0; pos < nome.length; pos++) {
    // nomeInvertido2=nomeInvertido2+nome.charAt(nome.length-pos-1);
    // debugger; // para debugging
    nomeInvertido2 = nome.charAt(pos) + nomeInvertido2;
    console.log(nome.charAt(pos) + " / " + nomeInvertido2);
}
console.log(nomeInvertido2);
// odlaomeR ordeP

console.log(nome.split("").reverse().join(""));

// para arredondar números para inteiros - ceil, round, floor
// parseInt(Math.random()*10+1)
let numeroAAdivinhar = Math.floor(Math.random() * 10 + 1);
console.log(numeroAAdivinhar);
let numeroTentativas = 3;
do {
    let numero = prompt("Introduza um número entre 1 e 10:");
    console.log(numero);
    // = - assignment - atribuição
    // == - comparação - de valores - "2"==2 - true
    // === - comparação - de valores e de tipos de dados - "2"===2 - false
    // console.log(typeof numero); // mostra o tipo de dados da variável 'numero' - neste caso 'string'
    if (numero !== null) {
        numero=numero.trim();
        // if (numero.length!==0) {
        if (numero !== "") {
            if (!isNaN(numero)) {
                let numero2 = Number(numero);
                if (numero2>=1 && numero2<=10) {
                    if (numeroAAdivinhar === numero2) {
                        alert("Acertou no número!");
                        break;
                    } else {
                        alert("Falhou!");
                        numeroTentativas--;
                    }
                } else {
                    alert("Tem de introduzir um número entre 1 e 10!");    
                }
            } else {
                alert("Tem de introduzir um número!");
            }
        } else {
            alert("Tem de introduzir um número!");
        }
    } else { // null
        break;
    }
} while (numeroTentativas > 0)
alert("Jogo terminado!");
