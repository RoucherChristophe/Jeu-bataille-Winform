﻿namespace BatailleWinForm
{
    partial class frmBataille
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJouer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picCarteEnCoursJoueur = new System.Windows.Forms.PictureBox();
            this.picCarteEnCoursOrdi = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarteEnCoursJoueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarteEnCoursOrdi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NouvellePartieToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.jeuToolStripMenuItem.Text = "jeu";
            // 
            // NouvellePartieToolStripMenuItem
            // 
            this.NouvellePartieToolStripMenuItem.Name = "NouvellePartieToolStripMenuItem";
            this.NouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.NouvellePartieToolStripMenuItem.Text = "Nouvelle Partie";
            this.NouvellePartieToolStripMenuItem.Click += new System.EventHandler(this.NuvellePartieToolStripMenuItem_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.Enabled = false;
            this.btnJouer.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.Location = new System.Drawing.Point(200, 203);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(108, 46);
            this.btnJouer.TabIndex = 1;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ordinateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Joueur";
            // 
            // picCarteEnCoursJoueur
            // 
            this.picCarteEnCoursJoueur.Location = new System.Drawing.Point(77, 95);
            this.picCarteEnCoursJoueur.Name = "picCarteEnCoursJoueur";
            this.picCarteEnCoursJoueur.Size = new System.Drawing.Size(100, 136);
            this.picCarteEnCoursJoueur.TabIndex = 4;
            this.picCarteEnCoursJoueur.TabStop = false;
            // 
            // picCarteEnCoursOrdi
            // 
            this.picCarteEnCoursOrdi.Location = new System.Drawing.Point(356, 95);
            this.picCarteEnCoursOrdi.Name = "picCarteEnCoursOrdi";
            this.picCarteEnCoursOrdi.Size = new System.Drawing.Size(100, 136);
            this.picCarteEnCoursOrdi.TabIndex = 5;
            this.picCarteEnCoursOrdi.TabStop = false;
            // 
            // frmBataille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(515, 261);
            this.Controls.Add(this.picCarteEnCoursOrdi);
            this.Controls.Add(this.picCarteEnCoursJoueur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "frmBataille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bataille";
            this.Load += new System.EventHandler(this.frmBataille_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarteEnCoursJoueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarteEnCoursOrdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NouvellePartieToolStripMenuItem;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCarteEnCoursJoueur;
        private System.Windows.Forms.PictureBox picCarteEnCoursOrdi;
    }
}

