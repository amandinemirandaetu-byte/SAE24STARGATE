namespace SAE24STARGATE
{
    partial class FrmDetails
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
            this.pnlMembres = new System.Windows.Forms.Panel();
            this.pntMission = new SAE24STARGATE.Planete();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMembres
            // 
            this.pnlMembres.Location = new System.Drawing.Point(10, 280);
            this.pnlMembres.Name = "pnlMembres";
            this.pnlMembres.Size = new System.Drawing.Size(810, 240);
            this.pnlMembres.TabIndex = 1;
            // 
            // pntMission
            // 
            this.pntMission.BackColor = System.Drawing.Color.Black;
            this.pntMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pntMission.Location = new System.Drawing.Point(11, 11);
            this.pntMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pntMission.Name = "pntMission";
            this.pntMission.Size = new System.Drawing.Size(98, 118);
            this.pntMission.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Black;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Orbitron", 10F);
            this.btnQuitter.Location = new System.Drawing.Point(700, 10);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(125, 50);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(835, 538);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pnlMembres);
            this.Controls.Add(this.pntMission);
            this.Font = new System.Drawing.Font("Orbitron", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmDetails";
            this.Text = "FrmDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private Planete pntMission;
        private System.Windows.Forms.Panel pnlMembres;
        private System.Windows.Forms.Button btnQuitter;
    }
}