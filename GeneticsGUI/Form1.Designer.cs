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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.lsvPopulation = new System.Windows.Forms.ListView();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Generation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSort = new System.Windows.Forms.Button();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnMate = new System.Windows.Forms.Button();
            this.cboMateOne = new System.Windows.Forms.ComboBox();
            this.cboMateTwo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplay.Location = new System.Drawing.Point(268, 37);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(422, 574);
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
            this.lsvPopulation.Location = new System.Drawing.Point(12, 37);
            this.lsvPopulation.MultiSelect = false;
            this.lsvPopulation.Name = "lsvPopulation";
            this.lsvPopulation.Size = new System.Drawing.Size(250, 451);
            this.lsvPopulation.TabIndex = 1;
            this.lsvPopulation.UseCompatibleStateImageBehavior = false;
            this.lsvPopulation.View = System.Windows.Forms.View.Details;
            this.lsvPopulation.SelectedIndexChanged += new System.EventHandler(this.lsvPopulation_SelectedIndexChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(265, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(85, 25);
            this.lblDisplay.TabIndex = 2;
            this.lblDisplay.Text = "Details";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulation.Location = new System.Drawing.Point(12, 9);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(124, 25);
            this.lblPopulation.TabIndex = 3;
            this.lblPopulation.Text = "Population";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // Generation
            // 
            this.Generation.Text = "Generation";
            this.Generation.Width = 120;
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(12, 488);
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
            this.cboSort.Location = new System.Drawing.Point(125, 496);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(137, 28);
            this.cboSort.TabIndex = 5;
            // 
            // btnMate
            // 
            this.btnMate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMate.Location = new System.Drawing.Point(12, 569);
            this.btnMate.Name = "btnMate";
            this.btnMate.Size = new System.Drawing.Size(248, 42);
            this.btnMate.TabIndex = 6;
            this.btnMate.Text = "Mate";
            this.btnMate.UseVisualStyleBackColor = true;
            this.btnMate.Click += new System.EventHandler(this.btnMate_Click);
            // 
            // cboMateOne
            // 
            this.cboMateOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMateOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMateOne.FormattingEnabled = true;
            this.cboMateOne.Location = new System.Drawing.Point(12, 535);
            this.cboMateOne.Name = "cboMateOne";
            this.cboMateOne.Size = new System.Drawing.Size(121, 28);
            this.cboMateOne.TabIndex = 7;
            // 
            // cboMateTwo
            // 
            this.cboMateTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMateTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMateTwo.FormattingEnabled = true;
            this.cboMateTwo.Location = new System.Drawing.Point(139, 535);
            this.cboMateTwo.Name = "cboMateTwo";
            this.cboMateTwo.Size = new System.Drawing.Size(121, 28);
            this.cboMateTwo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 623);
            this.Controls.Add(this.cboMateTwo);
            this.Controls.Add(this.cboMateOne);
            this.Controls.Add(this.btnMate);
            this.Controls.Add(this.cboSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lsvPopulation);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "Form1";
            this.Text = "Genetic Abominations";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ComboBox cboMateOne;
        private System.Windows.Forms.ComboBox cboMateTwo;
    }
}

