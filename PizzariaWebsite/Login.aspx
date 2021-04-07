<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PizzariaWebsite.Login" %>

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
                <a class="nav-link" href="Menu.aspx"><b>Menu</b></a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="MyPage.Aspx"><b>My Page</b></a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="Cart.Aspx"><b>Cart</b></a>
              </li>
              <li class="nav-item">
                <a class="nav-link active" aria-current="page" href="Login.Aspx"><b>Login</b></a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="Contact.Aspx"><b>Contact</b></a>
              </li>
            </ul>
          </div>
        </div>
      </nav>
      <div class="container">
        <fieldset class="grid">
          <legend>Login</legend>
          <div class="container">
            <label for="uname"><b>Username</b></label>
            <input id="username" runat="server" type="text" placeholder="Enter Username" name="uname" required>

            <p></p>

            <label for="psw"><b>Password</b></label>
            <input id="password" runat="server" type="password" placeholder="Enter Password" name="psw" required>

            <p></p>

            <asp:Button type="button" ID="LoginButton" Text="Login" OnClick="LoginButton_Click"/>

            <label>
              <input type="checkbox" checked="checked" name="remember"> Remember
            </label>

            <p></p>

            <span class="psw">Forgot <a href="">Click here</a></span>
          </div>
        </fieldset>
        <div>
          <img src="assets/AvatarLogin.png" style="position:fixed; right: 60%; bottom:60%; width:200px; height:200px; border:none"> 
        </div>
      </div>
  </form>
</body>
</html>
