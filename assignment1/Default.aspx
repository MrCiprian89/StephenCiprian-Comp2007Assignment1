<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" MasterPageFile="~/MasterPages/Frontend.Master" Inherits="assignment1.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Game Calculator</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    
    <div class="container">
        <form id="calculatorForm" runat="server">
            <div class="row">
                <div class="col-md-6 col-lg-3 game-container">
                    <h2>Game 1</h2>
                    <asp:Label  ID="resultLabel1" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Value="Win">Win</asp:ListItem>
                        <asp:ListItem Value="Lose">Lose</asp:ListItem>
                    </asp:RadioButtonList>
                    <div>
                        <asp:Label  ID="pointsScoredLabel1" runat="server" Text="Points Scored:"></asp:Label>
                        <asp:TextBox ID="pointsScoredTextBox1" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label  ID="pointsAllowedLabel1" runat="server" Text="Points Allowed:"></asp:Label>
                        <asp:TextBox ID="pointsAllowedTextBox1" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label  ID="spectatorsLabel1" runat="server" Text="Spectators:"></asp:Label>
                        <asp:TextBox ID="spectatorsTextBox1" runat="server"></asp:TextBox>
                    </div>
                </div><!-- /.game-container -->
                  <div class="col-md-6 col-lg-3 game-container">
                    <h2>Game 2</h2>
                    <asp:Label ID="resultLabel2" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                        <asp:ListItem Value="Win">Win</asp:ListItem>
                        <asp:ListItem Value="Lose">Lose</asp:ListItem>
                    </asp:RadioButtonList>
                    <div>
                        <asp:Label ID="pointsScoredLabel2" runat="server" Text="Points Scored:"></asp:Label>
                        <asp:TextBox ID="pointsScoredTextBox2" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="pointsAllowedLabel2" runat="server" Text="Points Allowed:"></asp:Label>
                        <asp:TextBox ID="pointsAllowedTextBox2" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="spectatorsLabel2" runat="server" Text="Spectators:"></asp:Label>
                        <asp:TextBox ID="spectatorsTextBox2" runat="server"></asp:TextBox>
                    </div>
                </div><!-- /.game-container -->
                  <div class="col-md-6 col-lg-3 game-container">
                    <h2>Game 3</h2>
                    <asp:Label ID="resultLabel3" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                        <asp:ListItem Value="Win">Win</asp:ListItem>
                        <asp:ListItem Value="Lose">Lose</asp:ListItem>
                    </asp:RadioButtonList>
                    <div>
                        <asp:Label ID="pointsScoredLabel3" runat="server" Text="Points Scored:"></asp:Label>
                        <asp:TextBox ID="pointsScoredTextBox3" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="pointsAllowedLabel3" runat="server" Text="Points Allowed:"></asp:Label>
                        <asp:TextBox ID="pointsAllowedTextBox3" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="spectatorsLabel3" runat="server" Text="Spectators:"></asp:Label>
                        <asp:TextBox ID="spectatorsTextBox3" runat="server"></asp:TextBox>
                    </div>
                </div><!-- /.game-container -->
                  <div class="col-md-6 col-lg-3 game-container">
                    <h2>Game 4</h2>
                    <asp:Label ID="resultLabel4" runat="server" Text="Result:"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList4" runat="server">
                        <asp:ListItem Value="Win">Win</asp:ListItem>
                        <asp:ListItem Value="Lose">Lose</asp:ListItem>
                    </asp:RadioButtonList>
                    <div>
                        <asp:Label ID="pointsScoredLabel4" runat="server" Text="Points Scored:"></asp:Label>
                        <asp:TextBox ID="pointsScoredTextBox4" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="pointsAllowedLabel4" runat="server" Text="Points Allowed:"></asp:Label>
                        <asp:TextBox ID="pointsAllowedTextBox4" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="spectatorsLabel4" runat="server" Text="Spectators:"></asp:Label>
                        <asp:TextBox ID="spectatorsTextBox4" runat="server"></asp:TextBox>
                    </div>
                </div><!-- /.game-container -->
            </div>
            <div id="buttonDiv">
            <asp:Button class="btn btn-primary btn-lg" ID="summaryButton" runat="server" Text="Summary" />
            </div>
        </form>
    </div>
</asp:Content>

