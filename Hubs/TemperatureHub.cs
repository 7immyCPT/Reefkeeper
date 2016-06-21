using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Reefkeeper.Hubs
{
    public class TemperatureHub : Hub
    {
        public void PushTemperatureToClients(ReefClient.Temperature temp)
        {
            Clients.All.pushPhValue(temp.TemperatureProbId, temp.TemperatureValue);
        }
    }
}