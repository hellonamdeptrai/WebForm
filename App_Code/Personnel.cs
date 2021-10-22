using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Personnel
/// </summary>
public class Personnel
{
	public Personnel()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Avatar { get; set; }
    public string Status { get; set; }
    public string Position { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string Date_created { get; set; }
    public string Date_edit { get; set; }

}