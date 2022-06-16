// dada uma variável do tipo string, verificar se um determinado caractere existe nessa string, e em que posição
// existe na posição x
// não existe
let nome='Pedro Remoaldo';
let caractere='e';

let existe=false; // flag
let pos;
for(pos=0; pos<nome.length; pos++) {
    if (nome.charAt(pos)===caractere) {
        existe=true;
        break;
    }
}
// if (pos>=nome.length) {
//     console.log("Não existe!");
// } else {
//     alert(`Existe na posição ${pos+1}`);
// }
// if (existe===true) {
if (existe) {
    alert(`Existe na posição ${pos+1}`);
} else {
    alert('Não existe!');
}

// indexOf - devolve a posição da primeira ocorrência, senão, devolve -1, caso não encontre
// lastIndexOf
// includes - devolve true/false
// search - funciona como o indexOf, mas permite expressões regulares (regex)
