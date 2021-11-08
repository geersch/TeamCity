<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SearchModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>People Finder</h2>

    <% using (Html.BeginForm("Index", "Home", FormMethod.Post)) { %>
       <%: Html.LabelFor(m => m.LastName) %>
       <%= Html.TextBoxFor(m => m.LastName) %>
       <%: Html.ValidationMessageFor(m => m.LastName) %>
       <input type="submit" value="Search" />
    <% } %>
    <br />

    <% if (Model.People != null) { %>

    <table>
    <% foreach (var person in Model.People) { %>
    <tr>
      <td><%: person.Id %></td>
      <td><%: person.Firstname %></td>
      <td><%: person.Lastname %></td>
    </tr>
    <% } %>
    </table>

    <% } %>
</asp:Content>
