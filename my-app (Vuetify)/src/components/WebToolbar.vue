<template>
 <v-toolbar color="green darken-4" dark>
  <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
  <div class="hidden-sm-and-down">
    <v-btn flat text>Home</v-btn>
    <v-btn flat text>Profile</v-btn>
    <v-btn flat text>Unit/Lembaga</v-btn>
    <v-btn flat text>Akademik</v-btn>
    <v-btn flat text>Dokumen</v-btn>
    <v-btn flat text>Gallery</v-btn>
    <v-btn flat text>Peta</v-btn>
    <v-btn flat text>Video Profil</v-btn>
    <router-link to="/login">
        <v-btn flat text>Kontak</v-btn>
    </router-link>
  </div>
  <div class="hidden-sm-and-down">
    <v-navigation-drawer
    v model="drawer"
    absolute
    temporary
    height="800px">
    <v-list class="pa-1">
    <v-list-tile avatar>
    <v-list-tile-avatar>
    <img src="https://randomuser.me/api/portraits/men/85.jpg">
    </v-list-tile-avatar>
    <v-list-tile-content>
        <v-list-tile-tittle>John Leider</v-list-tile-tittle>
    </v-list-tile-content>
    </v-list-tile>
    </v-list>
    <v-list class="pt-0" dense>
        <v-divider></v-divider>

        <v-list-tile v-for="item in items"
            :key="item.tittle">
            <v-list-tittle-action>
                <v-icon>{{ item.icon }}</v-icon>
            </v-list-tittle-action>

            <v-list-tile-content>
                <v-list-tile-tittle>{{ item.ittle }}</v-list-tile-tittle>
            </v-list-tile-content>
        </v-list-tile>
    </v-list>
    </v-navigation-drawer>
  </div>
 </v-toolbar>
</template>

<script>
export default {
data (){
return {
drawer: null,
items: [
    {tittle : 'home', icon: 'dashboard'},
    {tittle : 'about', icon:'question_answer'}
]
}
}
}
</script>