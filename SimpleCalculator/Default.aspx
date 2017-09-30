<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 260px">
    <h2><em>Simple Calculator</em></h2>

    <form id="form1" runat="server">
        <div style="font-family: Arial, Helvetica, sans-serif; font-weight: normal">
            First Value:
            <asp:TextBox ID="firstNumber" runat="server"></asp:TextBox>
            <br />
            Second Value:
            <asp:TextBox ID="secondNumber" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Addition" runat="server" OnClick="Addition_Click" Text=" + " />
            <asp:Button ID="Subtraction" runat="server" Text=" - " OnClick="Subtraction_Click" />
            <asp:Button ID="Multiplication" runat="server" Text=" * " OnClick="Multiplication_Click" />
            <asp:Button ID="Division" runat="server" Text=" / " OnClick="Division_Click" />
            <br />
            <br />
            <asp:Label ID="Result" runat="server" BackColor="#3399FF" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </div>
    </form>
</body>
</html>
