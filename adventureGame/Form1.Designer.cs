namespace adventureGame
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
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.leaveButton = new System.Windows.Forms.Button();
            this.honkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.Transparent;
            this.option1Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.option1Button.FlatAppearance.BorderSize = 0;
            this.option1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.option1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Button.ForeColor = System.Drawing.Color.White;
            this.option1Button.Location = new System.Drawing.Point(64, 367);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(38, 31);
            this.option1Button.TabIndex = 0;
            this.option1Button.Text = ">";
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.option2Button.FlatAppearance.BorderSize = 0;
            this.option2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.option2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Button.ForeColor = System.Drawing.Color.White;
            this.option2Button.Location = new System.Drawing.Point(64, 404);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(38, 31);
            this.option2Button.TabIndex = 1;
            this.option2Button.Text = ">";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option2Label
            // 
            this.option2Label.BackColor = System.Drawing.Color.Transparent;
            this.option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(117, 407);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(323, 31);
            this.option2Label.TabIndex = 3;
            this.option2Label.Text = "Hide";
            // 
            // option1Label
            // 
            this.option1Label.BackColor = System.Drawing.Color.Transparent;
            this.option1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(117, 370);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(323, 31);
            this.option1Label.TabIndex = 2;
            this.option1Label.Text = "Look around";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(428, 86);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "You are stuck in a pizzeria with killer animatronics. Do you Hide or do you Look " +
    "Around";
            // 
            // leaveButton
            // 
            this.leaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leaveButton.FlatAppearance.BorderSize = 0;
            this.leaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveButton.ForeColor = System.Drawing.Color.White;
            this.leaveButton.Location = new System.Drawing.Point(389, 64);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(51, 31);
            this.leaveButton.TabIndex = 5;
            this.leaveButton.Text = "Leave?";
            this.leaveButton.UseVisualStyleBackColor = false;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // honkButton
            // 
            this.honkButton.BackColor = System.Drawing.Color.Black;
            this.honkButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.honkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.honkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.honkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.honkButton.ForeColor = System.Drawing.Color.Black;
            this.honkButton.Location = new System.Drawing.Point(233, 190);
            this.honkButton.Name = "honkButton";
            this.honkButton.Size = new System.Drawing.Size(35, 21);
            this.honkButton.TabIndex = 6;
            this.honkButton.UseVisualStyleBackColor = false;
            this.honkButton.Click += new System.EventHandler(this.honkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::adventureGame.Properties.Resources.freddyBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.honkButton);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "adventureGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button honkButton;
    }
}

