using System;

// Classe global para o AppMain.cs achar o Acelerômetro direto
public class Accelerometer
{
	public bool IsSupported => false;
	public void Start() { }
	public void Stop() { }
}

// Namespace completo para caso ele busque pelo caminho longo
namespace Microsoft.Devices.Sensors
{
	public class Accelerometer
	{
		public bool IsSupported => false;
		public void Start() { }
		public void Stop() { }
	}
}
