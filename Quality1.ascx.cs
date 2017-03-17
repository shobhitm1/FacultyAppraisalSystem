using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Quality1 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string Term
    {
        get
        {
            return term.Value;
        }
        set
        {
            term.Value = value;
        }

    }
    public string Remarks
    {
        get
        {
            return txtRem.Text;
        }
        set
        {
            txtRem.Text = value;
        }

    }

    public string FacultyCerti 
    {
        get
        {
            return txtcertiself.Text;
        }
        set
        {
            txtcertiself.Text = value;
        }

    }
    public string HodCerti
    {
        get
        {
            return txtcertihod.Text;
        }
        set
        {
            txtcertihod.Text = value;
        }

    }
    public string PointsAwd
    {
        get
        {
            return txtpntawd.Text;
        }
        set
        {
            txtpntawd.Text = value;
        }

    }

    public bool IsEdit()
    {
        bool res;
        if (txtcertihod.Text == "0.0" && txtcertiself.Text == "0.0" && txtpntawd.Text == "0.0" && txtRem.Text.Length == 0)
            res = false;
        else
            res = true;

            return res;
    }


    
}
