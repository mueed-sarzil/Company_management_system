namespace CompanyManagementSystem
{
    partial class ClientPanel
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
            this.buttonaddClient = new System.Windows.Forms.Button();
            this.buttonClientDetails = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonaddClient
            // 
            this.buttonaddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonaddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddClient.Location = new System.Drawing.Point(94, 177);
            this.buttonaddClient.Name = "buttonaddClient";
            this.buttonaddClient.Size = new System.Drawing.Size(186, 44);
            this.buttonaddClient.TabIndex = 1;
            this.buttonaddClient.Text = "New Client";
            this.buttonaddClient.UseVisualStyleBackColor = false;
            this.buttonaddClient.Click += new System.EventHandler(this.buttonaddClient_Click);
            // 
            // buttonClientDetails
            // 
            this.buttonClientDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientDetails.Location = new System.Drawing.Point(322, 177);
            this.buttonClientDetails.Name = "buttonClientDetails";
            this.buttonClientDetails.Size = new System.Drawing.Size(186, 44);
            this.buttonClientDetails.TabIndex = 2;
            this.buttonClientDetails.Text = "Client Details";
            this.buttonClientDetails.UseVisualStyleBackColor = false;
            this.buttonClientDetails.Click += new System.EventHandler(this.buttonClientDetails_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(555, -2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(68, 28);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "<<Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CompanyManagementSystem.Properties.Resources.client1;
            this.pictureBox1.Location = new System.Drawing.Point(94, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(623, 304);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClientDetails);
            this.Controls.Add(this.buttonaddClient);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClientPanel";
            this.Text = "ClientPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonaddClient;
        private System.Windows.Forms.Button buttonClientDetails;
        private System.Windows.Forms.Button buttonBack;
    }
}