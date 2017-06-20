using System;

namespace UnityDemo.Domain
{
	public class CheapSpeaker : ISpeaker
	{
		public void Start()
		{
			Console.WriteLine("Sounds cheap");
		}
	}
}
