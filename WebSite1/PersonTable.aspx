<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PersonTable.aspx.cs" Inherits="PersonTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div>  <table style="width:100%"> <caption><h2>Persons</h2></caption>
  <tr>
    <th>Person Type</th>
      <th>Name</th>
    <th>Registration No</th> 
    <th>Society</th>
      <th>Address</th>
      <th>Phone No</th>
  </tr>
  <tr>
    <td>Volunteer</td>
    <td>Smith</td> 
    <td>2016-cs-1</td>
      <td>UET NEWS</td> 
      <td>UET</td> 
      <td>0900101033</td> 
  </tr>
  <tr>
      <td>Volunteer</td>
    <td>Amna</td> 
    <td>2016-cs-2</td>
      <td>Blood Donor Society</td> 
      <td>UET</td> 
      <td>0900101888</td> 
    
  </tr>
  <tr>
      <td>Volunteer</td>
    <td>Asad</td> 
    <td>2016-cs-12</td>
      <td>Dramatic Society</td> 
      <td>UET</td> 
      <td>0300101888</td> 
    
  </tr>
</table>    
        </div>
</asp:Content>

