<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="PizzariaWebsite.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js" integrity="sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0" crossorigin="anonymous"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <title>Pizzaria</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <img src="assets/logo.png"  class="logo"/>
            <ul>
                <li><a href="Default.aspx">Home</a></li>
                <li><a href="Menu.aspx">Menu</a></li>
                <li><a href="MyPage.Aspx">My Page</a></li>
                <li><a href="Cart.Aspx">Cart</a></li>
                <li><a href="Login.Aspx">Login</a></li>
                <li><a href="Contact.Aspx">Contact</a></li>
            </ul>
        </div>
        <div class="menucontainer" id="menu">
            <div class="Menucontent">
                <h1 style="color:white">Menuen</h1>
                <asp:GridView ID="MenuGrid" runat="server" AutoGenerateColumns="False" Height="750px" Width="550px">
                    <Columns>
                        <asp:BoundField DataField="PizzaID" HeaderText="Nr." ReadOnly="True" InsertVisible="False" SortExpression="PizzaID"></asp:BoundField>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"></asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button CssClass="AddToCartBtn" ID="AddToCart"  Text="AddToCart" runat="server" OnClick="AddToCart_Click"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <%--<asp:GridView ID="ToppingGrid" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="TopID" HeaderText="TopID" ReadOnly="True" InsertVisible="false" SortExpression="TopID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Cheese" HeaderText="Cheese" SortExpression="Cheese"></asp:BoundField>
                        <asp:BoundField DataField="Onion" HeaderText="Onion" SortExpression="Onion"></asp:BoundField>
                        <asp:BoundField DataField="Meatsauce" HeaderText="Meatsauce" SortExpression="Meatsauce"></asp:BoundField>
                        <asp:BoundField DataField="Chilli" HeaderText="Chilli" SortExpression="Chilli"></asp:BoundField>
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"></asp:BoundField>
                    </Columns>
                </asp:GridView>--%>
                
            </div>
        </div>
    </form>
</body>
</html>
