using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
	public Order()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string Id { get; set; }
    public string NameProduct { get; set; }
    public string Status { get; set; }
    public string SalePrice { get; set; }
    public string Quantity { get; set; }
    public string NameUser { get; set; }
    public string DateCreated { get; set; }
    public string DateEdit { get; set; }
}