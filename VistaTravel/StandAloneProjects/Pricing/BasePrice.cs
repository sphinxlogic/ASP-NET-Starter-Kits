namespace Pricing
{
using System;

/// <summary>
///    Summary description for Class1.
/// </summary>
public class BasePrice
{
    public BasePrice()
    {
        //
        // TODO: Add Constructor Logic here
        //
    }

	public virtual double GetPrice( double TotalCost)
	{
		//
		// Return the price
		//
		return TotalCost;
	}
}
}
