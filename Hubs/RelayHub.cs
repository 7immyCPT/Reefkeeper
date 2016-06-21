using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using static Reefkeeper.ReefClient;

namespace Reefkeeper
{
    public class RelayHub : Hub
    {

        private static List<ReefClient> ConnectedClientList = new List<ReefClient>();

        public void JoinRelayGroup(ReefClient.Relay newRelay)
        {
            Groups.Add(Context.ConnectionId, "RelayGroup");
        }

        public void PushRelaySwitch(String message)
        {
            Clients.Client(Context.ConnectionId).addRelay(message);
        }
    }
}