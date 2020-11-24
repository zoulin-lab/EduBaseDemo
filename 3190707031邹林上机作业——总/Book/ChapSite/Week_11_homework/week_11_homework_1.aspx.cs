﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Week_11_homework_week_11_homework_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Select_Click(object sender, EventArgs e)
    {
        MyPetShopDataContext db = new MyPetShopDataContext();
        var results = from r in db.Product
                      where r.ListPrice > 30 &&( r.Name.Contains("c") || r.Name.Contains("C"))
                      select r;
        gv_Product.DataSource = results;
        gv_Product.DataBind();
    }
}