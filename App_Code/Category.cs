using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Category
/// </summary>
public class Category
{
	public Category()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public string DateCreated { get; set; }
    public string DateEdit { get; set; }
}