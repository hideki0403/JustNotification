using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustNotification
{
    public class IPC
    {
        public string PipeName { get; set; } = "UnityNamedPipe";
        public int ReceiveTimeout { get; set; }
        public NamedPipeClientStream Client { get; set; }

        public async Task<string> Send(string message)
        {
            try
            {
                await Connect();
                await SendToUnity(message);
                return await ReceiveFromUnity();
            }
            finally
            {
                if (Client is not null)
                    await Client.DisposeAsync();
            }
        }

        private async Task Connect()
        {
            Client = new NamedPipeClientStream(PipeName);
            await Client.ConnectAsync(1000);
        }

        private async Task SendToUnity(string message)
        {
            if (Client == null)
                throw new InvalidOperationException();
            var bytes = Encoding.UTF8.GetBytes(message);
            await Client.WriteAsync(bytes, 0, bytes.Length);
            await Client.FlushAsync();
        }

        private async Task<string> ReceiveFromUnity()
        {
            if (Client == null)
                throw new InvalidOperationException();
            var buffer = new byte[1024];
            using var cancel = new CancellationTokenSource();
            if (ReceiveTimeout > 0)
                cancel.CancelAfter(ReceiveTimeout);
            var len = await Client.ReadAsync(buffer, 0, buffer.Length, cancel.Token);
            return Encoding.UTF8.GetString(buffer, 0, len);
        }
    }
}
