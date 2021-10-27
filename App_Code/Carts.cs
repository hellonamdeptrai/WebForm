using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Carts
/// </summary>
public class Carts
{
	public Carts()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string IdProduct { get; set; }
    public string Avatar { get; set; }
    public string Name { get; set; }
    public string SalePrice { get; set; }
    public int Quantity { get; set; }
    public string TotalPrice { get; set; }
}