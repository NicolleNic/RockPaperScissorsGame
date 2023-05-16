
namespace RockPaperScissorsGame
{
    partial class RockPaperScissors
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbPaper = new System.Windows.Forms.PictureBox();
            this.pbScissors = new System.Windows.Forms.PictureBox();
            this.pbRock = new System.Windows.Forms.PictureBox();
            this.pbComputerChoice = new System.Windows.Forms.PictureBox();
            this.pbUserChoice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(362, 31);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(183, 22);
            this.tbUsername.TabIndex = 5;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStart.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(285, 193);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 49);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnReset.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(147, 496);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 44);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(404, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 44);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter your username:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Humnst777 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(42, 78);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 25);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Your name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Humnst777 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Computer";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Humnst777 Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(306, 123);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(54, 30);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "X:X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Humnst777 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Choose your picture:";
            // 
            // pbPaper
            // 
            this.pbPaper.Image = global::RockPaperScissorsGame.Properties.Resources.paper;
            this.pbPaper.Location = new System.Drawing.Point(251, 338);
            this.pbPaper.Name = "pbPaper";
            this.pbPaper.Size = new System.Drawing.Size(169, 136);
            this.pbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPaper.TabIndex = 4;
            this.pbPaper.TabStop = false;
            this.pbPaper.Click += new System.EventHandler(this.pbPaper_Click);
            // 
            // pbScissors
            // 
            this.pbScissors.Image = global::RockPaperScissorsGame.Properties.Resources.unnamed;
            this.pbScissors.Location = new System.Drawing.Point(459, 338);
            this.pbScissors.Name = "pbScissors";
            this.pbScissors.Size = new System.Drawing.Size(169, 136);
            this.pbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScissors.TabIndex = 3;
            this.pbScissors.TabStop = false;
            this.pbScissors.Click += new System.EventHandler(this.pbScissors_Click);
            // 
            // pbRock
            // 
            this.pbRock.Image = global::RockPaperScissorsGame.Properties.Resources.rock;
            this.pbRock.Location = new System.Drawing.Point(47, 338);
            this.pbRock.Name = "pbRock";
            this.pbRock.Size = new System.Drawing.Size(169, 136);
            this.pbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRock.TabIndex = 2;
            this.pbRock.TabStop = false;
            this.pbRock.Click += new System.EventHandler(this.pbRock_Click);
            // 
            // pbComputerChoice
            // 
            this.pbComputerChoice.Image = global::RockPaperScissorsGame.Properties.Resources.smile;
            this.pbComputerChoice.Location = new System.Drawing.Point(419, 106);
            this.pbComputerChoice.Name = "pbComputerChoice";
            this.pbComputerChoice.Size = new System.Drawing.Size(210, 160);
            this.pbComputerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputerChoice.TabIndex = 1;
            this.pbComputerChoice.TabStop = false;
            // 
            // pbUserChoice
            // 
            this.pbUserChoice.Image = global::RockPaperScissorsGame.Properties.Resources.smile;
            this.pbUserChoice.Location = new System.Drawing.Point(47, 106);
            this.pbUserChoice.Name = "pbUserChoice";
            this.pbUserChoice.Size = new System.Drawing.Size(210, 160);
            this.pbUserChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserChoice.TabIndex = 0;
            this.pbUserChoice.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(701, 587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pbPaper);
            this.Controls.Add(this.pbScissors);
            this.Controls.Add(this.pbRock);
            this.Controls.Add(this.pbComputerChoice);
            this.Controls.Add(this.pbUserChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserChoice;
        private System.Windows.Forms.PictureBox pbComputerChoice;
        private System.Windows.Forms.PictureBox pbRock;
        private System.Windows.Forms.PictureBox pbScissors;
        private System.Windows.Forms.PictureBox pbPaper;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
    }
}

