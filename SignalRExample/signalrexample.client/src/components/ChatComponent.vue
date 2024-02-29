<template>
  <section>
    <h1>Chat</h1>

    <div>
      <div>
        <input type="text" placeholder="Username" v-model="username" />
      </div>

      <div>
        <input type="text" placeholder="Message" v-model="message" />
      </div>

      <button @click="onSend()">Send</button>
    </div>
  </section>
</template>

<script setup lang="ts">
import * as signalR from "@microsoft/signalr";
import { onMounted, ref } from "vue";

const username = ref("");
const message = ref("");

let connection: signalR.HubConnection;

onMounted(() => {
  connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

  connection.on("ReceiveMessage", (user, message) => {
    console.log(user + " says " + message);
  });

  connection
    .start()
    .then(() => {
      console.log("Connection started!");
    })
    .catch((err) => console.error(err));
});

function onSend() {
  connection.invoke("SendMessage", username.value, message.value);
}
</script>
