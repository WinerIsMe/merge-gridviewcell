<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MergeRow.aspx.cs" Inherits="Nmtree.Demo.MergeRow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="gv_origin">
            <h3>原始的GridView</h3>
            <asp:GridView ID="gvOrigin" runat="server" AutoGenerateColumns="false"
                OnRowDataBound="gvOrigin_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="姓名" />
                    <asp:BoundField DataField="Item" HeaderText="工资项" />
                    <asp:BoundField DataField="SubItem" HeaderText="工资子项" />
                    <asp:BoundField DataField="Month" HeaderText="月份" />
                    <asp:BoundField DataField="Money" HeaderText="金额" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="gv_merge">
            <h3>连续列合并行的GridView</h3>
            <asp:GridView ID="gvMerge" runat="server" AutoGenerateColumns="false"
                OnRowDataBound="gvOrigin_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="姓名" />
                    <asp:BoundField DataField="Item" HeaderText="工资项" />
                    <asp:BoundField DataField="SubItem" HeaderText="工资子项" />
                    <asp:BoundField DataField="Month" HeaderText="月份" />
                    <asp:BoundField DataField="Money" HeaderText="金额" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="gv_merge">
            <h3>指定列合并行的GridView</h3>
            <asp:GridView ID="gvMerge1" runat="server" AutoGenerateColumns="false"
                OnRowDataBound="gvOrigin_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="姓名" />
                    <asp:BoundField DataField="Item" HeaderText="工资项" />
                    <asp:BoundField DataField="SubItem" HeaderText="工资子项" />
                    <asp:BoundField DataField="Month" HeaderText="月份" />
                    <asp:BoundField DataField="Money" HeaderText="金额" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="gv_merge">
            <h3>指定列合并行的GridView</h3>
            <asp:GridView ID="gvMerge2" runat="server" AutoGenerateColumns="false"
                OnRowDataBound="gvOrigin_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="姓名" />
                    <asp:BoundField DataField="Item" HeaderText="工资项" />
                    <asp:BoundField DataField="SubItem" HeaderText="工资子项" />
                    <asp:BoundField DataField="Month" HeaderText="月份" />
                    <asp:BoundField DataField="Money" HeaderText="金额" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
