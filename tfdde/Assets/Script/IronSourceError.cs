using System;

public class IronSourceError
{
	private string description;

	private int code;

	public IronSourceError(int errorCode, string errorDescription)
	{
		this.code = errorCode;
		this.description = errorDescription;
	}

	public int getErrorCode()
	{
		return this.code;
	}

	public string getDescription()
	{
		return this.description;
	}

	public int getCode()
	{
		return this.code;
	}

	public override string ToString()
	{
		return this.code + " : " + this.description;
	}
}
