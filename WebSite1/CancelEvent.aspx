<%@ Page Title="CancelEvent" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CancelEvent.aspx.cs" Inherits="CancelEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            left: -5px;
            top: -16px;
            height: 51px;
            margin-bottom: 0px;
        }
        .auto-style14 {
            left: -5px;
            top: -16px;
            height: 51px;
            margin-bottom: 0px;
            width: 318px;
        }
        .auto-style15 {
            width: 74px;
        }
        .auto-style16 {
            width: 318px;
        }
        .auto-style17 {
            width: 156px;
        }
        
    
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
      <div class="auto-style2">
        </div>
         
                
  <table class="auto-style9" >
                <caption><h2 class="auto-style11">Cancel Event</h2></caption>    
          <tr>
              <td class="auto-style16"></td>
              <td class="auto-style17"> <label for="event type">Event Type</label></td>
              <td class="auto-style15">
              <asp:DropDownList ID="DropDownList1" runat="server" Width="304px"></asp:DropDownList>
              </td>
               <td></td>             
          </tr>
           <tr>
              <td class="auto-style16"></td>
              <td class="auto-style17"><label for="name">Date</label> </td>
              <td class="auto-style8"><asp:DataList ID="DataList1" runat="server"></asp:DataList></td>
               <td></td>
          </tr>
         <tr>
             <td class="auto-style16">
             </td>
             <td class="auto-style17"><label for="time">Time</label></td>
        <td class="auto-style8"><input type="text" name="Time" value="" style="width: 298px" /><br /></td>
              <td></td>
             </tr>
            <tr>
                <td class="auto-style16">
                </td>
                <td class="auto-style17"><label for="Place">Place</label></td>
                <td class="auto-style8"><input type="text" name="Place" value="" style="width: 296px" /><br /></td>
                 <td></td>
            </tr>
        <tr>
            <td class="auto-style16">
            </td>
            <td class="auto-style17">
                 <label for="society">Society</label>
            </td>
            <td class="auto-style8">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="305px"></asp:DropDownList>
            </td>
             <td></td>
        </tr>
      <tr>
           <td class="auto-style14">

           </td>
          <td></td>
          <td style="text-align:right"> <button type="button" style="background-color:white;border-color:blueviolet;color: blueviolet;padding: 10px 32px;text-align: center;text-decoration-color: blueviolet;display: inline-block; font-size: 15px;
   ">Cancel</button></td>
          <td></td>
          
       </tr>
            </table>
</asp:Content>

