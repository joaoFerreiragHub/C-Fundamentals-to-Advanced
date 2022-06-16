const cicon = document.querySelector(".icon");
const voltar = document.getElementById("backTop");
const body = document.querySelector("body");
const myForm = document.getElementById("myForm");
const telasp = document.querySelector("#tela span");
const tela = document.querySelector("#tela");
const email = document.getElementById("email");
const password = document.getElementById("psword");
const passError = document.querySelector("#emailPswError");
const emailError = document.querySelector("#emailError");
const form = document.getElementById("form");
const logout = document.querySelector("#logout");
const autentica = document.getElementById("autentica");
const autenticar = document.querySelector("#autenticar");
const bemVindo = document.querySelector("#bemVindo");
const erEmail = document.getElementById("emailError");
const erPass = document.getElementById("emailPswError");

// ----- BURGER BUTTON --------------------------------
function btnBurger() {
  var burger = document.getElementById("myTopnav");
  if (burger.className === "topnav") {
    burger.className += " responsive";
  } else {
    burger.className = "topnav";
  }
}

cicon.addEventListener("click", () => {
  document.querySelector("#header").classList.toggle("displayButton");
  document.querySelector(".fonts").classList.toggle("marginButton");
  cicon.style.setProperty("top", "-40px");
});

//--- SETA VOLTAR PARA CIMA -----------------------------
window.onscroll = function () {
  scrollFunction();
};

function scrollFunction() {
  if (document.body.scrollTop > 10 || document.documentElement.scrollTop > 10) {
    voltar.style.display = "block";
  } else {
    voltar.style.display = "none";
  }
}
function topFunction() {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
}

//--------------------------Fechar Cookies --------------------------

document.querySelector(".btnAceitar").addEventListener("click", () => {
  body.style.overflow = "scroll";
  document.querySelector(".ShadowCookie").removeAttribute("class");
  var elem = document.getElementById("policy");
  elem.parentNode.removeChild(elem);
});

// Abrir e fechar login  --------------------------

function openForm() {
  body.style.overflow = "hidden";
  myForm.style.display = "block";
  telasp.style.visibility = "visible";
}

telasp.addEventListener("click", function () {
  myForm.style.display = "none";
  tela.style.visibility = "hidden";
});

form.addEventListener("submit", function (e) {
  if (!validate()) e.preventDefault();
});

function validate() {
  valid = true;
  var regx = /^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$/;
  if (email.value == "" || password.value == "") {
    erPass.innerHTML = "Os dois campos são de preenchimento obrigatório";
    valid = false;
  }
  if (!email.value.match(regx)) {
    erEmail.innerHTML = "O e-mail tem um formato incorreto!";
    valid = false;
  }
  return valid;
}

function limparemail() {
  email.value = "";
  emailError.textContent = null;
}

function limparpass() {
  password.value = "";
  passError.textContent = null;
}

//  Limpar dados da caixa login caso feche o form
const btn = document.getElementById("icon");

btn.addEventListener("click", function handleClick(event) {
  event.preventDefault();

  const inputs = document.querySelectorAll("#email, #psword");

  inputs.forEach((input) => {
    input.value = "";
  });
});

// Zona de testing --------------------------

function validUsers() {
  form.addEventListener("submit", function (e) {
    if (!validUsers()) e.preventDefault();
  });

  fetch(`http://localhost:3000/Utilizadores`)
    .then((response) => {
      if (response.ok) {
        return response.json();
      } else {
        throw Error(response.status);
      }
    })
    .then((utilizadores) => {
      const emailExiste = utilizadores.filter((item) => {
        return item.email === email.value;
      });
      valid = true;
      if (emailExiste.length > 0) {
        const login = utilizadores.filter((item) => {
          return item.email === email.value && item.senha === password.value;
        });
        if (login.length > 0) {
          autentica.innerHTML = "Email Correto";
          valid = true;
          myForm.style.display = "none";
          tela.style.visibility = "hidden";
          autenticar.style.display = "none";
          logout.style.display = "inline";
          body.style.overflow = "scroll";
          bemVindo.innerHTML = `Bem-vindo(a), ${login[0].nome}`;

          const foundUser = Object.values(utilizadores).find(
            (user) => user.email === email.value
          );
          let userId = foundUser.id;

          sessionStorage.setItem("ID", userId);
          return valid;
        } else {
          autentica.innerHTML = "Password esta incorreta!";
          valid = false;
          return valid;
        }
      } else {
        autentica.innerHTML = "Utilizador Inexistente";
        valid = false;
        return valid;
      }
    })
    .catch((erro) => {
      if (erro.message === "404") {
        window.location.href = "interpretes404.html";
      } else {
        alert("Ocorreu um erro. Por favor volte a tentar mais tarde.");
        console.log(erro);
      }
    });
}

function logoutf() {
  logout.addEventListener("click", function () {
    window.sessionStorage.removeItem("ID");
    autenticar.style.display = "inline";
    logout.style.display = "none";
    bemVindo.textContent = null;
  });
}

telasp.addEventListener("click", () => {
  body.style.overflow = "scroll";
});
