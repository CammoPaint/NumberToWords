<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NumberToWords.Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>NumberToWords</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/custom.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server" Width="100%">
        <nav class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">NumberToWords</a>
                </div>
                <div id="navbar" class="collapse navbar-collapse">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="#">Home</a></li>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
        </nav>

        <div class="container">
            <h1>Convert Number to Words</h1>
            <p class="lead">Use this page to convert decimal numbers into words.</p>
            <div class="well">
                <div class="form">
                    <div class="form-group">
                        <label>Number to convert (e.g. 127.34)</label>
                        <asp:TextBox ID="txtNumber" placeholder="Number" class="form-control" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="valNumberRange" ControlToValidate="txtNumber" runat="server" MinimumValue="0" MaximumValue="2147483647" Type="Double" ErrorMessage="Please enter a valid number range"></asp:RangeValidator>
                    </div>
                    <asp:Button ID="btnConvert" runat="server" CssClass="btn btn-primary" Text="Convert" OnClick="btnConvert_Click" />
                </div>
                <h1 class="uppercase"><asp:Label ID="lblResult" runat="server" Text=""></asp:Label></h1>
            </div>

        </div>
        <!-- /.container -->

        <script src="Scripts/jquery-1.9.1.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>

    </form>
</body>
</html>
