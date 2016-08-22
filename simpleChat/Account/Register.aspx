<%@ Page Language="C#" MasterPageFile="~/Views/Shared/FormLayout.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="simpleChat.Account.Register" %>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="head">
    <title>Register</title>

</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <div class="row" >
            <form id="form1" class="form" runat="server">

                <div class="row">
                    <div class="row-md-5">
                        <label>User Name : </label>
                    </div>
                    <div class="row-md-5">
                        <asp:TextBox ID="userName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="row-md-5">
                        <label>Password : </label>
                    </div>
                    <div class="row-md-5">
                        <asp:TextBox ID="password" runat="server" type="password" CssClass="form-control" TabIndex="1"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="row-md-5">
                        <label>Confirm Password : </label>
                    </div>
                    <div class="row-md-5">
                        <asp:TextBox ID="confirmPassword" runat="server" type="password" CssClass="form-control" TabIndex="2"></asp:TextBox>
                    </div>
                    <div class="row">

                        <div class="row-md-offset-5 row-md-5">
                            <asp:Label runat="server" ID="confirmPassMessage" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="center">
                        <asp:Button ID="Submit" OnClick="Submit_Click" runat="server" Text="Register" CssClass="btn btn-primary" TabIndex="3" />
                    </div>
                </div>

            </form>

            <br />
            <div class="row alert alert-danger" runat="server" id="errorMess">
                <asp:Label ID="errorMessages" runat="server" Text=""></asp:Label>
            </div>
        </div>

</asp:Content>

