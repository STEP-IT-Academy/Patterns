namespace Bridge
{
    class Remote
    {
        protected IDevice device;

        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void Power()
        {
            if (device.IsEnabled()) device.Disable(); 
            else device.Enable(); 
        }

        public void VolumeDown()
        {
            device.SetVolume(device.GetVolume() - 10);
        }

        public void VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 10);
        }

        public void ChanneDown()
        {
            device.SetChannel(device.GetChannel() - 1);
        }

        public void ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 1);
        }
    }
}
