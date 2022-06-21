namespace beaconapi
{
    public class DeviceSignalLog
    {
        public string Id { get; set; } = String.Empty;
        public string Category { get; set; } = String.Empty;
        public string GatewayId { get; set; } = String.Empty;
        public string uuid { get; set; } = String.Empty;
        public int major { get; set; }
        public int minor { get; set; }
        public int rssi { get; set; }
        public DateTime timestamp { get; set; }
    }
}
