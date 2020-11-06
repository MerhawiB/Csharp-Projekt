namespace RSSReader
{
    partial class frmRss
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
            this.lstVPodcast = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstBoxCategory = new System.Windows.Forms.ListBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cmbBoxInterval = new System.Windows.Forms.ComboBox();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnNewPodcast = new System.Windows.Forms.Button();
            this.btnUpdatePodCast = new System.Windows.Forms.Button();
            this.btnDeletePodCast = new System.Windows.Forms.Button();
            this.txtBoxCategory = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnChangeCategoryName = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.txtBoxEpisodeDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPodCastDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxEpisodes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnShowAllPodCast = new System.Windows.Forms.Button();
            this.btnFilterEpisodes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVPodcast
            // 
            this.lstVPodcast.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstVPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstVPodcast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstVPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVPodcast.FullRowSelect = true;
            this.lstVPodcast.GridLines = true;
            this.lstVPodcast.HideSelection = false;
            this.lstVPodcast.Location = new System.Drawing.Point(57, 30);
            this.lstVPodcast.Name = "lstVPodcast";
            this.lstVPodcast.Size = new System.Drawing.Size(608, 264);
            this.lstVPodcast.TabIndex = 0;
            this.lstVPodcast.UseCompatibleStateImageBehavior = false;
            this.lstVPodcast.View = System.Windows.Forms.View.Details;
            this.lstVPodcast.SelectedIndexChanged += new System.EventHandler(this.lstVPodcast_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Avsnitt";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Namn";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frekvens";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            this.columnHeader4.Width = 150;
            // 
            // lstBoxCategory
            // 
            this.lstBoxCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstBoxCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxCategory.FormattingEnabled = true;
            this.lstBoxCategory.ItemHeight = 19;
            this.lstBoxCategory.Location = new System.Drawing.Point(780, 30);
            this.lstBoxCategory.Name = "lstBoxCategory";
            this.lstBoxCategory.Size = new System.Drawing.Size(195, 270);
            this.lstBoxCategory.TabIndex = 1;
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(60, 342);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(260, 21);
            this.txtUrl.TabIndex = 2;
            // 
            // cmbBoxInterval
            // 
            this.cmbBoxInterval.FormattingEnabled = true;
            this.cmbBoxInterval.Location = new System.Drawing.Point(361, 342);
            this.cmbBoxInterval.Name = "cmbBoxInterval";
            this.cmbBoxInterval.Size = new System.Drawing.Size(153, 21);
            this.cmbBoxInterval.TabIndex = 3;
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(532, 342);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(125, 21);
            this.cmbBoxCategory.TabIndex = 4;
            // 
            // btnNewPodcast
            // 
            this.btnNewPodcast.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNewPodcast.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnNewPodcast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPodcast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewPodcast.Location = new System.Drawing.Point(60, 380);
            this.btnNewPodcast.Name = "btnNewPodcast";
            this.btnNewPodcast.Size = new System.Drawing.Size(128, 36);
            this.btnNewPodcast.TabIndex = 5;
            this.btnNewPodcast.Text = "Ny";
            this.btnNewPodcast.UseVisualStyleBackColor = false;
            this.btnNewPodcast.Click += new System.EventHandler(this.btnNewPodcast_Click_1Async);
            // 
            // btnUpdatePodCast
            // 
            this.btnUpdatePodCast.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdatePodCast.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnUpdatePodCast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePodCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePodCast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdatePodCast.Location = new System.Drawing.Point(229, 380);
            this.btnUpdatePodCast.Name = "btnUpdatePodCast";
            this.btnUpdatePodCast.Size = new System.Drawing.Size(128, 36);
            this.btnUpdatePodCast.TabIndex = 6;
            this.btnUpdatePodCast.Text = "Uppdatera";
            this.btnUpdatePodCast.UseVisualStyleBackColor = false;
            this.btnUpdatePodCast.Click += new System.EventHandler(this.btnUpdatePodCast_ClickAsync);
            // 
            // btnDeletePodCast
            // 
            this.btnDeletePodCast.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeletePodCast.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDeletePodCast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePodCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePodCast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletePodCast.Location = new System.Drawing.Point(403, 380);
            this.btnDeletePodCast.Name = "btnDeletePodCast";
            this.btnDeletePodCast.Size = new System.Drawing.Size(128, 36);
            this.btnDeletePodCast.TabIndex = 7;
            this.btnDeletePodCast.Text = "Ta bort";
            this.btnDeletePodCast.UseVisualStyleBackColor = false;
            this.btnDeletePodCast.Click += new System.EventHandler(this.btnRemovePodCast_Click);
            // 
            // txtBoxCategory
            // 
            this.txtBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCategory.Location = new System.Drawing.Point(780, 342);
            this.txtBoxCategory.Multiline = true;
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.txtBoxCategory.Size = new System.Drawing.Size(195, 23);
            this.txtBoxCategory.TabIndex = 8;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCategory.Location = new System.Drawing.Point(780, 385);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(128, 36);
            this.btnAddCategory.TabIndex = 9;
            this.btnAddCategory.Text = "Ny";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnChangeCategoryName
            // 
            this.btnChangeCategoryName.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangeCategoryName.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnChangeCategoryName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCategoryName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeCategoryName.Location = new System.Drawing.Point(949, 385);
            this.btnChangeCategoryName.Name = "btnChangeCategoryName";
            this.btnChangeCategoryName.Size = new System.Drawing.Size(128, 36);
            this.btnChangeCategoryName.TabIndex = 10;
            this.btnChangeCategoryName.Text = "Ändra Namn";
            this.btnChangeCategoryName.UseVisualStyleBackColor = false;
            this.btnChangeCategoryName.Click += new System.EventHandler(this.btnChangeCategoryName_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteCategory.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteCategory.Location = new System.Drawing.Point(1106, 385);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(128, 37);
            this.btnDeleteCategory.TabIndex = 11;
            this.btnDeleteCategory.Text = "Ta bort";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // txtBoxEpisodeDescription
            // 
            this.txtBoxEpisodeDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxEpisodeDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEpisodeDescription.Location = new System.Drawing.Point(780, 470);
            this.txtBoxEpisodeDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxEpisodeDescription.Multiline = true;
            this.txtBoxEpisodeDescription.Name = "txtBoxEpisodeDescription";
            this.txtBoxEpisodeDescription.ReadOnly = true;
            this.txtBoxEpisodeDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxEpisodeDescription.Size = new System.Drawing.Size(454, 156);
            this.txtBoxEpisodeDescription.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Uppdateras inom(minuter)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(779, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kategorier";
            // 
            // lblPodCastDescription
            // 
            this.lblPodCastDescription.AutoSize = true;
            this.lblPodCastDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodCastDescription.Location = new System.Drawing.Point(779, 450);
            this.lblPodCastDescription.Name = "lblPodCastDescription";
            this.lblPodCastDescription.Size = new System.Drawing.Size(128, 15);
            this.lblPodCastDescription.TabIndex = 21;
            this.lblPodCastDescription.Text = "Avsnittsbeskrivning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "URL:";
            // 
            // lstBoxEpisodes
            // 
            this.lstBoxEpisodes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstBoxEpisodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstBoxEpisodes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxEpisodes.FormattingEnabled = true;
            this.lstBoxEpisodes.ItemHeight = 19;
            this.lstBoxEpisodes.Location = new System.Drawing.Point(60, 470);
            this.lstBoxEpisodes.Name = "lstBoxEpisodes";
            this.lstBoxEpisodes.Size = new System.Drawing.Size(471, 156);
            this.lstBoxEpisodes.TabIndex = 23;
            this.lstBoxEpisodes.SelectedIndexChanged += new System.EventHandler(this.lstBoxEpisodes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "PodCast:";
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcast.Location = new System.Drawing.Point(136, 450);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(58, 15);
            this.lblPodcast.TabIndex = 25;
            this.lblPodcast.Text = "Podcast";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Podcasts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(779, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Kategorins namn";
            // 
            // btnShowAllPodCast
            // 
            this.btnShowAllPodCast.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAllPodCast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllPodCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllPodCast.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnShowAllPodCast.Location = new System.Drawing.Point(1008, 30);
            this.btnShowAllPodCast.Name = "btnShowAllPodCast";
            this.btnShowAllPodCast.Size = new System.Drawing.Size(128, 37);
            this.btnShowAllPodCast.TabIndex = 29;
            this.btnShowAllPodCast.Text = "Visa alla Pods";
            this.btnShowAllPodCast.UseVisualStyleBackColor = false;
            this.btnShowAllPodCast.Click += new System.EventHandler(this.btnShowAllPodCast_Click);
            // 
            // btnFilterEpisodes
            // 
            this.btnFilterEpisodes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFilterEpisodes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilterEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterEpisodes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFilterEpisodes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilterEpisodes.Location = new System.Drawing.Point(1008, 88);
            this.btnFilterEpisodes.Name = "btnFilterEpisodes";
            this.btnFilterEpisodes.Size = new System.Drawing.Size(128, 37);
            this.btnFilterEpisodes.TabIndex = 30;
            this.btnFilterEpisodes.Text = "Filtrera Pods";
            this.btnFilterEpisodes.UseVisualStyleBackColor = false;
            this.btnFilterEpisodes.Click += new System.EventHandler(this.btnFilterEpisodes_Click);
            // 
            // frmRss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1307, 690);
            this.Controls.Add(this.btnFilterEpisodes);
            this.Controls.Add(this.btnShowAllPodCast);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBoxEpisodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPodCastDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxEpisodeDescription);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnChangeCategoryName);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtBoxCategory);
            this.Controls.Add(this.btnDeletePodCast);
            this.Controls.Add(this.btnUpdatePodCast);
            this.Controls.Add(this.btnNewPodcast);
            this.Controls.Add(this.cmbBoxCategory);
            this.Controls.Add(this.cmbBoxInterval);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lstBoxCategory);
            this.Controls.Add(this.lstVPodcast);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmRss";
            this.Text = "RSSLäsare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstVPodcast;
        private System.Windows.Forms.ListBox lstBoxCategory;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox cmbBoxInterval;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.Button btnNewPodcast;
        private System.Windows.Forms.Button btnUpdatePodCast;
        private System.Windows.Forms.Button btnDeletePodCast;
        private System.Windows.Forms.TextBox txtBoxCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnChangeCategoryName;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.TextBox txtBoxEpisodeDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPodCastDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListBox lstBoxEpisodes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPodcast;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnShowAllPodCast;
        private System.Windows.Forms.Button btnFilterEpisodes;
    }
}

