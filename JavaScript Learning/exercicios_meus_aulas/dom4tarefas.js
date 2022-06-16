let elTarefa=document.querySelector("#tarefa");
// quando o utilizador clica no botão btRegistar
// document.getElementById("btRegistar").addEventListener
document.querySelector("#btRegistar").addEventListener("click", function() {
    // ler o valor submetido pelo utilizador
    let valor=elTarefa.value;

    // document.querySelector("#listaTarefas").textContent.toUpperCase().includes(valor.toUpperCase());

    let existe=false;
    let lista=document.querySelectorAll("#listaTarefas p");
    for(let item of lista) {
        if (item.textContent.toUpperCase()===valor.toUpperCase()) {
            existe=true;
            break;
        }
    }
    if (!existe) {
        // acrescentar a tarefa submetida à lista de tarefas
        // document.querySelector("#listaTarefas").innerHTML+=`<li>${valor}</li>`;
        // document.querySelector("#listaTarefas").innerHTML=document.querySelector("#listaTarefas").innerHTML+`<li>${valor}</li>`;

        // temos de criar o seguinte elemento
        // <li><span>Limpar</span> <button type="button">X</button></li>

        let item=document.createElement("li");
        let span=document.createElement("span");
        span.append(valor);
        span.addEventListener("click",function() {
            // console.log(item.textContent);
            if (this.classList.contains("terminada")) {
                this.classList.remove("terminada");
            } else {
                this.classList.add("terminada");
            }
            // this.classList.toggle("terminada");
        });
        item.append(span);
        item.append(" "); // <li><span>${valor}</span> </li>

        let botao=document.createElement("button");
        botao.setAttribute("type","button");
        botao.append("X");
        botao.addEventListener("click",function() {
            this.parentElement.remove();
        });
        item.append(botao);


        document.querySelector("#listaTarefas").append(item);
        elTarefa.value="";

        // focus - evento que é disparado quando o utilizador coloca o cursor dentro do campo
        // blur - evento que é disparado quando o utilizador sai do campo (com o teclado ou com o rato)
        elTarefa.focus();
    } else {
        alert("Tarefa já existente na lista.");
        elTarefa.select(); // selecciona o conteúdo do campo "tarefa"
    }
});
// elTarefa.focus(); // para colocar o cursor dentro do campo quando a página é carregada

elTarefa.addEventListener("keydown",function(evento) { // e, evt, event
    if (evento.code==="Enter") {
        evento.preventDefault(); // evita o comportamento por omissão do Enter, que é submeter o formulário (no caso de só existir um único campo no formulário)
        document.querySelector("#btRegistar").click();
    }
});
