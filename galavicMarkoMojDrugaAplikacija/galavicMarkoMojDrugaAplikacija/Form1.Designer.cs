namespace galavicMarkoMojDrugaAplikacija
{
    partial class Form1
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
            this.butunPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butunPlus
            // 
            this.butunPlus.Location = new System.Drawing.Point(192, 192);
            this.butunPlus.Name = "butunPlus";
            this.butunPlus.Size = new System.Drawing.Size(75, 23);
            this.butunPlus.TabIndex = 0;
            this.butunPlus.Text = "+";
            this.butunPlus.UseVisualStyleBackColor = true;
            this.butunPlus.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(489, 191);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(298, 121);
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(166, 20);
            this.txtPrikaz.TabIndex = 2;
            this.txtPrikaz.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.butunPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butunPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.TextBox txtPrikaz;
    }
}

