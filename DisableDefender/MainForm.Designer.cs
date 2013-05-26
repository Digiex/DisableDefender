namespace DisableDefender
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.understandBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.disableButton = new System.Windows.Forms.Button();
            this.xdaLink = new System.Windows.Forms.LinkLabel();
            this.enableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // understandBox
            // 
            this.understandBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.understandBox.AutoSize = true;
            this.understandBox.Location = new System.Drawing.Point(12, 118);
            this.understandBox.Name = "understandBox";
            this.understandBox.Size = new System.Drawing.Size(407, 17);
            this.understandBox.TabIndex = 0;
            this.understandBox.Text = "I understand that disabling Windows Defender might affect the security of this PC" +
    "";
            this.understandBox.UseVisualStyleBackColor = true;
            this.understandBox.CheckedChanged += new System.EventHandler(this.understandBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // logoBox
            // 
            this.logoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoBox.Location = new System.Drawing.Point(486, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(32, 32);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 2;
            this.logoBox.TabStop = false;
            // 
            // disableButton
            // 
            this.disableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disableButton.Enabled = false;
            this.disableButton.Location = new System.Drawing.Point(442, 112);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(75, 23);
            this.disableButton.TabIndex = 3;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // xdaLink
            // 
            this.xdaLink.AutoSize = true;
            this.xdaLink.Location = new System.Drawing.Point(15, 87);
            this.xdaLink.Name = "xdaLink";
            this.xdaLink.Size = new System.Drawing.Size(167, 13);
            this.xdaLink.TabIndex = 4;
            this.xdaLink.TabStop = true;
            this.xdaLink.Text = "XDA Thread. Created by jessenic.";
            this.xdaLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.xdaLink_LinkClicked);
            // 
            // enableButton
            // 
            this.enableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enableButton.Location = new System.Drawing.Point(442, 87);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(75, 23);
            this.enableButton.TabIndex = 5;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 147);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.xdaLink);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.understandBox);
            this.Name = "MainForm";
            this.Text = "Disable Windows Defender";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox understandBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.LinkLabel xdaLink;
        private System.Windows.Forms.Button enableButton;
    }
}

