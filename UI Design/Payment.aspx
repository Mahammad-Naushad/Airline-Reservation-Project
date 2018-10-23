<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="UI_Design.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        height: 23px;
    }
    .auto-style4 {
        height: 23px;
        width: 190px;
    }
    .auto-style5 {
        width: 190px;
    }
    .auto-style6 {
        width: 190px;
        height: 26px;
    }
    .auto-style7 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="background-color:lightyellow; font-family: 'Century Gothic'; font-size: 14px; font-weight: normal; font-style: normal;">
        <tr>
            <td class="auto-style4">Confirm TicketID:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>
                <asp:Button ID="btnTicket" runat="server" OnClick="Unnamed1_Click" Text="Confirm Ticket ID" Width="124px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Select Bank Name:</td>
            <td class="auto-style3">
                <asp:DropDownList ID="ddlBank" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>HDFC Bank</asp:ListItem>
                    <asp:ListItem>Canara Bank</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlBank" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Enter Card Number:</td>
            <td>
                <asp:TextBox ID="txtCardNumber" runat="server" TextMode="Number" OnTextChanged="txtCardNumber_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCardNumber" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Enter CVV:</td>
            <td>
                <asp:TextBox ID="txtCvv" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCvv" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Expiry Date:</td>
            <td>
                <asp:TextBox ID="txtExpiry" runat="server" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtExpiry" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <asp:Button ID="btnPayment" runat="server" Text="Confirm Payment" Width="131px" OnClick="btnPayment_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
