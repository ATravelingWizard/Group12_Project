namespace Group15_Project
{
    partial class Output
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
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxOutput
            // 
            this.lbxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lbxOutput.ForeColor = System.Drawing.Color.White;
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(12, 12);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(421, 329);
            this.lbxOutput.TabIndex = 0;
            this.lbxOutput.SelectedIndexChanged += new System.EventHandler(this.lbxOutput_SelectedIndexChanged);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(13, 348);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(150, 46);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "Output to PDF";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(282, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(444, 405);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.lbxOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Output";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Output";
            this.Load += new System.EventHandler(this.Output_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnClose;
    }
}