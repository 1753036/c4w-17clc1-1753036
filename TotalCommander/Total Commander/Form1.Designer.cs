namespace Total_Commander
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultTextEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublimeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenFIlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
            this.tsb_view = new System.Windows.Forms.ToolStripButton();
            this.tsb_list = new System.Windows.Forms.ToolStripButton();
            this.tsb_detail = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeleteF8 = new System.Windows.Forms.Button();
            this.buttonNewFolderF7 = new System.Windows.Forms.Button();
            this.buttonMoveF6 = new System.Windows.Forms.Button();
            this.lv_left_view = new System.Windows.Forms.ListView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.renameContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_right_view = new System.Windows.Forms.ListView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCopyF5 = new System.Windows.Forms.Button();
            this.buttonEditF4 = new System.Windows.Forms.Button();
            this.buttonViewF3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.leftComboBox = new System.Windows.Forms.ComboBox();
            this.leftLabelInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rightComboBox = new System.Windows.Forms.ComboBox();
            this.rightLabelInfo = new System.Windows.Forms.Label();
            this.leftAddressBar = new System.Windows.Forms.TextBox();
            this.rightAddressBar = new System.Windows.Forms.TextBox();
            this.mainMenuBar.SuspendLayout();
            this.mainToolBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mainMenuBar.Name = "mainMenuBar";
            this.mainMenuBar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenuBar.Size = new System.Drawing.Size(1162, 28);
            this.mainMenuBar.TabIndex = 3;
            this.mainMenuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.newFolderToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewContextMenu_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyContextMenu_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.moveToolStripMenuItem.Text = "Cut";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveContextMenu_Click);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderContextMenu_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteContextMenu_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultTextEditorToolStripMenuItem,
            this.hiddenFIlesToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // defaultTextEditorToolStripMenuItem
            // 
            this.defaultTextEditorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.sublimeTextToolStripMenuItem});
            this.defaultTextEditorToolStripMenuItem.Name = "defaultTextEditorToolStripMenuItem";
            this.defaultTextEditorToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.defaultTextEditorToolStripMenuItem.Text = "Default Text Editor";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // sublimeTextToolStripMenuItem
            // 
            this.sublimeTextToolStripMenuItem.Name = "sublimeTextToolStripMenuItem";
            this.sublimeTextToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.sublimeTextToolStripMenuItem.Text = "Sublime Text";
            this.sublimeTextToolStripMenuItem.Click += new System.EventHandler(this.sublimeTextToolStripMenuItem_Click);
            // 
            // hiddenFIlesToolStripMenuItem
            // 
            this.hiddenFIlesToolStripMenuItem.Name = "hiddenFIlesToolStripMenuItem";
            this.hiddenFIlesToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.hiddenFIlesToolStripMenuItem.Text = "Hidden FIles";
            this.hiddenFIlesToolStripMenuItem.Click += new System.EventHandler(this.hiddenFIlesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // mainToolBar
            // 
            this.mainToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_view,
            this.tsb_list,
            this.tsb_detail,
            this.toolStripButton4});
            this.mainToolBar.Location = new System.Drawing.Point(0, 28);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.Size = new System.Drawing.Size(1162, 27);
            this.mainToolBar.TabIndex = 4;
            this.mainToolBar.Text = "toolStrip1";
            // 
            // tsb_view
            // 
            this.tsb_view.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_view.Image = ((System.Drawing.Image)(resources.GetObject("tsb_view.Image")));
            this.tsb_view.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_view.Name = "tsb_view";
            this.tsb_view.Size = new System.Drawing.Size(24, 24);
            this.tsb_view.Text = "View";
            this.tsb_view.Click += new System.EventHandler(this.tsb_view_Click);
            // 
            // tsb_list
            // 
            this.tsb_list.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_list.Image = ((System.Drawing.Image)(resources.GetObject("tsb_list.Image")));
            this.tsb_list.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_list.Name = "tsb_list";
            this.tsb_list.Size = new System.Drawing.Size(24, 24);
            this.tsb_list.Text = "List";
            this.tsb_list.Click += new System.EventHandler(this.tsb_list_Click);
            // 
            // tsb_detail
            // 
            this.tsb_detail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_detail.Image = ((System.Drawing.Image)(resources.GetObject("tsb_detail.Image")));
            this.tsb_detail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_detail.Name = "tsb_detail";
            this.tsb_detail.Size = new System.Drawing.Size(24, 24);
            this.tsb_detail.Text = "Details";
            this.tsb_detail.Click += new System.EventHandler(this.tsb_detail_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Refresh";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lv_left_view, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lv_right_view, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 126);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 402);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.buttonDeleteF8, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonNewFolderF7, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonMoveF6, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(579, 341);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(567, 57);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // buttonDeleteF8
            // 
            this.buttonDeleteF8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteF8.Location = new System.Drawing.Point(382, 4);
            this.buttonDeleteF8.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteF8.Name = "buttonDeleteF8";
            this.buttonDeleteF8.Size = new System.Drawing.Size(181, 49);
            this.buttonDeleteF8.TabIndex = 4;
            this.buttonDeleteF8.Text = "Delete (F8)";
            this.buttonDeleteF8.UseVisualStyleBackColor = true;
            this.buttonDeleteF8.Click += new System.EventHandler(this.buttonDeleteF8_Click);
            // 
            // buttonNewFolderF7
            // 
            this.buttonNewFolderF7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewFolderF7.Location = new System.Drawing.Point(193, 4);
            this.buttonNewFolderF7.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewFolderF7.Name = "buttonNewFolderF7";
            this.buttonNewFolderF7.Size = new System.Drawing.Size(181, 49);
            this.buttonNewFolderF7.TabIndex = 3;
            this.buttonNewFolderF7.Text = "New Folder (F7)";
            this.buttonNewFolderF7.UseVisualStyleBackColor = true;
            this.buttonNewFolderF7.Click += new System.EventHandler(this.buttonNewFolderF7_Click);
            // 
            // buttonMoveF6
            // 
            this.buttonMoveF6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveF6.Location = new System.Drawing.Point(4, 4);
            this.buttonMoveF6.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveF6.Name = "buttonMoveF6";
            this.buttonMoveF6.Size = new System.Drawing.Size(181, 49);
            this.buttonMoveF6.TabIndex = 2;
            this.buttonMoveF6.Text = "Move (F6)";
            this.buttonMoveF6.UseVisualStyleBackColor = true;
            this.buttonMoveF6.Click += new System.EventHandler(this.buttonMoveF6_Click);
            // 
            // lv_left_view
            // 
            this.lv_left_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_left_view.ContextMenuStrip = this.contextMenu;
            this.lv_left_view.Location = new System.Drawing.Point(3, 2);
            this.lv_left_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_left_view.Name = "lv_left_view";
            this.lv_left_view.Size = new System.Drawing.Size(569, 333);
            this.lv_left_view.TabIndex = 0;
            this.lv_left_view.UseCompatibleStateImageBehavior = false;
            this.lv_left_view.View = System.Windows.Forms.View.Details;
            this.lv_left_view.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListView_AfterEdit);
            this.lv_left_view.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
            this.lv_left_view.Enter += new System.EventHandler(this.leftListView_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewContextMenu,
            this.editContextMenu,
            this.copyContextMenu,
            this.cutContextMenu,
            this.pasteContextMenu,
            this.newFolderContextMenu,
            this.deleteContextMenu,
            this.renameContextMenu});
            this.contextMenu.Name = "mainMenu";
            this.contextMenu.Size = new System.Drawing.Size(155, 196);
            // 
            // viewContextMenu
            // 
            this.viewContextMenu.Name = "viewContextMenu";
            this.viewContextMenu.Size = new System.Drawing.Size(154, 24);
            this.viewContextMenu.Text = "View";
            this.viewContextMenu.Click += new System.EventHandler(this.viewContextMenu_Click);
            // 
            // editContextMenu
            // 
            this.editContextMenu.Name = "editContextMenu";
            this.editContextMenu.Size = new System.Drawing.Size(154, 24);
            this.editContextMenu.Text = "Edit";
            this.editContextMenu.Click += new System.EventHandler(this.editContextMenu_Click);
            // 
            // copyContextMenu
            // 
            this.copyContextMenu.Name = "copyContextMenu";
            this.copyContextMenu.Size = new System.Drawing.Size(154, 24);
            this.copyContextMenu.Text = "Copy";
            this.copyContextMenu.Click += new System.EventHandler(this.copyContextMenu_Click);
            // 
            // cutContextMenu
            // 
            this.cutContextMenu.Name = "cutContextMenu";
            this.cutContextMenu.Size = new System.Drawing.Size(154, 24);
            this.cutContextMenu.Text = "Cut";
            this.cutContextMenu.Click += new System.EventHandler(this.moveContextMenu_Click);
            // 
            // pasteContextMenu
            // 
            this.pasteContextMenu.Name = "pasteContextMenu";
            this.pasteContextMenu.Size = new System.Drawing.Size(154, 24);
            this.pasteContextMenu.Text = "Paste";
            this.pasteContextMenu.Click += new System.EventHandler(this.pasteContextMenu_Click);
            // 
            // newFolderContextMenu
            // 
            this.newFolderContextMenu.Name = "newFolderContextMenu";
            this.newFolderContextMenu.Size = new System.Drawing.Size(154, 24);
            this.newFolderContextMenu.Text = "New Folder";
            this.newFolderContextMenu.Click += new System.EventHandler(this.newFolderContextMenu_Click);
            // 
            // deleteContextMenu
            // 
            this.deleteContextMenu.Name = "deleteContextMenu";
            this.deleteContextMenu.Size = new System.Drawing.Size(154, 24);
            this.deleteContextMenu.Text = "Delete";
            this.deleteContextMenu.Click += new System.EventHandler(this.deleteContextMenu_Click);
            // 
            // renameContextMenu
            // 
            this.renameContextMenu.Name = "renameContextMenu";
            this.renameContextMenu.Size = new System.Drawing.Size(154, 24);
            this.renameContextMenu.Text = "Rename";
            this.renameContextMenu.Click += new System.EventHandler(this.renameContextMenu_Click);
            // 
            // lv_right_view
            // 
            this.lv_right_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_right_view.ContextMenuStrip = this.contextMenu;
            this.lv_right_view.Location = new System.Drawing.Point(578, 2);
            this.lv_right_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_right_view.Name = "lv_right_view";
            this.lv_right_view.Size = new System.Drawing.Size(569, 333);
            this.lv_right_view.TabIndex = 1;
            this.lv_right_view.UseCompatibleStateImageBehavior = false;
            this.lv_right_view.View = System.Windows.Forms.View.Details;
            this.lv_right_view.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListView_AfterEdit);
            this.lv_right_view.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
            this.lv_right_view.Enter += new System.EventHandler(this.rightListView_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonCopyF5, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonEditF4, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonViewF3, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 341);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(567, 57);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // buttonCopyF5
            // 
            this.buttonCopyF5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyF5.Location = new System.Drawing.Point(382, 4);
            this.buttonCopyF5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCopyF5.Name = "buttonCopyF5";
            this.buttonCopyF5.Size = new System.Drawing.Size(181, 49);
            this.buttonCopyF5.TabIndex = 3;
            this.buttonCopyF5.Text = "Copy (F5)";
            this.buttonCopyF5.UseVisualStyleBackColor = true;
            this.buttonCopyF5.Click += new System.EventHandler(this.buttonCopyF5_Click);
            // 
            // buttonEditF4
            // 
            this.buttonEditF4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditF4.Location = new System.Drawing.Point(193, 4);
            this.buttonEditF4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditF4.Name = "buttonEditF4";
            this.buttonEditF4.Size = new System.Drawing.Size(181, 49);
            this.buttonEditF4.TabIndex = 2;
            this.buttonEditF4.Text = "Edit (F4)";
            this.buttonEditF4.UseVisualStyleBackColor = true;
            this.buttonEditF4.Click += new System.EventHandler(this.buttonEditF4_Click);
            // 
            // buttonViewF3
            // 
            this.buttonViewF3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewF3.Location = new System.Drawing.Point(4, 4);
            this.buttonViewF3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewF3.Name = "buttonViewF3";
            this.buttonViewF3.Size = new System.Drawing.Size(181, 49);
            this.buttonViewF3.TabIndex = 1;
            this.buttonViewF3.Text = "View (F3)";
            this.buttonViewF3.UseVisualStyleBackColor = true;
            this.buttonViewF3.Click += new System.EventHandler(this.buttonViewF3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftAddressBar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.rightAddressBar, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 59);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1306, 62);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.58824F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.41177F));
            this.tableLayoutPanel3.Controls.Add(this.leftComboBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.leftLabelInfo, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(379, 30);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // leftComboBox
            // 
            this.leftComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftComboBox.FormattingEnabled = true;
            this.leftComboBox.Location = new System.Drawing.Point(3, 2);
            this.leftComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftComboBox.Name = "leftComboBox";
            this.leftComboBox.Size = new System.Drawing.Size(108, 24);
            this.leftComboBox.TabIndex = 0;
            this.leftComboBox.SelectedIndexChanged += new System.EventHandler(this.leftComboBox_SelectedIndexChanged);
            // 
            // leftLabelInfo
            // 
            this.leftLabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftLabelInfo.AutoSize = true;
            this.leftLabelInfo.Location = new System.Drawing.Point(118, 0);
            this.leftLabelInfo.Name = "leftLabelInfo";
            this.leftLabelInfo.Size = new System.Drawing.Size(46, 30);
            this.leftLabelInfo.TabIndex = 1;
            this.leftLabelInfo.Text = "label1";
            this.leftLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.28169F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.71831F));
            this.tableLayoutPanel4.Controls.Add(this.rightComboBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rightLabelInfo, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(653, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(379, 30);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // rightComboBox
            // 
            this.rightComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rightComboBox.FormattingEnabled = true;
            this.rightComboBox.Location = new System.Drawing.Point(3, 2);
            this.rightComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightComboBox.Name = "rightComboBox";
            this.rightComboBox.Size = new System.Drawing.Size(108, 24);
            this.rightComboBox.TabIndex = 0;
            this.rightComboBox.SelectedIndexChanged += new System.EventHandler(this.rightComboBox_SelectedIndexChanged);
            // 
            // rightLabelInfo
            // 
            this.rightLabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rightLabelInfo.AutoSize = true;
            this.rightLabelInfo.Location = new System.Drawing.Point(117, 0);
            this.rightLabelInfo.Name = "rightLabelInfo";
            this.rightLabelInfo.Size = new System.Drawing.Size(46, 30);
            this.rightLabelInfo.TabIndex = 1;
            this.rightLabelInfo.Text = "label2";
            this.rightLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // leftAddressBar
            // 
            this.leftAddressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftAddressBar.Location = new System.Drawing.Point(3, 33);
            this.leftAddressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftAddressBar.Name = "leftAddressBar";
            this.leftAddressBar.ReadOnly = true;
            this.leftAddressBar.Size = new System.Drawing.Size(647, 22);
            this.leftAddressBar.TabIndex = 2;
            this.leftAddressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddressBar_Click);
            this.leftAddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leftAddressBar_KeyDown);
            this.leftAddressBar.Leave += new System.EventHandler(this.AddressBar_Leave);
            // 
            // rightAddressBar
            // 
            this.rightAddressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightAddressBar.Location = new System.Drawing.Point(656, 33);
            this.rightAddressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightAddressBar.Name = "rightAddressBar";
            this.rightAddressBar.ReadOnly = true;
            this.rightAddressBar.Size = new System.Drawing.Size(647, 22);
            this.rightAddressBar.TabIndex = 3;
            this.rightAddressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddressBar_Click);
            this.rightAddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rightAddressBar_KeyDown);
            this.rightAddressBar.Leave += new System.EventHandler(this.AddressBar_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 549);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainToolBar);
            this.Controls.Add(this.mainMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(798, 596);
            this.Name = "Form1";
            this.Text = "Total Commander";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyPress);
            this.mainMenuBar.ResumeLayout(false);
            this.mainMenuBar.PerformLayout();
            this.mainToolBar.ResumeLayout(false);
            this.mainToolBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolBar;
        private System.Windows.Forms.ToolStripButton tsb_view;
        private System.Windows.Forms.ToolStripButton tsb_list;
        private System.Windows.Forms.ToolStripButton tsb_detail;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListView lv_left_view;
        private System.Windows.Forms.ListView lv_right_view;
        private System.Windows.Forms.TextBox leftAddressBar;
        private System.Windows.Forms.TextBox rightAddressBar;
        private System.Windows.Forms.ComboBox leftComboBox;
        private System.Windows.Forms.Label leftLabelInfo;
        private System.Windows.Forms.ComboBox rightComboBox;
        private System.Windows.Forms.Label rightLabelInfo;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem viewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cutContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newFolderContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem renameContextMenu;
        private System.Windows.Forms.ToolStripMenuItem defaultTextEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiddenFIlesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonCopyF5;
        private System.Windows.Forms.Button buttonEditF4;
        private System.Windows.Forms.Button buttonViewF3;
        private System.Windows.Forms.Button buttonNewFolderF7;
        private System.Windows.Forms.Button buttonMoveF6;
        private System.Windows.Forms.Button buttonDeleteF8;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublimeTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}

