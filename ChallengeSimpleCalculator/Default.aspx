<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple Calculator</h1>
    
    </div>
        <p>
            First Value:&nbsp;
            <asp:TextBox ID="number1TextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value:&nbsp;
            <asp:TextBox ID="number2TextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;&nbsp;
            <asp:Button ID="subButton" runat="server" OnClick="subButton_Click" Text="-" />
&nbsp;&nbsp;
            <asp:Button ID="multButton" runat="server" OnClick="multButton_Click" Text="x" />
&nbsp;&nbsp;
            <asp:Button ID="divButton" runat="server" OnClick="divButton_Click" Text="÷" />
        &nbsp;&nbsp;
            <asp:Button ID="exButton" runat="server" Text="X^Y" OnClick="exButton_Click" />
        </p>
        <p>
            <asp:Label ID="answerLabel" runat="server" BackColor="#99CCFF" Font-Size="Large"></asp:Label>
        </p>
    </form>
</body>
</html>
