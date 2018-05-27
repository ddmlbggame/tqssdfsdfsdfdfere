using System;
using System.Collections.Generic;
using System.Linq;

public class IronSourceSegment
{
	public int age;

	public string gender;

	public int level;

	public int isPaying;

	public long userCreationDate;

	public double iapt;

	public string segmentName;

	public Dictionary<string, string> customs;

	public IronSourceSegment()
	{
		this.customs = new Dictionary<string, string>();
		this.age = -1;
		this.level = -1;
		this.isPaying = -1;
		this.userCreationDate = -1L;
		this.iapt = 0.0;
	}

	public void setCustom(string key, string value)
	{
		this.customs.Add(key, value);
	}

	public Dictionary<string, string> getSegmentAsDict()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (this.age != -1)
		{
			dictionary.Add("age", this.age + string.Empty);
		}
		if (!string.IsNullOrEmpty(this.gender))
		{
			dictionary.Add("gender", this.gender);
		}
		if (this.level != -1)
		{
			dictionary.Add("level", this.level + string.Empty);
		}
		if (this.isPaying > -1 && this.isPaying < 2)
		{
			dictionary.Add("isPaying", this.isPaying + string.Empty);
		}
		if (this.userCreationDate != -1L)
		{
			dictionary.Add("userCreationDate", this.userCreationDate + string.Empty);
		}
		if (!string.IsNullOrEmpty(this.segmentName))
		{
			dictionary.Add("segmentName", this.segmentName);
		}
		if (this.iapt > 0.0)
		{
			dictionary.Add("iapt", this.iapt + string.Empty);
		}
		return (from d in dictionary.Concat(this.customs)
		group d by d.Key).ToDictionary((IGrouping<string, KeyValuePair<string, string>> d) => d.Key, (IGrouping<string, KeyValuePair<string, string>> d) => d.First<KeyValuePair<string, string>>().Value);
	}
}
