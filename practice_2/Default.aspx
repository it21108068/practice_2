<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="practice_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8">
            <div class="card">
                <div class="card-header" style="text-align: center; font-weight: bold">User Detail Form</div>
                <div class="card-body">
                    <form>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>First Name</label>
                                    <asp:TextBox runat="server" ID="txt_fname" class="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Last Name</label>
                                    <asp:TextBox runat="server" ID="txt_Lname" class="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Age</label>
                                    <asp:TextBox runat="server" ID="txt_Age" class="form-control">30</asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-group">
                                     <label>Gender</label>
                                    <asp:DropDownList ID="ddl" runat="server" class="form-control">
                                        <asp:ListItem Value="-1" Text="Select Gender"></asp:ListItem>
                                        <asp:ListItem Value="0" Text="Male"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="Female"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            </div>

                        <div class="row">
                             <div class="col-md-6">
                                <div class="form-group">
                                    <label>Telephone Number</label>
                                    <asp:TextBox runat="server" ID="txt_Num" class="form-control"></asp:TextBox>
                                </div>
                            </div>

                             <div class="col-md-6">
                                    <label>Active</label>
                                    <asp:CheckBox ID="CheckBox1" runat="server"/>
                            </div>
                        </div>
                        <div class="row">
                             <div class="col-md-4"></div>
                            <div class="col-md-4">
                             <asp:Button runat="server" Text="Submit" ID="btn_submit" class="btn btn-primary col-md-12" OnClick="btn_submit_Click"/>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
