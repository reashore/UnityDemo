namespace UnityDemo.Domain
{
	public interface IRadio
	{
		IBattery Battery { get; set; }
		string Name { get; set; }
		ITuner Tuner { get; set; }
		string RadioName();
		void Start();
	}
}
