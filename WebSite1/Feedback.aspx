<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            width: 408px;
        }
        .auto-style12 {
            width: 310px;
        }
        .auto-style14 {
            width: 192px;
            height: 170px;
            margin-left: 0px;
        }
        .auto-style15 {
            width: 200px;
        }
    .auto-style16 {
        left: -5px;
        top: -16px;
        height: 84px;
        margin-bottom: 0px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="auto-style2">
        <table class="auto-style9" >
          <caption><h2 class="auto-style16">Feedback</h2></caption>
           <tr>
              <td class="auto-style11"></td>
              <td class="auto-style12"><label for="name">Give Your Feedback</label> </td>
              <td class="auto-style15"><input type="text" name="feedback" value="" class="auto-style14" /><br /></td>
              <td>

              </td>
          </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>

            </tr>
            <tr>
                <td class="auto-style11"> </td>
          <td class="auto-style12"></td>
          <td style="text-align:right" class="auto-style15"> <button type="button" style="background-color:white;border-color:blueviolet;color: blueviolet;padding: 10px 32px;text-align: center;text-decoration-color: blueviolet;display: inline-block; font-size: 15px;
   ">Save</button>          </td>
          <td></td>
            </tr>
            </table>
        </div>
</asp:Content>

