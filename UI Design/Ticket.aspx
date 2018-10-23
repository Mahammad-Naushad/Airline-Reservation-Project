<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ticket.aspx.cs" Inherits="UI_Design.Ticket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 97px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="font-family: 'Century Gothic'; font-size: 14px; font-weight: bold; font-style: normal; background-color: #FFFF99">
        <tr>
            <td>Enter Number of Seats&nbsp;&nbsp;
                <asp:TextBox ID="txtCount" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbA1" runat="server" Text="A1" />
&nbsp;&nbsp;
                <asp:CheckBox ID="cbA2" runat="server" Text="A2" />
&nbsp;&nbsp;
                <asp:CheckBox ID="cbA3" runat="server" Text="A3" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbB1" runat="server" Text="B1" />
&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="cbB2" runat="server" Text="B2" />
&nbsp;&nbsp;
                <asp:CheckBox ID="cbB3" runat="server" Text="B3" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Enter Age: A1
                <asp:TextBox ID="txtA1" runat="server" Height="16px" TextMode="Number" Width="39px"></asp:TextBox>
&nbsp; A2<asp:TextBox ID="txtA2" runat="server" TextMode="Number" Width="44px"></asp:TextBox>
&nbsp; A3<asp:TextBox ID="txtA3" runat="server" TextMode="Number" Width="38px"></asp:TextBox>
&nbsp;B1
                <asp:TextBox ID="txtB1" runat="server" TextMode="Number" Width="34px"></asp:TextBox>
&nbsp;B2<asp:TextBox ID="txtB2" runat="server" TextMode="Number" Width="47px"></asp:TextBox>
&nbsp;B3<asp:TextBox ID="txtB3" runat="server" TextMode="Number" Width="45px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnGenerate" runat="server" OnClick="btnGenerate_Click" Text="Generate Ticket" Width="139px" />
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="74px" Width="477px">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnPay" runat="server" OnClick="btnPay_Click" Text="Confirm Ticket" Width="166px" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" Width="154px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </asp:Content>
