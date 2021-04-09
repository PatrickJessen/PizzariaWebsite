<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="PizzariaWebsite.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <link rel="stylesheet" href="Style.css"/>
    <link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
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
                <li><a href="Login.Aspx">Login</a></li>
                <li><a href="Contact.Aspx">Contact</a></li>
            </ul>
        </div>
      <div class="login-box">
          <h1>Registre</h1>
          <img src="assets/AvatarLogin.png" />
          <div class="textbox">
             <i class="fa fa-user"></i>
            <label for="uname"><b>Username</b></label>
            <input id="username" runat="server" type="text" placeholder="Enter Username" name="uname" required>

            <p></p>
            <i class="fa fa-lock"></i>
            <label for="psw"><b>Password</b></label>
            <input id="password" runat="server" type="password" placeholder="Enter Password" name="psw" required>

            <p></p>
            <label for="firstName"><b>First name</b></label>
            <input id="fName" runat="server" type="text" placeholder="Enter First name" name="fName" required>

            <p></p>
            <label for="lastName"><b>Last name</b></label>
            <input id="lName" runat="server" type="text" placeholder="Enter Last name" name="lName" required>

            <p></p>
            <label for="phoneNr"><b>Phone Number</b></label>
            <input id="phoneNr" runat="server" type="text" placeholder="Enter Phone number" name="phoneNr">

            <p></p>
            <label for="adress"><b>Adress</b></label>
              <p></p>
            <input id="adress" runat="server" type="text" placeholder="Enter Adress" name="adress" required>

            <p></p>

            <asp:Button type="button" runat="server" ID="RegBtn" Text="Registre" OnClick="RegBtn_Click"/>
          </div>
      </div>
  </form>
</body>
</html>
