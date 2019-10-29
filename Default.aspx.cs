﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrawleyJ_Prog3.App_Code;

namespace CrawleyJ_Prog3
{
   public partial class Default : System.Web.UI.Page
   {
      
      protected void Page_Load(object sender, EventArgs e)
      {         
         SQLDataClass.getAllProducts();
         ProductGrid.DataSource = SQLDataClass.tblProduct;
         ProductGrid.DataBind();
      }
   }
}