//Esta función se activara cuando el evento haya iniciado:
module.exports = (client) => {
  
    client.user.setPresence({
        status: "online",
        activity: {
          name: "nada por el momento",
          type: "PLAYING"
        }
      });
   
    
  }