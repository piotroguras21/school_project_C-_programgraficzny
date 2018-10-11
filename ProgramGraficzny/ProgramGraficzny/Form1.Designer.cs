namespace ProgramGraficzny
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgObrazek = new System.Windows.Forms.PictureBox();
            this.buttoncolour = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.Kolor = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgObrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgObrazek);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 408);
            this.panel1.TabIndex = 0;
            // 
            // imgObrazek
            // 
            this.imgObrazek.Location = new System.Drawing.Point(-1, -1);
            this.imgObrazek.Name = "imgObrazek";
            this.imgObrazek.Size = new System.Drawing.Size(408, 408);
            this.imgObrazek.TabIndex = 0;
            this.imgObrazek.TabStop = false;
            this.imgObrazek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgObrazek_MouseDown);
            this.imgObrazek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgObrazek_MouseMove);
            // 
            // buttoncolour
            // 
            this.buttoncolour.Location = new System.Drawing.Point(432, 12);
            this.buttoncolour.Name = "buttoncolour";
            this.buttoncolour.Size = new System.Drawing.Size(80, 31);
            this.buttoncolour.TabIndex = 1;
            this.buttoncolour.Text = "Colour";
            this.buttoncolour.UseVisualStyleBackColor = true;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(432, 105);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(116, 30);
            this.buttonsave.TabIndex = 2;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(432, 58);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(116, 30);
            this.buttonclear.TabIndex = 3;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            // 
            // Kolor
            // 
            this.Kolor.BackColor = System.Drawing.Color.Black;
            this.Kolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kolor.Location = new System.Drawing.Point(518, 13);
            this.Kolor.Name = "Kolor";
            this.Kolor.Size = new System.Drawing.Size(30, 30);
            this.Kolor.TabIndex = 4;
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(432, 150);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(116, 30);
            this.buttonexit.TabIndex = 5;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.cmdZamknij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(567, 431);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.Kolor);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttoncolour);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Program Graficzny";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgObrazek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgObrazek;
        private System.Windows.Forms.Button buttoncolour;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Label Kolor;
        private System.Windows.Forms.Button buttonexit;
    }
}

