let valor1 = ""; // false
let valor2 = "Primavera"; // false
let valor3 = "Be"; // false;
let valor4 = "Amesterdão"; // true
let valor5 = "Benin"; // true

if (
  (valor1.length >= 3 && valor1.charAt(0) == "A") ||
  (valor1.length >= 3 && valor1.charAt(0) == "B")
) {
  console.log("True");
} else {
  console.log("false");
}
