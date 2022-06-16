let temperaturas = [12, 34, 45, 3, 8, 23, 56];

let max = Math.max(...temperaturas);
let min = Math.min(...temperaturas);
let avg = 0;

for (let pos = 0; pos < temperaturas.length; pos++) {
  avg += temperaturas[pos];
}
let avgfinal = avg / temperaturas.length;

console.log(max);
console.log(min);
console.log(avgfinal);
