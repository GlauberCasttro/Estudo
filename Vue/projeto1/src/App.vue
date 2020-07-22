<template>
  <div>
    <div id="slogan" class="text-center">
      <h1>NameGator</h1>
      <span class="fa fa-check"></span>
      <br />
      <h6 class="text-secondary">
        Gerador de nomes utilizando GraphQL, Node e Vue.js.
      </h6>
    </div>

    <div id="main">
      <div class="container">
        <div class="row">



          <!---------------------------------Prefixos------------------------------------------>
          <div class="col-md">
            <h5>
              Prefixos
              <span class="badge badge-info">{{ prefixes.length }}</span>
            </h5>
            <div class="card">
              <div class="card-body">
                <ul class="list-group">

                  <!--Lista os dados do array de prefixes-->
                  <li class="list-group-item d-flex justify-content-between align-items-center"
                    v-for="(prefix,index) in prefixes" v-bind:key="prefix">
                    {{ prefix }}
                    <button class="btn btn-danger" title="Remova" v-on:click="removePrefix(index)">
                      <span class="fa fa-trash"></span>
                    </button>
                  </li>

                </ul>
                <br />
                <div class="input-group">
                  <!--v-model serve para passar o dado para o metodo addPrefix 
                  v-on:keyup é o evento de teclado enter
                  -->
                  <!--Criando o imput para adicionar o prefix-->
                  <input class="form-control" type="text" v-model="prefix" v-on:keyup.enter="addPrefix(prefix)"
                    placeholder="Digite o prefixo" />
                  <div class="input-group-append">
                    <button class="btn btn-info" v-on:click="addPrefix(prefix)">
                      <span class="fa fa-plus"></span>
                    </button>
                  </div>
                </div>
                <br/>
                <div class="form-group">
                  <div class="input-group-append">
                    <button type="button" class="btn btn-info btn-sm btn-block" v-on:click="RemoverTodosPrefixos()">Limpar Prefixos</button>
                  </div>
                </div>
                
              </div>
            </div>
          </div>



          <!---------------------------------Sufixos------------------------------------------>
          <div class="col-md">
            <h5>
              Sufixos <span class="badge badge-info">{{ sufixes.length }}</span>
            </h5>
            <div class="card">
              <div class="card-body">
                <ul class="list-group">

                  <!--Lista os dados do array de prefixes-->
                  <li class="list-group-item d-flex justify-content-between align-items-center"
                    v-for="(sufix, index) in sufixes" v-bind:key="sufix">
                    {{ sufix }}
                    <button class="btn btn-danger" title="Remova" v-on:click="removeSufix(index)">
                      <span class="fa fa-trash"></span>
                    </button>
                  </li>
                </ul>
                <br />



                <!--Criando o imput para adicionar o sufixo-->
                <div class="input-group">
                  <input class="form-control" type="text" v-model="sufix" v-on:keyup.enter="addSufix(sufix)"
                    placeholder="Digite o Sufixo" />
                  <div class="input-group-append">
                    <button class="btn btn-info" v-on:click="addSufix(sufix)">
                      <span class="fa fa-plus"></span>
                    </button>
                  </div>
                </div>
                <br/>
                <div class="form-group">
                  <div class="input-group-append">
                    <button type="button" class="btn btn-info btn-sm btn-block" v-on:click="RemoverTodosSufixos()">Limpar Sufixos</button>
                  </div>
                </div>
                

              </div>
            </div>
          </div>
        </div>
        <br />
        <h5 class="text-center">Domains <span class="badge badge-info">{{domains.length}}</span></h5>
        <div class="card">
          <div class="card-body">
            <ul class="list-group">
              <li class="list-group-item" v-for="domain in domains" v-bind:key="domain.name">
                <div class="row">
                  <div class="col-md">
                    {{ domain.name }} 
                  </div>
                  <div class="col-md text-right">
                    <!--v:bind serve para tratar atributos html-->
                    <a class="btn btn-info" v-bind:href="domain.checkout" target="_blank"> 
                      <span class="fa fa-shopping-cart"> Testar Registro</span>
                    </a>
                  </div>
                </div>

              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
  import "bootstrap/dist/css/bootstrap.css";
  import "font-awesome/css/font-awesome.css";

  export default {
    name: "App",
    data: function () {
      return {
        prefix: "",
        sufix: "",
        prefixes: ['a', 'b', 'c'],
        sufixes: ['c', 'd', 'e']
        //domains: [],
      };
    },
    methods: {
      addPrefix(prefix) {
        if (prefix != "")
          this.prefixes.push(prefix);
        // this.generateDomains();
        this.prefix = "";
      },
      addSufix(sufix) {
        if (sufix != "")
          this.sufixes.push(sufix);
        // this.generateDomains();
        this.sufix = ""



      }, removePrefix(index) {
        this.prefixes.splice(index, 1);
        // this.generateDomains();
      },
      RemoverTodosPrefixos(){
        this.prefixes = [];
      },
      removeSufix(index) {
        this.sufixes.splice(index, 1);
        //this.generateDomains();
      },
      RemoverTodosSufixos(){
        this.sufixes = [];
      }
    }, computed: {

      domains() {
        console.log('genererating domains...')
        const domains = [];
        for (let prefix of this.prefixes) {
          for (let sufix of this.sufixes) {
            const name = prefix+sufix;
            const url = name.toLowerCase();
            
            const checkout = `https://checkout.hostgator.com.br/?a=add&sld=${url}&tld=.com`;
            domains.push({
              name, checkout
            });
          }
        }
        return domains;
      }
    }
  };
</script>

<style>
  #slogan {
    margin-bottom: 30px;
    margin-top: 30px;
  }

  #main {
    background-color: #f1f1f1;
    padding-top: 30px;
    padding-bottom: 30px;
  }
</style>