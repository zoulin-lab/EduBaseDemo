﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControl_AutoPro : System.Web.UI.UserControl
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();

    public List<Product> GetAllProduct()
    {
        return (from p  in db.Product 
                select p ).ToList();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();//调用自定义方法
    }
    protected void Bind()
    {
        gvProduct.DataSource = GetAllProduct();
        gvProduct.DataBind();
    }

    protected void gvProduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvProduct.PageIndex = e.NewPageIndex;
        Bind();
    }

    protected void tmrAutoShow_Tick(object sender, EventArgs e)
    {
        int newPageIndex = gvProduct.PageIndex;
        if (newPageIndex == gvProduct.PageCount - 1)
        {
            newPageIndex = 0;
        }
        else
        {
            newPageIndex += 1;
        }
        gvProduct.PageIndex = newPageIndex;
        System.Threading.Thread.Sleep(3000);  //用于感受UpdateProgress控件效果，实际工程中需删除
    }

    protected void chkAutoShow_CheckedChanged(object sender, EventArgs e)
    {
        tmrAutoShow.Enabled = chkAutoShow.Checked;
    }
}