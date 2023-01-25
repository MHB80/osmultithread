namespace project2
{
    partial class play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(play));
            this.playvidbutton = new System.Windows.Forms.Button();
            this.pausebuttom = new System.Windows.Forms.Button();
            this.volup = new System.Windows.Forms.Button();
            this.voldown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // playvidbutton
            // 
            this.playvidbutton.Location = new System.Drawing.Point(628, 56);
            this.playvidbutton.Name = "playvidbutton";
            this.playvidbutton.Size = new System.Drawing.Size(121, 122);
            this.playvidbutton.TabIndex = 0;
            this.playvidbutton.Text = "button1";
            this.playvidbutton.UseVisualStyleBackColor = true;
            this.playvidbutton.Click += new System.EventHandler(this.playvidbutton_Click);
            // 
            // pausebuttom
            // 
            this.pausebuttom.Location = new System.Drawing.Point(646, 195);
            this.pausebuttom.Name = "pausebuttom";
            this.pausebuttom.Size = new System.Drawing.Size(90, 95);
            this.pausebuttom.TabIndex = 1;
            this.pausebuttom.Text = "button2";
            this.pausebuttom.UseVisualStyleBackColor = true;
            this.pausebuttom.Click += new System.EventHandler(this.pausebuttom_Click);
            // 
            // volup
            // 
            this.volup.Location = new System.Drawing.Point(699, 296);
            this.volup.Name = "volup";
            this.volup.Size = new System.Drawing.Size(79, 74);
            this.volup.TabIndex = 2;
            this.volup.Text = "button3";
            this.volup.UseVisualStyleBackColor = true;
            this.volup.Click += new System.EventHandler(this.volup_Click);
            // 
            // voldown
            // 
            this.voldown.Location = new System.Drawing.Point(604, 296);
            this.voldown.Name = "voldown";
            this.voldown.Size = new System.Drawing.Size(79, 74);
            this.voldown.TabIndex = 3;
            this.voldown.Text = "button4";
            this.voldown.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mediaplayer);
            this.panel1.Location = new System.Drawing.Point(33, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 391);
            this.panel1.TabIndex = 4;
            // 
            // mediaplayer
            // 
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(19, 3);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(461, 372);
            this.mediaplayer.TabIndex = 0;
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.voldown);
            this.Controls.Add(this.volup);
            this.Controls.Add(this.pausebuttom);
            this.Controls.Add(this.playvidbutton);
            this.Name = "play";
            this.Text = "play";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.play_FormClosed);
            this.Load += new System.EventHandler(this.play_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playvidbutton;
        private System.Windows.Forms.Button pausebuttom;
        private System.Windows.Forms.Button volup;
        private System.Windows.Forms.Button voldown;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer mediaplayer;
    }
}