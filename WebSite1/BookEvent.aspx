<%@ Page Title="BookEvent" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookEvent.aspx.cs" Inherits="BookEvent" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="auto-style2">
  <table class="auto-style9" >
                <caption><h2 class="auto-style10">Book Event</h2></caption>    
          <tr>
              <td class="auto-style15"></td>
              <td class="auto-style19"> <label for="event type">Event Type</label></td>
              <td class="auto-style17">
              <asp:DropDownList ID="DropDownList1" runat="server" Width="254px"></asp:DropDownList>
              </td>
               <td></td>
              
          </tr>
           <tr>
              <td class="auto-style11"></td>
              <td class="auto-style20"><label for="name">Date</label> </td>
              <td class="auto-style21"></td>
               <td></td>
          </tr>
         <tr>
             <td class="auto-style11">
             </td>
             <td class="auto-style20"><label for="time">Time</label></td>
        <td class="auto-style21"><input type="text" name="Time" value="" class="auto-style13" /><br /></td>
              <td></td>
             </tr>
            <tr>
                <td class="auto-style11">
                </td>
                <td class="auto-style20"><label for="Place">Place</label></td>
                <td class="auto-style21"><input type="text" name="Place" value="" class="auto-style14" /><br /></td>
                 <td></td>
            </tr>
        <tr>
            <td class="auto-style11">
            </td>
            <td class="auto-style20">
                 <label for="society">Society</label>
            </td>
            <td class="auto-style21">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="255px"></asp:DropDownList>
            </td>
             <td></td>
        </tr>
            
         <tr>
             
            <td class="auto-style11">
                 &nbsp;</td>
            <td class="auto-style20">
                
                
                 <label for="Image">Event Poster</label>
            </td>
            <td class="auto-style21">
                
                            </td>
              <td></td>
        </tr>
       <tr>
           <td class="auto-style11"></td>
            <td class="auto-style20"></td>
           <td class="auto-style21">
               <button type="button" style="background-color:white;border-color:blueviolet;color: blueviolet;padding: 10px 32px;text-align: center;text-decoration-color: blueviolet;display: inline-block; font-size: 15px;
   ">Upload Image</button></td>
              
           <td></td>
       </tr>
      <tr>
          <td class="auto-style11"></td>
          <td class="auto-style20"></td>
          <td class="auto-style21"><asp:Button ID="Button2" runat="server" Text="Confirm" Width="118px" /></td>
           <td></td>
      </tr>
         <tr>
             <td class="auto-style11">
                  <a href ="#">Event Detail</a>
             </td>
             <td class="auto-style20">
                 <a href ="#">Back</a>
             </td>
             <td class="auto-style21">

             </td>
              <td></td>
         </tr>
       
      </table>
              
    </div>
   

</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style9 {
            width: 1243px;
        }
        .auto-style11 {
        width: 476px;
    }
        .auto-style13 {
        width: 244px;
    }
    .auto-style14 {
        width: 246px;
    }
    .auto-style15 {
        width: 476px;
        height: 48px;
    }
    .auto-style17 {
        width: 712px;
        height: 48px;
    }
    .auto-style19 {
        width: 359px;
        height: 48px;
    }
    .auto-style20 {
        width: 359px;
    }
    .auto-style21 {
        width: 712px;
    }
    </style>
</asp:Content>


