namespace FightingClub_Nikita.PlayerItems
{
    partial class PlayerForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnHead = new System.Windows.Forms.Button();
            this.btnBody = new System.Windows.Forms.Button();
            this.btnLeg = new System.Windows.Forms.Button();
            this.playerPicture = new System.Windows.Forms.PictureBox();
            this.lblEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(129, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 36);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(46, 286);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(29, 17);
            this.lblHP.TabIndex = 2;
            this.lblHP.Text = "HP";
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.Location = new System.Drawing.Point(79, 283);
            this.progressBarHealth.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(167, 23);
            this.progressBarHealth.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(128, 327);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 28);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Attack";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHead
            // 
            this.btnHead.Location = new System.Drawing.Point(10, 370);
            this.btnHead.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(90, 40);
            this.btnHead.TabIndex = 5;
            this.btnHead.Text = "Head";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.BodyButton_Clicked);
            // 
            // btnBody
            // 
            this.btnBody.Location = new System.Drawing.Point(112, 370);
            this.btnBody.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnBody.Name = "btnBody";
            this.btnBody.Size = new System.Drawing.Size(90, 40);
            this.btnBody.TabIndex = 10;
            this.btnBody.Text = "Body";
            this.btnBody.UseVisualStyleBackColor = true;
            this.btnBody.Click += new System.EventHandler(this.BodyButton_Clicked);
            // 
            // btnLeg
            // 
            this.btnLeg.Location = new System.Drawing.Point(215, 370);
            this.btnLeg.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnLeg.Name = "btnLeg";
            this.btnLeg.Size = new System.Drawing.Size(90, 40);
            this.btnLeg.TabIndex = 11;
            this.btnLeg.Text = "Leg";
            this.btnLeg.UseVisualStyleBackColor = true;
            this.btnLeg.Click += new System.EventHandler(this.BodyButton_Clicked);
            // 
            // playerPicture
            // 
            this.playerPicture.Image = global::FightingClub_Nikita.Properties.Resources.Fighter1;
            this.playerPicture.Location = new System.Drawing.Point(79, 48);
            this.playerPicture.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.playerPicture.Name = "playerPicture";
            this.playerPicture.Size = new System.Drawing.Size(167, 230);
            this.playerPicture.TabIndex = 13;
            this.playerPicture.TabStop = false;
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Sitka Banner", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblEnd.Location = new System.Drawing.Point(128, 327);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(57, 32);
            this.lblEnd.TabIndex = 14;
            this.lblEnd.Text = "dead";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnd.Visible = false;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 430);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.progressBarHealth);
            this.Controls.Add(this.playerPicture);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnHead);
            this.Controls.Add(this.btnBody);
            this.Controls.Add(this.btnLeg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerForm";
            this.ShowInTaskbar = false;
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.PictureBox playerPicture;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.Button btnBody;
        private System.Windows.Forms.Button btnLeg;
        private System.Windows.Forms.Label lblEnd;
    }
}