<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PizzariaWebsite.Contact" %>

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
        <div class="contact-container">
            <div class="contact-content">
                <h1>About Us</h1>

                <p>
                    We started this Italian restaurant in March 2021 with a goal of being able to deliver the best pizzas around to the people..
               So far we have had great success.. It is possible for customers to order food directly from our website, after which we can deliver the food or they can come and pick up the food themselves.
                We have an ambition to be able to develop and make our business bigger.
                </p>

                <h1>Employee of the month</h1>
                <p style="text-align: center" class="Contactimg">
                    <img src="assets/employee.jpg" />
                </p>
                <p style="text-align: center" class="employeetxt">Janni is our employee of this month</p>
            </div>
            <h1>Contact Us</h1>
            <div class="contact-info">
                <div class="contact-opening">
                    <h3>Opening times</h3>
                    <ul>
                        <li>Mandag: 12:00 - 20:00</li>
                        <li>Tirsdag: 12:00 - 20:00</li>
                        <li>Onsdag: 12:00 - 20:00</li>
                        <li>Torsdag: 12:00 - 20:00</li>
                        <li>Fredag: 12:00 - 20:00</li>
                        <li>Lørdag: 13:00 - 21:00</li>
                        <li>Søndag: 13:00 - 21:00</li>
                    </ul>
                </div>
                <div class="contacts">
                    <h3>Contact Information</h3>
                    <ul>
                        <li>Email: Gruppe3Pizza@test.dk</li>
                        <li>Tlf: +4512345678</li>
                        <li>Adresse: Gruppe3vej 14 1234 Sjælland</li>
                    </ul>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
