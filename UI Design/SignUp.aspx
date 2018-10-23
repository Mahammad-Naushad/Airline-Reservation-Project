<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="UI_Design.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 23px;
        }
    .auto-style4 {
        width: 167px;
    }
    .auto-style5 {
        height: 23px;
        width: 167px;
    }
    .auto-style6 {
        margin-bottom: 0px;
    }
        .auto-style7 {
            width: 287px;
        }
        .auto-style8 {
            height: 23px;
            width: 287px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="background-color:lightyellow">
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">&nbsp;</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome to Registeration Procees</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">Name:</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">
                <asp:TextBox ID="txtName" runat="server" Width="136px"></asp:TextBox>
            </td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">Address:</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="137px"></asp:TextBox>
            </td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">Contact:</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">
                <asp:TextBox ID="txtContact" runat="server" TextMode="Number" Width="135px"></asp:TextBox>
            </td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtContact" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">Gender:</td>
            <td class="auto-style8" style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">
                <asp:DropDownList ID="ddlGender" runat="server" AutoPostBack="True">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3" style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlGender" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">E-mail:</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="136px"></asp:TextBox>
            </td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email format doesn't match" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">Age:</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">
                <asp:TextBox ID="txtAge" runat="server" OnTextChanged="TextBox5_TextChanged" TextMode="Number" Width="134px"></asp:TextBox>
            </td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAge" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age should be Less than 100" MaximumValue="100" MinimumValue="0"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">User_ID:</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">
                <asp:TextBox ID="txtUserName" runat="server" CssClass="auto-style6" Width="133px"></asp:TextBox>
            </td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtUserName" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">Password:</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">
                <asp:TextBox ID="txtPassword" runat="server" Width="134px" TextMode="Password"></asp:TextBox>
            </td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPassword" ErrorMessage="*Compulsory Field"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">&nbsp;</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">
                <asp:Button ID="btnRegister" runat="server" OnClick="Button1_Click" Text="Register" Width="141px" />
            </td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style4">Already&nbsp; a User ?</td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal" class="auto-style7">
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/LogInPage.aspx">Click Here</asp:HyperLink>
            </td>
            <td style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
