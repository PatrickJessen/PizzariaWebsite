<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="PizzariaWebsite.Checkout" %>

<!DOCTYPE html>

<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="Style.css"/>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl" crossorigin="anonymous"/>
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
                <li><a href="Login.Aspx" id="LoginPage" runat="server">Login</a></li>
                <li><a href="Contact.Aspx">Contact</a></li>
            </ul>
        </div>
      <div class="CheckoutPayment">
          <label>Credit card number</label>
          <asp:TextBox ID="cardNumber" runat="server" TextMode="Number" ></asp:TextBox>
      <p>
          <label>Expire date<asp:TextBox ID="cardExpire" runat="server" ></asp:TextBox>
          </label>
      </p>
      <p>
          <label>CVV code</label><asp:TextBox ID="cardCVV" runat="server" TextMode="Number" ></asp:TextBox>
      </p>
      <asp:Button ID="BuyPizza" runat="server" Text="Buy" OnClick="BuyPizza_Click"/>
      </div>
  </form>
</body>
</html>
