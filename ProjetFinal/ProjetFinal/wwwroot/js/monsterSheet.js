"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/monsterHub").build();



connection.on("ReceiveSheet", function (monster) {
    var msg = monster.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    //var encodedMsg = user + " says " + msg;
    //var li = document.createElement("li");
    //li.textContent = encodedMsg;
    document.getElementById("monsterSheet").innerHTML = createMonsterHTML(msg);
});

connection.start().then(function () {
    
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("Title").addEventListener("input", function (event) {
    var name = document.getElementById("Title").value;
    //var message = document.getElementById("messageInput").value;
    connection.invoke("UpdateSheet", name).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

document.getElementById("Name").addEventListener("input", function (event) {
    var name = document.getElementById("Name").value;
    //var message = document.getElementById("messageInput").value;
    connection.invoke("UpdateSheet", name).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
var createMonsterHTML = function (monsterJson) {
    return "<strong>"+monsterJson+"</strong>"
};