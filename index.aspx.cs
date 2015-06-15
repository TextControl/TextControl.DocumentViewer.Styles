using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tx_documentviewer_style
{
    public partial class index : System.Web.UI.Page
    {
        private TXTextControl.DocumentServer.DocumentController documentController1;
        private TXTextControl.ServerTextControl serverTextControl1;
        private System.ComponentModel.IContainer components;
    
        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            DocumentViewer1.DocumentController = documentController1;
            DocumentViewer1.LoadDocument(Server.MapPath("documents/Demo.rtf"), TXTextControl.DocumentServer.FileFormat.RichTextFormat);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.documentController1 = new TXTextControl.DocumentServer.DocumentController(this.components);
            this.serverTextControl1 = new TXTextControl.ServerTextControl();
            // 
            // documentController1
            // 
            this.documentController1.TextComponent = this.serverTextControl1;
            // 
            // serverTextControl1
            // 
            this.serverTextControl1.SpellChecker = null;

        }
    }
}