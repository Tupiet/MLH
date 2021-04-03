module.exports = (client, message, args) => { 
    const user = message.author;
    client.users.fetch(user.id).then((user) => {
        user.send(`Hola ${user.username}`);
    });
  
  }