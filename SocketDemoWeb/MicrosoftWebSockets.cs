using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.WebSockets;

namespace SocketDemoWeb
{
    public class MicrosoftWebSockets:WebSocketHandler
    {
        private static WebSocketCollection clients = new WebSocketCollection();

        private string name;

        public override void OnOpen()
        {
            name = this.WebSocketContext.QueryString["name"];
            clients.Add(this);
            clients.Broadcast(name + " is connented");
        }

        public override void OnClose()
        {
            base.OnClose();
        }

        public override void OnMessage(string message)
        {
            clients.Broadcast(message);
        }


        public override void OnError()
        {
            clients.Remove(this);
        }

    }
}