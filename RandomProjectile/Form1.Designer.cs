namespace RandomProjectile
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
            this.components = new System.ComponentModel.Container();
            this.tmFire = new System.Windows.Forms.Timer(this.components);
            this.tmMove = new System.Windows.Forms.Timer(this.components);
            this.lblYou = new System.Windows.Forms.Label();
            this.tmPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmFire
            // 
            this.tmFire.Enabled = true;
            this.tmFire.Interval = 1000;
            this.tmFire.Tick += new System.EventHandler(this.tmFire_Tick);
            // 
            // tmMove
            // 
            this.tmMove.Interval = 10;
            this.tmMove.Tick += new System.EventHandler(this.tmMove_Tick);
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(538, 480);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(47, 29);
            this.lblYou.TabIndex = 1;
            this.lblYou.Text = "\\O/";
            // 
            // tmPlayerMove
            // 
            this.tmPlayerMove.Enabled = true;
            this.tmPlayerMove.Interval = 10;
            this.tmPlayerMove.Tick += new System.EventHandler(this.tmPlayerMove_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 971);
            this.Controls.Add(this.lblYou);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmFire;
        private System.Windows.Forms.Timer tmMove;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Timer tmPlayerMove;
    }
}

