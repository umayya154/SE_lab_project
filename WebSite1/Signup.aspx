<%@ Page Title="Signup" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Front" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <div class="auto-style2">
        <table class="auto-style9" >
          <caption><h2 class="auto-style10">Signup</h2></caption>
          
          <tr>
              <td class="auto-style11"></td>
              <td class="auto-style12"> <label for="user type">User Type</label></td>
              <td class="auto-style8">
              <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="130px"></asp:DropDownList>
              </td>
              
          </tr>
           <tr>
              <td class="auto-style11"></td>
              <td class="auto-style12"><label for="name">Name</label> </td>
              <td class="auto-style8"><input type="text" name="Name" value="" /><br /></td>
              
          </tr>
         <tr>
             <td class="auto-style11">
             </td>
             <td class="auto-style12"><label for="registration number">Registration Number</label></td>
        <td class="auto-style8"><input type="text" name="Registration Number" value="" /><br /></td>
             </tr>
            <tr>
                <td class="auto-style11">
                </td>
                <td class="auto-style12"><label for="department">Department</label></td>
                <td class="auto-style8"><input type="text" name="Department" value="" /><br /></td>
            </tr>
        <tr>
            <td class="auto-style11">
            </td>
            <td class="auto-style12">
                 <label for="society">Society</label>
            </td>
            <td class="auto-style8">
            <asp:DropDownList ID="DropDownList2" runat="server" Width="124px"></asp:DropDownList>
                
            </td>
        </tr>
         <tr>
            <td class="auto-style11">
            </td>
            <td class="auto-style12">
                 <label for="home address">Home Address</label>
            </td>
            <td class="auto-style8">
                  <input type="text" name="Home Address" value="" /><br />
            </td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12"> <label for="phone number">Phone Number</label></td>
            <td class="auto-style8"><input type="text" name="Phone Number" value="" /><br /></td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12"> <label for="password">Password</label></td>
            <td class="auto-style8"> <input type="text" name="Passwprd" value="" /><br /></td>
        </tr>
       
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12"> <label for="confirm password">Confirm Password</label></td>
            <td class="auto-style8"> <input type="text" name="Confirm Password" value="" /><br /></td>
        </tr>
       <tr>
           <td>

           </td>
           <td class="auto-style12">

           </td>
           <td class="auto-style11">
               <button type="button">Register</button><br />
           </td>
       </tr>
            
    
       
         <tr>
             <td class="auto-style11">
                  <p>Already have an account.<a href ="#">Login</a></p>
             </td>
             <td class="auto-style12">
                
             </td>
             <td class="auto-style8">

             </td>
         </tr>
       
      </table>
              
    </div>
   
</asp:Content>

      <asp:Content ID="Content2" runat="server" contentplaceholderid="head">
          <style type="text/css">
              .auto-style8 {
                  width: 697px;
              }
              .auto-style9 {
                  width: 1255px;
              }
              .auto-style10 {
                  width: 1259px;
                  height: 30px;
              }
              .auto-style11 {
                  width: 306px;
              }
              .auto-style12 {
                  width: 382px;
              }
          </style>
</asp:Content>


      