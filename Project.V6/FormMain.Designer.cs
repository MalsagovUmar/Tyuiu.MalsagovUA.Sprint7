
namespace Project.V6
{
    partial class FormMain
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
            this.buttonClientFormMain_MUA = new System.Windows.Forms.Button();
            this.buttonWorkerFormMain_MUA = new System.Windows.Forms.Button();
            this.labelFormMain_MUA = new System.Windows.Forms.Label();
            this.menuStripMain_MUA = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAbout_MUA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProgram_MUA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain_MUA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClientFormMain_MUA
            // 
            this.buttonClientFormMain_MUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientFormMain_MUA.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientFormMain_MUA.Location = new System.Drawing.Point(216, 243);
            this.buttonClientFormMain_MUA.Name = "buttonClientFormMain_MUA";
            this.buttonClientFormMain_MUA.Size = new System.Drawing.Size(179, 98);
            this.buttonClientFormMain_MUA.TabIndex = 0;
            this.buttonClientFormMain_MUA.Text = "Клиент";
            this.buttonClientFormMain_MUA.UseVisualStyleBackColor = true;
            // 
            // buttonWorkerFormMain_MUA
            // 
            this.buttonWorkerFormMain_MUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkerFormMain_MUA.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWorkerFormMain_MUA.Location = new System.Drawing.Point(496, 243);
            this.buttonWorkerFormMain_MUA.Name = "buttonWorkerFormMain_MUA";
            this.buttonWorkerFormMain_MUA.Size = new System.Drawing.Size(179, 98);
            this.buttonWorkerFormMain_MUA.TabIndex = 0;
            this.buttonWorkerFormMain_MUA.Text = "Работник";
            this.buttonWorkerFormMain_MUA.UseVisualStyleBackColor = true;
            this.buttonWorkerFormMain_MUA.Click += new System.EventHandler(this.buttonWorkerFormMain_MUA_Click);
            // 
            // labelFormMain_MUA
            // 
            this.labelFormMain_MUA.AutoSize = true;
            this.labelFormMain_MUA.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormMain_MUA.Location = new System.Drawing.Point(360, 176);
            this.labelFormMain_MUA.Name = "labelFormMain_MUA";
            this.labelFormMain_MUA.Size = new System.Drawing.Size(179, 43);
            this.labelFormMain_MUA.TabIndex = 1;
            this.labelFormMain_MUA.Text = "Зайти как...";
            // 
            // menuStripMain_MUA
            // 
            this.menuStripMain_MUA.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain_MUA.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain_MUA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout_MUA,
            this.ToolStripMenuItemProgram_MUA});
            this.menuStripMain_MUA.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain_MUA.Name = "menuStripMain_MUA";
            this.menuStripMain_MUA.Size = new System.Drawing.Size(978, 36);
            this.menuStripMain_MUA.TabIndex = 2;
            this.menuStripMain_MUA.Text = "menuStrip1";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.labelFormMain_MUA);
            this.Controls.Add(this.buttonWorkerFormMain_MUA);
            this.Controls.Add(this.buttonClientFormMain_MUA);
            this.Controls.Add(this.menuStripMain_MUA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain_MUA;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника \"Здоровье+\"";
            this.menuStripMain_MUA.ResumeLayout(false);
            this.menuStripMain_MUA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClientFormMain_MUA;
        private System.Windows.Forms.Button buttonWorkerFormMain_MUA;
        private System.Windows.Forms.Label labelFormMain_MUA;
        private System.Windows.Forms.MenuStrip menuStripMain_MUA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout_MUA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProgram_MUA;
    }
}

