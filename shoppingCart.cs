using System;
using System.Collections.Generic;

public class shoppingCart
{

	private List<T_shirt> orderTShirt;
	public float Total_cost;
	public Address addData;
	
	public shoppingCart(Address dataAddress)
	{
		addData = dataAddress;
		orderTShirt = new List<T_shirt>();
	}
	public void addList(T_shirt shirt)
	{
	    orderTShirt.Add(shirt);
		Total_cost = Total_cost + shirt.cost;
	}
	public void getList()
	{
		Console.WriteLine("Street : " + addData.street + " City : " + addData.city + " ZipCode : " + addData.zipCode);
		orderTShirt.ForEach(value => { Console.WriteLine("Size : " + value.size + " Color : " + value.color + " Cost : " + value.cost + " Image : "+ value.image); });
		Console.WriteLine("Total Cost : "+ Total_cost);
    }
	
}
