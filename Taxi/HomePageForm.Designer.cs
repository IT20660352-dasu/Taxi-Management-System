namespace Taxi
{
    partial class HomePageForm
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
            this.buttonDriver = new System.Windows.Forms.Button();
            this.buttonRider = new System.Windows.Forms.Button();
            this.buttonTrip = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDriver
            // 
            this.buttonDriver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDriver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDriver.Location = new System.Drawing.Point(86, 71);
            this.buttonDriver.Name = "buttonDriver";
            this.buttonDriver.Size = new System.Drawing.Size(102, 49);
            this.buttonDriver.TabIndex = 0;
            this.buttonDriver.Text = "Driver";
            this.buttonDriver.UseVisualStyleBackColor = false;
            this.buttonDriver.Click += new System.EventHandler(this.buttonDriver_Click);
            // 
            // buttonRider
            // 
            this.buttonRider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRider.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRider.Location = new System.Drawing.Point(86, 126);
            this.buttonRider.Name = "buttonRider";
            this.buttonRider.Size = new System.Drawing.Size(102, 49);
            this.buttonRider.TabIndex = 1;
            this.buttonRider.Text = "Rider";
            this.buttonRider.UseVisualStyleBackColor = false;
            this.buttonRider.Click += new System.EventHandler(this.buttonRider_Click);
            // 
            // buttonTrip
            // 
            this.buttonTrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTrip.Location = new System.Drawing.Point(86, 181);
            this.buttonTrip.Name = "buttonTrip";
            this.buttonTrip.Size = new System.Drawing.Size(102, 49);
            this.buttonTrip.TabIndex = 2;
            this.buttonTrip.Text = "Trip";
            this.buttonTrip.UseVisualStyleBackColor = false;
            this.buttonTrip.Click += new System.EventHandler(this.buttonTrip_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogOut.Location = new System.Drawing.Point(86, 236);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(102, 49);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 286);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonTrip);
            this.Controls.Add(this.buttonRider);
            this.Controls.Add(this.buttonDriver);
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDriver;
        private System.Windows.Forms.Button buttonRider;
        private System.Windows.Forms.Button buttonTrip;
        private System.Windows.Forms.Button buttonLogOut;
    }
}