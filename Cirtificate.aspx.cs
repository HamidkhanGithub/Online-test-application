﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cirtificate : System.Web.UI.Page
{
    string sub;

    protected void Page_Load(object sender, EventArgs e)
    {

        string user = User.Identity.Name;
        //string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();

        Label1.Text = user;
        sub = Session["Subject"].ToString();

        Label2.Text = sub;


    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.Visible = false;
    }
}