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
            <asp:Label ID="lblCupSize" runat="server" Text="Cup Size:"></asp:Label>
            &nbsp;
            <asp:Label ID="lblSelectedCup" runat="server" Text="Pick One"></asp:Label>
            <br />
            <asp:Button ID="btnSmall" runat="server" Text="Small" OnClick="btnSmall_Click" />
            <asp:Button ID="btnMedium" runat="server" Text="Medium" OnClick="btnMedium_Click" />
            <asp:Button ID="btnLarge" runat="server" OnClick="btnLarge_Click" Text="Large" />
            <br />
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
            <br />
            <asp:Label ID="Label1" runat="server" Text="Small:"></asp:Label>
&nbsp;<asp:Label ID="lblSmallCups" runat="server" Text="0"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAddSmall" runat="server" Height="33px" OnClick="btnAddSmall_Click" Text="+" Width="35px" />
            <br />
            <br />
            <asp:Label ID="lblMed" runat="server" Text="Medium: "></asp:Label>
            <asp:Label ID="lblMedCups" runat="server" Text="0"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAddMedium" runat="server" Height="33px" Text="+" Width="35px" OnClick="btnAddMedium_Click" />
            <br />
            <br />
            <asp:Label ID="lblLg" runat="server" Text="Large:"></asp:Label>
&nbsp;<asp:Label ID="lblLgCups" runat="server" Text="0"></asp:Label>
            &nbsp;
            <asp:Button ID="btnAddLg" runat="server" Height="33px" Text="+" Width="35px" OnClick="btnAddLg_Click" />
            <br />
            <br />
            <asp:Label ID="lblIngredients" runat="server" Text="Ingredient Storage"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblWater" runat="server" Text="Water Source Pressure: "></asp:Label>
            <asp:Label ID="lblWaterPress" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCo2" runat="server" Text="CO2 Tank Pressure:"></asp:Label>
            <asp:Label ID="lblCo2Press" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblSyrupTitle" runat="server" Text="Syrup Levels: "></asp:Label>
&nbsp;<asp:Label ID="lblSyrupLevels" runat="server" Text="0"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAddSyrup" runat="server" Height="33px" Text="+" Width="35px" OnClick="btnAddSyrup_Click" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
