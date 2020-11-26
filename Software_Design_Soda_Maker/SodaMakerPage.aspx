<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SodaMakerPage.aspx.cs" Inherits="Software_Design_Soda_Maker.SodaMakerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Soda Maker"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblNozzleTitle" runat="server" Text="Nozzle status: "></asp:Label>
            <asp:Label ID="lblNozzle" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblIndicatorTitle" runat="server" Text="Indicator: "></asp:Label>
            <asp:Label ID="lblIndicator" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCupSize" runat="server" Text="Cup Size"></asp:Label>
            &nbsp;
            <asp:Label ID="lblSelectedCup" runat="server" Text="Pick One"></asp:Label>
            <br />
            <asp:Button ID="btnSmall" runat="server" Text="Small" OnClick="btnSmall_Click" />
            <asp:Button ID="btnMedium" runat="server" Text="Medium" OnClick="btnMedium_Click" />
            <asp:Button ID="btnLarge" runat="server" OnClick="btnLarge_Click" Text="Large" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Button ID="btnDispense" runat="server" OnClick="btnDispense_Click" Text="Dispense" />
            <br />
            <br />
            <asp:Button ID="btnTakeCup" runat="server" OnClick="btnTakeCup_Click" Text="Take Cup" Visible="False" />
            <br />
            <br />
            <asp:Label ID="lblCStorage" runat="server" Text="Cup Storage"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Small"></asp:Label>
&nbsp;<asp:Label ID="lblSmallCups" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
