<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzariaWebsite.Default" %>

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
            <img src="assets/logo.png" class="logo" />
            <ul>
                <li><a href="Default.aspx">Home</a></li>
                <li><a href="Menu.aspx">Menu</a></li>
                <li><a href="MyPage.Aspx">My Page</a></li>
                <li><a href="Cart.Aspx">Cart</a></li>
                <li><a href="Login.Aspx" id="LoginPage" runat="server">Login</a></li>
                <li><a href="Contact.Aspx">Contact</a></li>
            </ul>
        </div>
        <div class="MainPageContent">
            <h1>Welcome to Pizzariet</h1>
            <p>Here with us, we care very much about Italian food and quality. We serve Italian ingredients with fantastic taste. You can see our large selection of pizzas by clicking the Menu button, you can also read more about us by clicking the About Us button<br />
                <strong style="font-weight:bold">IMPORTANT!!! Remember to sign in first, before you order your pizza</strong>
            </p>
            <div>
                <a href="Menu.aspx" class="MainPagebutton">Menu</a>
                <a href="Contact.aspx" class="MainPagebutton">About Us</a>
            </div>
        </div>
    </form>
</body>
</html>
