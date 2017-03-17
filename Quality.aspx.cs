using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Quality : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            SyllabusQ s = new SyllabusQ();
            s.Login = Session["user"].ToString();
            DataTable dt = s.UserSyllabus();
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (i == 0)
                {
                    display( appq1,dr);
                    
                }
                if (i == 1)
                {
                    display(appq2, dr);
                    
                }
                if (i == 2)
                {
                    display(appq3, dr);
                    
                }
                i++;

            }

            
            
          
        }
    }
    private void display(Quality1 q, DataRow dr)
    {
        q.FacultyCerti = dr["SelfCerti"].ToString();
        q.HodCerti = dr["hodcerti"].ToString();
        q.PointsAwd = dr["pointsawd"].ToString();
        q.Remarks = dr["Remarks"].ToString();
    }
    protected void Save(object sender, EventArgs e)
    {
        String disp = "";   
        if (appq1.IsEdit() == true)
        {
            SyllabusQ s = new SyllabusQ();
            s.Login = Session["user"].ToString();
            s.Term = int.Parse(appq1.Term);
            if (s.IsEntered() == "yes")
            {
                disp += " Term 1 already Entered";
            }
            else
            {
                s.SelfCerti = decimal.Parse(appq1.FacultyCerti);
                s.HodCerti = decimal.Parse(appq1.HodCerti);
                s.Remarks = appq1.Remarks;
                s.Pointsawt = decimal.Parse(appq1.PointsAwd);

                if (s.NewSyllabusQ() == false)
                {
                    disp += s.Error;
                }
                else
                {
                    disp += "Saved Term 1";
                }
            }
        }
        if (appq2.IsEdit() == true)
        {

            SyllabusQ s1 = new SyllabusQ();
            s1.Login = Session["user"].ToString();
            s1.Term = int.Parse(appq2.Term);
            if (s1.IsEntered() == "yes")
            {
                disp += " Term 2 already Entered";
            }
            else
            {

                s1.SelfCerti = decimal.Parse(appq2.FacultyCerti);
                s1.HodCerti = decimal.Parse(appq2.HodCerti);
                s1.Remarks = appq2.Remarks;
                s1.Pointsawt = decimal.Parse(appq2.PointsAwd);

                if (s1.NewSyllabusQ() == false)
                {
                    disp += s1.Error;
                }
                else
                {
                    disp += "Saved Term 2";
                }
            }
        }
        if (appq3.IsEdit() == true)
        {

            SyllabusQ s2 = new SyllabusQ();
            s2.Login = Session["user"].ToString();
            s2.Term = int.Parse(appq3.Term);
            if (s2.IsEntered() == "yes")
            {
                disp += " Term 3 already Entered";
            }
            else
            {

                s2.SelfCerti = decimal.Parse(appq3.FacultyCerti);
                s2.HodCerti = decimal.Parse(appq3.HodCerti);
                s2.Remarks = appq3.Remarks;
                s2.Pointsawt = decimal.Parse(appq3.PointsAwd);

                if (s2.NewSyllabusQ() == false)
                {
                    disp += s2.Error;
                }
                else
                {
                    disp += "Saved Term 3";
                }
            }
        }
        mess.Text = disp;
    }
    protected void Update(object sender, EventArgs e)
    {
        String disp = "";
        if (appq1.IsEdit() == true)
        {
            SyllabusQ s = new SyllabusQ();
            s.Login = Session["user"].ToString();
            s.Term = int.Parse(appq1.Term);
            if (s.IsEntered() == "yes")
            {
                s.SelfCerti = decimal.Parse(appq1.FacultyCerti);
                s.HodCerti = decimal.Parse(appq1.HodCerti);
                s.Remarks = appq1.Remarks;
                s.Pointsawt = decimal.Parse(appq1.PointsAwd);
                s.UpdateSyllabusQ();
                
                disp += " Term1 updated" +s.Error;
            }
            else
            {
                
                    disp += "Term 1 Not Entered";
                
            }
        }
        if (appq2.IsEdit() == true)
        {
            SyllabusQ s = new SyllabusQ();
            s.Login = Session["user"].ToString();
            s.Term = int.Parse(appq2.Term);
            if (s.IsEntered() == "yes")
            {
                s.SelfCerti = decimal.Parse(appq2.FacultyCerti);
                s.HodCerti = decimal.Parse(appq2.HodCerti);
                s.Remarks = appq2.Remarks;
                s.Pointsawt = decimal.Parse(appq2.PointsAwd);
                s.UpdateSyllabusQ();

                disp += " Term2 updated";
            }
            else
            {

                disp += "Term 2 Not Entered";

            }
        }
        if (appq3.IsEdit() == true)
        {
            SyllabusQ s = new SyllabusQ();
            s.Login = Session["user"].ToString();
            s.Term = int.Parse(appq3.Term);
            if (s.IsEntered() == "yes")
            {
                s.SelfCerti = decimal.Parse(appq3.FacultyCerti);
                s.HodCerti = decimal.Parse(appq3.HodCerti);
                s.Remarks = appq3.Remarks;
                s.Pointsawt = decimal.Parse(appq3.PointsAwd);
                s.UpdateSyllabusQ();

                disp += " Term3 updated";
            }
            else
            {

                disp += "Term 3 Not Entered";

            }
        }
       
        mess.Text = disp;
    }
}