<%@ Page Title="AssignTask" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="taskassign.aspx.cs" Inherits="taskassign" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat ="server">

     <div class="auto-style3">
     
  </div>
      <table class="auto-style9" >
          <caption><h2 class="auto-style10">AssignTask</h2></caption>
          
          <tr>
              <td class="auto-style14"></td>
              <td class="auto-style16"> <label for ="UserName">User Name/Registraton Number</label></td>
              <td class="auto-style17"><input type ="text" name="Registraton Number" value="" /><br /></td>
              <td></td>
          </tr>
           <tr>
              <td class="auto-style14"></td>
              <td class="auto-style16"> <label for ="Email Address">Email Address</label></td>
              <td class="auto-style17"><input type ="text" name="Email Address" value="" /><br /></td>
                 <td></td>         
          </tr>
          <tr>
              <td class="auto-style14"></td>
              <td class="auto-style16"> <label for ="Email Content">Task</label></td>
              <td class="auto-style17"><input type ="text" name="Email Content" value="" class="auto-style13" /><br /></td>
              <td></td>
          </tr>
          <tr>
              <td class="auto-style14">

              </td>
              <td class="auto-style16">

              </td>
              <td class="auto-style17">
              <asp:Button ID="Button1" runat="server" Text="Send" Width="143px" />
                  </td>
              <td></td>
          </tr>
      </table>
     
  </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style9 {
            width: 1253px;
            height: 300px;
        }
        .auto-style10 {
            width: 1255px;
        }
        .auto-style13 {
        height: 56px;
        width: 246px;
    }
        .auto-style14 {
        width: 371px;
    }
    .auto-style16 {
        width: 236px;
    }
    .auto-style17 {
        width: 254px;
    }
    </style>
</asp:Content>
