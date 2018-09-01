<%@ Page Title="Car Loan Calculator" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
    .style1
    {
        font-family: "Segoe UI";
        color: #FF0000;
        font-weight: normal;
    }
</style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 class="style1">
        <em>Car Loan Calculator</em></h2>
    <p>
        Enter the required information and click Calculate!</p>
    <br />
<br />
<asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
&nbsp;
<asp:Label ID="lblAmount" runat="server" Text="Loan Amount"></asp:Label>
<br />
<br />
<asp:TextBox ID="txtInterest" runat="server"></asp:TextBox>
&nbsp;
<asp:Label ID="lblInterest" runat="server" 
    Text="Interest Rate (for example, 0.09)"></asp:Label>
<br />
<br />
<asp:TextBox ID="txtPayment" runat="server"></asp:TextBox>
&nbsp;
<asp:Label ID="lblPayment" runat="server" Text="Monthly Payment"></asp:Label>
<br />
<br />
<asp:Button ID="btnCalculate" runat="server" Text="Calculate" />
<br />
<br />
<asp:HyperLink ID="lnkProspects" runat="server" 
    NavigateUrl="~/FacultyLoanLeads.aspx">Display Loan Prospects</asp:HyperLink>
<br />
<br />
</asp:Content>