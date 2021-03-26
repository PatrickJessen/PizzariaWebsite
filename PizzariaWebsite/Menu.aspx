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
        <div>
            <fieldset class="TopHeader">
                <h1>Pizzaria</h1>
            </fieldset>
        </div>
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container-fluid">
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link" href="Default.aspx"><b>Home</b></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="Menu.aspx"><b>Menu</b></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="MyPage.Aspx"><b>My Page</b></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Cart.Aspx"><b>Cart</b></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Login.Aspx"><b>Login</b></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Contact.Aspx"><b>Contact</b></a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="menucontainer" id="menu">
            <h1 class="MenuTitle">Menu</h1>
            <div class="content">
                <asp:GridView ID="MenuGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="PizzaID" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="PizzaID" HeaderText="Nr." ReadOnly="True" InsertVisible="False" SortExpression="PizzaID"></asp:BoundField>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"></asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="AddToCart" Text="AddToCart" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:PizzaDBConnectionString %>' SelectCommand="SELECT [PizzaID], [Name], [Price] FROM [Pizza]"></asp:SqlDataSource>
            </div>
        </div>
    </form>
</body>
</html>
