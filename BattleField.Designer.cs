namespace PokeWar
{
    partial class BattleField
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
            this.Screen = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.FrameRate = new System.Windows.Forms.Timer(this.components);
            this.tbSkillA = new System.Windows.Forms.TextBox();
            this.tbSkillB = new System.Windows.Forms.TextBox();
            this.tbSkillC = new System.Windows.Forms.TextBox();
            this.tbMention = new System.Windows.Forms.TextBox();
            this.pbSkillA = new System.Windows.Forms.PictureBox();
            this.pbSkillB = new System.Windows.Forms.PictureBox();
            this.pbSkillC = new System.Windows.Forms.PictureBox();
            this.cbSkillA = new System.Windows.Forms.CheckBox();
            this.cbSkillB = new System.Windows.Forms.CheckBox();
            this.cbSkillC = new System.Windows.Forms.CheckBox();
            this.ttSkillInfor = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillC)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Location = new System.Drawing.Point(-6, 3);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(986, 466);
            this.Screen.TabIndex = 24;
            this.Screen.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrameRate
            // 
            this.FrameRate.Interval = 60;
            this.FrameRate.Tick += new System.EventHandler(this.FrameRate_Tick);
            // 
            // tbSkillA
            // 
            this.tbSkillA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbSkillA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSkillA.Location = new System.Drawing.Point(25, 589);
            this.tbSkillA.Multiline = true;
            this.tbSkillA.Name = "tbSkillA";
            this.tbSkillA.ReadOnly = true;
            this.tbSkillA.Size = new System.Drawing.Size(94, 31);
            this.tbSkillA.TabIndex = 28;
            this.tbSkillA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSkillB
            // 
            this.tbSkillB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbSkillB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSkillB.Location = new System.Drawing.Point(125, 589);
            this.tbSkillB.Multiline = true;
            this.tbSkillB.Name = "tbSkillB";
            this.tbSkillB.ReadOnly = true;
            this.tbSkillB.Size = new System.Drawing.Size(94, 31);
            this.tbSkillB.TabIndex = 29;
            this.tbSkillB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSkillC
            // 
            this.tbSkillC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbSkillC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSkillC.Location = new System.Drawing.Point(228, 589);
            this.tbSkillC.Multiline = true;
            this.tbSkillC.Name = "tbSkillC";
            this.tbSkillC.ReadOnly = true;
            this.tbSkillC.Size = new System.Drawing.Size(94, 31);
            this.tbSkillC.TabIndex = 30;
            this.tbSkillC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMention
            // 
            this.tbMention.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbMention.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMention.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbMention.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbMention.Location = new System.Drawing.Point(406, 501);
            this.tbMention.Multiline = true;
            this.tbMention.Name = "tbMention";
            this.tbMention.ReadOnly = true;
            this.tbMention.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMention.Size = new System.Drawing.Size(530, 119);
            this.tbMention.TabIndex = 31;
            this.tbMention.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbSkillA
            // 
            this.pbSkillA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSkillA.Location = new System.Drawing.Point(25, 501);
            this.pbSkillA.Name = "pbSkillA";
            this.pbSkillA.Size = new System.Drawing.Size(94, 82);
            this.pbSkillA.TabIndex = 32;
            this.pbSkillA.TabStop = false;
            this.pbSkillA.Click += new System.EventHandler(this.pbSkillA_Click);
            // 
            // pbSkillB
            // 
            this.pbSkillB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSkillB.Location = new System.Drawing.Point(125, 501);
            this.pbSkillB.Name = "pbSkillB";
            this.pbSkillB.Size = new System.Drawing.Size(94, 82);
            this.pbSkillB.TabIndex = 33;
            this.pbSkillB.TabStop = false;
            this.pbSkillB.Click += new System.EventHandler(this.pbSkillB_Click);
            // 
            // pbSkillC
            // 
            this.pbSkillC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSkillC.Location = new System.Drawing.Point(228, 501);
            this.pbSkillC.Name = "pbSkillC";
            this.pbSkillC.Size = new System.Drawing.Size(94, 82);
            this.pbSkillC.TabIndex = 34;
            this.pbSkillC.TabStop = false;
            this.pbSkillC.Click += new System.EventHandler(this.pbSkillC_Click);
            // 
            // cbSkillA
            // 
            this.cbSkillA.AutoSize = true;
            this.cbSkillA.Enabled = false;
            this.cbSkillA.Location = new System.Drawing.Point(66, 626);
            this.cbSkillA.Name = "cbSkillA";
            this.cbSkillA.Size = new System.Drawing.Size(18, 17);
            this.cbSkillA.TabIndex = 35;
            this.cbSkillA.UseVisualStyleBackColor = true;
            // 
            // cbSkillB
            // 
            this.cbSkillB.AutoSize = true;
            this.cbSkillB.Enabled = false;
            this.cbSkillB.Location = new System.Drawing.Point(165, 626);
            this.cbSkillB.Name = "cbSkillB";
            this.cbSkillB.Size = new System.Drawing.Size(18, 17);
            this.cbSkillB.TabIndex = 36;
            this.cbSkillB.UseVisualStyleBackColor = true;
            // 
            // cbSkillC
            // 
            this.cbSkillC.AutoSize = true;
            this.cbSkillC.Enabled = false;
            this.cbSkillC.Location = new System.Drawing.Point(266, 626);
            this.cbSkillC.Name = "cbSkillC";
            this.cbSkillC.Size = new System.Drawing.Size(18, 17);
            this.cbSkillC.TabIndex = 37;
            this.cbSkillC.UseVisualStyleBackColor = true;
            // 
            // BattleField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.cbSkillC);
            this.Controls.Add(this.cbSkillB);
            this.Controls.Add(this.cbSkillA);
            this.Controls.Add(this.pbSkillC);
            this.Controls.Add(this.pbSkillB);
            this.Controls.Add(this.tbMention);
            this.Controls.Add(this.tbSkillC);
            this.Controls.Add(this.tbSkillB);
            this.Controls.Add(this.tbSkillA);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.pbSkillA);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "BattleField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleField";
            this.Load += new System.EventHandler(this.BattleField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Screen;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer FrameRate;
        private System.Windows.Forms.TextBox tbSkillA;
        private System.Windows.Forms.TextBox tbSkillB;
        private System.Windows.Forms.TextBox tbSkillC;
        private System.Windows.Forms.TextBox tbMention;
        private System.Windows.Forms.PictureBox pbSkillA;
        private System.Windows.Forms.PictureBox pbSkillB;
        private System.Windows.Forms.PictureBox pbSkillC;
        private System.Windows.Forms.CheckBox cbSkillA;
        private System.Windows.Forms.CheckBox cbSkillB;
        private System.Windows.Forms.CheckBox cbSkillC;
        private System.Windows.Forms.ToolTip ttSkillInfor;
    }
}