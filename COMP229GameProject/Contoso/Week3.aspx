<%@ Page Title="Week 3" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Week3.aspx.cs" Inherits="COMP229GameProject.Week3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container-fluid">
    <div class="row">
        <div class="col-md-offset-2 col-md-8">
            <div class="jumbotron" id="content" runat="server">
                
                <asp:GridView ID="CricketsGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table table-bordered table-striped table-hover">
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
