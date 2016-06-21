namespace Reefkeeper
{
    public class ReefClient
    {
        public string ClientId { get; set; }
        public string ClientUserName { get; set; }

        public class Temperature
        {
            public string TemperatureProbId { get; set; }
            public double TemperatureValue { get; set; }
        }

        public class PH
        {
            public string PHProbId { get; set; }
            public double PHValue { get; set; }
        }

        public class Relay
        {
            public string RelayId { get; set; }

            public string ChannelId { get; set; }
            public bool Status { get; set; }
        }
    }
}