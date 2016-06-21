using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Reefkeeper.Hubs
{
    public class pHHub : Hub
    {
        public void PushPhToClients(ReefClient.PH ph)
        {
            Clients.All.pushPhValue(ph.PHProbId, ph.PHValue);
        }
    }
}