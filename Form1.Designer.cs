namespace ZwiftSelector
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
            this.Zwiftselection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aktWorld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Zwiftselection
            // 
            this.Zwiftselection.FormattingEnabled = true;
            this.Zwiftselection.Items.AddRange(new object[] {
            "Watopia",
            "France",
            "Makuri Islands",
            "Innsbruck",
            "Richmond",
            "New York",
            "London",
            "Yorkshire",
            "Paris"});
            this.Zwiftselection.Location = new System.Drawing.Point(119, 31);
            this.Zwiftselection.Name = "Zwiftselection";
            this.Zwiftselection.Size = new System.Drawing.Size(232, 21);
            this.Zwiftselection.TabIndex = 0;
            this.Zwiftselection.SelectedIndexChanged += new System.EventHandler(this.Zwiftselection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "World";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "aktuell eingestellt";
            // 
            // aktWorld
            // 
            this.aktWorld.Enabled = false;
            this.aktWorld.Location = new System.Drawing.Point(119, 5);
            this.aktWorld.Name = "aktWorld";
            this.aktWorld.Size = new System.Drawing.Size(232, 20);
            this.aktWorld.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 58);
            this.Controls.Add(this.aktWorld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zwiftselection);
            this.Name = "Form1";
            this.Text = "Zwift Selector (C) 2021 J. Heinze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Zwiftselection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aktWorld;
    }
}

