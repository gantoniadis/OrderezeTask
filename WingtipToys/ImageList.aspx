	<%@ Page Title="Images" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ImageList.aspx.cs" Inherits="WingtipToys.ImageList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="imageList" runat="server" 
                DataKeyNames="Id" GroupItemCount="5"
                ItemType="WingtipToys.Models.Image" SelectMethod="GetImages">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ImageDetails.aspx?Id=<%#:Item.Id%>">
                                        <img src="/Catalog/Images/<%#:Item.ImagePath%>"
                                            width="100" height="75" style="border: solid" />
                                    </a>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ImageDetails.aspx?Id=<%#:Item.Id%>">
                                        <span>
                                            <%#:Item.Name%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Description: </b><%#:String.Format("{0:c}", Item.Description)%>
                                    </span>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>