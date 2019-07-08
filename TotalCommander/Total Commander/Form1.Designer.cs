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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tsb_view = new System.Windows.Forms.ToolStripButton();
            this.tsb_list = new System.Windows.Forms.ToolStripButton();
            this.tsb_detail = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lv_left_view = new System.Windows.Forms.ListView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.renameContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_right_view = new System.Windows.Forms.ListView();
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
            this.contextMenu.SuspendLayout();
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
            this.mainMenuBar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenuBar.Size = new System.Drawing.Size(806, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mainToolBar
            // 
            this.mainToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.tsb_view,
            this.tsb_list,
            this.tsb_detail});
            this.mainToolBar.Location = new System.Drawing.Point(0, 24);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.Size = new System.Drawing.Size(806, 27);
            this.mainToolBar.TabIndex = 4;
            this.mainToolBar.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Back";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Forward";
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
            this.tsb_detail.Text = "Detail";
            this.tsb_detail.Click += new System.EventHandler(this.tsb_detail_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.lv_left_view, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lv_right_view, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 102);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 520);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lv_left_view
            // 
            this.lv_left_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_left_view.ContextMenuStrip = this.contextMenu;
            this.lv_left_view.Location = new System.Drawing.Point(2, 2);
            this.lv_left_view.Margin = new System.Windows.Forms.Padding(2);
            this.lv_left_view.Name = "lv_left_view";
            this.lv_left_view.Size = new System.Drawing.Size(389, 516);
            this.lv_left_view.TabIndex = 0;
            this.lv_left_view.UseCompatibleStateImageBehavior = false;
            this.lv_left_view.View = System.Windows.Forms.View.Details;
            this.lv_left_view.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListView_AfterEdit);
            this.lv_left_view.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
            this.lv_left_view.Enter += new System.EventHandler(this.leftListView_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.copyContextMenu,
            this.cutContextMenu,
            this.pasteContextMenu,
            this.newFolderContextMenu,
            this.deleteContextMenu,
            this.renameContextMenu});
            this.contextMenu.Name = "mainMenu";
            this.contextMenu.Size = new System.Drawing.Size(135, 180);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // copyContextMenu
            // 
            this.copyContextMenu.Name = "copyContextMenu";
            this.copyContextMenu.Size = new System.Drawing.Size(134, 22);
            this.copyContextMenu.Text = "Copy";
            this.copyContextMenu.Click += new System.EventHandler(this.copyContextMenu_Click);
            // 
            // cutContextMenu
            // 
            this.cutContextMenu.Name = "cutContextMenu";
            this.cutContextMenu.Size = new System.Drawing.Size(134, 22);
            this.cutContextMenu.Text = "Cut";
            this.cutContextMenu.Click += new System.EventHandler(this.cutContextMenu_Click);
            // 
            // pasteContextMenu
            // 
            this.pasteContextMenu.Name = "pasteContextMenu";
            this.pasteContextMenu.Size = new System.Drawing.Size(134, 22);
            this.pasteContextMenu.Text = "Paste";
            this.pasteContextMenu.Click += new System.EventHandler(this.pasteContextMenu_Click);
            // 
            // newFolderContextMenu
            // 
            this.newFolderContextMenu.Name = "newFolderContextMenu";
            this.newFolderContextMenu.Size = new System.Drawing.Size(134, 22);
            this.newFolderContextMenu.Text = "New Folder";
            this.newFolderContextMenu.Click += new System.EventHandler(this.newFolderContextMenu_Click);
            // 
            // deleteContextMenu
            // 
            this.deleteContextMenu.Name = "deleteContextMenu";
            this.deleteContextMenu.Size = new System.Drawing.Size(134, 22);
            this.deleteContextMenu.Text = "Delete";
            this.deleteContextMenu.Click += new System.EventHandler(this.deleteContextMenu_Click);
            // 
            // renameContextMenu
            // 
            this.renameContextMenu.Name = "renameContextMenu";
            this.renameContextMenu.Size = new System.Drawing.Size(134, 22);
            this.renameContextMenu.Text = "Rename";
            this.renameContextMenu.Click += new System.EventHandler(this.renameContextMenu_Click);
            // 
            // lv_right_view
            // 
            this.lv_right_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_right_view.ContextMenuStrip = this.contextMenu;
            this.lv_right_view.Location = new System.Drawing.Point(395, 2);
            this.lv_right_view.Margin = new System.Windows.Forms.Padding(2);
            this.lv_right_view.Name = "lv_right_view";
            this.lv_right_view.Size = new System.Drawing.Size(389, 516);
            this.lv_right_view.TabIndex = 1;
            this.lv_right_view.UseCompatibleStateImageBehavior = false;
            this.lv_right_view.View = System.Windows.Forms.View.Details;
            this.lv_right_view.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListView_AfterEdit);
            this.lv_right_view.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
            this.lv_right_view.Enter += new System.EventHandler(this.rightListView_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 48);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 50);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(284, 24);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // leftComboBox
            // 
            this.leftComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftComboBox.FormattingEnabled = true;
            this.leftComboBox.Location = new System.Drawing.Point(2, 2);
            this.leftComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.leftComboBox.Name = "leftComboBox";
            this.leftComboBox.Size = new System.Drawing.Size(82, 21);
            this.leftComboBox.TabIndex = 0;
            this.leftComboBox.SelectedIndexChanged += new System.EventHandler(this.leftComboBox_SelectedIndexChanged);
            // 
            // leftLabelInfo
            // 
            this.leftLabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftLabelInfo.AutoSize = true;
            this.leftLabelInfo.Location = new System.Drawing.Point(88, 0);
            this.leftLabelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leftLabelInfo.Name = "leftLabelInfo";
            this.leftLabelInfo.Size = new System.Drawing.Size(35, 24);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(393, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(284, 24);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // rightComboBox
            // 
            this.rightComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rightComboBox.FormattingEnabled = true;
            this.rightComboBox.Location = new System.Drawing.Point(2, 2);
            this.rightComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.rightComboBox.Name = "rightComboBox";
            this.rightComboBox.Size = new System.Drawing.Size(82, 21);
            this.rightComboBox.TabIndex = 0;
            this.rightComboBox.SelectedIndexChanged += new System.EventHandler(this.rightComboBox_SelectedIndexChanged);
            // 
            // rightLabelInfo
            // 
            this.rightLabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rightLabelInfo.AutoSize = true;
            this.rightLabelInfo.Location = new System.Drawing.Point(88, 0);
            this.rightLabelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightLabelInfo.Name = "rightLabelInfo";
            this.rightLabelInfo.Size = new System.Drawing.Size(35, 24);
            this.rightLabelInfo.TabIndex = 1;
            this.rightLabelInfo.Text = "label2";
            this.rightLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // leftAddressBar
            // 
            this.leftAddressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftAddressBar.Location = new System.Drawing.Point(2, 27);
            this.leftAddressBar.Margin = new System.Windows.Forms.Padding(2);
            this.leftAddressBar.Name = "leftAddressBar";
            this.leftAddressBar.ReadOnly = true;
            this.leftAddressBar.Size = new System.Drawing.Size(389, 20);
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
            this.rightAddressBar.Location = new System.Drawing.Point(395, 27);
            this.rightAddressBar.Margin = new System.Windows.Forms.Padding(2);
            this.rightAddressBar.Name = "rightAddressBar";
            this.rightAddressBar.ReadOnly = true;
            this.rightAddressBar.Size = new System.Drawing.Size(389, 20);
            this.rightAddressBar.TabIndex = 3;
            this.rightAddressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddressBar_Click);
            this.rightAddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rightAddressBar_KeyDown);
            this.rightAddressBar.Leave += new System.EventHandler(this.AddressBar_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 639);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainToolBar);
            this.Controls.Add(this.mainMenuBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(604, 495);
            this.Name = "Form1";
            this.Text = "Total Commander";
            this.mainMenuBar.ResumeLayout(false);
            this.mainMenuBar.PerformLayout();
            this.mainToolBar.ResumeLayout(false);
            this.mainToolBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cutContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newFolderContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem renameContextMenu;
    }
}

