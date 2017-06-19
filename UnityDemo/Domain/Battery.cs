namespace UnityDemo.Domain
{
	public class Battery : IBattery
	{
		public bool SelfCheck()
		{
			return true;
		}

		public int ChargeRemaining()
		{
			return 70;
		}

		public string Manufacturer()
		{
			return "Wayne Enterprises";
		}

		public string SerialNumber()
		{
			return "123XXGDASJ2345";
		}
	}
}
