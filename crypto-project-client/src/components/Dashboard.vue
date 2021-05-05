<template>
<div>
    <div class="row">
        <div class="mb-5 col-12">
            <h2>Crea tu clave.</h2>
            <form @submit.prevent="create">
                <div class="form-row">
                    <div class="col-12 col-sm-10">
                        <input type="text" class="form-control" name="password" id="password" placeholder="Clave" required v-model="password">
                    </div>
                    <div class="col-12 col-sm-1">
                        <button type="submit" class="btn btn-primary btn-block">Enviar</button>
                    </div>
                    <div class="col-12 col-sm-1 d-flex align-items-center" v-if="isLoading">
                        <feather class="text-success" type="loader" animation="spin" animation-speed="fast"></feather>
                    </div>
                </div>
            </form>
        </div>
    </div>
    <div class="row">
        <div class="col-12 col-md-6">
            <h2>Password With Salt (Hash)</h2>
            <div class="shadow card">
                <div class="card-body">
                    <h3 class="card-title">Una pizca de... Si! De seguridad!</h3>
                    <p class="card-text">Mira la información de como darle sabor a tus claves aquí.</p>
                    <a href="https://auth0.com/blog/adding-salt-to-hashing-a-better-way-to-store-passwords/" target="_blank" class="btn btn-primary">Ver</a>
                </div>
                <ul class="list-group">
                    <li class="list-group-item">
                        Password Id: 
                        <span class="badge badge-primary badge-pill">{{passwordSalt.id}}</span>
                    </li>
                    <li class="list-group-item">
                        <span class="badge badge-primary badge-pill">Hash:</span>
                        {{passwordSalt.hash}}
                    </li>
                    <li class="list-group-item">
                        <span class="badge badge-primary badge-pill">Password:</span>
                        {{password}}
                    </li>
                    <li class="list-group-item">
                        <span class="badge badge-primary badge-pill">Salt:</span>
                        {{passwordSalt.salt}}
                    </li>
                    <li class="list-group-item">
                        <span class="badge badge-primary badge-pill">Hash = Salt + Password</span>
                        {{passwordSalt.salt}} <strong class="h3 text-warning">+</strong> {{password}} 
                    </li>
                </ul>
            </div>
        </div>
        <div class="col-12 col-md-6">
            <h2>Password Without Salt (Encriptado)</h2>
            <div class="shadow card">
                <div class="card-body">
                    <h3 class="card-title">El sabor común de las claves</h3>
                    <p class="card-text">Mira la información de como cocinar una clave aquí.</p>
                    <a href="https://www.searchabledesign.com/blog/post/Password-Encryption#:~:text=What%20is%20Password%20Encryption%3F,word%20cryptography%20has%20Greek%20origins" target="_blank" class="btn btn-primary">Ver</a>
                </div>
                <ul class="list-group">
                    <li class="list-group-item">
                        Password Id: 
                        <span class="badge badge-primary badge-pill">{{passwordNoSalt.id}}</span>
                    </li>
                    <li class="list-group-item">
                        <span class="badge badge-primary badge-pill">Hash:</span>
                        {{passwordNoSalt.hash}}
                    </li>
                    <li class="list-group-item">
                        <span class="badge badge-primary badge-pill">Password:</span>
                        {{password}}
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>
</template>
<script>
import axios from 'axios';
axios.defaults.baseURL = 'https://localhost:44301/';
export default {
    mounted() {
        // this.get();
    },
    data() {
        return {
            isLoading: false,
            password: '',
            passwordSalt: {id: 0, hash: 'F1IGKjwP+VutwnCBuqCQwfTg+Z09b9vbk42jT/', salt: 'OPwMr5fr35ouXRGJn2wiK+xGiAd5SXx27zsy2te8TavGebQ1UP8hO43ALVUnk+r/wM5PsrZ49Y5BZ8EI2sUd2g=='},
            passwordNoSalt: {id: 0, hash: '"F1IGKjwP+VutwnCBuqCQwfTg+Z09b9vbk42jT/'},
        }
    },
    methods: {
        async create(){
            let vm = this;
            try {
                vm.isLoading = true;
                let passwordSaltRequestAsync = axios.post('Password/salt', {password: vm.password});
                let passwordNoSaltRequestAsync = axios.post('Password/no-salt', {password: vm.password});
                let passwordSaltResponse = await passwordSaltRequestAsync;
                let passwordNoSaltResponse = await passwordNoSaltRequestAsync;
                vm.isLoading = false;
                vm.passwordSalt = passwordSaltResponse.data;
                vm.passwordNoSalt = passwordNoSaltResponse.data;
            } catch (error) {
                alert(error.response.data);
            }
        }
    },
}
</script>
<style scoped>

</style>