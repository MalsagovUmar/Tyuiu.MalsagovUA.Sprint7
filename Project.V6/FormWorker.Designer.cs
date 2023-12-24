
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
            this.groupBoxChooseProfile_MUA = new System.Windows.Forms.GroupBox();
            this.radioButtonIvanov_MUA = new System.Windows.Forms.RadioButton();
            this.radioButtonSergeev_MUA = new System.Windows.Forms.RadioButton();
            this.radioButtonKirillova_MUA = new System.Windows.Forms.RadioButton();
            this.radioButtonDishuk_MUA = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStripWorker_MUA.SuspendLayout();
            this.groupBoxChooseProfile_MUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.ToolStripMenuItemAbout_MUA.Size = new System.Drawing.Size(157, 32);
            this.ToolStripMenuItemAbout_MUA.Text = "О разработчике";
            this.ToolStripMenuItemAbout_MUA.Click += new System.EventHandler(this.ToolStripMenuItemAbout_MUA_Click);
            // 
            // ToolStripMenuItemProgram_MUA
            // 
            this.ToolStripMenuItemProgram_MUA.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemProgram_MUA.Name = "ToolStripMenuItemProgram_MUA";
            this.ToolStripMenuItemProgram_MUA.Size = new System.Drawing.Size(137, 32);
            this.ToolStripMenuItemProgram_MUA.Text = "О программе";
            // 
            // groupBoxChooseProfile_MUA
            // 
            this.groupBoxChooseProfile_MUA.Controls.Add(this.radioButtonDishuk_MUA);
            this.groupBoxChooseProfile_MUA.Controls.Add(this.radioButtonKirillova_MUA);
            this.groupBoxChooseProfile_MUA.Controls.Add(this.radioButtonSergeev_MUA);
            this.groupBoxChooseProfile_MUA.Controls.Add(this.radioButtonIvanov_MUA);
            this.groupBoxChooseProfile_MUA.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChooseProfile_MUA.Location = new System.Drawing.Point(13, 36);
            this.groupBoxChooseProfile_MUA.Name = "groupBoxChooseProfile_MUA";
            this.groupBoxChooseProfile_MUA.Size = new System.Drawing.Size(253, 181);
            this.groupBoxChooseProfile_MUA.TabIndex = 1;
            this.groupBoxChooseProfile_MUA.TabStop = false;
            this.groupBoxChooseProfile_MUA.Text = "Выберите профиль:";
            // 
            // radioButtonIvanov_MUA
            // 
            this.radioButtonIvanov_MUA.AutoSize = true;
            this.radioButtonIvanov_MUA.Location = new System.Drawing.Point(7, 34);
            this.radioButtonIvanov_MUA.Name = "radioButtonIvanov_MUA";
            this.radioButtonIvanov_MUA.Size = new System.Drawing.Size(145, 31);
            this.radioButtonIvanov_MUA.TabIndex = 0;
            this.radioButtonIvanov_MUA.Text = "Иванов П.А.";
            this.radioButtonIvanov_MUA.UseVisualStyleBackColor = true;
            // 
            // radioButtonSergeev_MUA
            // 
            this.radioButtonSergeev_MUA.AutoSize = true;
            this.radioButtonSergeev_MUA.Location = new System.Drawing.Point(7, 71);
            this.radioButtonSergeev_MUA.Name = "radioButtonSergeev_MUA";
            this.radioButtonSergeev_MUA.Size = new System.Drawing.Size(149, 31);
            this.radioButtonSergeev_MUA.TabIndex = 0;
            this.radioButtonSergeev_MUA.Text = "Сергеев Н.К.";
            this.radioButtonSergeev_MUA.UseVisualStyleBackColor = true;
            // 
            // radioButtonKirillova_MUA
            // 
            this.radioButtonKirillova_MUA.AutoSize = true;
            this.radioButtonKirillova_MUA.Location = new System.Drawing.Point(7, 108);
            this.radioButtonKirillova_MUA.Name = "radioButtonKirillova_MUA";
            this.radioButtonKirillova_MUA.Size = new System.Drawing.Size(174, 31);
            this.radioButtonKirillova_MUA.TabIndex = 0;
            this.radioButtonKirillova_MUA.Text = "Кириллова Т.С.";
            this.radioButtonKirillova_MUA.UseVisualStyleBackColor = true;
            // 
            // radioButtonDishuk_MUA
            // 
            this.radioButtonDishuk_MUA.AutoSize = true;
            this.radioButtonDishuk_MUA.Location = new System.Drawing.Point(7, 144);
            this.radioButtonDishuk_MUA.Name = "radioButtonDishuk_MUA";
            this.radioButtonDishuk_MUA.Size = new System.Drawing.Size(134, 31);
            this.radioButtonDishuk_MUA.TabIndex = 0;
            this.radioButtonDishuk_MUA.Text = "Дищук Е.А.";
            this.radioButtonDishuk_MUA.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(519, 496);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxChooseProfile_MUA);
            this.Controls.Add(this.menuStripWorker_MUA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripWorker_MUA;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника \"Здоровье+\" | Работники";
            this.menuStripWorker_MUA.ResumeLayout(false);
            this.menuStripWorker_MUA.PerformLayout();
            this.groupBoxChooseProfile_MUA.ResumeLayout(false);
            this.groupBoxChooseProfile_MUA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripWorker_MUA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout_MUA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProgram_MUA;
        private System.Windows.Forms.GroupBox groupBoxChooseProfile_MUA;
        private System.Windows.Forms.RadioButton radioButtonDishuk_MUA;
        private System.Windows.Forms.RadioButton radioButtonKirillova_MUA;
        private System.Windows.Forms.RadioButton radioButtonSergeev_MUA;
        private System.Windows.Forms.RadioButton radioButtonIvanov_MUA;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}