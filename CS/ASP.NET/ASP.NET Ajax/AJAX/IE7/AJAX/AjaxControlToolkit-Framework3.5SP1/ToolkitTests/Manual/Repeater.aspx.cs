// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx.
// All other rights reserved.


using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using AjaxControlToolkit;

public partial class Manual_Repeater : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable table = new DataTable();
        table.Columns.Add(new DataColumn("Value", typeof(string)));

        foreach (string value in "one,two,three,four,five".Split(','))
        {
            DataRow row = table.NewRow();
            row["Value"] = value;
            table.Rows.Add(row);
        }

        Repeater1.DataSource = new DataView(table);
        Repeater1.DataBind();
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        PopupControlExtender.GetProxyForCurrentPopup(Page).Commit(Calendar1.SelectedDate.ToShortDateString());
    }
}
