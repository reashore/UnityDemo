﻿using System;

namespace UnityDemo.Domain
{
	public class Radio : IRadio
	{
		public IBattery Battery { get; set; }
		public ITuner Tuner { get; set; }
		public string Name { get; set; }

		public Radio(IBattery radioBattery, ITuner radioTuner, string radioName)
		{
			Battery = radioBattery;
			Tuner = radioTuner;
			Name = radioName;
		}

		public string RadioName()
		{
			return Name;
		}

		public void Start()
		{
			string message = $"{Name} sings: Radio Ga Ga";
			Console.WriteLine(message);
		}
	}
}
