public class BurstINTOnCritical : OnCritical
{
	public override bool OnEnable()
	{
		ApplyStatus(base.Owner, StatusEnum.MagicSpike, base.Val1);
		return true;
	}
}
