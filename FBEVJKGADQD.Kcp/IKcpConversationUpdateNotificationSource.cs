namespace FBEVJKGADQD.Kcp
{
    internal interface IKcpConversationUpdateNotificationSource
    {
        ReadOnlyMemory<byte> Packet { get; }
        void Release();
    }
}
