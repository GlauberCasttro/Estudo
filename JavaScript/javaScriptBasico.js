/*----------------------------------------------------Basico do javascript -----------------------------------------------------------*/

var nome = 'Olá, mundo!!!';
/*
 * tipos de declaração de variaveis
 LET -> variavel de escopo ou só é acessivel dentro do bloco
 CONST -> tipo de declaração de constantes dentro do javascript
 VAR -> criar uma variavel no antigo javascript 
 */

/**
 * Numeros em javascript
 * 
 * tipo de numeros inteiros ou flutuantes , ou decimais utiliza-se NUMBER
 * 
 * TypeOf mostra o tipo de dados da variavel
 * InstanceOf mostra se de qual instancia e de qual objeto veio aquela variavel
 *
 * função para conversao parseInt, ParseFloat
 * 
 * eval é uma funcao nativa do javascript que concatena dados para calculo
 * 
 * funcao anonima é uma funcao sem nome
 */

/**----------------------------------------------------------------------------------------------------- */

var resultado = somar(2, '+', 4);

console.log('Funcao normal=> ', resultado);


/**----------------------------------------funcao------------------------------------------------------- */
function somar(x, op, y){
    return eval(`${x} ${op} ${y} `);//funcao para calcular até uma string 
};

/**funcao anomima */
console.log('Funcao anomina=> ', (function (x, op, y){
    return eval(`${x} ${op} ${y} `);
})(2, '+', 4));

/**-------------------------------------ArrowFunction------------------------------------------------------ */

let calc = (x, y, op) =>{
    return eval(`${x} ${op} ${y} `); 
};

console.log('ArrowFunction=>', calc(10,6,"-"));

/**--------------------------------------------------------------------------------------------------------- */

/**eventos é a ação de reagir com os atos do usuario no navegador
 * 
 * Eventos de teclado
 * eventos de tempo
 * eventos personalizados
 * 
 */


 /*Evento para toda a janela do navegador*/
 window.addEventListener('focus', event=>{
     console.log('focando...')
 });


 /**Evento de click no document do navegador */
 document.addEventListener('click', event =>{
     console.log('Clicando no documento...')
 });


 /*
 Eventos da window 
 Window.Open -> abri uma proxima janela
 window.close -> fechar uma janela
 Window.focus -> foca em uma janela
 */

 /*-------------------------------Datas no javascript------------------------------------------ */
 console.log('--------------------------------Datas-------------------------------------------');
 let data = new Date();

 console.log(data.getDate());/**dia */
 console.log(data.getFullYear());//** ano*/
 console.log(data.getMonth());/*mês  */
 console.log(data.toLocaleDateString('pt-br'));//**data pelo locale do usuario */
 
 

/** Array---------------------------------------------------------------------------------*/
console.log('----------------------------------------------------------------------');
let carros = ['palio', 'gol', 'uno', 'toro', 1999, new Date(), function(){}];

console.log('carros', carros[5].getDay());


/** percorrer todo array com uma função anomina */
console.log('----------------------------Percorrendo o Array------------------------------------------');
carros.forEach(function(valor, index){
    console.log(valor, index);
});

//**Orientação a objetos em javascript */

/*Uma classe é um arquivo que representa caracteristicas e comportamentos de um elemento real */
/**Atributos são as caracteristicas e metodos(funções do objetos) são os comportamentos */

let celular = function(){
    this.cor = 'Prata';

    this.ligar = function(){
    console.log("ligando");
    }
}

let obt = new celular();

obt.cor = 'prata';