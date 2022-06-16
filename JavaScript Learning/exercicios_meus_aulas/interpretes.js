fetch(`http://localhost:3000/interpretes`)
  .then((response) => response.json())
  .then((dados) => {
    console.log(dados);
  });
