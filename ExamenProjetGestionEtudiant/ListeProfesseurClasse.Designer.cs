﻿namespace ExamenProjetGestionEtudiant
{
    partial class ListeProfesseurClasse
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
            this.dataGridViewProfesseurClasse = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesseurClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewProfesseurClasse);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewProfesseurClasse
            // 
            this.dataGridViewProfesseurClasse.AllowUserToAddRows = false;
            this.dataGridViewProfesseurClasse.AllowUserToDeleteRows = false;
            this.dataGridViewProfesseurClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfesseurClasse.Location = new System.Drawing.Point(58, 20);
            this.dataGridViewProfesseurClasse.Name = "dataGridViewProfesseurClasse";
            this.dataGridViewProfesseurClasse.ReadOnly = true;
            this.dataGridViewProfesseurClasse.RowHeadersWidth = 62;
            this.dataGridViewProfesseurClasse.RowTemplate.Height = 28;
            this.dataGridViewProfesseurClasse.Size = new System.Drawing.Size(667, 349);
            this.dataGridViewProfesseurClasse.TabIndex = 0;
            // 
            // ListeProfesseurClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ListeProfesseurClasse";
            this.Text = "ListeProfesseurClasse";
            this.Load += new System.EventHandler(this.ListeProfesseurClasse_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfesseurClasse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProfesseurClasse;
    }
}