﻿namespace ExamenProjetGestionEtudiant
{
    partial class ListClasseProfesseur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewListeClasseProfesseur = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeClasseProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewListeClasseProfesseur);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 435);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewListeClasseProfesseur
            // 
            this.dataGridViewListeClasseProfesseur.AllowUserToAddRows = false;
            this.dataGridViewListeClasseProfesseur.AllowUserToDeleteRows = false;
            this.dataGridViewListeClasseProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeClasseProfesseur.Location = new System.Drawing.Point(37, 32);
            this.dataGridViewListeClasseProfesseur.Name = "dataGridViewListeClasseProfesseur";
            this.dataGridViewListeClasseProfesseur.ReadOnly = true;
            this.dataGridViewListeClasseProfesseur.RowHeadersWidth = 62;
            this.dataGridViewListeClasseProfesseur.RowTemplate.Height = 28;
            this.dataGridViewListeClasseProfesseur.Size = new System.Drawing.Size(722, 394);
            this.dataGridViewListeClasseProfesseur.TabIndex = 0;
            // 
            // ListClasseProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ListClasseProfesseur";
            this.Text = "ListClasseProfesseur";
            this.Load += new System.EventHandler(this.ListClasseProfesseur_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeClasseProfesseur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewListeClasseProfesseur;
    }
}