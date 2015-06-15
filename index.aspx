<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="index.aspx.cs" Inherits="tx_documentviewer_style.index" %>

<%@ Register assembly="TXDocumentServer, Version=22.0.800.500,
    Culture=neutral, PublicKeyToken=6b83fe9a75cfb638" namespace="TXTextControl.DocumentServer.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DocumentViewer Style Sample</title>
    <link href="DocumentViewer.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <cc1:DocumentViewer ID="DocumentViewer1"
                    runat="server" Height="400px" Width="795px" />
            </ContentTemplate>
        </asp:UpdatePanel>
            
    </div>
    </form>
</body>
</html>
