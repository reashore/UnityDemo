namespace UnityDemo.Domain
{
	public interface ITuner
	{
		string Manufacturer();
		int TunedFrequency();
		bool SelfCheck();
		string SerialNumber();
	}
}
