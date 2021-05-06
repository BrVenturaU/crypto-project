<template>
    <div>
        <div class="row">
            <div class="col-12">
                <div class="form-group">
                    <label for="salt" class="mr-1">Salt:</label>
                    <input class="mr-2" type="radio" name="logOption" id="salt" v-model="logOption" value="S">
                    <label for="no-salt" class="mr-1">No Salt:</label>
                    <input type="radio" name="logOption" id="no-salt" v-model="logOption" value="N">
                </div>
                <select class="form-control" v-model="selectedLogId" v-if="!isLoading">
                   <option v-for="log of subLogs" :key="log.id" :value="log.id">Id: {{log.id}} - Hash: {{log.hash}}</option> 
                </select>
            </div>
        </div>
        <div class="mt-5 text-center">
            <feather class="text-success" type="loader" animation="spin" size="5rem" animation-speed="fast" v-if="isLoading"></feather>
        </div>
        <div class="row">
            <div class="mb-5 col-12 col-md-8">
                <h2>Actualiza tu clave.</h2>
                <form @submit.prevent="update">
                    <div class="form-row">
                        <div class="col-12 col-sm-4">
                            <input type="text" class="form-control" name="password" id="password" placeholder="Clave actual" required v-model="passwordForm.password">
                            <span class="text-danger" v-for="(error, index) in errors.password" :key="index">{{error}}</span>
                        </div>
                        <div class="col-12 col-sm-4">
                            <input type="text" class="form-control" name="newPassword" id="newPassword" placeholder="Nueva clave" required v-model="passwordForm.newPassword">
                            <span class="text-danger" v-for="(error, index) in errors.newPassword" :key="index">{{error}}</span>
                        </div>
                        <div class="col-12 col-sm-4">
                            <input type="text" class="form-control" name="confirmPassword" id="confirmPassword" placeholder="Clave de confirmación" required v-model="passwordForm.confirmPassword">
                            <span class="text-danger" v-for="(error, index) in errors.confirmPassword" :key="index">{{error}}</span>
                        </div>
                    </div>
                    <div class="mt-3 d-flex align-items-center">
                        <button type="submit" class="mr-4 btn btn-primary">Enviar</button>
                    </div>
                </form>
            </div>
            <div class="col-12 col-md-4 bg-light d-flex align-items-center justify-content-center">
                <feather class="text-success" type="loader" animation="spin" size="5rem" animation-speed="fast" v-if="isUpdating"></feather>
                <pre class="text-muted" v-if="!isUpdating">{{passwordUpdated}}</pre>
            </div>
        </div>
    </div>
</template>
<script>
import axios from 'axios';
axios.defaults.baseURL = 'https://localhost:44301';
export default {
    created(){
        let vm = this;
        vm.get();
    },
    watch:{
        logOption: function(){
            this.passwordUpdated = {};
            this.selectedLogId = 1;
            this.get()
        }
    },
    data() {
        return {
            logs: [],
            logOption: "S",
            selectedLogId: 1,
            isLoading: false,
            isUpdating: false,
            passwordForm:{
                password: '',
                newPassword: '',
                confirmPassword: ''
            },
            passwordUpdated: {},
            errors: {
                password: [],
                newPassword: [],
                confirmPassword: []
            }
        }
    },
    computed:{
        subLogs(){
            let subData = this.logs.slice(0, this.logs.length);
            subData.hash = subData.forEach(l => l.hash = l.hash.substring(0, 12));
            return subData;
        },
        url(){
            let vm = this;
            return vm.logOption == "S" ? "Password/salt" : "Password/no-salt";
            
        }
    },
    methods: {
        async get(){
            let vm = this;
            vm.isLoading = true;
            let response = await axios.get(vm.url);
            vm.isLoading = false;
            vm.logs = response.data;
        },
        async update(){
            let vm = this;
            vm.errors = {
                password: [''],
                newPassword: [''],
                confirmPassword: ['']
            };
            let response = {};
            try {
                vm.isUpdating = true;
                if(vm.logOption == "S"){
                    let passwordSaltRequestAsync = axios.put(`${vm.url}/${vm.selectedLogId}`, vm.passwordForm);
                    response = await passwordSaltRequestAsync;
                }else{
                    let passwordNoSaltRequestAsync = axios.put(`${vm.url}/${vm.selectedLogId}`, vm.passwordForm);
                    response = await passwordNoSaltRequestAsync;
                }
                vm.passwordUpdated = response.data;
                vm.get();
            } catch (error) {
                let vm = this;
                let errors = error.response.data.errors;
                if(errors != undefined){
                    for (const key in errors) {
                        console.log(key)
                        switch (key) {
                            case "Password":
                                vm.errors.password = errors[key];
                                break;
                            case "NewPassword":
                                vm.errors.newPassword = errors[key];
                                break;
                            case "ConfirmPassword":
                                console.log(vm.errors);
                                vm.errors.confirmPassword = errors[key];
                                break;
                        }
                    }
                }else{
                    alert(error.response.data);
                }
                vm.passwordUpdated = {};
            }
            vm.isUpdating = false;
        }
    },
}
</script>
<style scoped>

</style>