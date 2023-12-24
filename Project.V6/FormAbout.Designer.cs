
namespace Project.V6
{
    partial class FormAbout_MUA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_MUA));
            this.pictureBoxAvatarAbout_MUA = new System.Windows.Forms.PictureBox();
            this.labelAbout_MUA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarAbout_MUA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatarAbout_MUA
            // 
            this.pictureBoxAvatarAbout_MUA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatarAbout_MUA.Image")));
            this.pictureBoxAvatarAbout_MUA.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatarAbout_MUA.Name = "pictureBoxAvatarAbout_MUA";
            this.pictureBoxAvatarAbout_MUA.Size = new System.Drawing.Size(173, 211);
            this.pictureBoxAvatarAbout_MUA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatarAbout_MUA.TabIndex = 0;
            this.pictureBoxAvatarAbout_MUA.TabStop = false;
            // 
            // labelAbout_MUA
            // 
            this.labelAbout_MUA.AutoSize = true;
            this.labelAbout_MUA.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout_MUA.Location = new System.Drawing.Point(192, 13);
            this.labelAbout_MUA.Name = "labelAbout_MUA";
            this.labelAbout_MUA.Size = new System.Drawing.Size(441, 108);
            this.labelAbout_MUA.TabIndex = 1;
            this.labelAbout_MUA.Text = "Разработчик: Мальсагов Умар Асланович\r\nГруппа: АСОиУб-23-2\r\nТИУ, ВШЦТ (с) 2023\r\nП" +
    "рограмма разработана в рамках изучения C#";
            // 
            // FormAbout_MUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 253);
            this.Controls.Add(this.labelAbout_MUA);
            this.Controls.Add(this.pictureBoxAvatarAbout_MUA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(746, 309);
            this.Name = "FormAbout_MUA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarAbout_MUA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatarAbout_MUA;
        private System.Windows.Forms.Label labelAbout_MUA;
    }
}