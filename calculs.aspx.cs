using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calculs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label4.Text = (Int32.Parse(TextBox1.Text) + Int32.Parse(TextBox2.Text)).ToString();
        DataSetTableAdapters.CALCULTableAdapter tab = new DataSetTableAdapters.CALCULTableAdapter();
        tab.AJOUTER(Int32.Parse(TextBox1.Text), Int32.Parse(TextBox2.Text), Int32.Parse(Label4.Text));
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}



//salman