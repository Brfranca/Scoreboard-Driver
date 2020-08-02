namespace BasketballTime
{
    partial class BasketballScoreboardControl
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRightT1 = new System.Windows.Forms.Button();
            this.btnLeftT1 = new System.Windows.Forms.Button();
            this.btnLeftT2 = new System.Windows.Forms.Button();
            this.btnRightT2 = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScoreT1 = new System.Windows.Forms.Label();
            this.lblScoreT2 = new System.Windows.Forms.Label();
            this.btnAddOneT1 = new System.Windows.Forms.Button();
            this.btnAddTwoT1 = new System.Windows.Forms.Button();
            this.btnAddThreeT1 = new System.Windows.Forms.Button();
            this.btnAddThreeT2 = new System.Windows.Forms.Button();
            this.btnAddTwoT2 = new System.Windows.Forms.Button();
            this.btnAddOneT2 = new System.Windows.Forms.Button();
            this.btnDecreaseT1 = new System.Windows.Forms.Button();
            this.btnDecreaseT2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFoulT2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFoulT1 = new System.Windows.Forms.Label();
            this.btnAddFoulT1 = new System.Windows.Forms.Button();
            this.btnAddFoulT2 = new System.Windows.Forms.Button();
            this.btnStartRestart = new System.Windows.Forms.Button();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(575, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnRightT1
            // 
            this.btnRightT1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightT1.Location = new System.Drawing.Point(166, 248);
            this.btnRightT1.Name = "btnRightT1";
            this.btnRightT1.Size = new System.Drawing.Size(30, 25);
            this.btnRightT1.TabIndex = 2;
            this.btnRightT1.Text = " >";
            this.btnRightT1.UseVisualStyleBackColor = true;
            this.btnRightT1.Click += new System.EventHandler(this.btnRightT1_Click);
            // 
            // btnLeftT1
            // 
            this.btnLeftT1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftT1.Location = new System.Drawing.Point(130, 248);
            this.btnLeftT1.Name = "btnLeftT1";
            this.btnLeftT1.Size = new System.Drawing.Size(30, 25);
            this.btnLeftT1.TabIndex = 3;
            this.btnLeftT1.Text = " <";
            this.btnLeftT1.UseVisualStyleBackColor = true;
            this.btnLeftT1.Click += new System.EventHandler(this.btnLeftT1_Click);
            // 
            // btnLeftT2
            // 
            this.btnLeftT2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftT2.Location = new System.Drawing.Point(677, 248);
            this.btnLeftT2.Name = "btnLeftT2";
            this.btnLeftT2.Size = new System.Drawing.Size(30, 25);
            this.btnLeftT2.TabIndex = 5;
            this.btnLeftT2.Text = " <";
            this.btnLeftT2.UseVisualStyleBackColor = true;
            this.btnLeftT2.Click += new System.EventHandler(this.btnLeftT2_Click);
            // 
            // btnRightT2
            // 
            this.btnRightT2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightT2.Location = new System.Drawing.Point(713, 248);
            this.btnRightT2.Name = "btnRightT2";
            this.btnRightT2.Size = new System.Drawing.Size(30, 25);
            this.btnRightT2.TabIndex = 4;
            this.btnRightT2.Text = " >";
            this.btnRightT2.UseVisualStyleBackColor = true;
            this.btnRightT2.Click += new System.EventHandler(this.btnRightT2_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(317, 50);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(237, 91);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "12:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 73);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // lblScoreT1
            // 
            this.lblScoreT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreT1.Location = new System.Drawing.Point(172, 301);
            this.lblScoreT1.Name = "lblScoreT1";
            this.lblScoreT1.Size = new System.Drawing.Size(227, 108);
            this.lblScoreT1.TabIndex = 8;
            this.lblScoreT1.Text = "0";
            this.lblScoreT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreT2
            // 
            this.lblScoreT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreT2.Location = new System.Drawing.Point(487, 301);
            this.lblScoreT2.Name = "lblScoreT2";
            this.lblScoreT2.Size = new System.Drawing.Size(227, 108);
            this.lblScoreT2.TabIndex = 9;
            this.lblScoreT2.Text = "0";
            this.lblScoreT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddOneT1
            // 
            this.btnAddOneT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOneT1.Location = new System.Drawing.Point(95, 315);
            this.btnAddOneT1.Name = "btnAddOneT1";
            this.btnAddOneT1.Size = new System.Drawing.Size(49, 46);
            this.btnAddOneT1.TabIndex = 10;
            this.btnAddOneT1.Text = "+ 1";
            this.btnAddOneT1.UseVisualStyleBackColor = true;
            this.btnAddOneT1.Click += new System.EventHandler(this.btnAddOneT1_Click);
            // 
            // btnAddTwoT1
            // 
            this.btnAddTwoT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTwoT1.Location = new System.Drawing.Point(95, 367);
            this.btnAddTwoT1.Name = "btnAddTwoT1";
            this.btnAddTwoT1.Size = new System.Drawing.Size(49, 46);
            this.btnAddTwoT1.TabIndex = 11;
            this.btnAddTwoT1.Text = "+ 2";
            this.btnAddTwoT1.UseVisualStyleBackColor = true;
            this.btnAddTwoT1.Click += new System.EventHandler(this.btnAddTwoT1_Click);
            // 
            // btnAddThreeT1
            // 
            this.btnAddThreeT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddThreeT1.Location = new System.Drawing.Point(95, 419);
            this.btnAddThreeT1.Name = "btnAddThreeT1";
            this.btnAddThreeT1.Size = new System.Drawing.Size(49, 46);
            this.btnAddThreeT1.TabIndex = 12;
            this.btnAddThreeT1.Text = "+ 3";
            this.btnAddThreeT1.UseVisualStyleBackColor = true;
            this.btnAddThreeT1.Click += new System.EventHandler(this.btnAddThreeT1_Click);
            // 
            // btnAddThreeT2
            // 
            this.btnAddThreeT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddThreeT2.Location = new System.Drawing.Point(730, 419);
            this.btnAddThreeT2.Name = "btnAddThreeT2";
            this.btnAddThreeT2.Size = new System.Drawing.Size(49, 46);
            this.btnAddThreeT2.TabIndex = 15;
            this.btnAddThreeT2.Text = "+ 3";
            this.btnAddThreeT2.UseVisualStyleBackColor = true;
            this.btnAddThreeT2.Click += new System.EventHandler(this.btnAddThreeT2_Click);
            // 
            // btnAddTwoT2
            // 
            this.btnAddTwoT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTwoT2.Location = new System.Drawing.Point(730, 367);
            this.btnAddTwoT2.Name = "btnAddTwoT2";
            this.btnAddTwoT2.Size = new System.Drawing.Size(49, 46);
            this.btnAddTwoT2.TabIndex = 14;
            this.btnAddTwoT2.Text = "+ 2";
            this.btnAddTwoT2.UseVisualStyleBackColor = true;
            this.btnAddTwoT2.Click += new System.EventHandler(this.btnAddTwoT2_Click);
            // 
            // btnAddOneT2
            // 
            this.btnAddOneT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOneT2.Location = new System.Drawing.Point(730, 315);
            this.btnAddOneT2.Name = "btnAddOneT2";
            this.btnAddOneT2.Size = new System.Drawing.Size(49, 46);
            this.btnAddOneT2.TabIndex = 13;
            this.btnAddOneT2.Text = "+ 1";
            this.btnAddOneT2.UseVisualStyleBackColor = true;
            this.btnAddOneT2.Click += new System.EventHandler(this.btnAddOneT2_Click);
            // 
            // btnDecreaseT1
            // 
            this.btnDecreaseT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseT1.Location = new System.Drawing.Point(40, 367);
            this.btnDecreaseT1.Name = "btnDecreaseT1";
            this.btnDecreaseT1.Size = new System.Drawing.Size(49, 46);
            this.btnDecreaseT1.TabIndex = 16;
            this.btnDecreaseT1.Text = "- 1";
            this.btnDecreaseT1.UseVisualStyleBackColor = true;
            this.btnDecreaseT1.Click += new System.EventHandler(this.btnDecreaseT1_Click);
            // 
            // btnDecreaseT2
            // 
            this.btnDecreaseT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseT2.Location = new System.Drawing.Point(785, 367);
            this.btnDecreaseT2.Name = "btnDecreaseT2";
            this.btnDecreaseT2.Size = new System.Drawing.Size(49, 46);
            this.btnDecreaseT2.TabIndex = 17;
            this.btnDecreaseT2.Text = "- 1";
            this.btnDecreaseT2.UseVisualStyleBackColor = true;
            this.btnDecreaseT2.Click += new System.EventHandler(this.btnDecreaseT2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(399, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Faltas";
            // 
            // lblFoulT2
            // 
            this.lblFoulT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoulT2.Location = new System.Drawing.Point(449, 443);
            this.lblFoulT2.Name = "lblFoulT2";
            this.lblFoulT2.Size = new System.Drawing.Size(66, 46);
            this.lblFoulT2.TabIndex = 20;
            this.lblFoulT2.Text = "0";
            this.lblFoulT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "X";
            // 
            // lblFoulT1
            // 
            this.lblFoulT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoulT1.Location = new System.Drawing.Point(358, 443);
            this.lblFoulT1.Name = "lblFoulT1";
            this.lblFoulT1.Size = new System.Drawing.Size(66, 46);
            this.lblFoulT1.TabIndex = 22;
            this.lblFoulT1.Text = "0";
            this.lblFoulT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddFoulT1
            // 
            this.btnAddFoulT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoulT1.Location = new System.Drawing.Point(315, 448);
            this.btnAddFoulT1.Name = "btnAddFoulT1";
            this.btnAddFoulT1.Size = new System.Drawing.Size(40, 36);
            this.btnAddFoulT1.TabIndex = 23;
            this.btnAddFoulT1.Text = "+";
            this.btnAddFoulT1.UseVisualStyleBackColor = true;
            this.btnAddFoulT1.Click += new System.EventHandler(this.btnAddFoulT1_Click);
            // 
            // btnAddFoulT2
            // 
            this.btnAddFoulT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoulT2.Location = new System.Drawing.Point(518, 448);
            this.btnAddFoulT2.Name = "btnAddFoulT2";
            this.btnAddFoulT2.Size = new System.Drawing.Size(40, 36);
            this.btnAddFoulT2.TabIndex = 24;
            this.btnAddFoulT2.Text = "+";
            this.btnAddFoulT2.UseVisualStyleBackColor = true;
            this.btnAddFoulT2.Click += new System.EventHandler(this.btnAddFoulT2_Click);
            // 
            // btnStartRestart
            // 
            this.btnStartRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStartRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRestart.Location = new System.Drawing.Point(386, 157);
            this.btnStartRestart.Name = "btnStartRestart";
            this.btnStartRestart.Size = new System.Drawing.Size(91, 27);
            this.btnStartRestart.TabIndex = 25;
            this.btnStartRestart.Text = "Start";
            this.btnStartRestart.UseVisualStyleBackColor = false;
            this.btnStartRestart.Click += new System.EventHandler(this.btnStartRestart_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPauseResume.Enabled = false;
            this.btnPauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseResume.Location = new System.Drawing.Point(386, 186);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(91, 27);
            this.btnPauseResume.TabIndex = 26;
            this.btnPauseResume.Text = "Pause";
            this.btnPauseResume.UseVisualStyleBackColor = false;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // btnAddTime
            // 
            this.btnAddTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime.Location = new System.Drawing.Point(418, 215);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(30, 28);
            this.btnAddTime.TabIndex = 27;
            this.btnAddTime.Text = "+";
            this.btnAddTime.UseVisualStyleBackColor = false;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BasketballScoreboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 538);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.btnPauseResume);
            this.Controls.Add(this.btnStartRestart);
            this.Controls.Add(this.btnAddFoulT2);
            this.Controls.Add(this.btnAddFoulT1);
            this.Controls.Add(this.lblFoulT1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFoulT2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecreaseT2);
            this.Controls.Add(this.btnDecreaseT1);
            this.Controls.Add(this.btnAddThreeT2);
            this.Controls.Add(this.btnAddTwoT2);
            this.Controls.Add(this.btnAddOneT2);
            this.Controls.Add(this.btnAddThreeT1);
            this.Controls.Add(this.btnAddTwoT1);
            this.Controls.Add(this.btnAddOneT1);
            this.Controls.Add(this.lblScoreT2);
            this.Controls.Add(this.lblScoreT1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnLeftT2);
            this.Controls.Add(this.btnRightT2);
            this.Controls.Add(this.btnLeftT1);
            this.Controls.Add(this.btnRightT1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BasketballScoreboardControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreboardControl";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRightT1;
        private System.Windows.Forms.Button btnLeftT1;
        private System.Windows.Forms.Button btnLeftT2;
        private System.Windows.Forms.Button btnRightT2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScoreT1;
        private System.Windows.Forms.Label lblScoreT2;
        private System.Windows.Forms.Button btnAddOneT1;
        private System.Windows.Forms.Button btnAddTwoT1;
        private System.Windows.Forms.Button btnAddThreeT1;
        private System.Windows.Forms.Button btnAddThreeT2;
        private System.Windows.Forms.Button btnAddTwoT2;
        private System.Windows.Forms.Button btnAddOneT2;
        private System.Windows.Forms.Button btnDecreaseT1;
        private System.Windows.Forms.Button btnDecreaseT2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFoulT2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFoulT1;
        private System.Windows.Forms.Button btnAddFoulT1;
        private System.Windows.Forms.Button btnAddFoulT2;
        private System.Windows.Forms.Button btnStartRestart;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Timer timer1;
    }
}