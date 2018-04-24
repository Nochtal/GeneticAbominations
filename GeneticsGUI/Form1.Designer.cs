namespace GeneticsGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.lsvPopulation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Generation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnMate = new System.Windows.Forms.Button();
            this.btnRandMate = new System.Windows.Forms.Button();
            this.nudRandAmount = new System.Windows.Forms.NumericUpDown();
            this.lblMateSelected = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSocietyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSocietyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSocietyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSocietyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSocietyClassifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editCreatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNewCreatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.removeCreatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitGraveyardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandAmount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplay.Location = new System.Drawing.Point(268, 80);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(704, 619);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // lsvPopulation
            // 
            this.lsvPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvPopulation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Generation});
            this.lsvPopulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsvPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPopulation.FullRowSelect = true;
            this.lsvPopulation.GridLines = true;
            this.lsvPopulation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvPopulation.Location = new System.Drawing.Point(12, 52);
            this.lsvPopulation.MultiSelect = false;
            this.lsvPopulation.Name = "lsvPopulation";
            this.lsvPopulation.Size = new System.Drawing.Size(250, 470);
            this.lsvPopulation.TabIndex = 1;
            this.lsvPopulation.UseCompatibleStateImageBehavior = false;
            this.lsvPopulation.View = System.Windows.Forms.View.Details;
            this.lsvPopulation.SelectedIndexChanged += new System.EventHandler(this.lsvPopulation_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 149;
            // 
            // Generation
            // 
            this.Generation.Text = "Generation";
            this.Generation.Width = 95;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(263, 52);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(85, 25);
            this.lblDisplay.TabIndex = 2;
            this.lblDisplay.Text = "Details";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulation.Location = new System.Drawing.Point(12, 24);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(124, 25);
            this.lblPopulation.TabIndex = 3;
            this.lblPopulation.Text = "Population";
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(12, 576);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(107, 42);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort by:";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cboSort
            // 
            this.cboSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            "Name",
            "Youngest",
            "Oldest",
            "Generation",
            "Deviation",
            "Race",
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma",
            "Arcane",
            "Divine"});
            this.cboSort.Location = new System.Drawing.Point(125, 584);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(137, 28);
            this.cboSort.TabIndex = 5;
            this.cboSort.SelectedIndexChanged += new System.EventHandler(this.cboSort_SelectedIndexChanged);
            // 
            // btnMate
            // 
            this.btnMate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMate.Location = new System.Drawing.Point(12, 657);
            this.btnMate.Name = "btnMate";
            this.btnMate.Size = new System.Drawing.Size(250, 42);
            this.btnMate.TabIndex = 6;
            this.btnMate.Text = "Mate";
            this.btnMate.UseVisualStyleBackColor = true;
            this.btnMate.Click += new System.EventHandler(this.btnMate_Click);
            // 
            // btnRandMate
            // 
            this.btnRandMate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRandMate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandMate.Location = new System.Drawing.Point(12, 528);
            this.btnRandMate.Name = "btnRandMate";
            this.btnRandMate.Size = new System.Drawing.Size(107, 42);
            this.btnRandMate.TabIndex = 9;
            this.btnRandMate.Text = "Randomly Mate";
            this.btnRandMate.UseVisualStyleBackColor = true;
            this.btnRandMate.Click += new System.EventHandler(this.btnRandMate_Click);
            // 
            // nudRandAmount
            // 
            this.nudRandAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudRandAmount.Location = new System.Drawing.Point(126, 544);
            this.nudRandAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRandAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandAmount.Name = "nudRandAmount";
            this.nudRandAmount.Size = new System.Drawing.Size(136, 20);
            this.nudRandAmount.TabIndex = 10;
            this.nudRandAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandAmount.ValueChanged += new System.EventHandler(this.nudRandAmount_ValueChanged);
            this.nudRandAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudRandAmount_KeyUp);
            // 
            // lblMateSelected
            // 
            this.lblMateSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMateSelected.AutoSize = true;
            this.lblMateSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateSelected.Location = new System.Drawing.Point(8, 634);
            this.lblMateSelected.Name = "lblMateSelected";
            this.lblMateSelected.Size = new System.Drawing.Size(210, 20);
            this.lblMateSelected.TabIndex = 11;
            this.lblMateSelected.Text = "Select Two Creatures Above";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSocietyToolStripMenuItem,
            this.openSocietyToolStripMenuItem,
            this.closeSocietyToolStripMenuItem,
            this.toolStripSeparator3,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSocietyToolStripMenuItem
            // 
            this.newSocietyToolStripMenuItem.Name = "newSocietyToolStripMenuItem";
            this.newSocietyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.newSocietyToolStripMenuItem.Text = "New Society";
            this.newSocietyToolStripMenuItem.Click += new System.EventHandler(this.newSocietyToolStripMenuItem_Click);
            // 
            // openSocietyToolStripMenuItem
            // 
            this.openSocietyToolStripMenuItem.Name = "openSocietyToolStripMenuItem";
            this.openSocietyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openSocietyToolStripMenuItem.Text = "Open Society";
            this.openSocietyToolStripMenuItem.Click += new System.EventHandler(this.openSocietyToolStripMenuItem_Click);
            // 
            // closeSocietyToolStripMenuItem
            // 
            this.closeSocietyToolStripMenuItem.Name = "closeSocietyToolStripMenuItem";
            this.closeSocietyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.closeSocietyToolStripMenuItem.Text = "Close Society";
            this.closeSocietyToolStripMenuItem.Click += new System.EventHandler(this.closeSocietyToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSocietyNameToolStripMenuItem,
            this.changeSocietyClassifierToolStripMenuItem,
            this.toolStripSeparator2,
            this.editCreatureToolStripMenuItem,
            this.editNewCreatureToolStripMenuItem,
            this.toolStripSeparator4,
            this.removeCreatureToolStripMenuItem,
            this.advanceAgeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeSocietyNameToolStripMenuItem
            // 
            this.changeSocietyNameToolStripMenuItem.Name = "changeSocietyNameToolStripMenuItem";
            this.changeSocietyNameToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.changeSocietyNameToolStripMenuItem.Text = "Change Society Name";
            this.changeSocietyNameToolStripMenuItem.Click += new System.EventHandler(this.changeSocietyNameToolStripMenuItem_Click);
            // 
            // changeSocietyClassifierToolStripMenuItem
            // 
            this.changeSocietyClassifierToolStripMenuItem.Name = "changeSocietyClassifierToolStripMenuItem";
            this.changeSocietyClassifierToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.changeSocietyClassifierToolStripMenuItem.Text = "Change Society Classifier";
            this.changeSocietyClassifierToolStripMenuItem.Click += new System.EventHandler(this.changeSocietyClassifierToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // editCreatureToolStripMenuItem
            // 
            this.editCreatureToolStripMenuItem.Name = "editCreatureToolStripMenuItem";
            this.editCreatureToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.editCreatureToolStripMenuItem.Text = "Edit Creature";
            this.editCreatureToolStripMenuItem.Click += new System.EventHandler(this.editCreatureToolStripMenuItem_Click);
            // 
            // editNewCreatureToolStripMenuItem
            // 
            this.editNewCreatureToolStripMenuItem.Name = "editNewCreatureToolStripMenuItem";
            this.editNewCreatureToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.editNewCreatureToolStripMenuItem.Text = "Edit New Creature";
            this.editNewCreatureToolStripMenuItem.Click += new System.EventHandler(this.editNewCreatureToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(203, 6);
            // 
            // removeCreatureToolStripMenuItem
            // 
            this.removeCreatureToolStripMenuItem.Name = "removeCreatureToolStripMenuItem";
            this.removeCreatureToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.removeCreatureToolStripMenuItem.Text = "Remove Creature";
            this.removeCreatureToolStripMenuItem.Click += new System.EventHandler(this.removeCreatureToolStripMenuItem_Click);
            // 
            // advanceAgeToolStripMenuItem
            // 
            this.advanceAgeToolStripMenuItem.Name = "advanceAgeToolStripMenuItem";
            this.advanceAgeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.advanceAgeToolStripMenuItem.Text = "Advance Age";
            this.advanceAgeToolStripMenuItem.Click += new System.EventHandler(this.advanceAgeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editColorsToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.visitGraveyardToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // editColorsToolStripMenuItem
            // 
            this.editColorsToolStripMenuItem.Name = "editColorsToolStripMenuItem";
            this.editColorsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editColorsToolStripMenuItem.Text = "Edit Colors";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // visitGraveyardToolStripMenuItem
            // 
            this.visitGraveyardToolStripMenuItem.Name = "visitGraveyardToolStripMenuItem";
            this.visitGraveyardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visitGraveyardToolStripMenuItem.Text = "Visit Graveyard";
            this.visitGraveyardToolStripMenuItem.Click += new System.EventHandler(this.visitGraveyardToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // basicsToolStripMenuItem
            // 
            this.basicsToolStripMenuItem.Name = "basicsToolStripMenuItem";
            this.basicsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.basicsToolStripMenuItem.Text = "Basics";
            this.basicsToolStripMenuItem.Click += new System.EventHandler(this.basicsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.advancedToolStripMenuItem.Text = "Advanced";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.advancedToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.lblMateSelected);
            this.Controls.Add(this.nudRandAmount);
            this.Controls.Add(this.btnRandMate);
            this.Controls.Add(this.btnMate);
            this.Controls.Add(this.cboSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lsvPopulation);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetic Abominations";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRandAmount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.ListView lsvPopulation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Generation;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.Button btnMate;
        private System.Windows.Forms.Button btnRandMate;
        private System.Windows.Forms.NumericUpDown nudRandAmount;
        private System.Windows.Forms.Label lblMateSelected;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSocietyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSocietyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeSocietyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSocietyNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSocietyClassifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editCreatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNewCreatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem removeCreatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitGraveyardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceAgeToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    }
}

