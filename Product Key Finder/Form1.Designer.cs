namespace Product_Key_Finder
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCopyToClipboar = new System.Windows.Forms.Button();
            this.lb_os = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCopyToClipboar
            // 
            this.btnCopyToClipboar.Location = new System.Drawing.Point(136, 78);
            this.btnCopyToClipboar.Name = "btnCopyToClipboar";
            this.btnCopyToClipboar.Size = new System.Drawing.Size(127, 23);
            this.btnCopyToClipboar.TabIndex = 6;
            this.btnCopyToClipboar.Text = "Copy key to clipboard";
            this.btnCopyToClipboar.UseVisualStyleBackColor = true;
            this.btnCopyToClipboar.Click += new System.EventHandler(this.btnCopyToClipboar_Click);
            // 
            // lb_os
            // 
            this.lb_os.AutoSize = true;
            this.lb_os.Location = new System.Drawing.Point(9, 19);
            this.lb_os.Name = "lb_os";
            this.lb_os.Size = new System.Drawing.Size(71, 13);
            this.lb_os.TabIndex = 5;
            this.lb_os.Text = "Product Key :";
            // 
            // tbKey
            // 
            this.tbKey.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.Location = new System.Drawing.Point(12, 43);
            this.tbKey.Name = "tbKey";
            this.tbKey.ReadOnly = true;
            this.tbKey.Size = new System.Drawing.Size(384, 22);
            this.tbKey.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save as text file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MariusBinary";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(408, 113);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnCopyToClipboar);
            this.Controls.Add(this.lb_os);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Product Key Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopyToClipboar;
        private System.Windows.Forms.Label lb_os;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label2;
    }
}

