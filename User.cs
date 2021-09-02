using System;

public class User
{
	public string name;
	public string email;
	public shoppingCart shopCart;
	
	public User(string IDname,string IDemail,shoppingCart shop)
	{
		name = IDname;
		email = IDemail;
		shopCart = shop;
	}
	public void GetUser()
    {
		Console.WriteLine("Name : " + name + " Email : " + email);
		shopCart.getList();
    }
	

}
