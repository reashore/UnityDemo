namespace UnityDemo.Domain
{
	public class Dial
	{
		public string TypeOfDial { get; set; }

		public Dial(string typeOfDial)
		{
			TypeOfDial = typeOfDial;
		}

		public string DialType()
		{
			return TypeOfDial;
		}
	}
}
