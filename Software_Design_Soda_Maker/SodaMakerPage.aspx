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
            <br />
            <asp:Button ID="btnSmall" runat="server" Text="Small" OnClick="btnSmall_Click" Visible="False" />
            <asp:Button ID="btnMedium" runat="server" Text="Medium" OnClick="btnMedium_Click" />
            <asp:Button ID="btnLarge" runat="server" OnClick="btnLarge_Click" Text="Large" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnDispense" runat="server" OnClick="btnDispense_Click" Text="Dispense" />
            <br />
        </div>
    </form>
</body>
</html>
