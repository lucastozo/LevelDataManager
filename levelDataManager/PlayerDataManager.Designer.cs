namespace levelDataManager
{
    partial class PlayerDataManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerDataManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btLevelDataManager = new System.Windows.Forms.ToolStripButton();
            this.dtPlayerData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDeleteRecord = new System.Windows.Forms.Button();
            this.btSaveFile = new System.Windows.Forms.Button();
            this.btLoadFile = new System.Windows.Forms.Button();
            this.btNewRecord = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlayerData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btLevelDataManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(225, 22);
            this.toolStripLabel1.Text = "PROGRAMA ATUAL: Player Data Manager";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btLevelDataManager
            // 
            this.btLevelDataManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btLevelDataManager.Image = ((System.Drawing.Image)(resources.GetObject("btLevelDataManager.Image")));
            this.btLevelDataManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLevelDataManager.Name = "btLevelDataManager";
            this.btLevelDataManager.Size = new System.Drawing.Size(144, 22);
            this.btLevelDataManager.Text = "Abrir Level Data Manager";
            this.btLevelDataManager.Click += new System.EventHandler(this.btLevelDataManager_Click);
            // 
            // dtPlayerData
            // 
            this.dtPlayerData.AllowUserToAddRows = false;
            this.dtPlayerData.AllowUserToDeleteRows = false;
            this.dtPlayerData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPlayerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPlayerData.Location = new System.Drawing.Point(12, 28);
            this.dtPlayerData.Name = "dtPlayerData";
            this.dtPlayerData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtPlayerData.Size = new System.Drawing.Size(1070, 641);
            this.dtPlayerData.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDeleteRecord);
            this.panel1.Controls.Add(this.btSaveFile);
            this.panel1.Controls.Add(this.btLoadFile);
            this.panel1.Controls.Add(this.btNewRecord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1088, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 656);
            this.panel1.TabIndex = 11;
            // 
            // btDeleteRecord
            // 
            this.btDeleteRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteRecord.BackColor = System.Drawing.Color.IndianRed;
            this.btDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteRecord.Location = new System.Drawing.Point(5, 301);
            this.btDeleteRecord.Name = "btDeleteRecord";
            this.btDeleteRecord.Size = new System.Drawing.Size(168, 60);
            this.btDeleteRecord.TabIndex = 2;
            this.btDeleteRecord.Text = "Deletar Record";
            this.btDeleteRecord.UseVisualStyleBackColor = false;
            this.btDeleteRecord.Click += new System.EventHandler(this.btDeleteRecord_Click);
            // 
            // btSaveFile
            // 
            this.btSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveFile.Location = new System.Drawing.Point(5, 584);
            this.btSaveFile.Name = "btSaveFile";
            this.btSaveFile.Size = new System.Drawing.Size(168, 60);
            this.btSaveFile.TabIndex = 3;
            this.btSaveFile.Text = "Salvar JSON";
            this.btSaveFile.UseVisualStyleBackColor = false;
            this.btSaveFile.Click += new System.EventHandler(this.btSaveFile_Click);
            // 
            // btLoadFile
            // 
            this.btLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoadFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadFile.Location = new System.Drawing.Point(5, 552);
            this.btLoadFile.Name = "btLoadFile";
            this.btLoadFile.Size = new System.Drawing.Size(168, 26);
            this.btLoadFile.TabIndex = 4;
            this.btLoadFile.Text = "Carregar JSON";
            this.btLoadFile.UseVisualStyleBackColor = false;
            this.btLoadFile.Click += new System.EventHandler(this.btLoadFile_Click);
            // 
            // btNewRecord
            // 
            this.btNewRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btNewRecord.BackColor = System.Drawing.Color.YellowGreen;
            this.btNewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewRecord.Location = new System.Drawing.Point(5, 235);
            this.btNewRecord.Name = "btNewRecord";
            this.btNewRecord.Size = new System.Drawing.Size(168, 60);
            this.btNewRecord.TabIndex = 1;
            this.btNewRecord.Text = "Novo Record";
            this.btNewRecord.UseVisualStyleBackColor = false;
            this.btNewRecord.Click += new System.EventHandler(this.btNewRecord_Click);
            // 
            // PlayerDataManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtPlayerData);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerDataManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Data Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlayerData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btLevelDataManager;
        private System.Windows.Forms.DataGridView dtPlayerData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDeleteRecord;
        private System.Windows.Forms.Button btSaveFile;
        private System.Windows.Forms.Button btLoadFile;
        private System.Windows.Forms.Button btNewRecord;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}