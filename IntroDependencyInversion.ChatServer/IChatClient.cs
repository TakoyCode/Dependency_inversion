namespace IntroDependencyInversion.Server
{
    public interface IChatClient
    {
        void Receive(string message);
    }
}
