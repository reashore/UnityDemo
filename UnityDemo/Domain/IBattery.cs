namespace UnityDemo.Domain
{
	public interface IBattery
	{
		bool SelfCheck();
		int ChargeRemaining();
		string Manufacturer();
		string SerialNumber();
	}
}
