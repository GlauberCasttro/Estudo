/*var nome = document.querySelector("#exampleInputName");
var sexo = document.querySelectorAll("#form-user-create [name=gender]:Checked");//como o formulario tem o radio, é necessario utilizar o parametro checked para pegar o radio selecionado
var aniversario  = document.querySelector("#exampleinputBirth");
var pais = document.querySelector("#exampleinputCountry");
var email = document.querySelector("#exampleinputEmai");
var password = document.querySelector("#exampleinputPassword");
var foto = document.querySelector("#exampleinputFile");
var admin = document.querySelector("#exempleInputAdmin");
*/

var fields = document.querySelectorAll("#form-user-create [name]");
var user = {};

//console.log(user);
//trabalhando com eventos de botao
document.querySelectorAll("button").forEach(function () {
  this.addEventListener("click", function () {
    //console.log("clicouu rrr");
    //pegando todos os dados do formulario com foreach
    fields.forEach(function (field, index) {
      if (field.name == "gender") {
        //como o genero tem 22 campos é necessario ver qual esta checado
        //console.log(field.id, "sim");
        if (field.checked) user[field.name] = field.value;
      } else {
        user[field.name] = field.value;
      }
    });
  });
});

document
  .getElementById("form-user-create")
  .addEventListener("submit", function (event) {
    event.preventDefault();//cancela o comportamennto padrao do formaulario, pois a primera vez que 
    //for chamado o mesmo esta vazio

    console.log(user);
  });
