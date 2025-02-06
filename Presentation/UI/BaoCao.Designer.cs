namespace Presentation
{
    partial class BaoCao
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
            this.viewBaoCao = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBaoCao
            // 
            this.viewBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewBaoCao.Location = new System.Drawing.Point(12, 55);
            this.viewBaoCao.Name = "viewBaoCao";
            this.viewBaoCao.Size = new System.Drawing.Size(811, 436);
            this.viewBaoCao.TabIndex = 0;
            this.viewBaoCao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewBaoCao_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Báo cáo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewBaoCao);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.viewBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewBaoCao;
        private System.Windows.Forms.Label label2;
    }
}