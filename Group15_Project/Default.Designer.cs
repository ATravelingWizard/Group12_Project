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
            this.pnlBottomLayout = new System.Windows.Forms.Panel();
            this.btnViewFlights = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnAddNewFlight = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTopLayout = new System.Windows.Forms.Panel();
            this.lblWelcomeTwo = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlBottomLayout.SuspendLayout();
            this.pnlTopLayout.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(186, 762);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBottomLayout
            // 
            this.pnlBottomLayout.Controls.Add(this.btnViewFlights);
            this.pnlBottomLayout.Controls.Add(this.btnPass);
            this.pnlBottomLayout.Controls.Add(this.btnAddNewFlight);
            this.pnlBottomLayout.Controls.Add(this.btnNew);
            this.pnlBottomLayout.Controls.Add(this.btnExit);
            this.pnlBottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomLayout.Location = new System.Drawing.Point(0, 144);
            this.pnlBottomLayout.Name = "pnlBottomLayout";
            this.pnlBottomLayout.Size = new System.Drawing.Size(186, 618);
            this.pnlBottomLayout.TabIndex = 1;
            this.pnlBottomLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBottomLayout_Paint);
            // 
            // btnViewFlights
            // 
            this.btnViewFlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewFlights.FlatAppearance.BorderSize = 0;
            this.btnViewFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFlights.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFlights.ForeColor = System.Drawing.Color.White;
            this.btnViewFlights.Location = new System.Drawing.Point(0, 105);
            this.btnViewFlights.Name = "btnViewFlights";
            this.btnViewFlights.Size = new System.Drawing.Size(186, 35);
            this.btnViewFlights.TabIndex = 5;
            this.btnViewFlights.Text = "&View Flights";
            this.btnViewFlights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFlights.UseVisualStyleBackColor = true;
            this.btnViewFlights.Click += new System.EventHandler(this.btnViewFlights_Click);
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
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnAddNewFlight
            // 
            this.btnAddNewFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewFlight.FlatAppearance.BorderSize = 0;
            this.btnAddNewFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewFlight.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewFlight.ForeColor = System.Drawing.Color.White;
            this.btnAddNewFlight.Location = new System.Drawing.Point(0, 35);
            this.btnAddNewFlight.Name = "btnAddNewFlight";
            this.btnAddNewFlight.Size = new System.Drawing.Size(186, 35);
            this.btnAddNewFlight.TabIndex = 3;
            this.btnAddNewFlight.Text = "&Add Flights";
            this.btnAddNewFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewFlight.UseVisualStyleBackColor = true;
            this.btnAddNewFlight.Click += new System.EventHandler(this.btnFlights_Click);
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
            this.btnNew.Text = "&Add New Passenger";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 593);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // lblWelcomeTwo
            // 
            this.lblWelcomeTwo.AutoSize = true;
            this.lblWelcomeTwo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeTwo.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeTwo.Location = new System.Drawing.Point(3, 77);
            this.lblWelcomeTwo.Name = "lblWelcomeTwo";
            this.lblWelcomeTwo.Size = new System.Drawing.Size(180, 25);
            this.lblWelcomeTwo.TabIndex = 1;
            this.lblWelcomeTwo.Text = "SkyFall Main Menu";
            this.lblWelcomeTwo.Click += new System.EventHandler(this.lblWelcomeTwo_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(12, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(151, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1252, 762);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlBottomLayout.ResumeLayout(false);
            this.pnlTopLayout.ResumeLayout(false);
            this.pnlTopLayout.PerformLayout();
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
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnAddNewFlight;
        private System.Windows.Forms.Button btnViewFlights;
    }
}

