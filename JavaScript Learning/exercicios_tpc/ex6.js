let email = prompt("Introduza o seu email");

console.log(email);
if (email.length !== 0) {
  let check = email.includes("@");
  if (check === true) {
    let beforeAt = email.split("@");
    console.log(beforeAt);
  } else {
    console.log("False");
  }
} else {
  alert("É necessário fornecer um email");
}
