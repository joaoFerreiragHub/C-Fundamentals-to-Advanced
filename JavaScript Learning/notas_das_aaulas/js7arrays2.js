let paises=[
    ["Portugal","Lisboa"],
    ["Espanha","Madrid"],
    ["Mali","Bamako"],
];
console.log(paises);
// console.log(paises[1,2]); // ['Mali', 'Bamako']
console.log(paises[1][1]); // Madrid
paises.push(["Alemanha","Berlim"]);
console.log(paises);
// Acrescentar um elemento a cada país que contém as línguas oficiais desse país. Por exemplo, para Portugal, acrescentar "Português" e "Mirandês"
paises[0].push(["Português","Mirandês"]);
paises[1].push(["Espanhol","Galego","Catalão","Basco"]);
paises[2].push(["Francês"]);
paises[2].push(["Alemão"]);
console.log(paises);
console.log(paises[0][2][1]); // Mirandês

// objectos literais - literal objects
// pares de chaves/valor (key/value pairs)
let pessoa={
    nome: "Dafne Palú",
    cidade: "Cuiabá",
    pais: "Brasil"
}
// dot notation
console.log(pessoa.cidade); // Cuiabá
console.log(pessoa["cidade"]); // Cuiabá
let propriedade="nome";
console.log(pessoa.propriedade); // undefined
console.log(pessoa[propriedade]); // Dafne Palú

// array de objectos - object's array
let paises2=[
    { 
        pais: "Portugal",
        capital: "Lisboa",
        linguas_oficiais: ["Português","Mirandês"]
    },
    { 
        pais: "Espanha",
        capital: "Madrid",
        linguas_oficiais: ["Espanhol","Galego","Catalão","Basco"]
    },
    { 
        pais: "Mali",
        capital: "Bamako",
        linguas_oficiais: ["Francês"]
    },
    { 
        pais: "Alemanha",
        capital: "Berlim",
        linguas_oficiais: ["Alemão"]
    }
]
console.log(paises2);
// língua oficial do Mali
console.log(paises2[2].linguas_oficiais); // ['Francês']
console.log(paises2[2].linguas_oficiais[0]); // Francês

for(let pos = 0; pos< paises2.length; pos ++){
    console.log(`${paises2[pos].pais} tem ${paises2[pos].linguas_oficiais.length} línguas oficiais.`);
}
let lista=[];
for (let pais of paises2) {
    console.log(`${pais.pais} tem ${pais.linguas_oficiais.length} línguas oficiais.`);
    lista.push([pais.pais,pais.linguas_oficiais.length]);
}
console.log(lista);
