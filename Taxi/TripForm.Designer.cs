namespace Taxi
{
    partial class TripForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPickUpLocation = new System.Windows.Forms.TextBox();
            this.textBoxDropLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTrip = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxDriver = new System.Windows.Forms.ComboBox();
            this.comboBoxRider = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trip Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pick Up Location";
            // 
            // textBoxPickUpLocation
            // 
            this.textBoxPickUpLocation.Location = new System.Drawing.Point(135, 59);
            this.textBoxPickUpLocation.Name = "textBoxPickUpLocation";
            this.textBoxPickUpLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxPickUpLocation.TabIndex = 2;
            // 
            // textBoxDropLocation
            // 
            this.textBoxDropLocation.Location = new System.Drawing.Point(135, 94);
            this.textBoxDropLocation.Name = "textBoxDropLocation";
            this.textBoxDropLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxDropLocation.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deop Location";
            // 
            // textBoxFar
            // 
            this.textBoxFar.Location = new System.Drawing.Point(135, 129);
            this.textBoxFar.Name = "textBoxFar";
            this.textBoxFar.Size = new System.Drawing.Size(100, 20);
            this.textBoxFar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Far";
            // 
            // dataGridViewTrip
            // 
            this.dataGridViewTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrip.Location = new System.Drawing.Point(300, 43);
            this.dataGridViewTrip.Name = "dataGridViewTrip";
            this.dataGridViewTrip.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTrip.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(78, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(374, 239);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.FormattingEnabled = true;
            this.comboBoxDriver.Location = new System.Drawing.Point(135, 159);
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDriver.TabIndex = 10;
            this.comboBoxDriver.Tag = "";
            // 
            // comboBoxRider
            // 
            this.comboBoxRider.FormattingEnabled = true;
            this.comboBoxRider.Location = new System.Drawing.Point(135, 189);
            this.comboBoxRider.Name = "comboBoxRider";
            this.comboBoxRider.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRider.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Driver";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rider";
            // 
            // TripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 375);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxRider);
            this.Controls.Add(this.comboBoxDriver);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewTrip);
            this.Controls.Add(this.textBoxFar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDropLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPickUpLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TripForm";
            this.Text = "TripForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPickUpLocation;
        private System.Windows.Forms.TextBox textBoxDropLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewTrip;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxDriver;
        private System.Windows.Forms.ComboBox comboBoxRider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}