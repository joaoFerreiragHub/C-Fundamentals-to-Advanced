let excluir = /^[^`~!@#%^&*()çÇ+={}\[\]|\\:;“’<,>.?๐฿]*$/;
let excluir2 = [
  "break",
  "case",
  "catch",
  "continue",
  "debugger",
  "default",
  "delete",
  "do",
  "else",
  "finally",
  "for",
  "function",
  "if",
  "in",
  "instanceof",
  "new",
  "return",
  "switch",
  "this",
  "throw",
  "try",
  "typeof",
  "var",
  "void",
  "while",
  "with",
  "class",
  "const",
  "enum",
  "export",
  "extends",
  "import",
  "super",
  "implements",
  "interface",
  "let",
  "package",
  "private",
  "protected",
  "public",
  "static",
  "yield",
  "true",
  "false",
  "null",
  "NaN",
  "Infinity",
  "undefined",
];
let excluir3 = /^\d/;
let nomeVariavel = "Çteste";

function validaNome(nomeVariavel) {
  if (
    excluir2.includes(nomeVariavel) ||
    excluir.test(nomeVariavel) === false ||
    excluir3.test(nomeVariavel) === true
  ) {
    return false;
  } else {
    return true;
  }
}
console.log(validaNome(nomeVariavel));
console.log();
