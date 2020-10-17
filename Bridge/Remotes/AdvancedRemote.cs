namespace Bridge
{
    class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device) { }

        public void Mute() => device.SetVolume(0);
    }
}
