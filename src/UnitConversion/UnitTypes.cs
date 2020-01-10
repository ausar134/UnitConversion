namespace UnitConversion
{
	using System;

	[Flags]
	public enum UnitTypes
	{
		None = 0,
		Length = 1,
		Mass = Length << 1,
		Time = Mass << 1,
		Current = Time << 1,
		Temperature = Current << 1,
		Luminosity = Temperature << 1,
	}
}
