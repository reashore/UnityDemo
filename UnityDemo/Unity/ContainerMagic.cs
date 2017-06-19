using System;
using Microsoft.Practices.Unity;
using UnityDemo.Domain;

namespace UnityDemo.Unity
{
	public class ContainerMagic
	{
		public static void RegisterElements(IUnityContainer container)
		{
			Dial dial = new Dial("Linear");
			container.RegisterInstance(dial);

			container.RegisterType<IBattery, Battery>();
			container.RegisterType<ITuner, Tuner>();

			Type batteryType = typeof(IBattery);
			Type tunerType = typeof(ITuner);
			container.RegisterType<IRadio, Radio>(new InjectionConstructor(batteryType, tunerType, typeof(string)));
		}
	}
}
