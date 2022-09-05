namespace Group15_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTopLayout = new System.Windows.Forms.Panel();
            this.pnlBottomLayout = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeTwo = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlTopLayout.SuspendLayout();
            this.pnlBottomLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMain.Controls.Add(this.pnlBottomLayout);
            this.pnlMain.Controls.Add(this.pnlTopLayout);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(186, 577);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTopLayout
            // 
            this.pnlTopLayout.Controls.Add(this.lblWelcomeTwo);
            this.pnlTopLayout.Controls.Add(this.lblWelcome);
            this.pnlTopLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLayout.Name = "pnlTopLayout";
            this.pnlTopLayout.Size = new System.Drawing.Size(186, 144);
            this.pnlTopLayout.TabIndex = 0;
            // 
            // pnlBottomLayout
            // 
            this.pnlBottomLayout.Controls.Add(this.btnReport);
            this.pnlBottomLayout.Controls.Add(this.btnHelp);
            this.pnlBottomLayout.Controls.Add(this.btnPass);
            this.pnlBottomLayout.Controls.Add(this.btnFlights);
            this.pnlBottomLayout.Controls.Add(this.btnNew);
            this.pnlBottomLayout.Controls.Add(this.btnExit);
            this.pnlBottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomLayout.Location = new System.Drawing.Point(0, 144);
            this.pnlBottomLayout.Name = "pnlBottomLayout";
            this.pnlBottomLayout.Size = new System.Drawing.Size(186, 433);
            this.pnlBottomLayout.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(32, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(123, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to ";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWelcomeTwo
            // 
            this.lblWelcomeTwo.AutoSize = true;
            this.lblWelcomeTwo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeTwo.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeTwo.Location = new System.Drawing.Point(23, 76);
            this.lblWelcomeTwo.Name = "lblWelcomeTwo";
            this.lblWelcomeTwo.Size = new System.Drawing.Size(147, 25);
            this.lblWelcomeTwo.TabIndex = 1;
            this.lblWelcomeTwo.Text = "the Main Menu";
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(186, 35);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&Add New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnFlights
            // 
            this.btnFlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFlights.FlatAppearance.BorderSize = 0;
            this.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlights.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlights.ForeColor = System.Drawing.Color.White;
            this.btnFlights.Location = new System.Drawing.Point(0, 35);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(186, 35);
            this.btnFlights.TabIndex = 3;
            this.btnFlights.Text = "&View Flights";
            this.btnFlights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlights.UseVisualStyleBackColor = true;
            // 
            // btnPass
            // 
            this.btnPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.ForeColor = System.Drawing.Color.White;
            this.btnPass.Location = new System.Drawing.Point(0, 70);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(186, 35);
            this.btnPass.TabIndex = 4;
            this.btnPass.Text = "&View Passengers";
            this.btnPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPass.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(0, 373);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(186, 35);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(0, 105);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(186, 35);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "&Generate Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTopLayout.ResumeLayout(false);
            this.pnlTopLayout.PerformLayout();
            this.pnlBottomLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottomLayout;
        private System.Windows.Forms.Panel pnlTopLayout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcomeTwo;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnFlights;
    }
}

