namespace Bridge.Devices
{
    class Radio : IDevice
    {
        public bool Status { get; private set; }

        public int Channel { get; private set; }

        public int Volume { get; private set; }

        public void Disable() => Status = false;

        public void Enable() => Status = true;

        public int GetChannel() => Channel;

        public int GetVolume() => Volume;

        public bool IsEnabled() => Status;

        public void SetChannel(int channel) => Channel = channel;

        public void SetVolume(double percent)
        {
            Volume = (int)((Volume * percent) / 100);
        }
    }
}
