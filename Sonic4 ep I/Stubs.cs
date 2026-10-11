using System;

namespace Microsoft.Devices.Sensors
{
    public class Accelerometer
    {
        public event EventHandler<AccelerometerReadingEventArgs> ReadingChanged;
        public void Start() { }
        public void Stop() { }
    }

    public class AccelerometerReadingEventArgs : EventArgs
    {
        public double X => 0;
        public double Y => 0;
        public double Z => 0;
    }

    public class AccelerometerFailedException : Exception { }
}

namespace Microsoft.Xna.Framework.GamerServices
{
    public class GamerProfile { }
    public class SignedInGamer { }
    public class SignedInEventArgs : EventArgs { }
    public class GameUpdateRequiredException : Exception { }
}
