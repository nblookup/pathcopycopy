﻿namespace PathCopyCopy.Settings.UI.Forms
{
    partial class PipelinePluginForm
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
            if (disposing && (components != null)) {
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.BasePluginPage = new System.Windows.Forms.TabPage();
            this.BasePluginLst = new System.Windows.Forms.ListBox();
            this.BaseCommandLbl2 = new System.Windows.Forms.Label();
            this.BaseCommandLbl = new System.Windows.Forms.Label();
            this.OptionsPage = new System.Windows.Forms.TabPage();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.BrowserForExecutableBtn = new System.Windows.Forms.Button();
            this.ExecutableTxt = new System.Windows.Forms.TextBox();
            this.ExecutableLbl = new System.Windows.Forms.Label();
            this.LaunchExecutableChk = new System.Windows.Forms.CheckBox();
            this.CopyOnSameLineChk = new System.Windows.Forms.CheckBox();
            this.FindReplaceGroupBox = new System.Windows.Forms.GroupBox();
            this.TestRegexBtn = new System.Windows.Forms.Button();
            this.IgnoreCaseChk = new System.Windows.Forms.CheckBox();
            this.UseRegexChk = new System.Windows.Forms.CheckBox();
            this.ReplaceTxt = new System.Windows.Forms.TextBox();
            this.ReplaceLbl = new System.Windows.Forms.Label();
            this.FindTxt = new System.Windows.Forms.TextBox();
            this.FindLbl = new System.Windows.Forms.Label();
            this.SlashesGroupBox = new System.Windows.Forms.GroupBox();
            this.NoSlashesChangeRadio = new System.Windows.Forms.RadioButton();
            this.BackToForwardSlashesRadio = new System.Windows.Forms.RadioButton();
            this.ForwardToBackslashesRadio = new System.Windows.Forms.RadioButton();
            this.DecorationsGroupBox = new System.Windows.Forms.GroupBox();
            this.OptionalQuotesChk = new System.Windows.Forms.CheckBox();
            this.EncodeURICharsChk = new System.Windows.Forms.CheckBox();
            this.EncodeURIWhitespaceChk = new System.Windows.Forms.CheckBox();
            this.EmailLinksChk = new System.Windows.Forms.CheckBox();
            this.QuotesChk = new System.Windows.Forms.CheckBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ChooseExecutableOpenDlg = new System.Windows.Forms.OpenFileDialog();
            this.MainTabControl.SuspendLayout();
            this.BasePluginPage.SuspendLayout();
            this.OptionsPage.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.FindReplaceGroupBox.SuspendLayout();
            this.SlashesGroupBox.SuspendLayout();
            this.DecorationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(12, 15);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "&Name:";
            // 
            // NameTxt
            // 
            this.NameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTxt.Location = new System.Drawing.Point(56, 12);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(338, 20);
            this.NameTxt.TabIndex = 1;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.BasePluginPage);
            this.MainTabControl.Controls.Add(this.OptionsPage);
            this.MainTabControl.Location = new System.Drawing.Point(12, 38);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(382, 488);
            this.MainTabControl.TabIndex = 2;
            // 
            // BasePluginPage
            // 
            this.BasePluginPage.Controls.Add(this.BasePluginLst);
            this.BasePluginPage.Controls.Add(this.BaseCommandLbl2);
            this.BasePluginPage.Controls.Add(this.BaseCommandLbl);
            this.BasePluginPage.Location = new System.Drawing.Point(4, 22);
            this.BasePluginPage.Name = "BasePluginPage";
            this.BasePluginPage.Padding = new System.Windows.Forms.Padding(3);
            this.BasePluginPage.Size = new System.Drawing.Size(374, 462);
            this.BasePluginPage.TabIndex = 0;
            this.BasePluginPage.Text = "Base Command";
            this.BasePluginPage.UseVisualStyleBackColor = true;
            // 
            // BasePluginLst
            // 
            this.BasePluginLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasePluginLst.FormattingEnabled = true;
            this.BasePluginLst.Location = new System.Drawing.Point(9, 32);
            this.BasePluginLst.Name = "BasePluginLst";
            this.BasePluginLst.Size = new System.Drawing.Size(355, 355);
            this.BasePluginLst.TabIndex = 2;
            this.BasePluginLst.SelectedIndexChanged += new System.EventHandler(this.BasePluginLst_SelectedIndexChanged);
            // 
            // BaseCommandLbl2
            // 
            this.BaseCommandLbl2.AutoSize = true;
            this.BaseCommandLbl2.Location = new System.Drawing.Point(6, 16);
            this.BaseCommandLbl2.Name = "BaseCommandLbl2";
            this.BaseCommandLbl2.Size = new System.Drawing.Size(343, 13);
            this.BaseCommandLbl2.TabIndex = 1;
            this.BaseCommandLbl2.Text = "determine the path copy method to use before applying custom options.";
            // 
            // BaseCommandLbl
            // 
            this.BaseCommandLbl.AutoSize = true;
            this.BaseCommandLbl.Location = new System.Drawing.Point(6, 3);
            this.BaseCommandLbl.Name = "BaseCommandLbl";
            this.BaseCommandLbl.Size = new System.Drawing.Size(314, 13);
            this.BaseCommandLbl.TabIndex = 0;
            this.BaseCommandLbl.Text = "Please choose a base command for your custom command. It will";
            // 
            // OptionsPage
            // 
            this.OptionsPage.Controls.Add(this.OptionsGroupBox);
            this.OptionsPage.Controls.Add(this.FindReplaceGroupBox);
            this.OptionsPage.Controls.Add(this.SlashesGroupBox);
            this.OptionsPage.Controls.Add(this.DecorationsGroupBox);
            this.OptionsPage.Location = new System.Drawing.Point(4, 22);
            this.OptionsPage.Name = "OptionsPage";
            this.OptionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsPage.Size = new System.Drawing.Size(374, 462);
            this.OptionsPage.TabIndex = 1;
            this.OptionsPage.Text = "Options";
            this.OptionsPage.UseVisualStyleBackColor = true;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsGroupBox.Controls.Add(this.BrowserForExecutableBtn);
            this.OptionsGroupBox.Controls.Add(this.ExecutableTxt);
            this.OptionsGroupBox.Controls.Add(this.ExecutableLbl);
            this.OptionsGroupBox.Controls.Add(this.LaunchExecutableChk);
            this.OptionsGroupBox.Controls.Add(this.CopyOnSameLineChk);
            this.OptionsGroupBox.Location = new System.Drawing.Point(6, 357);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(362, 99);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // BrowserForExecutableBtn
            // 
            this.BrowserForExecutableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserForExecutableBtn.Enabled = false;
            this.BrowserForExecutableBtn.Location = new System.Drawing.Point(281, 65);
            this.BrowserForExecutableBtn.Name = "BrowserForExecutableBtn";
            this.BrowserForExecutableBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowserForExecutableBtn.TabIndex = 4;
            this.BrowserForExecutableBtn.Text = "Br&owse";
            this.BrowserForExecutableBtn.UseVisualStyleBackColor = true;
            this.BrowserForExecutableBtn.Click += new System.EventHandler(this.BrowserForExecutableBtn_Click);
            // 
            // ExecutableTxt
            // 
            this.ExecutableTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecutableTxt.Enabled = false;
            this.ExecutableTxt.Location = new System.Drawing.Point(91, 67);
            this.ExecutableTxt.Name = "ExecutableTxt";
            this.ExecutableTxt.Size = new System.Drawing.Size(184, 20);
            this.ExecutableTxt.TabIndex = 3;
            // 
            // ExecutableLbl
            // 
            this.ExecutableLbl.AutoSize = true;
            this.ExecutableLbl.Enabled = false;
            this.ExecutableLbl.Location = new System.Drawing.Point(22, 70);
            this.ExecutableLbl.Name = "ExecutableLbl";
            this.ExecutableLbl.Size = new System.Drawing.Size(63, 13);
            this.ExecutableLbl.TabIndex = 2;
            this.ExecutableLbl.Text = "E&xecutable:";
            // 
            // LaunchExecutableChk
            // 
            this.LaunchExecutableChk.AutoSize = true;
            this.LaunchExecutableChk.Location = new System.Drawing.Point(6, 42);
            this.LaunchExecutableChk.Name = "LaunchExecutableChk";
            this.LaunchExecutableChk.Size = new System.Drawing.Size(339, 17);
            this.LaunchExecutableChk.TabIndex = 1;
            this.LaunchExecutableChk.Text = "&Launch executable with path(s) instead of copying to the clipboard";
            this.LaunchExecutableChk.UseVisualStyleBackColor = true;
            this.LaunchExecutableChk.CheckedChanged += new System.EventHandler(this.LaunchExecutableChk_CheckedChanged);
            // 
            // CopyOnSameLineChk
            // 
            this.CopyOnSameLineChk.AutoSize = true;
            this.CopyOnSameLineChk.Location = new System.Drawing.Point(6, 19);
            this.CopyOnSameLineChk.Name = "CopyOnSameLineChk";
            this.CopyOnSameLineChk.Size = new System.Drawing.Size(197, 17);
            this.CopyOnSameLineChk.TabIndex = 0;
            this.CopyOnSameLineChk.Text = "Cop&y multiple paths on the same line";
            this.CopyOnSameLineChk.UseVisualStyleBackColor = true;
            // 
            // FindReplaceGroupBox
            // 
            this.FindReplaceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindReplaceGroupBox.Controls.Add(this.TestRegexBtn);
            this.FindReplaceGroupBox.Controls.Add(this.IgnoreCaseChk);
            this.FindReplaceGroupBox.Controls.Add(this.UseRegexChk);
            this.FindReplaceGroupBox.Controls.Add(this.ReplaceTxt);
            this.FindReplaceGroupBox.Controls.Add(this.ReplaceLbl);
            this.FindReplaceGroupBox.Controls.Add(this.FindTxt);
            this.FindReplaceGroupBox.Controls.Add(this.FindLbl);
            this.FindReplaceGroupBox.Location = new System.Drawing.Point(6, 246);
            this.FindReplaceGroupBox.Name = "FindReplaceGroupBox";
            this.FindReplaceGroupBox.Size = new System.Drawing.Size(362, 105);
            this.FindReplaceGroupBox.TabIndex = 2;
            this.FindReplaceGroupBox.TabStop = false;
            this.FindReplaceGroupBox.Text = "Find / Replace";
            // 
            // TestRegexBtn
            // 
            this.TestRegexBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TestRegexBtn.Enabled = false;
            this.TestRegexBtn.Location = new System.Drawing.Point(281, 71);
            this.TestRegexBtn.Name = "TestRegexBtn";
            this.TestRegexBtn.Size = new System.Drawing.Size(75, 23);
            this.TestRegexBtn.TabIndex = 6;
            this.TestRegexBtn.Text = "&Test...";
            this.TestRegexBtn.UseVisualStyleBackColor = true;
            this.TestRegexBtn.Click += new System.EventHandler(this.TestRegexBtn_Click);
            // 
            // IgnoreCaseChk
            // 
            this.IgnoreCaseChk.AutoSize = true;
            this.IgnoreCaseChk.Enabled = false;
            this.IgnoreCaseChk.Location = new System.Drawing.Point(153, 75);
            this.IgnoreCaseChk.Name = "IgnoreCaseChk";
            this.IgnoreCaseChk.Size = new System.Drawing.Size(82, 17);
            this.IgnoreCaseChk.TabIndex = 5;
            this.IgnoreCaseChk.Text = "&Ignore case";
            this.IgnoreCaseChk.UseVisualStyleBackColor = true;
            // 
            // UseRegexChk
            // 
            this.UseRegexChk.AutoSize = true;
            this.UseRegexChk.Location = new System.Drawing.Point(9, 75);
            this.UseRegexChk.Name = "UseRegexChk";
            this.UseRegexChk.Size = new System.Drawing.Size(138, 17);
            this.UseRegexChk.TabIndex = 4;
            this.UseRegexChk.Text = "Use r&egular expressions";
            this.UseRegexChk.UseVisualStyleBackColor = true;
            this.UseRegexChk.CheckedChanged += new System.EventHandler(this.UseRegexChk_CheckedChanged);
            // 
            // ReplaceTxt
            // 
            this.ReplaceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplaceTxt.Location = new System.Drawing.Point(84, 45);
            this.ReplaceTxt.Name = "ReplaceTxt";
            this.ReplaceTxt.Size = new System.Drawing.Size(272, 20);
            this.ReplaceTxt.TabIndex = 3;
            // 
            // ReplaceLbl
            // 
            this.ReplaceLbl.AutoSize = true;
            this.ReplaceLbl.Location = new System.Drawing.Point(6, 48);
            this.ReplaceLbl.Name = "ReplaceLbl";
            this.ReplaceLbl.Size = new System.Drawing.Size(72, 13);
            this.ReplaceLbl.TabIndex = 2;
            this.ReplaceLbl.Text = "&Replace with:";
            // 
            // FindTxt
            // 
            this.FindTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTxt.Location = new System.Drawing.Point(68, 19);
            this.FindTxt.Name = "FindTxt";
            this.FindTxt.Size = new System.Drawing.Size(288, 20);
            this.FindTxt.TabIndex = 1;
            // 
            // FindLbl
            // 
            this.FindLbl.AutoSize = true;
            this.FindLbl.Location = new System.Drawing.Point(6, 22);
            this.FindLbl.Name = "FindLbl";
            this.FindLbl.Size = new System.Drawing.Size(56, 13);
            this.FindLbl.TabIndex = 0;
            this.FindLbl.Text = "Find &what:";
            // 
            // SlashesGroupBox
            // 
            this.SlashesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SlashesGroupBox.Controls.Add(this.NoSlashesChangeRadio);
            this.SlashesGroupBox.Controls.Add(this.BackToForwardSlashesRadio);
            this.SlashesGroupBox.Controls.Add(this.ForwardToBackslashesRadio);
            this.SlashesGroupBox.Location = new System.Drawing.Point(6, 150);
            this.SlashesGroupBox.Name = "SlashesGroupBox";
            this.SlashesGroupBox.Size = new System.Drawing.Size(362, 90);
            this.SlashesGroupBox.TabIndex = 1;
            this.SlashesGroupBox.TabStop = false;
            this.SlashesGroupBox.Text = "Slashes";
            // 
            // NoSlashesChangeRadio
            // 
            this.NoSlashesChangeRadio.AutoSize = true;
            this.NoSlashesChangeRadio.Checked = true;
            this.NoSlashesChangeRadio.Location = new System.Drawing.Point(6, 65);
            this.NoSlashesChangeRadio.Name = "NoSlashesChangeRadio";
            this.NoSlashesChangeRadio.Size = new System.Drawing.Size(134, 17);
            this.NoSlashesChangeRadio.TabIndex = 2;
            this.NoSlashesChangeRadio.TabStop = true;
            this.NoSlashesChangeRadio.Text = "Do not change &slashes";
            this.NoSlashesChangeRadio.UseVisualStyleBackColor = true;
            // 
            // BackToForwardSlashesRadio
            // 
            this.BackToForwardSlashesRadio.AutoSize = true;
            this.BackToForwardSlashesRadio.Location = new System.Drawing.Point(6, 42);
            this.BackToForwardSlashesRadio.Name = "BackToForwardSlashesRadio";
            this.BackToForwardSlashesRadio.Size = new System.Drawing.Size(225, 17);
            this.BackToForwardSlashesRadio.TabIndex = 1;
            this.BackToForwardSlashesRadio.Text = "Change all backslashes to &forward slashes";
            this.BackToForwardSlashesRadio.UseVisualStyleBackColor = true;
            // 
            // ForwardToBackslashesRadio
            // 
            this.ForwardToBackslashesRadio.AutoSize = true;
            this.ForwardToBackslashesRadio.Location = new System.Drawing.Point(6, 19);
            this.ForwardToBackslashesRadio.Name = "ForwardToBackslashesRadio";
            this.ForwardToBackslashesRadio.Size = new System.Drawing.Size(265, 17);
            this.ForwardToBackslashesRadio.TabIndex = 0;
            this.ForwardToBackslashesRadio.Text = "Change all forward slashes ( / ) to &backslashes ( \\ )";
            this.ForwardToBackslashesRadio.UseVisualStyleBackColor = true;
            // 
            // DecorationsGroupBox
            // 
            this.DecorationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecorationsGroupBox.Controls.Add(this.OptionalQuotesChk);
            this.DecorationsGroupBox.Controls.Add(this.EncodeURICharsChk);
            this.DecorationsGroupBox.Controls.Add(this.EncodeURIWhitespaceChk);
            this.DecorationsGroupBox.Controls.Add(this.EmailLinksChk);
            this.DecorationsGroupBox.Controls.Add(this.QuotesChk);
            this.DecorationsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.DecorationsGroupBox.Name = "DecorationsGroupBox";
            this.DecorationsGroupBox.Size = new System.Drawing.Size(362, 138);
            this.DecorationsGroupBox.TabIndex = 0;
            this.DecorationsGroupBox.TabStop = false;
            this.DecorationsGroupBox.Text = "Decorations";
            // 
            // OptionalQuotesChk
            // 
            this.OptionalQuotesChk.AutoSize = true;
            this.OptionalQuotesChk.Enabled = false;
            this.OptionalQuotesChk.Location = new System.Drawing.Point(25, 42);
            this.OptionalQuotesChk.Name = "OptionalQuotesChk";
            this.OptionalQuotesChk.Size = new System.Drawing.Size(150, 17);
            this.OptionalQuotesChk.TabIndex = 1;
            this.OptionalQuotesChk.Text = "...only if it contains s&paces";
            this.OptionalQuotesChk.UseVisualStyleBackColor = true;
            // 
            // EncodeURICharsChk
            // 
            this.EncodeURICharsChk.AutoSize = true;
            this.EncodeURICharsChk.Enabled = false;
            this.EncodeURICharsChk.Location = new System.Drawing.Point(25, 111);
            this.EncodeURICharsChk.Name = "EncodeURICharsChk";
            this.EncodeURICharsChk.Size = new System.Drawing.Size(225, 17);
            this.EncodeURICharsChk.TabIndex = 4;
            this.EncodeURICharsChk.Text = "...and all in&valid URI characters (e.g., %xx)";
            this.EncodeURICharsChk.UseVisualStyleBackColor = true;
            // 
            // EncodeURIWhitespaceChk
            // 
            this.EncodeURIWhitespaceChk.AutoSize = true;
            this.EncodeURIWhitespaceChk.Location = new System.Drawing.Point(6, 88);
            this.EncodeURIWhitespaceChk.Name = "EncodeURIWhitespaceChk";
            this.EncodeURIWhitespaceChk.Size = new System.Drawing.Size(287, 17);
            this.EncodeURIWhitespaceChk.TabIndex = 3;
            this.EncodeURIWhitespaceChk.Text = "Encode w&hitespace using percent-encoding (e.g., %20)";
            this.EncodeURIWhitespaceChk.UseVisualStyleBackColor = true;
            this.EncodeURIWhitespaceChk.CheckedChanged += new System.EventHandler(this.EncodeURIWhitespaceChk_CheckedChanged);
            // 
            // EmailLinksChk
            // 
            this.EmailLinksChk.AutoSize = true;
            this.EmailLinksChk.Location = new System.Drawing.Point(6, 65);
            this.EmailLinksChk.Name = "EmailLinksChk";
            this.EmailLinksChk.Size = new System.Drawing.Size(243, 17);
            this.EmailLinksChk.TabIndex = 2;
            this.EmailLinksChk.Text = "Enclose path in < and > (to create e-&mail links)";
            this.EmailLinksChk.UseVisualStyleBackColor = true;
            // 
            // QuotesChk
            // 
            this.QuotesChk.AutoSize = true;
            this.QuotesChk.Location = new System.Drawing.Point(6, 19);
            this.QuotesChk.Name = "QuotesChk";
            this.QuotesChk.Size = new System.Drawing.Size(177, 17);
            this.QuotesChk.TabIndex = 0;
            this.QuotesChk.Text = "Enclose path in &quotation marks";
            this.QuotesChk.UseVisualStyleBackColor = true;
            this.QuotesChk.CheckedChanged += new System.EventHandler(this.QuotesChk_CheckedChanged);
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(238, 539);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 3;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(319, 539);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ChooseExecutableOpenDlg
            // 
            this.ChooseExecutableOpenDlg.Filter = "Executable files (*.exe;*.com;*.bat;*.cmd)|*.exe;*.com;*.bat;*.cmd|All files (*.*" +
    ")|*.*";
            // 
            // PipelinePluginForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(406, 574);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 613);
            this.Name = "PipelinePluginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Command";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PipelinePluginForm_FormClosing);
            this.Load += new System.EventHandler(this.PipelinePluginForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.BasePluginPage.ResumeLayout(false);
            this.BasePluginPage.PerformLayout();
            this.OptionsPage.ResumeLayout(false);
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.FindReplaceGroupBox.ResumeLayout(false);
            this.FindReplaceGroupBox.PerformLayout();
            this.SlashesGroupBox.ResumeLayout(false);
            this.SlashesGroupBox.PerformLayout();
            this.DecorationsGroupBox.ResumeLayout(false);
            this.DecorationsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage BasePluginPage;
        private System.Windows.Forms.TabPage OptionsPage;
        private System.Windows.Forms.Label BaseCommandLbl2;
        private System.Windows.Forms.Label BaseCommandLbl;
        private System.Windows.Forms.ListBox BasePluginLst;
        private System.Windows.Forms.GroupBox DecorationsGroupBox;
        private System.Windows.Forms.CheckBox QuotesChk;
        private System.Windows.Forms.GroupBox SlashesGroupBox;
        private System.Windows.Forms.RadioButton NoSlashesChangeRadio;
        private System.Windows.Forms.RadioButton BackToForwardSlashesRadio;
        private System.Windows.Forms.RadioButton ForwardToBackslashesRadio;
        private System.Windows.Forms.GroupBox FindReplaceGroupBox;
        private System.Windows.Forms.TextBox ReplaceTxt;
        private System.Windows.Forms.Label ReplaceLbl;
        private System.Windows.Forms.TextBox FindTxt;
        private System.Windows.Forms.Label FindLbl;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.CheckBox IgnoreCaseChk;
        private System.Windows.Forms.CheckBox UseRegexChk;
        private System.Windows.Forms.Button TestRegexBtn;
        private System.Windows.Forms.CheckBox EmailLinksChk;
        private System.Windows.Forms.CheckBox EncodeURIWhitespaceChk;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.CheckBox CopyOnSameLineChk;
        private System.Windows.Forms.CheckBox EncodeURICharsChk;
        private System.Windows.Forms.Button BrowserForExecutableBtn;
        private System.Windows.Forms.TextBox ExecutableTxt;
        private System.Windows.Forms.Label ExecutableLbl;
        private System.Windows.Forms.CheckBox LaunchExecutableChk;
        private System.Windows.Forms.OpenFileDialog ChooseExecutableOpenDlg;
        private System.Windows.Forms.CheckBox OptionalQuotesChk;
    }
}