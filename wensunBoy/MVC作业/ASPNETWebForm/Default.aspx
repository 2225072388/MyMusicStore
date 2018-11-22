<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200px">
    </asp:DropDownList>

    <br />

    <br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="774px" AllowPaging="True" DataKeyNames="ID" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" PageSize="18" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:BoundField DataField="StudentNo" HeaderText="学号" >
            <ControlStyle Width="120px" />
            </asp:BoundField>
            <asp:BoundField DataField="FullName" HeaderText="姓名" >
            <ControlStyle Width="120px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="学院">
                <EditItemTemplate>
                    <asp:DropDownList ID="DdlDepartMents" runat="server" Height="16px" Width="142px">
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LbLDepartMents" runat="server" ForeColor="#FFCC99" Text='<%# GetName(Eval("Department")) %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle Width="15%" />
            </asp:TemplateField>
            <asp:BoundField DataField="Phone" HeaderText="电话" >
            <ControlStyle Height="120px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="维护操作" ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="编辑"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" OnClientClick="return confirm('你真的要删除我吗？');"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
</asp:Content>