using System;
using Microsoft.Practices.Unity;
using UnityDemo.Domain;
using UnityDemo.Unity;

namespace UnityDemo
{
	public class Demo
	{
		private static void Main()
		{
			IUnityContainer container = new UnityContainer();
			ContainerMagic.RegisterElements(container);

			IBattery battery = container.Resolve<IBattery>();
			Console.WriteLine(battery.SerialNumber());

			Dial dial = container.Resolve<Dial>();
			Console.WriteLine(dial.DialType());

			ITuner tuner = container.Resolve<ITuner>();
			IRadio radio = container.Resolve<IRadio>(
				new ParameterOverride("radioBattery", battery),
				new ParameterOverride("radioTuner", tuner),
				new ParameterOverride("radioName", "BrokenRadio"));

			radio.Start();

			ISpeaker cheapSpeaker = container.Resolve<ISpeaker>("Cheap");
			ISpeaker priceySpeaker = container.Resolve<ISpeaker>("Expensive");
			cheapSpeaker.Start();
			priceySpeaker.Start();

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
