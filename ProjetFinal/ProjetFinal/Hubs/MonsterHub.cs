using Common.TransferObjects;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace ProjetFinal.Hubs
{
    public class MonsterHub : Hub
    {
        public async Task UpdateSheet(string name)
        {
            // Appel UseCase
            await Clients.Caller.SendAsync("ReceiveSheet",name);
        }
    }
}