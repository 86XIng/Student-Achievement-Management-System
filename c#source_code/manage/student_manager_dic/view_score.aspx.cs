﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manage_student_manager_dic_view_score : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["type"] == null || Session["type"].ToString() != "16")
        {
            Response.Redirect("../error_login.aspx");
        }
    }
}