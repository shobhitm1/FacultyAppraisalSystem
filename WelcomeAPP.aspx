<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WelcomeAPP.aspx.cs" Inherits="WelcomeAPP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div><h1>Performance Appraisal and Reward Scheme for Faculty (PARS-F) </h1>   </div>
    <hr />
    <Asp:hyperlink id="AHome" runat="server" NavigateUrl="~/AppraisalHome.aspx" Width="300px" Font-Size="X-Large" >Teaching Evaluation</Asp:hyperlink>
    <Asp:hyperlink id="QfS" runat="server" NavigateUrl="~/quality.aspx" Width="300px" Font-Size="X-Large">Quality Factor Syllabus</Asp:hyperlink>

    </div>
    </form>
</body>
</html>
