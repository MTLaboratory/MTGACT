namespace MTGAM;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.components = new System.ComponentModel.Container();
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.TC_Main = new TabControl();
        this.TP_Config = new TabPage();
        this.B_Reload = new Button();
        this.B_SaveChanges = new Button();
        this.L_Script = new Label();
        this.L_Version = new Label();
        this.L_Author = new Label();
        this.L_Name = new Label();
        this.TB_Script = new TextBox();
        this.CB_ValidPath = new CheckBox();
        this.TB_PluginRoot = new TextBox();
        this.TB_Description = new TextBox();
        this.TB_Version = new TextBox();
        this.TB_Author = new TextBox();
        this.TB_Name = new TextBox();
        this.TP_Scripts = new TabPage();
        this.panel1 = new Panel();
        this.button1 = new Button();
        this.label2 = new Label();
        this.button7 = new Button();
        this.button6 = new Button();
        this.label1 = new Label();
        this.CB_ScriptType = new ComboBox();
        this.PB_Coverage = new ProgressBar();
        this.CLB_Scripts = new CheckedListBox();
        this.CMS_Script = new ContextMenuStrip(this.components);
        this.TSMI_NewScript = new ToolStripMenuItem();
        this.toolStripSeparator3 = new ToolStripSeparator();
        this.TSMI_OpenScript = new ToolStripMenuItem();
        this.TSMI_DeleteScript = new ToolStripMenuItem();
        this.toolStripSeparator2 = new ToolStripSeparator();
        this.TSMI_EnableScript = new ToolStripMenuItem();
        this.TSMI_DisableScript = new ToolStripMenuItem();
        this.TSCB_ScriptType = new ToolStripComboBox();
        this.MS_Controls = new MenuStrip();
        this.TSMI_Addon = new ToolStripMenuItem();
        this.TSMI_New = new ToolStripMenuItem();
        this.TSMI_NewAddon = new ToolStripMenuItem();
        this.toolStripSeparator1 = new ToolStripSeparator();
        this.TSMI_NewSingleton = new ToolStripMenuItem();
        this.TSMI_NewType = new ToolStripMenuItem();
        this.TSS_0 = new ToolStripSeparator();
        this.TSMI_Save = new ToolStripMenuItem();
        this.TSMI_Load = new ToolStripMenuItem();
        this.TSS_1 = new ToolStripSeparator();
        this.TSMI_Package = new ToolStripMenuItem();
        this.TSMI_Edit = new ToolStripMenuItem();
        this.TSMI_IncVer = new ToolStripMenuItem();
        this.majorToolStripMenuItem = new ToolStripMenuItem();
        this.minorToolStripMenuItem = new ToolStripMenuItem();
        this.revisionToolStripMenuItem = new ToolStripMenuItem();
        this.TSMI_DecVer = new ToolStripMenuItem();
        this.majorToolStripMenuItem1 = new ToolStripMenuItem();
        this.minorToolStripMenuItem1 = new ToolStripMenuItem();
        this.revisionToolStripMenuItem1 = new ToolStripMenuItem();
        this.TSS_2 = new ToolStripSeparator();
        this.TSMI_Tools = new ToolStripMenuItem();
        this.TSMI_Links = new ToolStripMenuItem();
        this.TSMI_GAL = new ToolStripMenuItem();
        this.gitToolStripMenuItem = new ToolStripMenuItem();
        this.toolStripTextBox1 = new ToolStripTextBox();
        this.TSMI_RunGitCommand = new ToolStripMenuItem();
        this.TSMI_Exit = new ToolStripMenuItem();
        this.TC_Main.SuspendLayout();
        this.TP_Config.SuspendLayout();
        this.TP_Scripts.SuspendLayout();
        this.panel1.SuspendLayout();
        this.CMS_Script.SuspendLayout();
        this.MS_Controls.SuspendLayout();
        this.SuspendLayout();
        // 
        // TC_Main
        // 
        this.TC_Main.Controls.Add(this.TP_Config);
        this.TC_Main.Controls.Add(this.TP_Scripts);
        this.TC_Main.Dock = DockStyle.Fill;
        this.TC_Main.Location = new Point(0, 24);
        this.TC_Main.Name = "TC_Main";
        this.TC_Main.SelectedIndex = 0;
        this.TC_Main.Size = new Size(384, 437);
        this.TC_Main.TabIndex = 0;
        // 
        // TP_Config
        // 
        this.TP_Config.Controls.Add(this.B_Reload);
        this.TP_Config.Controls.Add(this.B_SaveChanges);
        this.TP_Config.Controls.Add(this.L_Script);
        this.TP_Config.Controls.Add(this.L_Version);
        this.TP_Config.Controls.Add(this.L_Author);
        this.TP_Config.Controls.Add(this.L_Name);
        this.TP_Config.Controls.Add(this.TB_Script);
        this.TP_Config.Controls.Add(this.CB_ValidPath);
        this.TP_Config.Controls.Add(this.TB_PluginRoot);
        this.TP_Config.Controls.Add(this.TB_Description);
        this.TP_Config.Controls.Add(this.TB_Version);
        this.TP_Config.Controls.Add(this.TB_Author);
        this.TP_Config.Controls.Add(this.TB_Name);
        this.TP_Config.Location = new Point(4, 24);
        this.TP_Config.Name = "TP_Config";
        this.TP_Config.Padding = new Padding(3);
        this.TP_Config.Size = new Size(376, 409);
        this.TP_Config.TabIndex = 0;
        this.TP_Config.Text = "configuration";
        this.TP_Config.UseVisualStyleBackColor = true;
        // 
        // B_Reload
        // 
        this.B_Reload.Enabled = false;
        this.B_Reload.Location = new Point(6, 210);
        this.B_Reload.Name = "B_Reload";
        this.B_Reload.Size = new Size(249, 23);
        this.B_Reload.TabIndex = 14;
        this.B_Reload.Text = "reload";
        this.B_Reload.UseVisualStyleBackColor = true;
        this.B_Reload.Click += this.B_Reload_Click;
        // 
        // B_SaveChanges
        // 
        this.B_SaveChanges.Enabled = false;
        this.B_SaveChanges.Location = new Point(261, 210);
        this.B_SaveChanges.Name = "B_SaveChanges";
        this.B_SaveChanges.Size = new Size(109, 23);
        this.B_SaveChanges.TabIndex = 13;
        this.B_SaveChanges.Text = "save changes";
        this.B_SaveChanges.UseVisualStyleBackColor = true;
        // 
        // L_Script
        // 
        this.L_Script.AutoSize = true;
        this.L_Script.Location = new Point(6, 184);
        this.L_Script.Name = "L_Script";
        this.L_Script.Size = new Size(36, 15);
        this.L_Script.TabIndex = 12;
        this.L_Script.Text = "script";
        // 
        // L_Version
        // 
        this.L_Version.AutoSize = true;
        this.L_Version.Location = new Point(6, 155);
        this.L_Version.Name = "L_Version";
        this.L_Version.Size = new Size(45, 15);
        this.L_Version.TabIndex = 11;
        this.L_Version.Text = "version";
        // 
        // L_Author
        // 
        this.L_Author.AutoSize = true;
        this.L_Author.Location = new Point(6, 126);
        this.L_Author.Name = "L_Author";
        this.L_Author.Size = new Size(42, 15);
        this.L_Author.TabIndex = 10;
        this.L_Author.Text = "author";
        // 
        // L_Name
        // 
        this.L_Name.AutoSize = true;
        this.L_Name.Location = new Point(6, 9);
        this.L_Name.Name = "L_Name";
        this.L_Name.Size = new Size(37, 15);
        this.L_Name.TabIndex = 9;
        this.L_Name.Text = "name";
        // 
        // TB_Script
        // 
        this.TB_Script.Location = new Point(54, 181);
        this.TB_Script.Name = "TB_Script";
        this.TB_Script.ReadOnly = true;
        this.TB_Script.Size = new Size(316, 23);
        this.TB_Script.TabIndex = 8;
        this.TB_Script.Click += this.TB_Script_Click;
        this.TB_Script.TextChanged += this.submitChange;
        // 
        // CB_ValidPath
        // 
        this.CB_ValidPath.AutoSize = true;
        this.CB_ValidPath.Enabled = false;
        this.CB_ValidPath.Location = new Point(314, 382);
        this.CB_ValidPath.Name = "CB_ValidPath";
        this.CB_ValidPath.Size = new Size(56, 19);
        this.CB_ValidPath.TabIndex = 7;
        this.CB_ValidPath.Text = "Valid?";
        this.CB_ValidPath.UseVisualStyleBackColor = true;
        // 
        // TB_PluginRoot
        // 
        this.TB_PluginRoot.Location = new Point(6, 380);
        this.TB_PluginRoot.Name = "TB_PluginRoot";
        this.TB_PluginRoot.ReadOnly = true;
        this.TB_PluginRoot.Size = new Size(302, 23);
        this.TB_PluginRoot.TabIndex = 6;
        this.TB_PluginRoot.Click += this.TB_PluginRoot_Click;
        // 
        // TB_Description
        // 
        this.TB_Description.Location = new Point(6, 35);
        this.TB_Description.Multiline = true;
        this.TB_Description.Name = "TB_Description";
        this.TB_Description.PlaceholderText = "description";
        this.TB_Description.Size = new Size(364, 82);
        this.TB_Description.TabIndex = 5;
        this.TB_Description.TextChanged += this.submitChange;
        // 
        // TB_Version
        // 
        this.TB_Version.Location = new Point(54, 152);
        this.TB_Version.Name = "TB_Version";
        this.TB_Version.Size = new Size(316, 23);
        this.TB_Version.TabIndex = 4;
        this.TB_Version.TextChanged += this.submitChange;
        // 
        // TB_Author
        // 
        this.TB_Author.Location = new Point(54, 123);
        this.TB_Author.Name = "TB_Author";
        this.TB_Author.Size = new Size(316, 23);
        this.TB_Author.TabIndex = 3;
        this.TB_Author.TextChanged += this.submitChange;
        // 
        // TB_Name
        // 
        this.TB_Name.Location = new Point(54, 6);
        this.TB_Name.Name = "TB_Name";
        this.TB_Name.Size = new Size(316, 23);
        this.TB_Name.TabIndex = 2;
        this.TB_Name.TextChanged += this.submitChange;
        // 
        // TP_Scripts
        // 
        this.TP_Scripts.Controls.Add(this.panel1);
        this.TP_Scripts.Controls.Add(this.label1);
        this.TP_Scripts.Controls.Add(this.CB_ScriptType);
        this.TP_Scripts.Controls.Add(this.PB_Coverage);
        this.TP_Scripts.Controls.Add(this.CLB_Scripts);
        this.TP_Scripts.Location = new Point(4, 24);
        this.TP_Scripts.Name = "TP_Scripts";
        this.TP_Scripts.Padding = new Padding(3);
        this.TP_Scripts.Size = new Size(376, 409);
        this.TP_Scripts.TabIndex = 4;
        this.TP_Scripts.Text = "scripts";
        this.TP_Scripts.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        this.panel1.BorderStyle = BorderStyle.Fixed3D;
        this.panel1.Controls.Add(this.button1);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.button7);
        this.panel1.Controls.Add(this.button6);
        this.panel1.Location = new Point(6, 35);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(362, 59);
        this.panel1.TabIndex = 7;
        // 
        // button1
        // 
        this.button1.Location = new Point(202, 29);
        this.button1.Name = "button1";
        this.button1.Size = new Size(72, 23);
        this.button1.TabIndex = 8;
        this.button1.Text = "button1";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(3, 0);
        this.label2.Name = "label2";
        this.label2.Size = new Size(38, 15);
        this.label2.TabIndex = 7;
        this.label2.Text = "label2";
        // 
        // button7
        // 
        this.button7.Location = new Point(280, 29);
        this.button7.Name = "button7";
        this.button7.Size = new Size(75, 23);
        this.button7.TabIndex = 6;
        this.button7.Text = "button7";
        this.button7.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        this.button6.Location = new Point(3, 29);
        this.button6.Name = "button6";
        this.button6.Size = new Size(129, 23);
        this.button6.TabIndex = 5;
        this.button6.Text = "button6";
        this.button6.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(10, 384);
        this.label1.Name = "label1";
        this.label1.Size = new Size(55, 15);
        this.label1.TabIndex = 4;
        this.label1.Text = "coverage";
        // 
        // CB_ScriptType
        // 
        this.CB_ScriptType.DropDownStyle = ComboBoxStyle.DropDownList;
        this.CB_ScriptType.FormattingEnabled = true;
        this.CB_ScriptType.Items.AddRange(new object[] { "scenes", "singletons", "types" });
        this.CB_ScriptType.Location = new Point(6, 6);
        this.CB_ScriptType.Name = "CB_ScriptType";
        this.CB_ScriptType.Size = new Size(364, 23);
        this.CB_ScriptType.Sorted = true;
        this.CB_ScriptType.TabIndex = 3;
        this.CB_ScriptType.SelectedIndexChanged += this.CB_ScriptType_SelectedIndexChanged;
        // 
        // PB_Coverage
        // 
        this.PB_Coverage.Location = new Point(6, 380);
        this.PB_Coverage.Name = "PB_Coverage";
        this.PB_Coverage.Size = new Size(364, 23);
        this.PB_Coverage.TabIndex = 1;
        // 
        // CLB_Scripts
        // 
        this.CLB_Scripts.ContextMenuStrip = this.CMS_Script;
        this.CLB_Scripts.FormattingEnabled = true;
        this.CLB_Scripts.Location = new Point(6, 100);
        this.CLB_Scripts.Name = "CLB_Scripts";
        this.CLB_Scripts.Size = new Size(364, 274);
        this.CLB_Scripts.TabIndex = 0;
        // 
        // CMS_Script
        // 
        this.CMS_Script.Items.AddRange(new ToolStripItem[] { this.TSMI_NewScript, this.toolStripSeparator3, this.TSMI_OpenScript, this.TSMI_DeleteScript, this.toolStripSeparator2, this.TSMI_EnableScript, this.TSMI_DisableScript, this.TSCB_ScriptType });
        this.CMS_Script.Name = "contextMenuStrip1";
        this.CMS_Script.RenderMode = ToolStripRenderMode.System;
        this.CMS_Script.Size = new Size(182, 153);
        // 
        // TSMI_NewScript
        // 
        this.TSMI_NewScript.Name = "TSMI_NewScript";
        this.TSMI_NewScript.Size = new Size(181, 22);
        this.TSMI_NewScript.Text = "new";
        // 
        // toolStripSeparator3
        // 
        this.toolStripSeparator3.Name = "toolStripSeparator3";
        this.toolStripSeparator3.Size = new Size(178, 6);
        // 
        // TSMI_OpenScript
        // 
        this.TSMI_OpenScript.Enabled = false;
        this.TSMI_OpenScript.Name = "TSMI_OpenScript";
        this.TSMI_OpenScript.Size = new Size(181, 22);
        this.TSMI_OpenScript.Text = "open";
        // 
        // TSMI_DeleteScript
        // 
        this.TSMI_DeleteScript.Enabled = false;
        this.TSMI_DeleteScript.Name = "TSMI_DeleteScript";
        this.TSMI_DeleteScript.Size = new Size(181, 22);
        this.TSMI_DeleteScript.Text = "delete";
        // 
        // toolStripSeparator2
        // 
        this.toolStripSeparator2.Name = "toolStripSeparator2";
        this.toolStripSeparator2.Size = new Size(178, 6);
        // 
        // TSMI_EnableScript
        // 
        this.TSMI_EnableScript.Enabled = false;
        this.TSMI_EnableScript.Name = "TSMI_EnableScript";
        this.TSMI_EnableScript.Size = new Size(181, 22);
        this.TSMI_EnableScript.Text = "enable";
        // 
        // TSMI_DisableScript
        // 
        this.TSMI_DisableScript.Enabled = false;
        this.TSMI_DisableScript.Name = "TSMI_DisableScript";
        this.TSMI_DisableScript.Size = new Size(181, 22);
        this.TSMI_DisableScript.Text = "disable";
        // 
        // TSCB_ScriptType
        // 
        this.TSCB_ScriptType.Items.AddRange(new object[] { "type/class", "singleton/autoload", "scene" });
        this.TSCB_ScriptType.Name = "TSCB_ScriptType";
        this.TSCB_ScriptType.Size = new Size(121, 23);
        // 
        // MS_Controls
        // 
        this.MS_Controls.Items.AddRange(new ToolStripItem[] { this.TSMI_Addon, this.TSMI_Edit, this.TSMI_Tools, this.TSMI_Exit });
        this.MS_Controls.Location = new Point(0, 0);
        this.MS_Controls.Name = "MS_Controls";
        this.MS_Controls.Size = new Size(384, 24);
        this.MS_Controls.TabIndex = 1;
        this.MS_Controls.Text = "menuStrip1";
        // 
        // TSMI_Addon
        // 
        this.TSMI_Addon.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_New, this.TSS_0, this.TSMI_Save, this.TSMI_Load, this.TSS_1, this.TSMI_Package });
        this.TSMI_Addon.Image = Properties.Resources.appbar_code_xml;
        this.TSMI_Addon.Name = "TSMI_Addon";
        this.TSMI_Addon.Size = new Size(69, 20);
        this.TSMI_Addon.Text = "addon";
        // 
        // TSMI_New
        // 
        this.TSMI_New.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_NewAddon, this.toolStripSeparator1, this.TSMI_NewSingleton, this.TSMI_NewType });
        this.TSMI_New.Name = "TSMI_New";
        this.TSMI_New.Size = new Size(118, 22);
        this.TSMI_New.Text = "new";
        // 
        // TSMI_NewAddon
        // 
        this.TSMI_NewAddon.Image = Properties.Resources.appbar_fingerprint;
        this.TSMI_NewAddon.Name = "TSMI_NewAddon";
        this.TSMI_NewAddon.Size = new Size(175, 22);
        this.TSMI_NewAddon.Text = "addon";
        this.TSMI_NewAddon.Click += this.TSMI_NewAddon_Click;
        // 
        // toolStripSeparator1
        // 
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new Size(172, 6);
        // 
        // TSMI_NewSingleton
        // 
        this.TSMI_NewSingleton.Enabled = false;
        this.TSMI_NewSingleton.Name = "TSMI_NewSingleton";
        this.TSMI_NewSingleton.Size = new Size(175, 22);
        this.TSMI_NewSingleton.Text = "singleton/autoload";
        // 
        // TSMI_NewType
        // 
        this.TSMI_NewType.Enabled = false;
        this.TSMI_NewType.Name = "TSMI_NewType";
        this.TSMI_NewType.Size = new Size(175, 22);
        this.TSMI_NewType.Text = "type/class";
        // 
        // TSS_0
        // 
        this.TSS_0.Name = "TSS_0";
        this.TSS_0.Size = new Size(115, 6);
        // 
        // TSMI_Save
        // 
        this.TSMI_Save.Enabled = false;
        this.TSMI_Save.Name = "TSMI_Save";
        this.TSMI_Save.Size = new Size(118, 22);
        this.TSMI_Save.Text = "Save";
        // 
        // TSMI_Load
        // 
        this.TSMI_Load.Name = "TSMI_Load";
        this.TSMI_Load.Size = new Size(118, 22);
        this.TSMI_Load.Text = "Load";
        this.TSMI_Load.Click += this.TSMI_Load_Click;
        // 
        // TSS_1
        // 
        this.TSS_1.Name = "TSS_1";
        this.TSS_1.Size = new Size(115, 6);
        // 
        // TSMI_Package
        // 
        this.TSMI_Package.Enabled = false;
        this.TSMI_Package.Name = "TSMI_Package";
        this.TSMI_Package.Size = new Size(118, 22);
        this.TSMI_Package.Text = "Package";
        // 
        // TSMI_Edit
        // 
        this.TSMI_Edit.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_IncVer, this.TSMI_DecVer, this.TSS_2 });
        this.TSMI_Edit.Enabled = false;
        this.TSMI_Edit.Name = "TSMI_Edit";
        this.TSMI_Edit.Size = new Size(39, 20);
        this.TSMI_Edit.Text = "edit";
        // 
        // TSMI_IncVer
        // 
        this.TSMI_IncVer.DropDownItems.AddRange(new ToolStripItem[] { this.majorToolStripMenuItem, this.minorToolStripMenuItem, this.revisionToolStripMenuItem });
        this.TSMI_IncVer.Name = "TSMI_IncVer";
        this.TSMI_IncVer.Size = new Size(180, 22);
        this.TSMI_IncVer.Text = "Increment Version";
        // 
        // majorToolStripMenuItem
        // 
        this.majorToolStripMenuItem.Name = "majorToolStripMenuItem";
        this.majorToolStripMenuItem.Size = new Size(180, 22);
        this.majorToolStripMenuItem.Text = "Major";
        // 
        // minorToolStripMenuItem
        // 
        this.minorToolStripMenuItem.Name = "minorToolStripMenuItem";
        this.minorToolStripMenuItem.Size = new Size(180, 22);
        this.minorToolStripMenuItem.Text = "Minor";
        // 
        // revisionToolStripMenuItem
        // 
        this.revisionToolStripMenuItem.Name = "revisionToolStripMenuItem";
        this.revisionToolStripMenuItem.Size = new Size(180, 22);
        this.revisionToolStripMenuItem.Text = "Revision";
        // 
        // TSMI_DecVer
        // 
        this.TSMI_DecVer.DropDownItems.AddRange(new ToolStripItem[] { this.majorToolStripMenuItem1, this.minorToolStripMenuItem1, this.revisionToolStripMenuItem1 });
        this.TSMI_DecVer.Name = "TSMI_DecVer";
        this.TSMI_DecVer.Size = new Size(180, 22);
        this.TSMI_DecVer.Text = "Decrement Version";
        // 
        // majorToolStripMenuItem1
        // 
        this.majorToolStripMenuItem1.Name = "majorToolStripMenuItem1";
        this.majorToolStripMenuItem1.Size = new Size(118, 22);
        this.majorToolStripMenuItem1.Text = "Major";
        // 
        // minorToolStripMenuItem1
        // 
        this.minorToolStripMenuItem1.Name = "minorToolStripMenuItem1";
        this.minorToolStripMenuItem1.Size = new Size(118, 22);
        this.minorToolStripMenuItem1.Text = "Minor";
        // 
        // revisionToolStripMenuItem1
        // 
        this.revisionToolStripMenuItem1.Name = "revisionToolStripMenuItem1";
        this.revisionToolStripMenuItem1.Size = new Size(118, 22);
        this.revisionToolStripMenuItem1.Text = "Revision";
        // 
        // TSS_2
        // 
        this.TSS_2.Name = "TSS_2";
        this.TSS_2.Size = new Size(177, 6);
        // 
        // TSMI_Tools
        // 
        this.TSMI_Tools.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_Links, this.gitToolStripMenuItem });
        this.TSMI_Tools.Name = "TSMI_Tools";
        this.TSMI_Tools.Size = new Size(45, 20);
        this.TSMI_Tools.Text = "tools";
        // 
        // TSMI_Links
        // 
        this.TSMI_Links.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_GAL });
        this.TSMI_Links.Image = Properties.Resources.appbar_qr;
        this.TSMI_Links.Name = "TSMI_Links";
        this.TSMI_Links.Size = new Size(98, 22);
        this.TSMI_Links.Text = "links";
        // 
        // TSMI_GAL
        // 
        this.TSMI_GAL.Name = "TSMI_GAL";
        this.TSMI_GAL.Size = new Size(177, 22);
        this.TSMI_GAL.Text = "Godot Asset Library";
        // 
        // gitToolStripMenuItem
        // 
        this.gitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripTextBox1, this.TSMI_RunGitCommand });
        this.gitToolStripMenuItem.Image = Properties.Resources.appbar_social_github_octocat;
        this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
        this.gitToolStripMenuItem.Size = new Size(98, 22);
        this.gitToolStripMenuItem.Text = "git";
        // 
        // toolStripTextBox1
        // 
        this.toolStripTextBox1.Name = "toolStripTextBox1";
        this.toolStripTextBox1.Size = new Size(100, 23);
        this.toolStripTextBox1.Text = "status";
        this.toolStripTextBox1.ToolTipText = "command";
        // 
        // TSMI_RunGitCommand
        // 
        this.TSMI_RunGitCommand.Image = Properties.Resources.appbar_console;
        this.TSMI_RunGitCommand.Name = "TSMI_RunGitCommand";
        this.TSMI_RunGitCommand.Size = new Size(160, 22);
        this.TSMI_RunGitCommand.Text = "run";
        // 
        // TSMI_Exit
        // 
        this.TSMI_Exit.Image = Properties.Resources.appbar_type_null;
        this.TSMI_Exit.Name = "TSMI_Exit";
        this.TSMI_Exit.Size = new Size(54, 20);
        this.TSMI_Exit.Text = "exit";
        this.TSMI_Exit.Click += this.TSMI_Exit_Click;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(384, 461);
        this.Controls.Add(this.TC_Main);
        this.Controls.Add(this.MS_Controls);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.Icon = (Icon) resources.GetObject("$this.Icon");
        this.MainMenuStrip = this.MS_Controls;
        this.MaximumSize = new Size(400, 500);
        this.MinimumSize = new Size(400, 500);
        this.Name = "MainForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "MT's Godot Addon Manager";
        this.Load += this.MainForm_Load;
        this.TC_Main.ResumeLayout(false);
        this.TP_Config.ResumeLayout(false);
        this.TP_Config.PerformLayout();
        this.TP_Scripts.ResumeLayout(false);
        this.TP_Scripts.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.CMS_Script.ResumeLayout(false);
        this.MS_Controls.ResumeLayout(false);
        this.MS_Controls.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private TabControl TC_Main;
    private TabPage TP_Config;
    private MenuStrip MS_Controls;
    private ToolStripMenuItem TSMI_Addon;
    private ToolStripMenuItem TSMI_Edit;
    private ToolStripMenuItem TSMI_Tools;
    private ToolStripMenuItem TSMI_Exit;
    private TextBox TB_Version;
    private TextBox TB_Author;
    private TextBox TB_Name;
    private TextBox TB_Description;
    private ToolStripMenuItem TSMI_Save;
    private ToolStripMenuItem TSMI_Load;
    private ToolStripMenuItem TSMI_Package;
    private ToolStripMenuItem TSMI_Links;
    private ToolStripMenuItem TSMI_IncVer;
    private ToolStripMenuItem majorToolStripMenuItem;
    private ToolStripMenuItem minorToolStripMenuItem;
    private ToolStripMenuItem revisionToolStripMenuItem;
    private ToolStripMenuItem TSMI_DecVer;
    private ToolStripMenuItem majorToolStripMenuItem1;
    private ToolStripMenuItem minorToolStripMenuItem1;
    private ToolStripMenuItem revisionToolStripMenuItem1;
    private ToolStripSeparator TSS_2;
    private ToolStripSeparator TSS_1;
    private ToolStripMenuItem TSMI_GAL;
    private ToolStripMenuItem TSMI_New;
    private ToolStripSeparator TSS_0;
    private ToolStripMenuItem TSMI_NewAddon;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem TSMI_NewSingleton;
    private ToolStripMenuItem TSMI_NewType;
    private TextBox TB_PluginRoot;
    private CheckBox CB_ValidPath;
    private TextBox TB_Script;
    private Label L_Author;
    private Label L_Name;
    private Label L_Script;
    private Label L_Version;
    private Button B_Reload;
    private Button B_SaveChanges;
    private ContextMenuStrip CMS_Script;
    private ToolStripMenuItem TSMI_EnableScript;
    private ToolStripMenuItem TSMI_DisableScript;
    private ToolStripMenuItem TSMI_DeleteScript;
    private TabPage TP_Scripts;
    private ProgressBar PB_Coverage;
    private CheckedListBox CLB_Scripts;
    private Label label1;
    private ComboBox CB_ScriptType;
    private Button button7;
    private Button button6;
    private Panel panel1;
    private Label label2;
    private ToolStripMenuItem TSMI_OpenScript;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripComboBox TSCB_ScriptType;
    private Button button1;
    private ToolStripMenuItem TSMI_NewScript;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem gitToolStripMenuItem;
    private ToolStripTextBox toolStripTextBox1;
    private ToolStripMenuItem TSMI_RunGitCommand;
}
