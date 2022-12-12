namespace PokeWar
{
    partial class ViewForm
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
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbHP = new System.Windows.Forms.ProgressBar();
            this.pbAtk = new System.Windows.Forms.ProgressBar();
            this.pbDef = new System.Windows.Forms.ProgressBar();
            this.pbSpAtk = new System.Windows.Forms.ProgressBar();
            this.pbSpDef = new System.Windows.Forms.ProgressBar();
            this.pbSpd = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbElement1 = new System.Windows.Forms.PictureBox();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSkillA = new System.Windows.Forms.TextBox();
            this.tbSkillB = new System.Windows.Forms.TextBox();
            this.tbSkillC = new System.Windows.Forms.TextBox();
            this.ttProperties = new System.Windows.Forms.ToolTip(this.components);
            this.ttSkill = new System.Windows.Forms.ToolTip(this.components);
            this.pbSkillA = new System.Windows.Forms.PictureBox();
            this.pbSkillB = new System.Windows.Forms.PictureBox();
            this.pbSkillC = new System.Windows.Forms.PictureBox();
            this.btnCheckSkills = new System.Windows.Forms.Button();
            this.tbAbility = new System.Windows.Forms.TextBox();
            this.pbContainer = new System.Windows.Forms.PictureBox();
            this.pbElement2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbElement1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbElement2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(49, 153);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(324, 364);
            this.dgvView.TabIndex = 0;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of Pokemons";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Spd:";
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(436, 449);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(79, 25);
            this.tb.TabIndex = 18;
            this.tb.Text = "SpDef:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "SpAtk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Def:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Atk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "HP:";
            // 
            // pbHP
            // 
            this.pbHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pbHP.Location = new System.Drawing.Point(531, 280);
            this.pbHP.Maximum = 200;
            this.pbHP.Name = "pbHP";
            this.pbHP.Size = new System.Drawing.Size(175, 23);
            this.pbHP.TabIndex = 20;
            // 
            // pbAtk
            // 
            this.pbAtk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAtk.Location = new System.Drawing.Point(531, 320);
            this.pbAtk.Maximum = 200;
            this.pbAtk.Name = "pbAtk";
            this.pbAtk.Size = new System.Drawing.Size(175, 23);
            this.pbAtk.TabIndex = 21;
            // 
            // pbDef
            // 
            this.pbDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDef.Location = new System.Drawing.Point(531, 363);
            this.pbDef.Maximum = 200;
            this.pbDef.Name = "pbDef";
            this.pbDef.Size = new System.Drawing.Size(175, 23);
            this.pbDef.TabIndex = 22;
            // 
            // pbSpAtk
            // 
            this.pbSpAtk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSpAtk.Location = new System.Drawing.Point(531, 409);
            this.pbSpAtk.Maximum = 200;
            this.pbSpAtk.Name = "pbSpAtk";
            this.pbSpAtk.Size = new System.Drawing.Size(175, 23);
            this.pbSpAtk.TabIndex = 23;
            // 
            // pbSpDef
            // 
            this.pbSpDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSpDef.Location = new System.Drawing.Point(531, 449);
            this.pbSpDef.Maximum = 200;
            this.pbSpDef.Name = "pbSpDef";
            this.pbSpDef.Size = new System.Drawing.Size(175, 23);
            this.pbSpDef.TabIndex = 22;
            // 
            // pbSpd
            // 
            this.pbSpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSpd.Location = new System.Drawing.Point(531, 494);
            this.pbSpd.Maximum = 200;
            this.pbSpd.Name = "pbSpd";
            this.pbSpd.Size = new System.Drawing.Size(175, 23);
            this.pbSpd.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Element:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ability: ";
            // 
            // pbElement1
            // 
            this.pbElement1.Location = new System.Drawing.Point(531, 156);
            this.pbElement1.Name = "pbElement1";
            this.pbElement1.Size = new System.Drawing.Size(26, 24);
            this.pbElement1.TabIndex = 28;
            this.pbElement1.TabStop = false;
            // 
            // pbPokemon
            // 
            this.pbPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPokemon.Location = new System.Drawing.Point(745, 53);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(175, 168);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPokemon.TabIndex = 29;
            this.pbPokemon.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(245, 548);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 42);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSkillA
            // 
            this.tbSkillA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSkillA.Location = new System.Drawing.Point(782, 320);
            this.tbSkillA.Name = "tbSkillA";
            this.tbSkillA.ReadOnly = true;
            this.tbSkillA.Size = new System.Drawing.Size(123, 22);
            this.tbSkillA.TabIndex = 32;
            this.tbSkillA.Text = "none";
            this.tbSkillA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSkillB
            // 
            this.tbSkillB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSkillB.Location = new System.Drawing.Point(782, 368);
            this.tbSkillB.Name = "tbSkillB";
            this.tbSkillB.ReadOnly = true;
            this.tbSkillB.Size = new System.Drawing.Size(123, 22);
            this.tbSkillB.TabIndex = 33;
            this.tbSkillB.Text = "none";
            this.tbSkillB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSkillC
            // 
            this.tbSkillC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSkillC.Location = new System.Drawing.Point(782, 414);
            this.tbSkillC.Name = "tbSkillC";
            this.tbSkillC.ReadOnly = true;
            this.tbSkillC.Size = new System.Drawing.Size(123, 22);
            this.tbSkillC.TabIndex = 34;
            this.tbSkillC.Text = "none";
            this.tbSkillC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbSkillA
            // 
            this.pbSkillA.Location = new System.Drawing.Point(914, 320);
            this.pbSkillA.Name = "pbSkillA";
            this.pbSkillA.Size = new System.Drawing.Size(23, 22);
            this.pbSkillA.TabIndex = 35;
            this.pbSkillA.TabStop = false;
            // 
            // pbSkillB
            // 
            this.pbSkillB.Location = new System.Drawing.Point(914, 368);
            this.pbSkillB.Name = "pbSkillB";
            this.pbSkillB.Size = new System.Drawing.Size(23, 22);
            this.pbSkillB.TabIndex = 36;
            this.pbSkillB.TabStop = false;
            // 
            // pbSkillC
            // 
            this.pbSkillC.Location = new System.Drawing.Point(914, 414);
            this.pbSkillC.Name = "pbSkillC";
            this.pbSkillC.Size = new System.Drawing.Size(23, 22);
            this.pbSkillC.TabIndex = 37;
            this.pbSkillC.TabStop = false;
            // 
            // btnCheckSkills
            // 
            this.btnCheckSkills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckSkills.Location = new System.Drawing.Point(782, 453);
            this.btnCheckSkills.Name = "btnCheckSkills";
            this.btnCheckSkills.Size = new System.Drawing.Size(123, 64);
            this.btnCheckSkills.TabIndex = 38;
            this.btnCheckSkills.Text = "Check Skills";
            this.btnCheckSkills.UseVisualStyleBackColor = true;
            this.btnCheckSkills.Click += new System.EventHandler(this.btnCheckSkills_Click);
            // 
            // tbAbility
            // 
            this.tbAbility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAbility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbAbility.Location = new System.Drawing.Point(531, 199);
            this.tbAbility.Name = "tbAbility";
            this.tbAbility.ReadOnly = true;
            this.tbAbility.Size = new System.Drawing.Size(123, 22);
            this.tbAbility.TabIndex = 39;
            this.tbAbility.Text = "none";
            this.tbAbility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbContainer
            // 
            this.pbContainer.BackColor = System.Drawing.Color.Transparent;
            this.pbContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbContainer.Location = new System.Drawing.Point(692, 30);
            this.pbContainer.Name = "pbContainer";
            this.pbContainer.Size = new System.Drawing.Size(278, 222);
            this.pbContainer.TabIndex = 41;
            this.pbContainer.TabStop = false;
            // 
            // pbElement2
            // 
            this.pbElement2.Location = new System.Drawing.Point(563, 157);
            this.pbElement2.Name = "pbElement2";
            this.pbElement2.Size = new System.Drawing.Size(26, 24);
            this.pbElement2.TabIndex = 42;
            this.pbElement2.TabStop = false;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.pbElement2);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.tbAbility);
            this.Controls.Add(this.btnCheckSkills);
            this.Controls.Add(this.pbSkillC);
            this.Controls.Add(this.pbSkillB);
            this.Controls.Add(this.pbSkillA);
            this.Controls.Add(this.tbSkillC);
            this.Controls.Add(this.tbSkillB);
            this.Controls.Add(this.tbSkillA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pbElement1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbSpd);
            this.Controls.Add(this.pbSpAtk);
            this.Controls.Add(this.pbDef);
            this.Controls.Add(this.pbSpDef);
            this.Controls.Add(this.pbAtk);
            this.Controls.Add(this.pbHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.pbContainer);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbElement1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkillC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbElement2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbHP;
        private System.Windows.Forms.ProgressBar pbAtk;
        private System.Windows.Forms.ProgressBar pbDef;
        private System.Windows.Forms.ProgressBar pbSpAtk;
        private System.Windows.Forms.ProgressBar pbSpDef;
        private System.Windows.Forms.ProgressBar pbSpd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbElement1;
        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbSkillA;
        private System.Windows.Forms.TextBox tbSkillB;
        private System.Windows.Forms.TextBox tbSkillC;
        private System.Windows.Forms.ToolTip ttProperties;
        private System.Windows.Forms.ToolTip ttSkill;
        private System.Windows.Forms.PictureBox pbSkillA;
        private System.Windows.Forms.PictureBox pbSkillB;
        private System.Windows.Forms.PictureBox pbSkillC;
        private System.Windows.Forms.Button btnCheckSkills;
        private System.Windows.Forms.TextBox tbAbility;
        private System.Windows.Forms.PictureBox pbContainer;
        private System.Windows.Forms.PictureBox pbElement2;
    }
}