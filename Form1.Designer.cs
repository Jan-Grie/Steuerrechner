
namespace SteuerrechnerV1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CmdBerechnen = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CheckBoxKs = new System.Windows.Forms.CheckBox();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdBerechnen
            // 
            this.CmdBerechnen.Location = new System.Drawing.Point(288, 39);
            this.CmdBerechnen.Name = "CmdBerechnen";
            this.CmdBerechnen.Size = new System.Drawing.Size(75, 23);
            this.CmdBerechnen.TabIndex = 0;
            this.CmdBerechnen.Text = "Berechnen";
            this.CmdBerechnen.UseVisualStyleBackColor = true;
            this.CmdBerechnen.Click += new System.EventHandler(this.CmdBerechnen_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(279, 198);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 1;
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(230, 113);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(203, 13);
            this.LblAnzeige.TabIndex = 2;
            this.LblAnzeige.Text = "Bitte geben Sie ihren Bruttolohn unten ein";
            // 
            // CheckBoxKs
            // 
            this.CheckBoxKs.AutoSize = true;
            this.CheckBoxKs.Location = new System.Drawing.Point(288, 151);
            this.CheckBoxKs.Name = "CheckBoxKs";
            this.CheckBoxKs.Size = new System.Drawing.Size(91, 17);
            this.CheckBoxKs.TabIndex = 3;
            this.CheckBoxKs.Text = "Kirchensteuer";
            this.CheckBoxKs.UseVisualStyleBackColor = true;
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(288, 255);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.LblAusgabe.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CheckBoxKs);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.CmdBerechnen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Steuerrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdBerechnen;
        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.CheckBox CheckBoxKs;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

