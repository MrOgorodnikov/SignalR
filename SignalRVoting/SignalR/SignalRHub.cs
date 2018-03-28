using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRVoting.SignalR
{
    public class SignalRHub : Hub
    {
        public SignalRHub()
        {
        }

        public async Task Connect(string sessionCode)
        {
            await Groups.AddAsync(Context.ConnectionId, sessionCode);
        }

        public async Task Vote(string sessionCode, string message)
        {
            await Clients.All.SendAsync("GetVote", message);
        }
    }
}
