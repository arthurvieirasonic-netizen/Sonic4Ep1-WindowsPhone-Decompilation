using System;

// Preenche o Acelerômetro para o AppMain sem duplicar nada de Xbox/Guide
public class Accelerometer
{
	public bool IsSupported => false;
	public void Start() { }
	public void Stop() { }
}

namespace Microsoft.Devices.Sensors
{
	public class Accelerometer
	{
		public bool IsSupported => false;
		public void Start() { }
		public void Stop() { }
	}
}
