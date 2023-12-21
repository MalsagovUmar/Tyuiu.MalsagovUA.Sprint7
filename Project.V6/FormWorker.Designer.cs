
namespace Project.V6
{
    partial class FormWorker
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
            this.menuStripWorker_MUA = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAbout_MUA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProgram_MUA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripWorker_MUA.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripWorker_MUA
            // 
            this.menuStripWorker_MUA.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripWorker_MUA.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripWorker_MUA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout_MUA,
            this.ToolStripMenuItemProgram_MUA});
            this.menuStripWorker_MUA.Location = new System.Drawing.Point(0, 0);
            this.menuStripWorker_MUA.Name = "menuStripWorker_MUA";
            this.menuStripWorker_MUA.Size = new System.Drawing.Size(978, 36);
            this.menuStripWorker_MUA.TabIndex = 0;
            this.menuStripWorker_MUA.Text = "menuStrip1";
            // 
            // ToolStripMenuItemAbout_MUA
            // 
            this.ToolStripMenuItemAbout_MUA.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemAbout_MUA.Name = "ToolStripMenuItemAbout_MUA";
            this.ToolStripMenuItemAbout_MUA.Size = new System.Drawing.Size(157, 30);
            this.ToolStripMenuItemAbout_MUA.Text = "О разработчике";
            this.ToolStripMenuItemAbout_MUA.Click += new System.EventHandler(this.ToolStripMenuItemAbout_MUA_Click);
            // 
            // ToolStripMenuItemProgram_MUA
            // 
            this.ToolStripMenuItemProgram_MUA.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemProgram_MUA.Name = "ToolStripMenuItemProgram_MUA";
            this.ToolStripMenuItemProgram_MUA.Size = new System.Drawing.Size(137, 30);
            this.ToolStripMenuItemProgram_MUA.Text = "О программе";
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.menuStripWorker_MUA);
            this.MainMenuStrip = this.menuStripWorker_MUA;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника \"Здоровье+\" | Зайдите в профиль";
            this.menuStripWorker_MUA.ResumeLayout(false);
            this.menuStripWorker_MUA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripWorker_MUA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout_MUA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProgram_MUA;
    }
}