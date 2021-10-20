using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
	public Product()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string SalePrice { get; set; }
    public string Avatar { get; set; }
    public string DateCreated { get; set; }
    public string DateEdit { get; set; }
}