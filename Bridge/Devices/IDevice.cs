namespace Bridge
{
    interface IDevice
    {
        bool IsEnabled();

        void Enable();

        void Disable();

        int GetVolume();

        void SetVolume(double percent);

        int GetChannel();

        void SetChannel(int channel);
    }
}
