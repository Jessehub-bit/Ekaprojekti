namespace Ekaprojekti
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
            this.TekstiLB = new System.Windows.Forms.Label();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.PeruutaTB = new System.Windows.Forms.Button();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.ViestiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TekstiLB
            // 
            this.TekstiLB.AutoSize = true;
            this.TekstiLB.Location = new System.Drawing.Point(47, 66);
            this.TekstiLB.Name = "TekstiLB";
            this.TekstiLB.Size = new System.Drawing.Size(183, 29);
            this.TekstiLB.TabIndex = 0;
            this.TekstiLB.Text = "Anna etunimesi:";
            this.TekstiLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MuutaBT
            // 
            this.MuutaBT.BackColor = System.Drawing.Color.Lime;
            this.MuutaBT.ForeColor = System.Drawing.Color.Black;
            this.MuutaBT.Location = new System.Drawing.Point(236, 108);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(155, 68);
            this.MuutaBT.TabIndex = 1;
            this.MuutaBT.Text = "Muuta teksti";
            this.MuutaBT.UseVisualStyleBackColor = false;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // PeruutaTB
            // 
            this.PeruutaTB.BackColor = System.Drawing.Color.OrangeRed;
            this.PeruutaTB.Location = new System.Drawing.Point(630, 107);
            this.PeruutaTB.Name = "PeruutaTB";
            this.PeruutaTB.Size = new System.Drawing.Size(155, 69);
            this.PeruutaTB.TabIndex = 2;
            this.PeruutaTB.Text = "Peruuta";
            this.PeruutaTB.UseVisualStyleBackColor = false;
            this.PeruutaTB.Click += new System.EventHandler(this.PeruutaTB_Click);
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(236, 66);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(549, 35);
            this.TekstiTB.TabIndex = 3;
            // 
            // ViestiLB
            // 
            this.ViestiLB.AutoSize = true;
            this.ViestiLB.Location = new System.Drawing.Point(84, 287);
            this.ViestiLB.Name = "ViestiLB";
            this.ViestiLB.Size = new System.Drawing.Size(72, 29);
            this.ViestiLB.TabIndex = 4;
            this.ViestiLB.Text = "Viesti";
            this.ViestiLB.Visible = false;
            this.ViestiLB.Click += new System.EventHandler(this.ViestiLB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 858);
            this.Controls.Add(this.ViestiLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.PeruutaTB);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.TekstiLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TekstiLB;
        private System.Windows.Forms.Button MuutaBT;
        private System.Windows.Forms.Button PeruutaTB;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Label ViestiLB;
    }
}

