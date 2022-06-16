let string = prompt("Introduza uma string");
let stringArray = Array.from(string);
let convert = "";

stringArray.forEach((element) => {
  let hashCode = element.codePointAt(0);

  if (hashCode >= 65 && hashCode <= 90) {
    convert = convert + element;
  } else if (hashCode >= 97 && hashCode <= 122) {
    hashCode = hashCode - 32;
    element = String.fromCharCode(hashCode);
    convert = convert + element;
  } else {
    convert = convert + element;
  }
});

alert(`Resultado final:${convert}`);
