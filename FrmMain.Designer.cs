namespace WFA221114_1
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiTenyesztok = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParkereso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBejelentes = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFajta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTulajdonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVaros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSuly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.Thistle;
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTenyesztok,
            this.tsmiParkereso,
            this.tsmiBejelentes});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(984, 79);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiTenyesztok
            // 
            this.tsmiTenyesztok.Image = global::WFA221114_1.Properties.Resources.wizard;
            this.tsmiTenyesztok.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTenyesztok.Name = "tsmiTenyesztok";
            this.tsmiTenyesztok.Size = new System.Drawing.Size(97, 75);
            this.tsmiTenyesztok.Text = "Tenyésztők";
            this.tsmiTenyesztok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiParkereso
            // 
            this.tsmiParkereso.Image = global::WFA221114_1.Properties.Resources.love;
            this.tsmiParkereso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiParkereso.Name = "tsmiParkereso";
            this.tsmiParkereso.Size = new System.Drawing.Size(90, 75);
            this.tsmiParkereso.Text = "Párkereső";
            this.tsmiParkereso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiBejelentes
            // 
            this.tsmiBejelentes.Image = global::WFA221114_1.Properties.Resources.unicorn;
            this.tsmiBejelentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiBejelentes.Name = "tsmiBejelentes";
            this.tsmiBejelentes.Size = new System.Drawing.Size(92, 75);
            this.tsmiBejelentes.Text = "Bejelentés";
            this.tsmiBejelentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColFajta,
            this.ColTulajdonos,
            this.ColVaros,
            this.ColSuly,
            this.ColNem});
            this.dgvMain.Location = new System.Drawing.Point(51, 53);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 25;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(858, 398);
            this.dgvMain.TabIndex = 1;
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.Controls.Add(this.dgvMain, 1, 1);
            this.tlpMain.Location = new System.Drawing.Point(12, 93);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.Size = new System.Drawing.Size(960, 506);
            this.tlpMain.TabIndex = 2;
            // 
            // ColId
            // 
            this.ColId.FillWeight = 1F;
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            // 
            // ColFajta
            // 
            this.ColFajta.FillWeight = 2F;
            this.ColFajta.HeaderText = "Fajta";
            this.ColFajta.Name = "ColFajta";
            // 
            // ColTulajdonos
            // 
            this.ColTulajdonos.FillWeight = 2F;
            this.ColTulajdonos.HeaderText = "Tulajdonos";
            this.ColTulajdonos.Name = "ColTulajdonos";
            // 
            // ColVaros
            // 
            this.ColVaros.FillWeight = 2F;
            this.ColVaros.HeaderText = "Város";
            this.ColVaros.Name = "ColVaros";
            // 
            // ColSuly
            // 
            this.ColSuly.FillWeight = 2F;
            this.ColSuly.HeaderText = "Súly";
            this.ColSuly.Name = "ColSuly";
            // 
            // ColNem
            // 
            this.ColNem.FillWeight = 2F;
            this.ColNem.HeaderText = "Nem";
            this.ColNem.Name = "ColNem";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Unikornis Ménes Manager 2021";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem tsmiTenyesztok;
        private ToolStripMenuItem tsmiParkereso;
        private ToolStripMenuItem tsmiBejelentes;
        private DataGridView dgvMain;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColFajta;
        private DataGridViewTextBoxColumn ColTulajdonos;
        private DataGridViewTextBoxColumn ColVaros;
        private DataGridViewTextBoxColumn ColSuly;
        private DataGridViewTextBoxColumn ColNem;
        private TableLayoutPanel tlpMain;
    }
}