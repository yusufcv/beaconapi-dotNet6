namespace beaconapi
{
    public class Device
    {
        public string Id { get; set; } = String.Empty;
        public string category { get; set; } = String.Empty;
        public string deviceId { get; set; } = String.Empty;
        public string macAdress { get; set; } = String.Empty;
        public string uuid { get; set; } = String.Empty;
        public int major { get; set; }
        public int minor { get; set; }
        public DateTime lastDataSent { get; set; }
    }
}
