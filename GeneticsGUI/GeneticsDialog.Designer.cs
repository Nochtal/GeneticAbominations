namespace GeneticsGUI
{
    partial class GeneticsDialog
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
            this.btnYes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblContext = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(270, 111);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(98, 38);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "OK";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Location = new System.Drawing.Point(12, 32);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(281, 24);
            this.lblContext.TabIndex = 2;
            this.lblContext.Text = "Context Passed When Called";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 76);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(460, 29);
            this.txtInput.TabIndex = 3;
            // 
            // GeneticsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "GeneticsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GeneticsDialog";
            this.Load += new System.EventHandler(this.GeneticsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.TextBox txtInput;
    }
}