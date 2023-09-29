using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAPS08
{
    public class ChatHub : Hub
    {
        public void Send(string usuario, string mensaje)
        {
            Clients.All.EnviarMensaje(usuario, mensaje);
        }
    }
}