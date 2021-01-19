using System.Net.Sockets;

namespace RiseHax.Core
{
    public class SwitchConnection
    {
        Socket socket;
        public void Connect(string host, int port, bool disconnect = false)
        {
            if (disconnect == false)
            {
                socket = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp);
                socket.Connect(host, port);
            }
            else
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}
