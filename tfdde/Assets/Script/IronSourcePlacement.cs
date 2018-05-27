using System;

public class IronSourcePlacement
{
	private string rewardName;

	private int rewardAmount;

	private string placementName;

	public IronSourcePlacement(string placementName, string rewardName, int rewardAmount)
	{
		this.placementName = placementName;
		this.rewardName = rewardName;
		this.rewardAmount = rewardAmount;
	}

	public string getRewardName()
	{
		return this.rewardName;
	}

	public int getRewardAmount()
	{
		return this.rewardAmount;
	}

	public string getPlacementName()
	{
		return this.placementName;
	}

	public override string ToString()
	{
		return string.Concat(new object[]
		{
			this.placementName,
			" : ",
			this.rewardName,
			" : ",
			this.rewardAmount
		});
	}
}
