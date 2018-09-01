<%@ Page Title="About Us" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="About.aspx.vb" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About
    </h2>
    <p>
        <strong>Car Loan Calculator</strong></p>
<p>
        The Car Loan Calculator Web site was developed for the book <em>Microsoft Visual 
        Basic 2010 Step by Step</em>, by Michael Halvorson (Microsoft Press, 2010). The 
        Web site is best viewed using Microsoft Internet Explorer version 6.0 or later. 
        To learn more about how this ADO.NET application was created, read Chapter 20 in 
        the book.</p>
<p>
        <strong>Operating Instructions:</strong>
    </p>
<p>
        Type a loan amount, without dollar sign or commas, into the Loan Amount box.</p>
<p>
        Type an interest rate in decimal format into the Interest Rate text box.</p>
<p>
        Do not include the “%” sign. For example, to specify a 9% interest rate, type 
        “0.09”.</p>
<p>
        Note that this loan calculator assumes a three-year, 36-month payment period.</p>
<p>
        Click the Calculate button to compute the basic monthly loan payment that does 
        not include taxes or other fees.</p>
</asp:Content>