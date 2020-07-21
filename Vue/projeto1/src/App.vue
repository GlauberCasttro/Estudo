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
                  <input class="form-control" type="text" v-model="prefix" v-on:keyup.enter="addPrefix(prefix)"
                    placeholder="Digite o prefixo" />
                  <div class="input-group-append">
                    <button class="btn btn-info" v-on:click="addPrefix(prefix)">
                      <span class="fa fa-plus"></span>
                    </button>

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
                   v-for="(sufix, index) in sufixes"
                    v-bind:key="sufix">
                    {{ sufix }}
                    <button class="btn btn-danger" title="Remova" v-on:click="removeSufix(index)">
                      <span class="fa fa-trash"></span>
                    </button>
                  </li>

                </ul>
                <br />




                <div class="input-group">
                  <input class="form-control" type="text" v-model="sufix" v-on:keyup.enter="addSufix(sufix)"
                    placeholder="Digite o Sufixo" />
                  <div class="input-group-append">
                    <button class="btn btn-info" v-on:click="addSufix(sufix)">
                      <span class="fa fa-plus"></span>
                    </button>
                  </div>
                </div>


              </div>
            </div>
          </div>
        </div>
        <br />
        <h5 class="text-center">Domains</h5>
        <div class="card">
          <div class="card-body">
            <ul class="list-group">
              <li class="list-group-item" v-for="domain in domains" v-bind:key="domain.name">
                {{ domain }}
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
        prefixes: [],
        sufixes: [],
        domains: [],
      };
    },
    methods: {
      addPrefix(prefix) {
        if (prefix != "")
          this.prefixes.push(prefix);
        this.generateDomains();
        this.prefix = "";
      },
      addSufix(sufix) {
        if (sufix != "")
          this.sufixes.push(sufix);
        this.generateDomains();
        this.sufix = ""
      },
      generateDomains() {
        this.domains = [];
        for (let prefix of this.prefixes) {
          for (let sufix of this.sufixes) {
            this.domains.push(prefix + sufix);
          }
        }

      },removePrefix(index){
       this.prefixes.splice(index,1);
      this.generateDomains();
      },
      removeSufix(index){
        this.sufixes.splice(index,1);
      this.generateDomains();
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