namespace Battleship
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
            this.pointLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shotStatusLabel = new System.Windows.Forms.Label();
            this.selectedPointTextBox = new System.Windows.Forms.TextBox();
            this.shotStatusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shipwreckTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pointLabel.Location = new System.Drawing.Point(18, 25);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(127, 20);
            this.pointLabel.TabIndex = 8;
            this.pointLabel.Text = "Selected Point: ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(141, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 305);
            this.panel1.TabIndex = 9;
            // 
            // shotStatusLabel
            // 
            this.shotStatusLabel.AutoSize = true;
            this.shotStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shotStatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shotStatusLabel.Location = new System.Drawing.Point(17, 62);
            this.shotStatusLabel.Name = "shotStatusLabel";
            this.shotStatusLabel.Size = new System.Drawing.Size(101, 20);
            this.shotStatusLabel.TabIndex = 10;
            this.shotStatusLabel.Text = "Shot Status:";
            // 
            // selectedPointTextBox
            // 
            this.selectedPointTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedPointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPointTextBox.Location = new System.Drawing.Point(152, 26);
            this.selectedPointTextBox.Name = "selectedPointTextBox";
            this.selectedPointTextBox.ReadOnly = true;
            this.selectedPointTextBox.Size = new System.Drawing.Size(201, 19);
            this.selectedPointTextBox.TabIndex = 11;
            // 
            // shotStatusTextBox
            // 
            this.shotStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shotStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shotStatusTextBox.Location = new System.Drawing.Point(152, 64);
            this.shotStatusTextBox.Name = "shotStatusTextBox";
            this.shotStatusTextBox.ReadOnly = true;
            this.shotStatusTextBox.Size = new System.Drawing.Size(201, 19);
            this.shotStatusTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(18, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Shipwrecks:";
            // 
            // shipwreckTextBox
            // 
            this.shipwreckTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shipwreckTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipwreckTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shipwreckTextBox.Location = new System.Drawing.Point(152, 102);
            this.shipwreckTextBox.Name = "shipwreckTextBox";
            this.shipwreckTextBox.ReadOnly = true;
            this.shipwreckTextBox.Size = new System.Drawing.Size(395, 19);
            this.shipwreckTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 524);
            this.Controls.Add(this.shipwreckTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shotStatusTextBox);
            this.Controls.Add(this.selectedPointTextBox);
            this.Controls.Add(this.shotStatusLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pointLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Battleship Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shotStatusLabel;
        private System.Windows.Forms.TextBox selectedPointTextBox;
        private System.Windows.Forms.TextBox shotStatusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shipwreckTextBox;
    }
}

