
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
            this.buttonClientFormMain = new System.Windows.Forms.Button();
            this.buttonWorkerFormMain = new System.Windows.Forms.Button();
            this.labelFormMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClientFormMain
            // 
            this.buttonClientFormMain.Location = new System.Drawing.Point(326, 256);
            this.buttonClientFormMain.Name = "buttonClientFormMain";
            this.buttonClientFormMain.Size = new System.Drawing.Size(104, 59);
            this.buttonClientFormMain.TabIndex = 0;
            this.buttonClientFormMain.Text = "Клиент";
            this.buttonClientFormMain.UseVisualStyleBackColor = true;
            // 
            // buttonWorkerFormMain
            // 
            this.buttonWorkerFormMain.Location = new System.Drawing.Point(488, 256);
            this.buttonWorkerFormMain.Name = "buttonWorkerFormMain";
            this.buttonWorkerFormMain.Size = new System.Drawing.Size(104, 59);
            this.buttonWorkerFormMain.TabIndex = 0;
            this.buttonWorkerFormMain.Text = "Работник";
            this.buttonWorkerFormMain.UseVisualStyleBackColor = true;
            // 
            // labelFormMain
            // 
            this.labelFormMain.AutoSize = true;
            this.labelFormMain.Location = new System.Drawing.Point(431, 203);
            this.labelFormMain.Name = "labelFormMain";
            this.labelFormMain.Size = new System.Drawing.Size(70, 20);
            this.labelFormMain.TabIndex = 1;
            this.labelFormMain.Text = "Кто вы?";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.labelFormMain);
            this.Controls.Add(this.buttonWorkerFormMain);
            this.Controls.Add(this.buttonClientFormMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника \"Здоровье+\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClientFormMain;
        private System.Windows.Forms.Button buttonWorkerFormMain;
        private System.Windows.Forms.Label labelFormMain;
    }
}

