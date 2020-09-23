namespace CompanyManagementSystem
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.buttonSoftware = new System.Windows.Forms.Button();
            this.buttonHRDept = new System.Windows.Forms.Button();
            this.buttonAcccounts = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(591, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(105, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Management System";
            // 
            // buttonManagement
            // 
            this.buttonManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManagement.Location = new System.Drawing.Point(112, 165);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(183, 51);
            this.buttonManagement.TabIndex = 1;
            this.buttonManagement.Text = "Management";
            this.buttonManagement.UseVisualStyleBackColor = false;
            this.buttonManagement.Click += new System.EventHandler(this.buttonManagement_Click);
            // 
            // buttonSoftware
            // 
            this.buttonSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoftware.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoftware.Location = new System.Drawing.Point(357, 165);
            this.buttonSoftware.Name = "buttonSoftware";
            this.buttonSoftware.Size = new System.Drawing.Size(183, 51);
            this.buttonSoftware.TabIndex = 2;
            this.buttonSoftware.Text = "Software";
            this.buttonSoftware.UseVisualStyleBackColor = false;
            this.buttonSoftware.Click += new System.EventHandler(this.buttonSoftware_Click);
            // 
            // buttonHRDept
            // 
            this.buttonHRDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonHRDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHRDept.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHRDept.Location = new System.Drawing.Point(112, 246);
            this.buttonHRDept.Name = "buttonHRDept";
            this.buttonHRDept.Size = new System.Drawing.Size(183, 51);
            this.buttonHRDept.TabIndex = 3;
            this.buttonHRDept.Text = "HR Department";
            this.buttonHRDept.UseVisualStyleBackColor = false;
            this.buttonHRDept.Click += new System.EventHandler(this.buttonHRDept_Click);
            // 
            // buttonAcccounts
            // 
            this.buttonAcccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAcccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcccounts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcccounts.Location = new System.Drawing.Point(357, 246);
            this.buttonAcccounts.Name = "buttonAcccounts";
            this.buttonAcccounts.Size = new System.Drawing.Size(183, 51);
            this.buttonAcccounts.TabIndex = 4;
            this.buttonAcccounts.Text = "Accounts";
            this.buttonAcccounts.UseVisualStyleBackColor = false;
            this.buttonAcccounts.Click += new System.EventHandler(this.buttonAcccounts_Click);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttendance.Location = new System.Drawing.Point(112, 328);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(183, 51);
            this.buttonAttendance.TabIndex = 5;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = false;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.Location = new System.Drawing.Point(357, 328);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(183, 51);
            this.buttonClient.TabIndex = 6;
            this.buttonClient.Text = "Client ";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(669, 471);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonAttendance);
            this.Controls.Add(this.buttonAcccounts);
            this.Controls.Add(this.buttonHRDept);
            this.Controls.Add(this.buttonSoftware);
            this.Controls.Add(this.buttonManagement);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonManagement;
        private System.Windows.Forms.Button buttonSoftware;
        private System.Windows.Forms.Button buttonHRDept;
        private System.Windows.Forms.Button buttonAcccounts;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button button1;
    }
}