<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PizzariaWebsite.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js" integrity="sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0" crossorigin="anonymous"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <title>Pizzaria</title>
    <style type="text/css">
        .contact-info {
            height: 90px;
            margin-left: 0px;
            margin-top: 0px;
        }
    </style>
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
                    Vi startede denne italienske restaurant Marts 2021 med et mål om at kunne levere de bedste pizzaer rundt til folket.
                Indtil videre har vi haft stor succes. Det er muligt for kunderne at bestille mad direkte fra vores hjemmesiden, hvorefter vi kan udbringe maden eller de kan komme og hente maden selv.
                Vi har en ambition om at kunne udvikle og gøre vores forretning større.
                </p>

                <h1>Employee of the month</h1>
                <p style="text-align: center" class="Contactimg">
                    <img src="assets/employee.jpg" />
                </p>
                <p style="text-align: center" class="employeetxt">Janni is our employee of this month</p>
            </div>
            <h1>Contact Us</h1>
            <div class="contact-opening-time">
                <h3>Åbningstider</h3>
                <ul>
                    <li>Mandag 11:00 - 21:00</li>
                    <li>Tirsdag 11:00 - 21:00</li>
                    <li>Onsdag 11:00 - 21:00</li>
                    <li>Torsdag 11:00 - 21:00</li>
                    <li>Fredag 11:00 - 21:00</li>
                    <li>Lørdag 13:00 - 21:00</li>
                    <li>Søndag 13:00 - 21:00</li>
                </ul>
            </div>
            <div class="contact-info">
                <h3>Contact Information</h3>
                <ul>
                    <li>E-mail: Gruppe3@test.dk</li>
                    <li>Tlf: +4512345678</li>
                    <li>Butik: Gruppetrevej 1 1234 Sjælland</li>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>
