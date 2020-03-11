using Nanoteer.Core;
using Nanoteer.Core.Gpio;
using System;

namespace Nanoteer.Boards.GHI
{
    public class Cerberus : IMainboard
    {
        /// <summary>
        /// The mainboard name, which is printed at startup in the debug window
        /// </summary>
        public string MainboardName => "GHI Electronics FEZCerberus";

        /// <summary>
        /// The mainboard version, which is printed at startup in the debug window
        /// </summary>
        public string MainboardVersion => "1.1";

        public Cerberus()
        {
            Socket socket;

            #region Socket 2
            socket = new Socket(2, SocketType.Y);
            socket.SocketPins[3] = CerberusPin.PA6;
            socket.SocketPins[4] = CerberusPin.PA2;
            socket.SocketPins[5] = CerberusPin.PA3;
            socket.SocketPins[6] = CerberusPin.PA1;
            socket.SocketPins[7] = CerberusPin.PA0;
            socket.SocketPins[8] = CerberusPin.PB7;
            socket.SocketPins[9] = CerberusPin.PB6;

            SocketHelper.RegisterSocket(socket);
            #endregion Socket 2

            #region Socket 3
            socket = new Socket(3, SocketType.Y);
            socket.SocketPins[3] = CerberusPin.PC0;
            socket.SocketPins[4] = CerberusPin.PC1;
            socket.SocketPins[5] = CerberusPin.PA4;
            socket.SocketPins[6] = CerberusPin.PC5;
            socket.SocketPins[7] = CerberusPin.PC6;
            socket.SocketPins[8] = CerberusPin.PA7;
            socket.SocketPins[9] = CerberusPin.PC7;

            SocketHelper.RegisterSocket(socket);
            #endregion Socket 3

            #region Socket 4
            socket = new Socket(4, SocketType.Y);
            socket.SocketPins[3] = CerberusPin.PC2;
            socket.SocketPins[4] = CerberusPin.PC3;
            socket.SocketPins[5] = CerberusPin.PA5;
            socket.SocketPins[6] = CerberusPin.PC13;
            socket.SocketPins[7] = CerberusPin.PA8;
            socket.SocketPins[8] = CerberusPin.PB0;
            socket.SocketPins[9] = CerberusPin.PB1;

            SocketHelper.RegisterSocket(socket);
            #endregion Socket 4

            #region Socket 7
            socket = new Socket(7, SocketType.Y);
            socket.SocketPins[3] = CerberusPin.PA15;
            socket.SocketPins[4] = CerberusPin.PC8;
            socket.SocketPins[5] = CerberusPin.PC9;
            socket.SocketPins[6] = CerberusPin.PD2;
            socket.SocketPins[7] = CerberusPin.PC10;
            socket.SocketPins[8] = CerberusPin.PC11;
            socket.SocketPins[9] = CerberusPin.PC12;

            SocketHelper.RegisterSocket(socket);
            #endregion Socket 7
        }

        public void PostInit()
        {
            return;
        }

        // change the below to the debug led pin on this mainboard
        private DigitalOutput debugLedPin = new DigitalOutput(null, CerberusPin.PC4);
        public void SetDebugLED(bool on)
        {
            debugLedPin.Write(on);
        }

        public void EnsureRgbSocketPinsAvailable()
        {
            throw new NotImplementedException();
        }

        public string[] GetStorageDeviceVolumeNames()
        {
            throw new NotImplementedException();
        }

        public bool MountStorageDevice(string volumeName)
        {
            throw new NotImplementedException();
        }

        public bool UnmountStorageDevice(string volumeName)
        {
            throw new NotImplementedException();
        }
    }
}
