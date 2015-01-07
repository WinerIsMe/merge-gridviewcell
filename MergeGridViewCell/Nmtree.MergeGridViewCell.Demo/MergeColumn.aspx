<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MergeColumn.aspx.cs" Inherits="Nmtree.Demo.MergeColumn" %>

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
            <h3>原始GridView</h3>
            <asp:GridView ID="gvBefore" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="First" HeaderText="一级指标" />
                    <asp:BoundField DataField="Second" HeaderText="二级指标" />
                    <asp:BoundField DataField="Third" HeaderText="二级指标" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="gv_merge">
            <h3>合并行列的GridView</h3>
            <asp:GridView ID="gvAfter" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="First" HeaderText="一级指标" />
                    <asp:BoundField DataField="Second" HeaderText="二级指标" />
                    <asp:BoundField DataField="Third" HeaderText="二级指标" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
