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
var user ={};

//pegando todos os dados do formulario com foreach
fields.forEach(function (field, index) {
  if (field.name == "gender" && field.checked == true) {
    //como o genero tem 22 campos é necessario ver qual esta checado
    //console.log(field.id, "sim");

    user[field.name] = field.value;


  }else{

    user[field.name] = field.value;
  }
 
});

console.log(user)
