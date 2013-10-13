namespace MovieShack
{
    partial class frmCatgoryReportDialog
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
            this.lblCategoryReportDialog = new System.Windows.Forms.Label();
            this.lblCatgeoryReportDialogueCategory = new System.Windows.Forms.Label();
            this.cmbCategoryReportDialogCategory = new System.Windows.Forms.ComboBox();
            this.btnCategoryReportSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategoryReportDialog
            // 
            this.lblCategoryReportDialog.AutoSize = true;
            this.lblCategoryReportDialog.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryReportDialog.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryReportDialog.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCategoryReportDialog.Location = new System.Drawing.Point(-4, 9);
            this.lblCategoryReportDialog.Name = "lblCategoryReportDialog";
            this.lblCategoryReportDialog.Size = new System.Drawing.Size(300, 19);
            this.lblCategoryReportDialog.TabIndex = 0;
            this.lblCategoryReportDialog.Text = "Which movie category would you like the report for?";
            // 
            // lblCatgeoryReportDialogueCategory
            // 
            this.lblCatgeoryReportDialogueCategory.AutoSize = true;
            this.lblCatgeoryReportDialogueCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCatgeoryReportDialogueCategory.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatgeoryReportDialogueCategory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCatgeoryReportDialogueCategory.Location = new System.Drawing.Point(25, 42);
            this.lblCatgeoryReportDialogueCategory.Name = "lblCatgeoryReportDialogueCategory";
            this.lblCatgeoryReportDialogueCategory.Size = new System.Drawing.Size(62, 19);
            this.lblCatgeoryReportDialogueCategory.TabIndex = 5;
            this.lblCatgeoryReportDialogueCategory.Text = "Category:";
            // 
            // cmbCategoryReportDialogCategory
            // 
            this.cmbCategoryReportDialogCategory.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryReportDialogCategory.FormattingEnabled = true;
            this.cmbCategoryReportDialogCategory.Items.AddRange(new object[] {
            "",
            "Action",
            "Comedy",
            "Drama",
            "Romance",
            "Sci-Fi",
            "Thriller"});
            this.cmbCategoryReportDialogCategory.Location = new System.Drawing.Point(102, 39);
            this.cmbCategoryReportDialogCategory.Name = "cmbCategoryReportDialogCategory";
            this.cmbCategoryReportDialogCategory.Size = new System.Drawing.Size(100, 27);
            this.cmbCategoryReportDialogCategory.Sorted = true;
            this.cmbCategoryReportDialogCategory.TabIndex = 4;
            // 
            // btnCategoryReportSubmit
            // 
            this.btnCategoryReportSubmit.Location = new System.Drawing.Point(110, 78);
            this.btnCategoryReportSubmit.Name = "btnCategoryReportSubmit";
            this.btnCategoryReportSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryReportSubmit.TabIndex = 6;
            this.btnCategoryReportSubmit.Text = "Submit";
            this.btnCategoryReportSubmit.UseVisualStyleBackColor = true;
            this.btnCategoryReportSubmit.Click += new System.EventHandler(this.btnCategoryReportSubmit_Click);
            // 
            // frmCatgoryReportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieShack.Properties.Resources.MovieShackBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(298, 116);
            this.Controls.Add(this.btnCategoryReportSubmit);
            this.Controls.Add(this.lblCatgeoryReportDialogueCategory);
            this.Controls.Add(this.cmbCategoryReportDialogCategory);
            this.Controls.Add(this.lblCategoryReportDialog);
            this.Name = "frmCatgoryReportDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Which Movie Category";
            this.Load += new System.EventHandler(this.frmCatgoryReportDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryReportDialog;
        private System.Windows.Forms.Label lblCatgeoryReportDialogueCategory;
        private System.Windows.Forms.ComboBox cmbCategoryReportDialogCategory;
        private System.Windows.Forms.Button btnCategoryReportSubmit;
    }
}