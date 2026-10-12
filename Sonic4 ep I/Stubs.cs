using System;

// Ícones de mensagem para caixas de diálogo no jogo
public enum MessageBoxIcon
{
	None,
	Error,
	Warning
}

// Suporte ao Acelerômetro no escopo global
public class Accelerometer
{
	public bool IsSupported => false;
	public void Start() { }
	public void Stop() { }
}

// Suporte ao Acelerômetro dentro do namespace específico
namespace Microsoft.Devices.Sensors
{
	public class Accelerometer
	{
		public bool IsSupported => false;
		public void Start() { }
		public void Stop() { }
	}
}
