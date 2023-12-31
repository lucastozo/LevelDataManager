﻿namespace levelDataManager
{
    partial class LevelDataManager
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelDataManager));
            this.dtLevelData = new System.Windows.Forms.DataGridView();
            this.btNewLevel = new System.Windows.Forms.Button();
            this.btDeleteLevel = new System.Windows.Forms.Button();
            this.btSaveFile = new System.Windows.Forms.Button();
            this.btLoadFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSubirPos = new System.Windows.Forms.Button();
            this.btDescerPos = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btPlayerDataManager = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevelData)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtLevelData
            // 
            this.dtLevelData.AllowUserToAddRows = false;
            this.dtLevelData.AllowUserToDeleteRows = false;
            this.dtLevelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevelData.Location = new System.Drawing.Point(12, 28);
            this.dtLevelData.Name = "dtLevelData";
            this.dtLevelData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtLevelData.Size = new System.Drawing.Size(1070, 641);
            this.dtLevelData.TabIndex = 0;
            // 
            // btNewLevel
            // 
            this.btNewLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btNewLevel.BackColor = System.Drawing.Color.YellowGreen;
            this.btNewLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewLevel.Location = new System.Drawing.Point(5, 261);
            this.btNewLevel.Name = "btNewLevel";
            this.btNewLevel.Size = new System.Drawing.Size(168, 60);
            this.btNewLevel.TabIndex = 1;
            this.btNewLevel.Text = "Novo Level";
            this.btNewLevel.UseVisualStyleBackColor = false;
            this.btNewLevel.Click += new System.EventHandler(this.btNewLevel_Click);
            // 
            // btDeleteLevel
            // 
            this.btDeleteLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteLevel.BackColor = System.Drawing.Color.IndianRed;
            this.btDeleteLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteLevel.Location = new System.Drawing.Point(5, 327);
            this.btDeleteLevel.Name = "btDeleteLevel";
            this.btDeleteLevel.Size = new System.Drawing.Size(168, 60);
            this.btDeleteLevel.TabIndex = 2;
            this.btDeleteLevel.Text = "Deletar Level";
            this.btDeleteLevel.UseVisualStyleBackColor = false;
            this.btDeleteLevel.Click += new System.EventHandler(this.btDeleteLevel_Click);
            // 
            // btSaveFile
            // 
            this.btSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveFile.Location = new System.Drawing.Point(5, 609);
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
            this.btLoadFile.Location = new System.Drawing.Point(5, 577);
            this.btLoadFile.Name = "btLoadFile";
            this.btLoadFile.Size = new System.Drawing.Size(168, 26);
            this.btLoadFile.TabIndex = 4;
            this.btLoadFile.Text = "Carregar JSON";
            this.btLoadFile.UseVisualStyleBackColor = false;
            this.btLoadFile.Click += new System.EventHandler(this.btLoadFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDeleteLevel);
            this.panel1.Controls.Add(this.btSaveFile);
            this.panel1.Controls.Add(this.btLoadFile);
            this.panel1.Controls.Add(this.btSubirPos);
            this.panel1.Controls.Add(this.btDescerPos);
            this.panel1.Controls.Add(this.btNewLevel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1088, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 681);
            this.panel1.TabIndex = 7;
            // 
            // btSubirPos
            // 
            this.btSubirPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btSubirPos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSubirPos.BackgroundImage = global::levelDataManager.Properties.Resources.up_arrow;
            this.btSubirPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSubirPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubirPos.Location = new System.Drawing.Point(5, 12);
            this.btSubirPos.Name = "btSubirPos";
            this.btSubirPos.Size = new System.Drawing.Size(168, 60);
            this.btSubirPos.TabIndex = 5;
            this.btSubirPos.UseVisualStyleBackColor = false;
            this.btSubirPos.Click += new System.EventHandler(this.btSubirPos_Click);
            // 
            // btDescerPos
            // 
            this.btDescerPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btDescerPos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDescerPos.BackgroundImage = global::levelDataManager.Properties.Resources.down_arrow;
            this.btDescerPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDescerPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDescerPos.Location = new System.Drawing.Point(5, 78);
            this.btDescerPos.Name = "btDescerPos";
            this.btDescerPos.Size = new System.Drawing.Size(168, 60);
            this.btDescerPos.TabIndex = 6;
            this.btDescerPos.UseVisualStyleBackColor = false;
            this.btDescerPos.Click += new System.EventHandler(this.btDescerPos_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btPlayerDataManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1088, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(220, 22);
            this.toolStripLabel1.Text = "PROGRAMA ATUAL: Level Data Manager";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btPlayerDataManager
            // 
            this.btPlayerDataManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btPlayerDataManager.Image = ((System.Drawing.Image)(resources.GetObject("btPlayerDataManager.Image")));
            this.btPlayerDataManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPlayerDataManager.Name = "btPlayerDataManager";
            this.btPlayerDataManager.Size = new System.Drawing.Size(149, 22);
            this.btPlayerDataManager.Text = "Abrir Player Data Manager";
            this.btPlayerDataManager.Click += new System.EventHandler(this.btPlayerDataManager_Click);
            // 
            // LevelDataManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtLevelData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LevelDataManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Data Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dtLevelData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtLevelData;
        private System.Windows.Forms.Button btNewLevel;
        private System.Windows.Forms.Button btDeleteLevel;
        private System.Windows.Forms.Button btSaveFile;
        private System.Windows.Forms.Button btLoadFile;
        private System.Windows.Forms.Button btSubirPos;
        private System.Windows.Forms.Button btDescerPos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btPlayerDataManager;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

