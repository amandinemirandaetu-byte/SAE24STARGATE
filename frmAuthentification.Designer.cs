namespace SAE24STARGATE
{
    partial class frmAuthentification
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
            this.lblTitreAuthentification = new System.Windows.Forms.Label();
            this.grpAuthentification = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.lblMDP = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnMontrerMdp = new System.Windows.Forms.Button();
            this.grpAuthentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitreAuthentification
            // 
            this.lblTitreAuthentification.AutoSize = true;
            this.lblTitreAuthentification.Font = new System.Drawing.Font("Orbitron SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAuthentification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblTitreAuthentification.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitreAuthentification.Location = new System.Drawing.Point(95, 19);
            this.lblTitreAuthentification.Name = "lblTitreAuthentification";
            this.lblTitreAuthentification.Size = new System.Drawing.Size(606, 60);
            this.lblTitreAuthentification.TabIndex = 0;
            this.lblTitreAuthentification.Text = "Pour créer une nouvelle mission,\r\nauthentifiez-vous en tant qu\'administrateur :\r\n" +
    "";
            this.lblTitreAuthentification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpAuthentification
            // 
            this.grpAuthentification.Controls.Add(this.btnMontrerMdp);
            this.grpAuthentification.Controls.Add(this.btnLogin);
            this.grpAuthentification.Controls.Add(this.txtMDP);
            this.grpAuthentification.Controls.Add(this.lblMDP);
            this.grpAuthentification.Controls.Add(this.txtLogin);
            this.grpAuthentification.Controls.Add(this.lblLogin);
            this.grpAuthentification.Location = new System.Drawing.Point(24, 88);
            this.grpAuthentification.Name = "grpAuthentification";
            this.grpAuthentification.Size = new System.Drawing.Size(750, 339);
            this.grpAuthentification.TabIndex = 1;
            this.grpAuthentification.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnLogin.Location = new System.Drawing.Point(251, 261);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(256, 46);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Se connecter";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtMDP
            // 
            this.txtMDP.HideSelection = false;
            this.txtMDP.Location = new System.Drawing.Point(251, 179);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '★';
            this.txtMDP.Size = new System.Drawing.Size(345, 26);
            this.txtMDP.TabIndex = 3;
            this.txtMDP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMDP_KeyPress);
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Font = new System.Drawing.Font("Orbitron Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblMDP.Location = new System.Drawing.Point(51, 178);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(173, 25);
            this.lblMDP.TabIndex = 2;
            this.lblMDP.Text = "Mot de passe :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(251, 58);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(345, 26);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Orbitron Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblLogin.Location = new System.Drawing.Point(51, 59);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // btnMontrerMdp
            // 
            this.btnMontrerMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMontrerMdp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMontrerMdp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMontrerMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMontrerMdp.Location = new System.Drawing.Point(636, 162);
            this.btnMontrerMdp.Name = "btnMontrerMdp";
            this.btnMontrerMdp.Size = new System.Drawing.Size(60, 60);
            this.btnMontrerMdp.TabIndex = 5;
            this.btnMontrerMdp.UseVisualStyleBackColor = true;
            // 
            // frmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAuthentification);
            this.Controls.Add(this.lblTitreAuthentification);
            this.Name = "frmAuthentification";
            this.Text = "Authentifiez-vous pour créer une nouvelle mission";
            this.grpAuthentification.ResumeLayout(false);
            this.grpAuthentification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreAuthentification;
        private System.Windows.Forms.GroupBox grpAuthentification;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnMontrerMdp;
    }
}