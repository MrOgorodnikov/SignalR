﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRVoting.SignalR
{
    public class SignalRHub : Hub
    {
        public SignalRHub()
        {
        }

        public async Task Vote(int id)
        {
            await Clients.All.SendAsync("GetVote", id);
        }
    }
}