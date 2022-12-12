namespace PokeWar
{
    partial class GeneratingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratingForm));
            this.btnCreateSkill = new System.Windows.Forms.Button();
            this.btnCreatePokemon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateSkill
            // 
            this.btnCreateSkill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateSkill.BackgroundImage")));
            this.btnCreateSkill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateSkill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSkill.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSkill.Location = new System.Drawing.Point(-1, -1);
            this.btnCreateSkill.Name = "btnCreateSkill";
            this.btnCreateSkill.Size = new System.Drawing.Size(502, 642);
            this.btnCreateSkill.TabIndex = 0;
            this.btnCreateSkill.Text = "Generate Skill/Ability";
            this.btnCreateSkill.UseVisualStyleBackColor = true;
            this.btnCreateSkill.Click += new System.EventHandler(this.btnCreateSkill_Click);
            // 
            // btnCreatePokemon
            // 
            this.btnCreatePokemon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreatePokemon.BackgroundImage")));
            this.btnCreatePokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreatePokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePokemon.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCreatePokemon.Location = new System.Drawing.Point(507, -1);
            this.btnCreatePokemon.Name = "btnCreatePokemon";
            this.btnCreatePokemon.Size = new System.Drawing.Size(473, 642);
            this.btnCreatePokemon.TabIndex = 1;
            this.btnCreatePokemon.Text = "Generate Pokemon";
            this.btnCreatePokemon.UseVisualStyleBackColor = true;
            this.btnCreatePokemon.Click += new System.EventHandler(this.btnCreatePokemon_Click);
            // 
            // GeneratingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnCreatePokemon);
            this.Controls.Add(this.btnCreateSkill);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "GeneratingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneratingForm";
            this.Load += new System.EventHandler(this.GeneratingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSkill;
        private System.Windows.Forms.Button btnCreatePokemon;
    }
}