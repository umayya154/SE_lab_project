<%@ Page Title="Login" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="p1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <table class="auto-style9" >
          <caption><h2 class="auto-style10">Login</h2></caption>
          
          <tr>
              <td class="auto-style12"></td>
              <td class="auto-style13"> <label for="user type">User Name</label></td>
              <td class="auto-style11"> <input type="text" name="User Name" value="" /><br /></td>
      

              
          </tr>
           <tr>
              <td class="auto-style12"></td>
              <td class="auto-style13"><label for="name">Password</label></td>
              <td class="auto-style11"><input type="text" name="Password" value="" /><br /></td>
              
          </tr>
         
         <tr>
             <td>

             </td>
             <td class="auto-style13">
                 <p>Remember me?<input type ="checkbox" name ="Remember me" value ="" /></p>
             </td>
             <td>

             </td>
         </tr>
         
          <tr>
              <td class="auto-style12">

              </td>
              <td class="auto-style13">

              </td>
              <td class="auto-style11">
                 <button type="button" style="background-color:white;border-color:blueviolet;color: blueviolet;padding: 10px 32px;text-align: center;text-decoration-color: blueviolet;display: inline-block; font-size: 15px;
   ">LOGIN</button>
              
                  </td>
              
          </tr>
         <tr>
             <td>
                 
    
             </td>
             <td class="auto-style13">
                 <a href ="Forgot Password.aspx">Forgot Password</a>
             </td>
         </tr>
      </table>
     
    
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style9 {
            width: 1256px;
            height: 236px;
        }
        .auto-style10 {
            width: 1248px;
            height: 39px;
        }
        .auto-style11 {
            width: 838px;
        }
        .auto-style12 {
            width: 139px;
        }
        .auto-style13 {
            width: 500px;
        }
    </style>
</asp:Content>


