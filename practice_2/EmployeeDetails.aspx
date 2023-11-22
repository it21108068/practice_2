<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="practice_2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
   
   <div class="card">
       <div class="card-header" style="text-align:center; font-weight:bolder; font-size:16px;">Employee Details Submission Form</div>
           <div class="card-body">
                <div class="row">
                    <div class="col-md-6 form-group">
                        <label>Employee ID</label>
                        <asp:TextBox ID="txtEid" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6 form-group">
                        <label>Employee Name</label>
                        <asp:TextBox ID="txtEname" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>

                 <div class="row">
                    <div class="col-md-6 form-group">
                        <label>Department</label>
                        <select class="form-control" id="selectDep">
                            <option>Finanace Department</option>
                            <option>HR Department</option>
                            <option>Logistic Department</option>
                        </select>
                    </div>
                    <div class="col-md-6 form-group">
                        <label>Working Type</label>
                        <select class="form-control" id="selectType">
                            <option>Full-time</option>
                            <option>Part-time</option>
                        </select>
                    </div>
                </div>

               <div class="row">
                    <div class="col-md-6 form-group">
                        <label>Working Hours</label>
                        <asp:TextBox ID="txtHrs" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6 form-group">
                        <label>Payment Per Hour</label>
                        <asp:TextBox ID="txtPay" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
               
               <div class="row">
                   <div class="col-md-4"></div>
                      <div class="col-md-4">
                           <asp:Button ID="btn1" runat="server" Text="submit" class="btn btn-primary col-md-4" OnClick="btn_submit_Click" />
                      </div>
                   </div>
            
 
           </div>
      

   </div>
</asp:Content>
