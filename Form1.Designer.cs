
namespace Magic8Ball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.eightBallButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(680, 116);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Think of a Question";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eightBallButton
            // 
            this.eightBallButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eightBallButton.BackgroundImage")));
            this.eightBallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eightBallButton.FlatAppearance.BorderSize = 0;
            this.eightBallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eightBallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eightBallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightBallButton.Location = new System.Drawing.Point(20, 94);
            this.eightBallButton.Name = "eightBallButton";
            this.eightBallButton.Size = new System.Drawing.Size(638, 495);
            this.eightBallButton.TabIndex = 1;
            this.eightBallButton.UseVisualStyleBackColor = true;
            this.eightBallButton.Click += new System.EventHandler(this.eightBallButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 645);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(656, 56);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(680, 699);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.eightBallButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button eightBallButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

