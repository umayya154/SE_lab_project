<%@ Page Title="Forgot Password" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <table class="auto-style8" >
          <caption><h2 class="auto-style10">Forgot Password</h2></caption>
          <tr>
              <td class="auto-style15"></td>
              <td class="auto-style13"> <label for="new password">New Password</label></td>
              <td class="auto-style11"> <input type="text" name="New Password" value="" /><br /></td>
        
          </tr>
        <tr>
              <td class="auto-style15"></td>
              <td class="auto-style13"><label for="password">Confirm Password</label></td>
              <td class="auto-style11"><input type="text" name="Confirm Password" value="" /><br /></td>
              
          </tr>
        <tr>
              <td class="auto-style14">

              </td>
              <td class="auto-style9">

              </td>
              <td class="auto-style9">
                   <button type="button" style="background-color:white;border-color:blueviolet;color: blueviolet;padding: 10px 32px;text-align: center;text-decoration-color: blueviolet;display: inline-block; font-size: 15px;
   ">Reset Password</button>
                 
              
                  </td>
              
          </tr> 
        </table>

</asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style8 {
        width: 1253px;
    }
    .auto-style9 {
        height: 18px;
    }
    .auto-style10 {
        width: 1246px;
    }
    .auto-style11 {
        height: 109px;
        width: 63px;
    }
    .auto-style13 {
        height: 109px;
        width: 66px;
    }
    .auto-style14 {
        height: 18px;
        width: 80px;
    }
    .auto-style15 {
        width: 80px;
    }
</style>
</asp:Content>



