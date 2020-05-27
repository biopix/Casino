<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GamePage.aspx.cs" Inherits="Casino.Views.Home.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/mystyle.css" rel="stylesheet" type="text/css" runat="server" />
    <style type="text/css">
        .auto-style1 {
            width: 870px;
            height: 542px;
            z-index: -1;
            left: 12px;
            top: 20px;
            position: absolute;

        }
        
        .button {
            display: inline-block;
            padding: 15px 25px;
            font-size: 24px;
            cursor: pointer;
            text-align: center;
            text-decoration: none;
            outline: none;
            color: #fff;
            background-color: #3b5998;
            border: none;
            border-radius: 15px;
            box-shadow: 0 9px #999;
        }

        .button:hover {background-color: #8c353a}

        .button:active {
            background-color: #3b5998;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }

        .dealButton {
            background-color: #3b5998;
            border: none;
            color: white;
            padding: 16px 32px;
            text-align: center;
            font-size: 16px;
            margin: 4px 2px;
            opacity: 0.6;
            transition: 0.3s;
            display: inline-block;
            text-decoration: none;
            cursor: pointer;
        }

            .dealButton:hover {opacity: 1}

    </style>
</head>
<body>
    <form id="form1" runat="server">
      
    
        <div>
        <asp:ImageButton ID="coin100" ImageUrl="~/Content/coins/100coin.png" runat="server" Height="50px" Width="50px" style="                z-index: 1;
                left: 21px;
                top: 435px;
                position: absolute
        " />
        <asp:ImageButton ID="coin50"  ImageUrl="~/Content/coins/50coin.png" runat="server" Height="50px" Width="50px" style=" z-index: 1; left: 78px; top: 458px; position: absolute; right: 1447px"  />
        <asp:ImageButton ID="coin25" ImageUrl="~/Content/coins/25coin.png" runat="server" Height="50px" Width="50px" style="z-index: 1; left: 137px; top: 479px; position: absolute"/>
        <asp:ImageButton ID="coin10"  ImageUrl="~/Content/coins/10coin.png" runat="server" Height="50px" Width="50px" style="z-index: 1; left: 195px; top: 492px; position: absolute"/>
    
            <img class="auto-style1" src="../../Content/backGround/topRed.png" /></div>

        
        <asp:Button CssClass="button" ID="btnStart" Text="Start"  OnClientClick="btnStart_Click"

            runat="server"  style="z-index: 1; left: 371px; top: 225px; position: absolute; 
            text-align: center; height: 52px; width: 150px" />


        <asp:Button CssClass="dealButton" ID="btnDeal" runat="server" Text="Deal" 
            style="z-index: 1; left: 611px; top: 464px;
        position: absolute; width: 87px" />

        <asp:Button CssClass="dealButton" ID="btnHit" runat="server" Text="Hit"
            style="z-index: 1; left: 699px; top: 464px; position: absolute;
        width: 87px; right: 760px" />

        <asp:Button CssClass="dealButton" ID="btnStand" runat="server" Text="Stand"
            style="z-index: 1; left: 787px; top: 464px; position: absolute; width: 87px" />
        <asp:ImageButton ID="btnExit" runat="server" ImageUrl="~/Content/backGround/exit.png" style="z-index: 2; left: 794px; top: 44px; position: absolute; height: 78px; width: 80px" />


        <asp:Label ID="lblBid" runat="server" Text="Bid" style="z-index: 1; left: 435px; top: 332px;
        position: absolute"></asp:Label>


        <asp:label ID="lblCash" BackColor="white" runat="server" Text="500" style="z-index: 1; left:
            671px; top: 525px; position: absolute; width: 119px;"></asp:label>
      
    
      
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
