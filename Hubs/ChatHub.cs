﻿using Microsoft.AspNetCore.SignalR;

namespace Casgem.SignalRChat.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}