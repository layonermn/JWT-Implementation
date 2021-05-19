<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApiSegura.Principal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">

            <asp:UpdatePanel runat="server" ID="UpdatePanel_TOKEN">
                <ContentTemplate>
                    <div class="col-md-12">
                        <span>Data:</span>
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode ="Password" />
                        <br />
                        <div style="float:left">
                            <asp:Button ID="btnConsumir" Text="Consumir" runat="server" CssClass="btn btn-sm btn-primary" OnClick="btnConsumir_Click" style="float:left"/> 
                            <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="UpdatePanel_TOKEN" style="float:left; margin-left:10px">
                                <ProgressTemplate>  
                                    <img src="Images/Gif/progreso2.gif" width="30" height="30"/>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </div>
                        <br />
                        <span>Respuesta Token:</span>
                        <asp:TextBox ID="txtResultado" runat="server" CssClass="form-control" TextMode ="MultiLine" Height="100"/>  
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </div>

</asp:Content>
