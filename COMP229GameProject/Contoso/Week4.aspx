<%@ Page Title="Week 4" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Week4.aspx.cs" Inherits="COMP229GameProject.Departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="container-fluid">
    <div class="row">
        <div class="col-md-offset-2 col-md-8">
            <div class="jumbotron" id="content" runat="server">
                
                <asp:GridView ID="CricketsGridView" runat="server" AutoGenerateColumns="false">
              <Columns>
                <asp:BoundField DataField="Team1" HeaderText="Team1" Visible="true" />
                    <asp:BoundField DataField="Team2" HeaderText="Team2" Visible="true"/>
                <asp:BoundField DataField="Team1Score" HeaderText="Team1 Score" Visible="true"/>
                <asp:BoundField DataField="Team2Score" HeaderText="Team2 Score" Visible="true" />
            </Columns>
        </asp:GridView>


            </div>
        </div>
    </div>
</div>
</asp:Content>
