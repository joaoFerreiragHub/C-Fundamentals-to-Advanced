// let num = 1;
// let factorial = 1;

// if (num <= -1 || num == 0 || num == 1) {
//   console.log("é negativo, 0 ou 1");
// }
// for (let pos = num; pos >= 1; pos--) {
//   factorial = factorial * pos;
// }

// console.log(factorial);

function factorial(n) {
  //base case
  if (n == 0 || n == 1) {
    return 1;
    //recursive case
  } else {
    return n * factorial(n - 1);
  }
}
let n = 4;
answer = factorial(n);
console.log("The factorial of " + n + " is " + answer);
