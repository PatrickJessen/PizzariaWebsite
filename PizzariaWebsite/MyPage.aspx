<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="PizzariaWebsite.MyPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
        <div class="Mypage-container">
            <div class="Mypage-content">
                <h3 style="color:#fff; text-align:center;">This is Mypage here you can see all your information and order history</h3>
                <asp:Image ImageUrl="assets/AvatarLogin.png" ID="avatarLoginImg" runat="server" Visible="false" />
                <p>FirstName: <asp:Label ID="MypageFirstName" runat="server" Visible="false" /></p>
                <p>LastName: <asp:Label ID="MyPageLastName" runat="server" Visible="false" /></p>
                
                <p>Phone number: <asp:Label ID="MyPageNumber" runat="server" Visible="false" /></p>
                
                <p>Adress: <asp:Label ID="MyPageAdresse" runat="server" Visible="false" /></p>
            </div>
        </div>
  </form>
</body>
</html>
