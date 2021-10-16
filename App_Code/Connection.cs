using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

/// <summary>
/// Summary description for Connection
/// </summary>
public class Connection
{
	public Connection()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static SqlConnection SqlConnectServer()
    {
        string ConnectString = WebConfigurationManager.ConnectionStrings["ShopData"].ConnectionString;
        return new SqlConnection(ConnectString);
    }
}