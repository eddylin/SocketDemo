﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.WebSockets;

namespace SocketDemo
{
    public class WebSocketServer : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //if(context.IsWebSocketRequest)
            //{
                context.AcceptWebSocketRequest(new MicrosoftWebSockets());
            //}
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}