namespace Piemers
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
            this.labAtbilde = new System.Windows.Forms.Label();
            this.butPieslegties = new System.Windows.Forms.Button();
            this.txtParole = new System.Windows.Forms.TextBox();
            this.txtLietotajs = new System.Windows.Forms.TextBox();
            this.labParole = new System.Windows.Forms.Label();
            this.labLietotajs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labAtbilde
            // 
            this.labAtbilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labAtbilde.Location = new System.Drawing.Point(24, 48);
            this.labAtbilde.Name = "labAtbilde";
            this.labAtbilde.Size = new System.Drawing.Size(336, 24);
            this.labAtbilde.TabIndex = 11;
            this.labAtbilde.Text = "Sveiks(a), ...!";
            // 
            // butPieslegties
            // 
            this.butPieslegties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butPieslegties.Location = new System.Drawing.Point(134, 115);
            this.butPieslegties.Name = "butPieslegties";
            this.butPieslegties.Size = new System.Drawing.Size(113, 26);
            this.butPieslegties.TabIndex = 10;
            this.butPieslegties.Text = "Pieslēgties";
            this.butPieslegties.UseVisualStyleBackColor = true;
            this.butPieslegties.Click += new System.EventHandler(this.butPieslegties_Click);
            // 
            // txtParole
            // 
            this.txtParole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtParole.Location = new System.Drawing.Point(162, 58);
            this.txtParole.Name = "txtParole";
            this.txtParole.PasswordChar = '*';
            this.txtParole.Size = new System.Drawing.Size(160, 29);
            this.txtParole.TabIndex = 9;
            // 
            // txtLietotajs
            // 
            this.txtLietotajs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtLietotajs.Location = new System.Drawing.Point(162, 21);
            this.txtLietotajs.Name = "txtLietotajs";
            this.txtLietotajs.Size = new System.Drawing.Size(160, 29);
            this.txtLietotajs.TabIndex = 8;
            // 
            // labParole
            // 
            this.labParole.AutoSize = true;
            this.labParole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labParole.Location = new System.Drawing.Point(24, 63);
            this.labParole.Name = "labParole";
            this.labParole.Size = new System.Drawing.Size(76, 24);
            this.labParole.TabIndex = 7;
            this.labParole.Text = "Parole:";
            // 
            // labLietotajs
            // 
            this.labLietotajs.AutoSize = true;
            this.labLietotajs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labLietotajs.Location = new System.Drawing.Point(24, 24);
            this.labLietotajs.Name = "labLietotajs";
            this.labLietotajs.Size = new System.Drawing.Size(132, 24);
            this.labLietotajs.TabIndex = 6;
            this.labLietotajs.Text = "Lietotājvārds:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.labAtbilde);
            this.Controls.Add(this.butPieslegties);
            this.Controls.Add(this.txtParole);
            this.Controls.Add(this.txtLietotajs);
            this.Controls.Add(this.labParole);
            this.Controls.Add(this.labLietotajs);
            this.Name = "Form1";
            this.Text = "Piemērs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAtbilde;
        private System.Windows.Forms.Button butPieslegties;
        private System.Windows.Forms.TextBox txtParole;
        private System.Windows.Forms.TextBox txtLietotajs;
        private System.Windows.Forms.Label labParole;
        private System.Windows.Forms.Label labLietotajs;
    }
}

