using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;

namespace MySisEvo.Controls
{
    public static class SocketIslemler
    {
        public static Socket MysisSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static SocketAsyncEventArgs MysisSocketOlay;
        public static DnsEndPoint MyEndPoint = new System.Net.DnsEndPoint("88.247.221.28", 4529);

        
    }
}
