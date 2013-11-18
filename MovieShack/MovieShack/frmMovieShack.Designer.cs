namespace MovieShack
{
    partial class frmMovieShack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovieShack));
            this.tctrlMovieShack = new System.Windows.Forms.TabControl();
            this.tpgRent = new System.Windows.Forms.TabPage();
            this.lblRentPrice = new System.Windows.Forms.Label();
            this.lbRentCustId = new System.Windows.Forms.ListBox();
            this.lbRentMovieID = new System.Windows.Forms.ListBox();
            this.lbRentPrice = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbRentPrice = new System.Windows.Forms.TextBox();
            this.btnRentRemove = new System.Windows.Forms.Button();
            this.btnRentMovieAdd = new System.Windows.Forms.Button();
            this.lblRentMovieMoviesToRent = new System.Windows.Forms.Label();
            this.lblRentTotal = new System.Windows.Forms.Label();
            this.txtbRentTotalPrice = new System.Windows.Forms.TextBox();
            this.lbRentMovieMoviesToRent = new System.Windows.Forms.ListBox();
            this.txtbRentMovieCustId = new System.Windows.Forms.TextBox();
            this.lblRentMovieCustId = new System.Windows.Forms.Label();
            this.txtbRentMovieTitle = new System.Windows.Forms.TextBox();
            this.txtbRentMovieId = new System.Windows.Forms.TextBox();
            this.lblRentMovieTitle = new System.Windows.Forms.Label();
            this.lblRentMovieId = new System.Windows.Forms.Label();
            this.tpgSearch = new System.Windows.Forms.TabPage();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.lbSearchResults = new System.Windows.Forms.ListBox();
            this.cmsListBoxCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToRentFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbSearchSearch = new System.Windows.Forms.GroupBox();
            this.rabSearchCustomer = new System.Windows.Forms.RadioButton();
            this.rabSearchMovie = new System.Windows.Forms.RadioButton();
            this.pnlSearchMovie = new System.Windows.Forms.Panel();
            this.lblSearchMovieTitle = new System.Windows.Forms.Label();
            this.txtbSearchMovieTitle = new System.Windows.Forms.TextBox();
            this.txtbSearchMovieID = new System.Windows.Forms.TextBox();
            this.lblSearchMovieId = new System.Windows.Forms.Label();
            this.pnlSearchCustomer = new System.Windows.Forms.Panel();
            this.lblSearchCustomerNumber = new System.Windows.Forms.Label();
            this.txtbSearchCustomerNumber = new System.Windows.Forms.TextBox();
            this.txtbSearchCustomerID = new System.Windows.Forms.TextBox();
            this.lblSearchCustomerId = new System.Windows.Forms.Label();
            this.tpgReports = new System.Windows.Forms.TabPage();
            this.grpbReportSelection = new System.Windows.Forms.GroupBox();
            this.btnReportCategory = new System.Windows.Forms.Button();
            this.btnReportCustomers = new System.Windows.Forms.Button();
            this.btnReportTotalRevenue = new System.Windows.Forms.Button();
            this.btnReportLatest = new System.Windows.Forms.Button();
            this.tpgAddNew = new System.Windows.Forms.TabPage();
            this.pnlAddMovie = new System.Windows.Forms.Panel();
            this.lblAddMovieId = new System.Windows.Forms.Label();
            this.txtbAddMovieId = new System.Windows.Forms.TextBox();
            this.lblAddMovieRuntime = new System.Windows.Forms.Label();
            this.txtbAddMovieRuntime = new System.Windows.Forms.TextBox();
            this.lblAddMovieCategory = new System.Windows.Forms.Label();
            this.cmbMovieCategory = new System.Windows.Forms.ComboBox();
            this.txtbAddMovieTitle = new System.Windows.Forms.TextBox();
            this.lblAddMovieTitle = new System.Windows.Forms.Label();
            this.grpbAddWhatToAdd = new System.Windows.Forms.GroupBox();
            this.rabAddCustomer = new System.Windows.Forms.RadioButton();
            this.rabAddMovie = new System.Windows.Forms.RadioButton();
            this.pnlAddCustomer = new System.Windows.Forms.Panel();
            this.lblAddCustomerIdNo = new System.Windows.Forms.Label();
            this.txtbAddCustomerIdNo = new System.Windows.Forms.TextBox();
            this.txtbAddCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblAddCustomerAddress = new System.Windows.Forms.Label();
            this.txtbAddCustomerSurname = new System.Windows.Forms.TextBox();
            this.lblAddCustomerNumber = new System.Windows.Forms.Label();
            this.txtbAddCustomerTelNo = new System.Windows.Forms.TextBox();
            this.lblAddCustomerSurname = new System.Windows.Forms.Label();
            this.txtbAddCustomerName = new System.Windows.Forms.TextBox();
            this.lblAddCustomerName = new System.Windows.Forms.Label();
            this.mnuStripMovieShack = new System.Windows.Forms.MenuStrip();
            this.mnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCategoryReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemRevenueReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLatestReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCustomerReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHelpFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovieShackSubmit = new System.Windows.Forms.Button();
            this.ttipCustomerReport = new System.Windows.Forms.ToolTip(this.components);
            this.ttipRevenueReport = new System.Windows.Forms.ToolTip(this.components);
            this.ttipCategoryReport = new System.Windows.Forms.ToolTip(this.components);
            this.ttipLatestReport = new System.Windows.Forms.ToolTip(this.components);
            this.ttipRentTab = new System.Windows.Forms.ToolTip(this.components);
            this.ttipSearchTab = new System.Windows.Forms.ToolTip(this.components);
            this.ttipReportsTab = new System.Windows.Forms.ToolTip(this.components);
            this.ttipAddNewTab = new System.Windows.Forms.ToolTip(this.components);
            this.tctrlMovieShack.SuspendLayout();
            this.tpgRent.SuspendLayout();
            this.tpgSearch.SuspendLayout();
            this.cmsListBoxCopy.SuspendLayout();
            this.grpbSearchSearch.SuspendLayout();
            this.pnlSearchMovie.SuspendLayout();
            this.pnlSearchCustomer.SuspendLayout();
            this.tpgReports.SuspendLayout();
            this.grpbReportSelection.SuspendLayout();
            this.tpgAddNew.SuspendLayout();
            this.pnlAddMovie.SuspendLayout();
            this.grpbAddWhatToAdd.SuspendLayout();
            this.pnlAddCustomer.SuspendLayout();
            this.mnuStripMovieShack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlMovieShack
            // 
            this.tctrlMovieShack.Controls.Add(this.tpgRent);
            this.tctrlMovieShack.Controls.Add(this.tpgSearch);
            this.tctrlMovieShack.Controls.Add(this.tpgReports);
            this.tctrlMovieShack.Controls.Add(this.tpgAddNew);
            this.tctrlMovieShack.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlMovieShack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tctrlMovieShack.Location = new System.Drawing.Point(0, 29);
            this.tctrlMovieShack.Name = "tctrlMovieShack";
            this.tctrlMovieShack.SelectedIndex = 0;
            this.tctrlMovieShack.Size = new System.Drawing.Size(464, 336);
            this.tctrlMovieShack.TabIndex = 1;
            // 
            // tpgRent
            // 
            this.tpgRent.AccessibleName = "tpgRent";
            this.tpgRent.BackColor = System.Drawing.Color.Transparent;
            this.tpgRent.BackgroundImage = global::MovieShack.Properties.Resources.MovieShackBG;
            this.tpgRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpgRent.Controls.Add(this.lblRentPrice);
            this.tpgRent.Controls.Add(this.lbRentCustId);
            this.tpgRent.Controls.Add(this.lbRentMovieID);
            this.tpgRent.Controls.Add(this.lbRentPrice);
            this.tpgRent.Controls.Add(this.label1);
            this.tpgRent.Controls.Add(this.txtbRentPrice);
            this.tpgRent.Controls.Add(this.btnRentRemove);
            this.tpgRent.Controls.Add(this.btnRentMovieAdd);
            this.tpgRent.Controls.Add(this.lblRentMovieMoviesToRent);
            this.tpgRent.Controls.Add(this.lblRentTotal);
            this.tpgRent.Controls.Add(this.txtbRentTotalPrice);
            this.tpgRent.Controls.Add(this.lbRentMovieMoviesToRent);
            this.tpgRent.Controls.Add(this.txtbRentMovieCustId);
            this.tpgRent.Controls.Add(this.lblRentMovieCustId);
            this.tpgRent.Controls.Add(this.txtbRentMovieTitle);
            this.tpgRent.Controls.Add(this.txtbRentMovieId);
            this.tpgRent.Controls.Add(this.lblRentMovieTitle);
            this.tpgRent.Controls.Add(this.lblRentMovieId);
            this.tpgRent.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.tpgRent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tpgRent.Location = new System.Drawing.Point(4, 32);
            this.tpgRent.Name = "tpgRent";
            this.tpgRent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRent.Size = new System.Drawing.Size(456, 300);
            this.tpgRent.TabIndex = 0;
            this.tpgRent.Text = "Rent";
            this.ttipRentTab.SetToolTip(this.tpgRent, "Click this tab to rent a movie for a customer");
            // 
            // lblRentPrice
            // 
            this.lblRentPrice.AutoSize = true;
            this.lblRentPrice.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRentPrice.Location = new System.Drawing.Point(399, 0);
            this.lblRentPrice.Name = "lblRentPrice";
            this.lblRentPrice.Size = new System.Drawing.Size(55, 26);
            this.lblRentPrice.TabIndex = 17;
            this.lblRentPrice.Text = "Price:";
            // 
            // lbRentCustId
            // 
            this.lbRentCustId.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbRentCustId.Enabled = false;
            this.lbRentCustId.FormattingEnabled = true;
            this.lbRentCustId.ItemHeight = 23;
            this.lbRentCustId.Location = new System.Drawing.Point(161, 185);
            this.lbRentCustId.Name = "lbRentCustId";
            this.lbRentCustId.Size = new System.Drawing.Size(142, 96);
            this.lbRentCustId.TabIndex = 16;
            this.lbRentCustId.Visible = false;
            // 
            // lbRentMovieID
            // 
            this.lbRentMovieID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbRentMovieID.Enabled = false;
            this.lbRentMovieID.FormattingEnabled = true;
            this.lbRentMovieID.ItemHeight = 23;
            this.lbRentMovieID.Location = new System.Drawing.Point(13, 185);
            this.lbRentMovieID.Name = "lbRentMovieID";
            this.lbRentMovieID.Size = new System.Drawing.Size(142, 96);
            this.lbRentMovieID.TabIndex = 15;
            this.lbRentMovieID.Visible = false;
            // 
            // lbRentPrice
            // 
            this.lbRentPrice.Enabled = false;
            this.lbRentPrice.FormattingEnabled = true;
            this.lbRentPrice.ItemHeight = 23;
            this.lbRentPrice.Location = new System.Drawing.Point(402, 23);
            this.lbRentPrice.Name = "lbRentPrice";
            this.lbRentPrice.Size = new System.Drawing.Size(43, 96);
            this.lbRentPrice.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Price:";
            // 
            // txtbRentPrice
            // 
            this.txtbRentPrice.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRentPrice.Location = new System.Drawing.Point(106, 121);
            this.txtbRentPrice.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtbRentPrice.Name = "txtbRentPrice";
            this.txtbRentPrice.Size = new System.Drawing.Size(41, 27);
            this.txtbRentPrice.TabIndex = 5;
            // 
            // btnRentRemove
            // 
            this.btnRentRemove.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRentRemove.Location = new System.Drawing.Point(321, 121);
            this.btnRentRemove.Name = "btnRentRemove";
            this.btnRentRemove.Size = new System.Drawing.Size(75, 27);
            this.btnRentRemove.TabIndex = 8;
            this.btnRentRemove.Text = "Remove";
            this.btnRentRemove.UseVisualStyleBackColor = true;
            this.btnRentRemove.Click += new System.EventHandler(this.btnRentRemove_Click);
            // 
            // btnRentMovieAdd
            // 
            this.btnRentMovieAdd.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentMovieAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRentMovieAdd.Location = new System.Drawing.Point(240, 121);
            this.btnRentMovieAdd.Name = "btnRentMovieAdd";
            this.btnRentMovieAdd.Size = new System.Drawing.Size(75, 27);
            this.btnRentMovieAdd.TabIndex = 6;
            this.btnRentMovieAdd.Text = "Add";
            this.btnRentMovieAdd.UseVisualStyleBackColor = true;
            this.btnRentMovieAdd.Click += new System.EventHandler(this.btnRentMovieAdd_Click);
            // 
            // lblRentMovieMoviesToRent
            // 
            this.lblRentMovieMoviesToRent.AutoSize = true;
            this.lblRentMovieMoviesToRent.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentMovieMoviesToRent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRentMovieMoviesToRent.Location = new System.Drawing.Point(247, 0);
            this.lblRentMovieMoviesToRent.Name = "lblRentMovieMoviesToRent";
            this.lblRentMovieMoviesToRent.Size = new System.Drawing.Size(113, 23);
            this.lblRentMovieMoviesToRent.TabIndex = 9;
            this.lblRentMovieMoviesToRent.Text = "Movies To Rent:";
            // 
            // lblRentTotal
            // 
            this.lblRentTotal.AutoSize = true;
            this.lblRentTotal.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentTotal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRentTotal.Location = new System.Drawing.Point(348, 196);
            this.lblRentTotal.Name = "lblRentTotal";
            this.lblRentTotal.Size = new System.Drawing.Size(48, 23);
            this.lblRentTotal.TabIndex = 8;
            this.lblRentTotal.Text = "Total:";
            // 
            // txtbRentTotalPrice
            // 
            this.txtbRentTotalPrice.Enabled = false;
            this.txtbRentTotalPrice.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRentTotalPrice.Location = new System.Drawing.Point(402, 196);
            this.txtbRentTotalPrice.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtbRentTotalPrice.Name = "txtbRentTotalPrice";
            this.txtbRentTotalPrice.Size = new System.Drawing.Size(43, 27);
            this.txtbRentTotalPrice.TabIndex = 7;
            // 
            // lbRentMovieMoviesToRent
            // 
            this.lbRentMovieMoviesToRent.FormattingEnabled = true;
            this.lbRentMovieMoviesToRent.ItemHeight = 23;
            this.lbRentMovieMoviesToRent.Location = new System.Drawing.Point(248, 23);
            this.lbRentMovieMoviesToRent.Name = "lbRentMovieMoviesToRent";
            this.lbRentMovieMoviesToRent.Size = new System.Drawing.Size(142, 96);
            this.lbRentMovieMoviesToRent.TabIndex = 7;
            // 
            // txtbRentMovieCustId
            // 
            this.txtbRentMovieCustId.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRentMovieCustId.Location = new System.Drawing.Point(106, 88);
            this.txtbRentMovieCustId.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtbRentMovieCustId.Name = "txtbRentMovieCustId";
            this.txtbRentMovieCustId.Size = new System.Drawing.Size(124, 27);
            this.txtbRentMovieCustId.TabIndex = 4;
            // 
            // lblRentMovieCustId
            // 
            this.lblRentMovieCustId.AutoSize = true;
            this.lblRentMovieCustId.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentMovieCustId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRentMovieCustId.Location = new System.Drawing.Point(9, 90);
            this.lblRentMovieCustId.Name = "lblRentMovieCustId";
            this.lblRentMovieCustId.Size = new System.Drawing.Size(95, 23);
            this.lblRentMovieCustId.TabIndex = 4;
            this.lblRentMovieCustId.Text = "Customer ID:";
            // 
            // txtbRentMovieTitle
            // 
            this.txtbRentMovieTitle.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRentMovieTitle.Location = new System.Drawing.Point(106, 55);
            this.txtbRentMovieTitle.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtbRentMovieTitle.Name = "txtbRentMovieTitle";
            this.txtbRentMovieTitle.Size = new System.Drawing.Size(124, 27);
            this.txtbRentMovieTitle.TabIndex = 3;
            // 
            // txtbRentMovieId
            // 
            this.txtbRentMovieId.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRentMovieId.Location = new System.Drawing.Point(106, 20);
            this.txtbRentMovieId.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtbRentMovieId.Name = "txtbRentMovieId";
            this.txtbRentMovieId.Size = new System.Drawing.Size(124, 27);
            this.txtbRentMovieId.TabIndex = 2;
            // 
            // lblRentMovieTitle
            // 
            this.lblRentMovieTitle.AutoSize = true;
            this.lblRentMovieTitle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentMovieTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRentMovieTitle.Location = new System.Drawing.Point(9, 57);
            this.lblRentMovieTitle.Name = "lblRentMovieTitle";
            this.lblRentMovieTitle.Size = new System.Drawing.Size(86, 23);
            this.lblRentMovieTitle.TabIndex = 1;
            this.lblRentMovieTitle.Text = "Movie Title:";
            // 
            // lblRentMovieId
            // 
            this.lblRentMovieId.AutoSize = true;
            this.lblRentMovieId.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentMovieId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRentMovieId.Location = new System.Drawing.Point(9, 22);
            this.lblRentMovieId.Name = "lblRentMovieId";
            this.lblRentMovieId.Size = new System.Drawing.Size(70, 23);
            this.lblRentMovieId.TabIndex = 0;
            this.lblRentMovieId.Text = "Movie ID:";
            // 
            // tpgSearch
            // 
            this.tpgSearch.BackColor = System.Drawing.Color.Transparent;
            this.tpgSearch.BackgroundImage = global::MovieShack.Properties.Resources.MovieShackBG;
            this.tpgSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpgSearch.Controls.Add(this.lblSearchResults);
            this.tpgSearch.Controls.Add(this.lbSearchResults);
            this.tpgSearch.Controls.Add(this.grpbSearchSearch);
            this.tpgSearch.Controls.Add(this.pnlSearchMovie);
            this.tpgSearch.Controls.Add(this.pnlSearchCustomer);
            this.tpgSearch.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.tpgSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tpgSearch.Location = new System.Drawing.Point(4, 32);
            this.tpgSearch.Name = "tpgSearch";
            this.tpgSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSearch.Size = new System.Drawing.Size(456, 300);
            this.tpgSearch.TabIndex = 1;
            this.tpgSearch.Text = "Search";
            this.ttipSearchTab.SetToolTip(this.tpgSearch, resources.GetString("tpgSearch.ToolTip"));
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchResults.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSearchResults.Location = new System.Drawing.Point(235, 48);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(58, 23);
            this.lblSearchResults.TabIndex = 11;
            this.lblSearchResults.Text = "Results:";
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.ContextMenuStrip = this.cmsListBoxCopy;
            this.lbSearchResults.FormattingEnabled = true;
            this.lbSearchResults.ItemHeight = 23;
            this.lbSearchResults.Location = new System.Drawing.Point(236, 73);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(156, 142);
            this.lbSearchResults.TabIndex = 10;
            // 
            // cmsListBoxCopy
            // 
            this.cmsListBoxCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToRentFieldsToolStripMenuItem});
            this.cmsListBoxCopy.Name = "cmsListBoxCopy";
            this.cmsListBoxCopy.Size = new System.Drawing.Size(180, 26);
            this.cmsListBoxCopy.Text = "Copy";
            // 
            // copyToRentFieldsToolStripMenuItem
            // 
            this.copyToRentFieldsToolStripMenuItem.Name = "copyToRentFieldsToolStripMenuItem";
            this.copyToRentFieldsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.copyToRentFieldsToolStripMenuItem.Text = "Copy To Rent Fields";
            this.copyToRentFieldsToolStripMenuItem.Click += new System.EventHandler(this.copyToRentFieldsToolStripMenuItem_Click);
            // 
            // grpbSearchSearch
            // 
            this.grpbSearchSearch.Controls.Add(this.rabSearchCustomer);
            this.grpbSearchSearch.Controls.Add(this.rabSearchMovie);
            this.grpbSearchSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSearchSearch.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbSearchSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpbSearchSearch.Location = new System.Drawing.Point(3, 3);
            this.grpbSearchSearch.Name = "grpbSearchSearch";
            this.grpbSearchSearch.Size = new System.Drawing.Size(450, 45);
            this.grpbSearchSearch.TabIndex = 0;
            this.grpbSearchSearch.TabStop = false;
            this.grpbSearchSearch.Text = "What To Search:";
            // 
            // rabSearchCustomer
            // 
            this.rabSearchCustomer.AutoSize = true;
            this.rabSearchCustomer.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabSearchCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rabSearchCustomer.Location = new System.Drawing.Point(71, 21);
            this.rabSearchCustomer.Name = "rabSearchCustomer";
            this.rabSearchCustomer.Size = new System.Drawing.Size(90, 27);
            this.rabSearchCustomer.TabIndex = 1;
            this.rabSearchCustomer.Text = "Customer";
            this.rabSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // rabSearchMovie
            // 
            this.rabSearchMovie.AutoSize = true;
            this.rabSearchMovie.Checked = true;
            this.rabSearchMovie.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabSearchMovie.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rabSearchMovie.Location = new System.Drawing.Point(7, 21);
            this.rabSearchMovie.Name = "rabSearchMovie";
            this.rabSearchMovie.Size = new System.Drawing.Size(65, 27);
            this.rabSearchMovie.TabIndex = 0;
            this.rabSearchMovie.TabStop = true;
            this.rabSearchMovie.Text = "Movie";
            this.rabSearchMovie.UseVisualStyleBackColor = true;
            this.rabSearchMovie.CheckedChanged += new System.EventHandler(this.rabSearchMovie_CheckedChanged);
            // 
            // pnlSearchMovie
            // 
            this.pnlSearchMovie.Controls.Add(this.lblSearchMovieTitle);
            this.pnlSearchMovie.Controls.Add(this.txtbSearchMovieTitle);
            this.pnlSearchMovie.Controls.Add(this.txtbSearchMovieID);
            this.pnlSearchMovie.Controls.Add(this.lblSearchMovieId);
            this.pnlSearchMovie.Location = new System.Drawing.Point(6, 59);
            this.pnlSearchMovie.Name = "pnlSearchMovie";
            this.pnlSearchMovie.Size = new System.Drawing.Size(221, 108);
            this.pnlSearchMovie.TabIndex = 1;
            // 
            // lblSearchMovieTitle
            // 
            this.lblSearchMovieTitle.AutoSize = true;
            this.lblSearchMovieTitle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMovieTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSearchMovieTitle.Location = new System.Drawing.Point(13, 61);
            this.lblSearchMovieTitle.Name = "lblSearchMovieTitle";
            this.lblSearchMovieTitle.Size = new System.Drawing.Size(86, 23);
            this.lblSearchMovieTitle.TabIndex = 3;
            this.lblSearchMovieTitle.Text = "Movie Title:";
            // 
            // txtbSearchMovieTitle
            // 
            this.txtbSearchMovieTitle.Location = new System.Drawing.Point(102, 58);
            this.txtbSearchMovieTitle.Name = "txtbSearchMovieTitle";
            this.txtbSearchMovieTitle.Size = new System.Drawing.Size(100, 30);
            this.txtbSearchMovieTitle.TabIndex = 2;
            // 
            // txtbSearchMovieID
            // 
            this.txtbSearchMovieID.Location = new System.Drawing.Point(102, 25);
            this.txtbSearchMovieID.Name = "txtbSearchMovieID";
            this.txtbSearchMovieID.Size = new System.Drawing.Size(100, 30);
            this.txtbSearchMovieID.TabIndex = 1;
            // 
            // lblSearchMovieId
            // 
            this.lblSearchMovieId.AutoSize = true;
            this.lblSearchMovieId.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMovieId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSearchMovieId.Location = new System.Drawing.Point(13, 28);
            this.lblSearchMovieId.Name = "lblSearchMovieId";
            this.lblSearchMovieId.Size = new System.Drawing.Size(70, 23);
            this.lblSearchMovieId.TabIndex = 0;
            this.lblSearchMovieId.Text = "Movie ID:";
            // 
            // pnlSearchCustomer
            // 
            this.pnlSearchCustomer.Controls.Add(this.lblSearchCustomerNumber);
            this.pnlSearchCustomer.Controls.Add(this.txtbSearchCustomerNumber);
            this.pnlSearchCustomer.Controls.Add(this.txtbSearchCustomerID);
            this.pnlSearchCustomer.Controls.Add(this.lblSearchCustomerId);
            this.pnlSearchCustomer.Location = new System.Drawing.Point(16, 64);
            this.pnlSearchCustomer.Name = "pnlSearchCustomer";
            this.pnlSearchCustomer.Size = new System.Drawing.Size(214, 103);
            this.pnlSearchCustomer.TabIndex = 12;
            this.pnlSearchCustomer.Visible = false;
            // 
            // lblSearchCustomerNumber
            // 
            this.lblSearchCustomerNumber.AutoSize = true;
            this.lblSearchCustomerNumber.Location = new System.Drawing.Point(-3, 61);
            this.lblSearchCustomerNumber.Name = "lblSearchCustomerNumber";
            this.lblSearchCustomerNumber.Size = new System.Drawing.Size(92, 23);
            this.lblSearchCustomerNumber.TabIndex = 3;
            this.lblSearchCustomerNumber.Text = "Tel Number:";
            // 
            // txtbSearchCustomerNumber
            // 
            this.txtbSearchCustomerNumber.Location = new System.Drawing.Point(96, 58);
            this.txtbSearchCustomerNumber.Name = "txtbSearchCustomerNumber";
            this.txtbSearchCustomerNumber.Size = new System.Drawing.Size(115, 30);
            this.txtbSearchCustomerNumber.TabIndex = 2;
            // 
            // txtbSearchCustomerID
            // 
            this.txtbSearchCustomerID.Location = new System.Drawing.Point(96, 25);
            this.txtbSearchCustomerID.Name = "txtbSearchCustomerID";
            this.txtbSearchCustomerID.Size = new System.Drawing.Size(115, 30);
            this.txtbSearchCustomerID.TabIndex = 1;
            // 
            // lblSearchCustomerId
            // 
            this.lblSearchCustomerId.AutoSize = true;
            this.lblSearchCustomerId.Location = new System.Drawing.Point(-3, 28);
            this.lblSearchCustomerId.Name = "lblSearchCustomerId";
            this.lblSearchCustomerId.Size = new System.Drawing.Size(95, 23);
            this.lblSearchCustomerId.TabIndex = 0;
            this.lblSearchCustomerId.Text = "Customer ID:";
            // 
            // tpgReports
            // 
            this.tpgReports.BackColor = System.Drawing.Color.Transparent;
            this.tpgReports.BackgroundImage = global::MovieShack.Properties.Resources.MovieShackBG;
            this.tpgReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpgReports.Controls.Add(this.grpbReportSelection);
            this.tpgReports.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tpgReports.Location = new System.Drawing.Point(4, 32);
            this.tpgReports.Name = "tpgReports";
            this.tpgReports.Size = new System.Drawing.Size(456, 300);
            this.tpgReports.TabIndex = 3;
            this.tpgReports.Text = "Reports";
            this.ttipReportsTab.SetToolTip(this.tpgReports, "This tab allows you to generate diffrent kinds of reports");
            // 
            // grpbReportSelection
            // 
            this.grpbReportSelection.Controls.Add(this.btnReportCategory);
            this.grpbReportSelection.Controls.Add(this.btnReportCustomers);
            this.grpbReportSelection.Controls.Add(this.btnReportTotalRevenue);
            this.grpbReportSelection.Controls.Add(this.btnReportLatest);
            this.grpbReportSelection.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpbReportSelection.Location = new System.Drawing.Point(23, 21);
            this.grpbReportSelection.Name = "grpbReportSelection";
            this.grpbReportSelection.Size = new System.Drawing.Size(343, 137);
            this.grpbReportSelection.TabIndex = 6;
            this.grpbReportSelection.TabStop = false;
            this.grpbReportSelection.Text = "Report Selection:";
            // 
            // btnReportCategory
            // 
            this.btnReportCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportCategory.Location = new System.Drawing.Point(4, 39);
            this.btnReportCategory.Name = "btnReportCategory";
            this.btnReportCategory.Size = new System.Drawing.Size(163, 32);
            this.btnReportCategory.TabIndex = 1;
            this.btnReportCategory.Text = "Category Report";
            this.ttipCategoryReport.SetToolTip(this.btnReportCategory, "This Report diplays all the movies owned in a specific category of you choice");
            this.btnReportCategory.UseVisualStyleBackColor = true;
            this.btnReportCategory.Click += new System.EventHandler(this.btnReportCategory_Click);
            // 
            // btnReportCustomers
            // 
            this.btnReportCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportCustomers.Location = new System.Drawing.Point(173, 77);
            this.btnReportCustomers.Name = "btnReportCustomers";
            this.btnReportCustomers.Size = new System.Drawing.Size(163, 32);
            this.btnReportCustomers.TabIndex = 4;
            this.btnReportCustomers.Text = "Customer Report";
            this.ttipCustomerReport.SetToolTip(this.btnReportCustomers, "This Report Displays all the current customers in the system");
            this.btnReportCustomers.UseVisualStyleBackColor = true;
            this.btnReportCustomers.Click += new System.EventHandler(this.btnReportCustomers_Click);
            // 
            // btnReportTotalRevenue
            // 
            this.btnReportTotalRevenue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportTotalRevenue.Location = new System.Drawing.Point(4, 77);
            this.btnReportTotalRevenue.Name = "btnReportTotalRevenue";
            this.btnReportTotalRevenue.Size = new System.Drawing.Size(163, 32);
            this.btnReportTotalRevenue.TabIndex = 2;
            this.btnReportTotalRevenue.Text = "Revenue Report";
            this.ttipRevenueReport.SetToolTip(this.btnReportTotalRevenue, "This Report displays all rentals made so far and the total income it has generate" +
                    "d");
            this.btnReportTotalRevenue.UseVisualStyleBackColor = true;
            this.btnReportTotalRevenue.Click += new System.EventHandler(this.btnReportTotalRevenue_Click);
            // 
            // btnReportLatest
            // 
            this.btnReportLatest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportLatest.Location = new System.Drawing.Point(173, 39);
            this.btnReportLatest.Name = "btnReportLatest";
            this.btnReportLatest.Size = new System.Drawing.Size(163, 32);
            this.btnReportLatest.TabIndex = 3;
            this.btnReportLatest.Text = "Latest Report";
            this.ttipLatestReport.SetToolTip(this.btnReportLatest, "This Report displays 5 most recently added movies");
            this.btnReportLatest.UseVisualStyleBackColor = true;
            this.btnReportLatest.Click += new System.EventHandler(this.btnReportLatest_Click);
            // 
            // tpgAddNew
            // 
            this.tpgAddNew.BackColor = System.Drawing.Color.Transparent;
            this.tpgAddNew.BackgroundImage = global::MovieShack.Properties.Resources.MovieShackBG;
            this.tpgAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpgAddNew.Controls.Add(this.pnlAddMovie);
            this.tpgAddNew.Controls.Add(this.grpbAddWhatToAdd);
            this.tpgAddNew.Controls.Add(this.pnlAddCustomer);
            this.tpgAddNew.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tpgAddNew.Location = new System.Drawing.Point(4, 32);
            this.tpgAddNew.Name = "tpgAddNew";
            this.tpgAddNew.Size = new System.Drawing.Size(456, 300);
            this.tpgAddNew.TabIndex = 4;
            this.tpgAddNew.Text = "Add New";
            // 
            // pnlAddMovie
            // 
            this.pnlAddMovie.Controls.Add(this.lblAddMovieId);
            this.pnlAddMovie.Controls.Add(this.txtbAddMovieId);
            this.pnlAddMovie.Controls.Add(this.lblAddMovieRuntime);
            this.pnlAddMovie.Controls.Add(this.txtbAddMovieRuntime);
            this.pnlAddMovie.Controls.Add(this.lblAddMovieCategory);
            this.pnlAddMovie.Controls.Add(this.cmbMovieCategory);
            this.pnlAddMovie.Controls.Add(this.txtbAddMovieTitle);
            this.pnlAddMovie.Controls.Add(this.lblAddMovieTitle);
            this.pnlAddMovie.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAddMovie.Location = new System.Drawing.Point(8, 55);
            this.pnlAddMovie.Name = "pnlAddMovie";
            this.pnlAddMovie.Size = new System.Drawing.Size(326, 168);
            this.pnlAddMovie.TabIndex = 3;
            // 
            // lblAddMovieId
            // 
            this.lblAddMovieId.AutoSize = true;
            this.lblAddMovieId.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMovieId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddMovieId.Location = new System.Drawing.Point(7, 50);
            this.lblAddMovieId.Name = "lblAddMovieId";
            this.lblAddMovieId.Size = new System.Drawing.Size(70, 23);
            this.lblAddMovieId.TabIndex = 7;
            this.lblAddMovieId.Text = "Movie ID:";
            // 
            // txtbAddMovieId
            // 
            this.txtbAddMovieId.Location = new System.Drawing.Point(116, 47);
            this.txtbAddMovieId.Name = "txtbAddMovieId";
            this.txtbAddMovieId.Size = new System.Drawing.Size(100, 30);
            this.txtbAddMovieId.TabIndex = 2;
            // 
            // lblAddMovieRuntime
            // 
            this.lblAddMovieRuntime.AutoSize = true;
            this.lblAddMovieRuntime.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMovieRuntime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddMovieRuntime.Location = new System.Drawing.Point(7, 123);
            this.lblAddMovieRuntime.Name = "lblAddMovieRuntime";
            this.lblAddMovieRuntime.Size = new System.Drawing.Size(106, 23);
            this.lblAddMovieRuntime.TabIndex = 5;
            this.lblAddMovieRuntime.Text = "Runtime(min):";
            // 
            // txtbAddMovieRuntime
            // 
            this.txtbAddMovieRuntime.Location = new System.Drawing.Point(116, 120);
            this.txtbAddMovieRuntime.Name = "txtbAddMovieRuntime";
            this.txtbAddMovieRuntime.Size = new System.Drawing.Size(100, 30);
            this.txtbAddMovieRuntime.TabIndex = 4;
            // 
            // lblAddMovieCategory
            // 
            this.lblAddMovieCategory.AutoSize = true;
            this.lblAddMovieCategory.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMovieCategory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddMovieCategory.Location = new System.Drawing.Point(7, 86);
            this.lblAddMovieCategory.Name = "lblAddMovieCategory";
            this.lblAddMovieCategory.Size = new System.Drawing.Size(73, 23);
            this.lblAddMovieCategory.TabIndex = 3;
            this.lblAddMovieCategory.Text = "Category:";
            // 
            // cmbMovieCategory
            // 
            this.cmbMovieCategory.FormattingEnabled = true;
            this.cmbMovieCategory.Items.AddRange(new object[] {
            "",
            "Action",
            "Comedy",
            "Drama",
            "Romance",
            "Sci-Fi",
            "Thriller"});
            this.cmbMovieCategory.Location = new System.Drawing.Point(116, 83);
            this.cmbMovieCategory.Name = "cmbMovieCategory";
            this.cmbMovieCategory.Size = new System.Drawing.Size(100, 31);
            this.cmbMovieCategory.Sorted = true;
            this.cmbMovieCategory.TabIndex = 3;
            // 
            // txtbAddMovieTitle
            // 
            this.txtbAddMovieTitle.Location = new System.Drawing.Point(116, 11);
            this.txtbAddMovieTitle.Name = "txtbAddMovieTitle";
            this.txtbAddMovieTitle.Size = new System.Drawing.Size(187, 30);
            this.txtbAddMovieTitle.TabIndex = 1;
            // 
            // lblAddMovieTitle
            // 
            this.lblAddMovieTitle.AutoSize = true;
            this.lblAddMovieTitle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMovieTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddMovieTitle.Location = new System.Drawing.Point(7, 14);
            this.lblAddMovieTitle.Name = "lblAddMovieTitle";
            this.lblAddMovieTitle.Size = new System.Drawing.Size(86, 23);
            this.lblAddMovieTitle.TabIndex = 0;
            this.lblAddMovieTitle.Text = "Movie Title:";
            // 
            // grpbAddWhatToAdd
            // 
            this.grpbAddWhatToAdd.Controls.Add(this.rabAddCustomer);
            this.grpbAddWhatToAdd.Controls.Add(this.rabAddMovie);
            this.grpbAddWhatToAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbAddWhatToAdd.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbAddWhatToAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpbAddWhatToAdd.Location = new System.Drawing.Point(0, 0);
            this.grpbAddWhatToAdd.Name = "grpbAddWhatToAdd";
            this.grpbAddWhatToAdd.Size = new System.Drawing.Size(456, 45);
            this.grpbAddWhatToAdd.TabIndex = 1;
            this.grpbAddWhatToAdd.TabStop = false;
            this.grpbAddWhatToAdd.Text = "What To Add:";
            this.ttipAddNewTab.SetToolTip(this.grpbAddWhatToAdd, "This tab allows you to add new movies or customers to the system");
            // 
            // rabAddCustomer
            // 
            this.rabAddCustomer.AutoSize = true;
            this.rabAddCustomer.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabAddCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rabAddCustomer.Location = new System.Drawing.Point(71, 19);
            this.rabAddCustomer.Name = "rabAddCustomer";
            this.rabAddCustomer.Size = new System.Drawing.Size(90, 27);
            this.rabAddCustomer.TabIndex = 2;
            this.rabAddCustomer.Text = "Customer";
            this.rabAddCustomer.UseVisualStyleBackColor = true;
            // 
            // rabAddMovie
            // 
            this.rabAddMovie.AutoSize = true;
            this.rabAddMovie.Checked = true;
            this.rabAddMovie.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabAddMovie.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rabAddMovie.Location = new System.Drawing.Point(7, 19);
            this.rabAddMovie.Name = "rabAddMovie";
            this.rabAddMovie.Size = new System.Drawing.Size(65, 27);
            this.rabAddMovie.TabIndex = 1;
            this.rabAddMovie.TabStop = true;
            this.rabAddMovie.Text = "Movie";
            this.rabAddMovie.UseVisualStyleBackColor = true;
            this.rabAddMovie.CheckedChanged += new System.EventHandler(this.rabAddMovie_CheckedChanged);
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.Controls.Add(this.lblAddCustomerIdNo);
            this.pnlAddCustomer.Controls.Add(this.txtbAddCustomerIdNo);
            this.pnlAddCustomer.Controls.Add(this.txtbAddCustomerAddress);
            this.pnlAddCustomer.Controls.Add(this.lblAddCustomerAddress);
            this.pnlAddCustomer.Controls.Add(this.txtbAddCustomerSurname);
            this.pnlAddCustomer.Controls.Add(this.lblAddCustomerNumber);
            this.pnlAddCustomer.Controls.Add(this.txtbAddCustomerTelNo);
            this.pnlAddCustomer.Controls.Add(this.lblAddCustomerSurname);
            this.pnlAddCustomer.Controls.Add(this.txtbAddCustomerName);
            this.pnlAddCustomer.Controls.Add(this.lblAddCustomerName);
            this.pnlAddCustomer.Location = new System.Drawing.Point(8, 66);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(387, 160);
            this.pnlAddCustomer.TabIndex = 3;
            this.pnlAddCustomer.Visible = false;
            // 
            // lblAddCustomerIdNo
            // 
            this.lblAddCustomerIdNo.AutoSize = true;
            this.lblAddCustomerIdNo.Location = new System.Drawing.Point(7, 123);
            this.lblAddCustomerIdNo.Name = "lblAddCustomerIdNo";
            this.lblAddCustomerIdNo.Size = new System.Drawing.Size(86, 23);
            this.lblAddCustomerIdNo.TabIndex = 10;
            this.lblAddCustomerIdNo.Text = "ID Number:";
            // 
            // txtbAddCustomerIdNo
            // 
            this.txtbAddCustomerIdNo.Location = new System.Drawing.Point(132, 120);
            this.txtbAddCustomerIdNo.Name = "txtbAddCustomerIdNo";
            this.txtbAddCustomerIdNo.Size = new System.Drawing.Size(121, 30);
            this.txtbAddCustomerIdNo.TabIndex = 4;
            // 
            // txtbAddCustomerAddress
            // 
            this.txtbAddCustomerAddress.Location = new System.Drawing.Point(242, 37);
            this.txtbAddCustomerAddress.Multiline = true;
            this.txtbAddCustomerAddress.Name = "txtbAddCustomerAddress";
            this.txtbAddCustomerAddress.Size = new System.Drawing.Size(140, 78);
            this.txtbAddCustomerAddress.TabIndex = 5;
            // 
            // lblAddCustomerAddress
            // 
            this.lblAddCustomerAddress.AutoSize = true;
            this.lblAddCustomerAddress.Location = new System.Drawing.Point(238, 11);
            this.lblAddCustomerAddress.Name = "lblAddCustomerAddress";
            this.lblAddCustomerAddress.Size = new System.Drawing.Size(66, 23);
            this.lblAddCustomerAddress.TabIndex = 7;
            this.lblAddCustomerAddress.Text = "Address:";
            // 
            // txtbAddCustomerSurname
            // 
            this.txtbAddCustomerSurname.Location = new System.Drawing.Point(132, 47);
            this.txtbAddCustomerSurname.Name = "txtbAddCustomerSurname";
            this.txtbAddCustomerSurname.Size = new System.Drawing.Size(100, 30);
            this.txtbAddCustomerSurname.TabIndex = 2;
            // 
            // lblAddCustomerNumber
            // 
            this.lblAddCustomerNumber.AutoSize = true;
            this.lblAddCustomerNumber.Location = new System.Drawing.Point(7, 88);
            this.lblAddCustomerNumber.Name = "lblAddCustomerNumber";
            this.lblAddCustomerNumber.Size = new System.Drawing.Size(92, 23);
            this.lblAddCustomerNumber.TabIndex = 5;
            this.lblAddCustomerNumber.Text = "Tel Number:";
            // 
            // txtbAddCustomerTelNo
            // 
            this.txtbAddCustomerTelNo.Location = new System.Drawing.Point(132, 85);
            this.txtbAddCustomerTelNo.Name = "txtbAddCustomerTelNo";
            this.txtbAddCustomerTelNo.Size = new System.Drawing.Size(100, 30);
            this.txtbAddCustomerTelNo.TabIndex = 3;
            // 
            // lblAddCustomerSurname
            // 
            this.lblAddCustomerSurname.AutoSize = true;
            this.lblAddCustomerSurname.Location = new System.Drawing.Point(7, 51);
            this.lblAddCustomerSurname.Name = "lblAddCustomerSurname";
            this.lblAddCustomerSurname.Size = new System.Drawing.Size(74, 23);
            this.lblAddCustomerSurname.TabIndex = 3;
            this.lblAddCustomerSurname.Text = "Surname:";
            // 
            // txtbAddCustomerName
            // 
            this.txtbAddCustomerName.Location = new System.Drawing.Point(132, 11);
            this.txtbAddCustomerName.Name = "txtbAddCustomerName";
            this.txtbAddCustomerName.Size = new System.Drawing.Size(100, 30);
            this.txtbAddCustomerName.TabIndex = 1;
            // 
            // lblAddCustomerName
            // 
            this.lblAddCustomerName.AutoSize = true;
            this.lblAddCustomerName.Location = new System.Drawing.Point(7, 14);
            this.lblAddCustomerName.Name = "lblAddCustomerName";
            this.lblAddCustomerName.Size = new System.Drawing.Size(119, 23);
            this.lblAddCustomerName.TabIndex = 0;
            this.lblAddCustomerName.Text = "Customer Name:";
            // 
            // mnuStripMovieShack
            // 
            this.mnuStripMovieShack.BackColor = System.Drawing.Color.Transparent;
            this.mnuStripMovieShack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuStripMovieShack.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripMovieShack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFile,
            this.mnuItemReports,
            this.mnuItemHelp});
            this.mnuStripMovieShack.Location = new System.Drawing.Point(0, 0);
            this.mnuStripMovieShack.Name = "mnuStripMovieShack";
            this.mnuStripMovieShack.Size = new System.Drawing.Size(452, 29);
            this.mnuStripMovieShack.TabIndex = 2;
            this.mnuStripMovieShack.Text = "menuStrip1";
            // 
            // mnuItemFile
            // 
            this.mnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemExit});
            this.mnuItemFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuItemFile.Name = "mnuItemFile";
            this.mnuItemFile.Size = new System.Drawing.Size(41, 25);
            this.mnuItemFile.Text = "File";
            this.mnuItemFile.MouseEnter += new System.EventHandler(this.mnuItemFile_MouseEnter);
            this.mnuItemFile.MouseLeave += new System.EventHandler(this.mnuItemFile_MouseLeave);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(103, 26);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // mnuItemReports
            // 
            this.mnuItemReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemCategoryReport,
            this.mnuItemRevenueReport,
            this.mnuItemLatestReport,
            this.mnuItemCustomerReport});
            this.mnuItemReports.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuItemReports.Name = "mnuItemReports";
            this.mnuItemReports.Size = new System.Drawing.Size(69, 25);
            this.mnuItemReports.Text = "Reports";
            this.mnuItemReports.MouseEnter += new System.EventHandler(this.mnuItemReports_MouseEnter);
            this.mnuItemReports.MouseLeave += new System.EventHandler(this.mnuItemReports_MouseLeave);
            // 
            // mnuItemCategoryReport
            // 
            this.mnuItemCategoryReport.Name = "mnuItemCategoryReport";
            this.mnuItemCategoryReport.Size = new System.Drawing.Size(184, 26);
            this.mnuItemCategoryReport.Text = "Category Report";
            this.mnuItemCategoryReport.Click += new System.EventHandler(this.btnReportCategory_Click);
            // 
            // mnuItemRevenueReport
            // 
            this.mnuItemRevenueReport.Name = "mnuItemRevenueReport";
            this.mnuItemRevenueReport.Size = new System.Drawing.Size(184, 26);
            this.mnuItemRevenueReport.Text = "Revenue Report";
            this.mnuItemRevenueReport.Click += new System.EventHandler(this.btnReportTotalRevenue_Click);
            // 
            // mnuItemLatestReport
            // 
            this.mnuItemLatestReport.Name = "mnuItemLatestReport";
            this.mnuItemLatestReport.Size = new System.Drawing.Size(184, 26);
            this.mnuItemLatestReport.Text = "Latest Report";
            this.mnuItemLatestReport.Click += new System.EventHandler(this.btnReportLatest_Click);
            // 
            // mnuItemCustomerReport
            // 
            this.mnuItemCustomerReport.Name = "mnuItemCustomerReport";
            this.mnuItemCustomerReport.Size = new System.Drawing.Size(184, 26);
            this.mnuItemCustomerReport.Text = "Customer Report";
            this.mnuItemCustomerReport.Click += new System.EventHandler(this.btnReportCustomers_Click);
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHelpFiles,
            this.mnuItemAbout});
            this.mnuItemHelp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(49, 25);
            this.mnuItemHelp.Text = "Help";
            this.mnuItemHelp.MouseEnter += new System.EventHandler(this.mnuItemHelp_MouseEnter);
            this.mnuItemHelp.MouseLeave += new System.EventHandler(this.mnuItemHelp_MouseLeave);
            // 
            // mnuItemHelpFiles
            // 
            this.mnuItemHelpFiles.Name = "mnuItemHelpFiles";
            this.mnuItemHelpFiles.Size = new System.Drawing.Size(136, 26);
            this.mnuItemHelpFiles.Text = "Help Files";
            this.mnuItemHelpFiles.Click += new System.EventHandler(this.mnuItemHelpFiles_Click);
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Name = "mnuItemAbout";
            this.mnuItemAbout.Size = new System.Drawing.Size(136, 26);
            this.mnuItemAbout.Text = "About";
            this.mnuItemAbout.Click += new System.EventHandler(this.mnuItemAbout_Click);
            // 
            // btnMovieShackSubmit
            // 
            this.btnMovieShackSubmit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieShackSubmit.Location = new System.Drawing.Point(317, 298);
            this.btnMovieShackSubmit.Name = "btnMovieShackSubmit";
            this.btnMovieShackSubmit.Size = new System.Drawing.Size(85, 26);
            this.btnMovieShackSubmit.TabIndex = 3;
            this.btnMovieShackSubmit.Text = "Submit";
            this.btnMovieShackSubmit.UseVisualStyleBackColor = true;
            this.btnMovieShackSubmit.Click += new System.EventHandler(this.btnMovieShackSubmit_Click);
            // 
            // ttipCustomerReport
            // 
            this.ttipCustomerReport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipCustomerReport.ToolTipTitle = "Customer Report";
            // 
            // ttipRevenueReport
            // 
            this.ttipRevenueReport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipRevenueReport.ToolTipTitle = "Revenue Report";
            // 
            // ttipCategoryReport
            // 
            this.ttipCategoryReport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipCategoryReport.ToolTipTitle = "Category Report";
            // 
            // ttipLatestReport
            // 
            this.ttipLatestReport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipLatestReport.ToolTipTitle = "Latest Report";
            // 
            // ttipRentTab
            // 
            this.ttipRentTab.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipRentTab.ToolTipTitle = "Rent Tab";
            // 
            // ttipSearchTab
            // 
            this.ttipSearchTab.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipSearchTab.ToolTipTitle = "Search Tab";
            // 
            // ttipReportsTab
            // 
            this.ttipReportsTab.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipReportsTab.ToolTipTitle = "Reports Tab";
            // 
            // ttipAddNewTab
            // 
            this.ttipAddNewTab.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipAddNewTab.ToolTipTitle = "Add New Tab";
            // 
            // frmMovieShack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieShack.Properties.Resources.MovieShackBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 363);
            this.Controls.Add(this.btnMovieShackSubmit);
            this.Controls.Add(this.tctrlMovieShack);
            this.Controls.Add(this.mnuStripMovieShack);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovieShack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Shack";
            this.Load += new System.EventHandler(this.frmMovieShack_Load);
            this.tctrlMovieShack.ResumeLayout(false);
            this.tpgRent.ResumeLayout(false);
            this.tpgRent.PerformLayout();
            this.tpgSearch.ResumeLayout(false);
            this.tpgSearch.PerformLayout();
            this.cmsListBoxCopy.ResumeLayout(false);
            this.grpbSearchSearch.ResumeLayout(false);
            this.grpbSearchSearch.PerformLayout();
            this.pnlSearchMovie.ResumeLayout(false);
            this.pnlSearchMovie.PerformLayout();
            this.pnlSearchCustomer.ResumeLayout(false);
            this.pnlSearchCustomer.PerformLayout();
            this.tpgReports.ResumeLayout(false);
            this.grpbReportSelection.ResumeLayout(false);
            this.tpgAddNew.ResumeLayout(false);
            this.pnlAddMovie.ResumeLayout(false);
            this.pnlAddMovie.PerformLayout();
            this.grpbAddWhatToAdd.ResumeLayout(false);
            this.grpbAddWhatToAdd.PerformLayout();
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            this.mnuStripMovieShack.ResumeLayout(false);
            this.mnuStripMovieShack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.TabControl tctrlMovieShack;
        private System.Windows.Forms.TabPage tpgSearch;
        private System.Windows.Forms.TextBox txtbRentMovieId;
        private System.Windows.Forms.Label lblRentMovieTitle;
        private System.Windows.Forms.Label lblRentMovieId;
        private System.Windows.Forms.TabPage tpgReports;
        private System.Windows.Forms.TabPage tpgAddNew;
        private System.Windows.Forms.MenuStrip mnuStripMovieShack;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelpFiles;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.Label lblRentMovieCustId;
        private System.Windows.Forms.TextBox txtbRentMovieTitle;
        private System.Windows.Forms.Label lblRentTotal;
        private System.Windows.Forms.TextBox txtbRentTotalPrice;
        private System.Windows.Forms.ListBox lbRentMovieMoviesToRent;
        private System.Windows.Forms.TextBox txtbRentMovieCustId;
        private System.Windows.Forms.Button btnRentMovieAdd;
        private System.Windows.Forms.Label lblRentMovieMoviesToRent;
        private System.Windows.Forms.GroupBox grpbSearchSearch;
        private System.Windows.Forms.RadioButton rabSearchCustomer;
        private System.Windows.Forms.RadioButton rabSearchMovie;
        private System.Windows.Forms.Button btnMovieShackSubmit;
        private System.Windows.Forms.Panel pnlSearchCustomer;
        private System.Windows.Forms.Label lblSearchCustomerNumber;
        private System.Windows.Forms.TextBox txtbSearchCustomerNumber;
        private System.Windows.Forms.TextBox txtbSearchCustomerID;
        private System.Windows.Forms.Label lblSearchCustomerId;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.ListBox lbSearchResults;
        private System.Windows.Forms.Panel pnlSearchMovie;
        private System.Windows.Forms.Label lblSearchMovieTitle;
        private System.Windows.Forms.TextBox txtbSearchMovieTitle;
        private System.Windows.Forms.TextBox txtbSearchMovieID;
        private System.Windows.Forms.Label lblSearchMovieId;
        private System.Windows.Forms.Panel pnlAddCustomer;
        private System.Windows.Forms.TextBox txtbAddCustomerAddress;
        private System.Windows.Forms.Label lblAddCustomerAddress;
        private System.Windows.Forms.TextBox txtbAddCustomerSurname;
        private System.Windows.Forms.Label lblAddCustomerNumber;
        private System.Windows.Forms.TextBox txtbAddCustomerTelNo;
        private System.Windows.Forms.Label lblAddCustomerSurname;
        private System.Windows.Forms.TextBox txtbAddCustomerName;
        private System.Windows.Forms.Label lblAddCustomerName;
        private System.Windows.Forms.Panel pnlAddMovie;
        private System.Windows.Forms.Label lblAddMovieRuntime;
        private System.Windows.Forms.TextBox txtbAddMovieRuntime;
        private System.Windows.Forms.Label lblAddMovieCategory;
        private System.Windows.Forms.ComboBox cmbMovieCategory;
        private System.Windows.Forms.TextBox txtbAddMovieTitle;
        private System.Windows.Forms.Label lblAddMovieTitle;
        private System.Windows.Forms.GroupBox grpbAddWhatToAdd;
        private System.Windows.Forms.RadioButton rabAddCustomer;
        private System.Windows.Forms.RadioButton rabAddMovie;
        private System.Windows.Forms.GroupBox grpbReportSelection;
        private System.Windows.Forms.Button btnReportCategory;
        private System.Windows.Forms.Button btnReportCustomers;
        private System.Windows.Forms.Button btnReportTotalRevenue;
        private System.Windows.Forms.Button btnReportLatest;
        private System.Windows.Forms.Label lblAddCustomerIdNo;
        private System.Windows.Forms.TextBox txtbAddCustomerIdNo;
        private System.Windows.Forms.Button btnRentRemove;
        private System.Windows.Forms.Label lblAddMovieId;
        private System.Windows.Forms.TextBox txtbAddMovieId;
        private System.Windows.Forms.TabPage tpgRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbRentPrice;
        private System.Windows.Forms.ListBox lbRentPrice;
        private System.Windows.Forms.ListBox lbRentCustId;
        private System.Windows.Forms.ListBox lbRentMovieID;
        private System.Windows.Forms.ToolTip ttipCustomerReport;
        private System.Windows.Forms.ToolTip ttipRevenueReport;
        private System.Windows.Forms.ToolTip ttipCategoryReport;
        private System.Windows.Forms.ToolTip ttipLatestReport;
        private System.Windows.Forms.ToolTip ttipRentTab;
        private System.Windows.Forms.ToolTip ttipSearchTab;
        private System.Windows.Forms.ToolTip ttipReportsTab;
        private System.Windows.Forms.ToolTip ttipAddNewTab;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.Label lblRentPrice;
        private System.Windows.Forms.ContextMenuStrip cmsListBoxCopy;
        private System.Windows.Forms.ToolStripMenuItem copyToRentFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReports;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCategoryReport;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRevenueReport;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLatestReport;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCustomerReport;
    }
}

