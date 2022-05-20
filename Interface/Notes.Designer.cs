
namespace Interface
{
    partial class Notes
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
            this.code_eleve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.note_f = new System.Windows.Forms.TextBox();
            this.matiere_eleve = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // code_eleve
            // 
            this.code_eleve.Location = new System.Drawing.Point(150, 46);
            this.code_eleve.Name = "code_eleve";
            this.code_eleve.Size = new System.Drawing.Size(169, 20);
            this.code_eleve.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Matière";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Code élève";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(411, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cornsilk;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(411, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Nouveau";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cornsilk;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(411, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 31);
            this.button3.TabIndex = 13;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cornsilk;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(610, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 31);
            this.button4.TabIndex = 14;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Cornsilk;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(610, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 31);
            this.button5.TabIndex = 15;
            this.button5.Text = "Rechercher";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // note_f
            // 
            this.note_f.Location = new System.Drawing.Point(150, 145);
            this.note_f.Name = "note_f";
            this.note_f.Size = new System.Drawing.Size(169, 20);
            this.note_f.TabIndex = 16;
            this.note_f.TextChanged += new System.EventHandler(this.note_TextChanged);
            // 
            // matiere_eleve
            // 
            this.matiere_eleve.FormattingEnabled = true;
            this.matiere_eleve.Location = new System.Drawing.Point(150, 93);
            this.matiere_eleve.Name = "matiere_eleve";
            this.matiere_eleve.Size = new System.Drawing.Size(169, 21);
            this.matiere_eleve.TabIndex = 17;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 231);
            this.Controls.Add(this.matiere_eleve);
            this.Controls.Add(this.note_f);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.code_eleve);
            this.Name = "Notes";
            this.Text = "Ajouter Etudiant";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox code_eleve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox note_f;
        private System.Windows.Forms.ComboBox matiere_eleve;
    }
}