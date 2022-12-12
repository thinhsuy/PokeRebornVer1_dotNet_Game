namespace PokeWar
{
    partial class CreateMoveForm
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
            this.tbAbilityId = new System.Windows.Forms.TextBox();
            this.lbAbilityId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAbilityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAbilityElement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAbilityDescribe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAbility = new System.Windows.Forms.Button();
            this.pbAbilityElement = new System.Windows.Forms.PictureBox();
            this.btnAddAbilityEffect = new System.Windows.Forms.Button();
            this.tbAbilityEffect = new System.Windows.Forms.TextBox();
            this.cbSkillElement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSkillName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSkillId = new System.Windows.Forms.TextBox();
            this.cbSkillKind = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSkillDescribe = new System.Windows.Forms.TextBox();
            this.btnAddSkillEffect = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSkillDamge = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSkillCD = new System.Windows.Forms.TextBox();
            this.pbSkillElement = new System.Windows.Forms.PictureBox();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSkillCategory = new System.Windows.Forms.TextBox();
            this.tbSkillEffect = new System.Windows.Forms.TextBox();
            this.tbSkillRate = new System.Windows.Forms.TextBox();
            this.tbAbilityRate = new System.Windows.Forms.TextBox();
            this.btnGetSkillID = new System.Windows.Forms.Button();
            this.btnGetAbilityId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbilityElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillElement)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAbilityId
            // 
            this.tbAbilityId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAbilityId.Location = new System.Drawing.Point(703, 65);
            this.tbAbilityId.Name = "tbAbilityId";
            this.tbAbilityId.Size = new System.Drawing.Size(100, 22);
            this.tbAbilityId.TabIndex = 0;
            // 
            // lbAbilityId
            // 
            this.lbAbilityId.AutoSize = true;
            this.lbAbilityId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbilityId.Location = new System.Drawing.Point(557, 62);
            this.lbAbilityId.Name = "lbAbilityId";
            this.lbAbilityId.Size = new System.Drawing.Size(105, 25);
            this.lbAbilityId.TabIndex = 1;
            this.lbAbilityId.Text = "Ability ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // tbAbilityName
            // 
            this.tbAbilityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAbilityName.Location = new System.Drawing.Point(703, 108);
            this.tbAbilityName.Name = "tbAbilityName";
            this.tbAbilityName.Size = new System.Drawing.Size(195, 22);
            this.tbAbilityName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Element:";
            // 
            // cbAbilityElement
            // 
            this.cbAbilityElement.FormattingEnabled = true;
            this.cbAbilityElement.Location = new System.Drawing.Point(703, 150);
            this.cbAbilityElement.Name = "cbAbilityElement";
            this.cbAbilityElement.Size = new System.Drawing.Size(142, 24);
            this.cbAbilityElement.TabIndex = 5;
            this.cbAbilityElement.SelectedIndexChanged += new System.EventHandler(this.cbAbilityElement_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Describe:";
            // 
            // tbAbilityDescribe
            // 
            this.tbAbilityDescribe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAbilityDescribe.Location = new System.Drawing.Point(703, 208);
            this.tbAbilityDescribe.Multiline = true;
            this.tbAbilityDescribe.Name = "tbAbilityDescribe";
            this.tbAbilityDescribe.Size = new System.Drawing.Size(195, 115);
            this.tbAbilityDescribe.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Effect(s):";
            // 
            // btnAddAbility
            // 
            this.btnAddAbility.Location = new System.Drawing.Point(703, 567);
            this.btnAddAbility.Name = "btnAddAbility";
            this.btnAddAbility.Size = new System.Drawing.Size(142, 41);
            this.btnAddAbility.TabIndex = 10;
            this.btnAddAbility.Text = "Add new Ability";
            this.btnAddAbility.UseVisualStyleBackColor = true;
            this.btnAddAbility.Click += new System.EventHandler(this.btnAddAbility_Click);
            // 
            // pbAbilityElement
            // 
            this.pbAbilityElement.Location = new System.Drawing.Point(872, 150);
            this.pbAbilityElement.Name = "pbAbilityElement";
            this.pbAbilityElement.Size = new System.Drawing.Size(26, 25);
            this.pbAbilityElement.TabIndex = 11;
            this.pbAbilityElement.TabStop = false;
            // 
            // btnAddAbilityEffect
            // 
            this.btnAddAbilityEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAbilityEffect.Location = new System.Drawing.Point(703, 349);
            this.btnAddAbilityEffect.Name = "btnAddAbilityEffect";
            this.btnAddAbilityEffect.Size = new System.Drawing.Size(32, 34);
            this.btnAddAbilityEffect.TabIndex = 12;
            this.btnAddAbilityEffect.Text = "+";
            this.btnAddAbilityEffect.UseVisualStyleBackColor = true;
            this.btnAddAbilityEffect.Click += new System.EventHandler(this.btnAddAbilityEffect_Click);
            // 
            // tbAbilityEffect
            // 
            this.tbAbilityEffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAbilityEffect.Enabled = false;
            this.tbAbilityEffect.Location = new System.Drawing.Point(703, 403);
            this.tbAbilityEffect.Multiline = true;
            this.tbAbilityEffect.Name = "tbAbilityEffect";
            this.tbAbilityEffect.Size = new System.Drawing.Size(142, 94);
            this.tbAbilityEffect.TabIndex = 13;
            this.tbAbilityEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSkillElement
            // 
            this.cbSkillElement.FormattingEnabled = true;
            this.cbSkillElement.Location = new System.Drawing.Point(192, 154);
            this.cbSkillElement.Name = "cbSkillElement";
            this.cbSkillElement.Size = new System.Drawing.Size(100, 24);
            this.cbSkillElement.TabIndex = 19;
            this.cbSkillElement.SelectedIndexChanged += new System.EventHandler(this.cbSkillElement_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Element:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name:";
            // 
            // tbSkillName
            // 
            this.tbSkillName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillName.Location = new System.Drawing.Point(192, 111);
            this.tbSkillName.Name = "tbSkillName";
            this.tbSkillName.Size = new System.Drawing.Size(213, 22);
            this.tbSkillName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Skill ID:";
            // 
            // tbSkillId
            // 
            this.tbSkillId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillId.Location = new System.Drawing.Point(192, 68);
            this.tbSkillId.Name = "tbSkillId";
            this.tbSkillId.Size = new System.Drawing.Size(100, 22);
            this.tbSkillId.TabIndex = 14;
            // 
            // cbSkillKind
            // 
            this.cbSkillKind.FormattingEnabled = true;
            this.cbSkillKind.Location = new System.Drawing.Point(192, 519);
            this.cbSkillKind.Name = "cbSkillKind";
            this.cbSkillKind.Size = new System.Drawing.Size(100, 24);
            this.cbSkillKind.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kind:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Describe:";
            // 
            // tbSkillDescribe
            // 
            this.tbSkillDescribe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillDescribe.Location = new System.Drawing.Point(192, 208);
            this.tbSkillDescribe.Multiline = true;
            this.tbSkillDescribe.Name = "tbSkillDescribe";
            this.tbSkillDescribe.Size = new System.Drawing.Size(213, 115);
            this.tbSkillDescribe.TabIndex = 22;
            // 
            // btnAddSkillEffect
            // 
            this.btnAddSkillEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSkillEffect.Location = new System.Drawing.Point(192, 349);
            this.btnAddSkillEffect.Name = "btnAddSkillEffect";
            this.btnAddSkillEffect.Size = new System.Drawing.Size(32, 34);
            this.btnAddSkillEffect.TabIndex = 25;
            this.btnAddSkillEffect.Text = "+";
            this.btnAddSkillEffect.UseVisualStyleBackColor = true;
            this.btnAddSkillEffect.Click += new System.EventHandler(this.btnAddSkillEffect_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Effect(s):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 567);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Damge:";
            // 
            // tbSkillDamge
            // 
            this.tbSkillDamge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillDamge.Location = new System.Drawing.Point(192, 567);
            this.tbSkillDamge.Name = "tbSkillDamge";
            this.tbSkillDamge.Size = new System.Drawing.Size(100, 22);
            this.tbSkillDamge.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(298, 567);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "CD:";
            // 
            // tbSkillCD
            // 
            this.tbSkillCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillCD.Location = new System.Drawing.Point(367, 567);
            this.tbSkillCD.Name = "tbSkillCD";
            this.tbSkillCD.Size = new System.Drawing.Size(38, 22);
            this.tbSkillCD.TabIndex = 29;
            // 
            // pbSkillElement
            // 
            this.pbSkillElement.Location = new System.Drawing.Point(301, 154);
            this.pbSkillElement.Name = "pbSkillElement";
            this.pbSkillElement.Size = new System.Drawing.Size(26, 25);
            this.pbSkillElement.TabIndex = 31;
            this.pbSkillElement.TabStop = false;
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.Location = new System.Drawing.Point(573, 567);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(113, 41);
            this.btnAddSkill.TabIndex = 32;
            this.btnAddSkill.Text = "Add new Skill";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(857, 567);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 41);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(296, 519);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "CAT:";
            // 
            // tbSkillCategory
            // 
            this.tbSkillCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillCategory.Location = new System.Drawing.Point(367, 519);
            this.tbSkillCategory.Name = "tbSkillCategory";
            this.tbSkillCategory.Size = new System.Drawing.Size(38, 22);
            this.tbSkillCategory.TabIndex = 34;
            // 
            // tbSkillEffect
            // 
            this.tbSkillEffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillEffect.Enabled = false;
            this.tbSkillEffect.Location = new System.Drawing.Point(192, 403);
            this.tbSkillEffect.Multiline = true;
            this.tbSkillEffect.Name = "tbSkillEffect";
            this.tbSkillEffect.Size = new System.Drawing.Size(156, 94);
            this.tbSkillEffect.TabIndex = 26;
            this.tbSkillEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSkillRate
            // 
            this.tbSkillRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillRate.Location = new System.Drawing.Point(367, 403);
            this.tbSkillRate.Multiline = true;
            this.tbSkillRate.Name = "tbSkillRate";
            this.tbSkillRate.Size = new System.Drawing.Size(38, 94);
            this.tbSkillRate.TabIndex = 36;
            this.tbSkillRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSkillRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSkillRate_KeyDown);
            // 
            // tbAbilityRate
            // 
            this.tbAbilityRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAbilityRate.Location = new System.Drawing.Point(860, 403);
            this.tbAbilityRate.Multiline = true;
            this.tbAbilityRate.Name = "tbAbilityRate";
            this.tbAbilityRate.Size = new System.Drawing.Size(38, 94);
            this.tbAbilityRate.TabIndex = 37;
            this.tbAbilityRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAbilityRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAbilityRate_KeyDown);
            // 
            // btnGetSkillID
            // 
            this.btnGetSkillID.Location = new System.Drawing.Point(324, 65);
            this.btnGetSkillID.Name = "btnGetSkillID";
            this.btnGetSkillID.Size = new System.Drawing.Size(81, 25);
            this.btnGetSkillID.TabIndex = 38;
            this.btnGetSkillID.Text = "Get ID";
            this.btnGetSkillID.UseVisualStyleBackColor = true;
            this.btnGetSkillID.Click += new System.EventHandler(this.btnGetSkillID_Click);
            // 
            // btnGetAbilityId
            // 
            this.btnGetAbilityId.Location = new System.Drawing.Point(817, 62);
            this.btnGetAbilityId.Name = "btnGetAbilityId";
            this.btnGetAbilityId.Size = new System.Drawing.Size(81, 25);
            this.btnGetAbilityId.TabIndex = 39;
            this.btnGetAbilityId.Text = "Get ID";
            this.btnGetAbilityId.UseVisualStyleBackColor = true;
            this.btnGetAbilityId.Click += new System.EventHandler(this.btnGetAbilityId_Click);
            // 
            // CreateMoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnGetAbilityId);
            this.Controls.Add(this.btnGetSkillID);
            this.Controls.Add(this.tbAbilityRate);
            this.Controls.Add(this.tbSkillRate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbSkillCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSkill);
            this.Controls.Add(this.pbSkillElement);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbSkillCD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbSkillDamge);
            this.Controls.Add(this.tbSkillEffect);
            this.Controls.Add(this.btnAddSkillEffect);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSkillDescribe);
            this.Controls.Add(this.cbSkillKind);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSkillElement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSkillName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSkillId);
            this.Controls.Add(this.tbAbilityEffect);
            this.Controls.Add(this.btnAddAbilityEffect);
            this.Controls.Add(this.pbAbilityElement);
            this.Controls.Add(this.btnAddAbility);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAbilityDescribe);
            this.Controls.Add(this.cbAbilityElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAbilityName);
            this.Controls.Add(this.lbAbilityId);
            this.Controls.Add(this.tbAbilityId);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "CreateMoveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateMoveForm";
            this.Load += new System.EventHandler(this.CreateMoveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAbilityElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAbilityId;
        private System.Windows.Forms.Label lbAbilityId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAbilityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAbilityElement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAbilityDescribe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddAbility;
        private System.Windows.Forms.PictureBox pbAbilityElement;
        private System.Windows.Forms.Button btnAddAbilityEffect;
        private System.Windows.Forms.TextBox tbAbilityEffect;
        private System.Windows.Forms.ComboBox cbSkillElement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSkillName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSkillId;
        private System.Windows.Forms.ComboBox cbSkillKind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSkillDescribe;
        private System.Windows.Forms.Button btnAddSkillEffect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSkillDamge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSkillCD;
        private System.Windows.Forms.PictureBox pbSkillElement;
        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSkillCategory;
        private System.Windows.Forms.TextBox tbSkillEffect;
        private System.Windows.Forms.TextBox tbSkillRate;
        private System.Windows.Forms.TextBox tbAbilityRate;
        private System.Windows.Forms.Button btnGetSkillID;
        private System.Windows.Forms.Button btnGetAbilityId;
    }
}