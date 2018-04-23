using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Collections;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

public partial class _Default : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {
        
    }
    protected void OnListBoxDataBinding(object sender, EventArgs e) {
        ASPxListBox listBox = sender as ASPxListBox;
        GridViewDataItemTemplateContainer container = (GridViewDataItemTemplateContainer)listBox.NamingContainer;
        Session["CategoryID"] = container.KeyValue;
        listBox.DataSource = AccessDataSource1;
    }
}

