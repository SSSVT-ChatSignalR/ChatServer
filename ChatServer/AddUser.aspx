<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="ChatServer.AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <input type="text" name="Nick" placeholder="Přezdívka" />
        <input type="text" name="Password" placeholder="Heslo" />
        <br />
        <input type="text" name="Name" placeholder="Jméno" />
        <input type="text" name="Surname" placeholder="Příjmení" />
        <br />
        <input type="text" name="Age" placeholder="Věk" />
        <input type="text" name="Email" placeholder="Email" />
        <br />
        <input type="submit" value="Vytvořit" />
    </form>
</body>
</html>
