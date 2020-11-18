namespace Timer
{
    partial class EvenementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afdrukkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.terugToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overTimer30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voertuig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TussenstandGroupBox = new System.Windows.Forms.GroupBox();
            this.StandingsListbox = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.AfdrukkenButton = new System.Windows.Forms.Button();
            this.TerugButton = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TussenstandGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSprintToolStripMenuItem,
            this.afdrukkenToolStripMenuItem,
            this.toolStripSeparator1,
            this.terugToolStripMenuItem1});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // startSprintToolStripMenuItem
            // 
            this.startSprintToolStripMenuItem.Name = "startSprintToolStripMenuItem";
            this.startSprintToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startSprintToolStripMenuItem.Text = "Start";
            this.startSprintToolStripMenuItem.Click += new System.EventHandler(this.startSprintToolStripMenuItem_Click);
            // 
            // afdrukkenToolStripMenuItem
            // 
            this.afdrukkenToolStripMenuItem.Name = "afdrukkenToolStripMenuItem";
            this.afdrukkenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afdrukkenToolStripMenuItem.Text = "Afdrukken";
            this.afdrukkenToolStripMenuItem.Click += new System.EventHandler(this.afdrukkenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // terugToolStripMenuItem1
            // 
            this.terugToolStripMenuItem1.Name = "terugToolStripMenuItem1";
            this.terugToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.terugToolStripMenuItem1.Text = "Terug";
            this.terugToolStripMenuItem1.Click += new System.EventHandler(this.terugToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overTimer30ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // overTimer30ToolStripMenuItem
            // 
            this.overTimer30ToolStripMenuItem.Name = "overTimer30ToolStripMenuItem";
            this.overTimer30ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.overTimer30ToolStripMenuItem.Text = "Over Timer 3.0";
            this.overTimer30ToolStripMenuItem.Click += new System.EventHandler(this.overTimer30ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nummer,
            this.Naam,
            this.Voertuig,
            this.Number});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(522, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_NewRowNeeded);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Nummer
            // 
            this.Nummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nummer.DataPropertyName = "NumberString";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Nummer.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nummer.HeaderText = "Nr.";
            this.Nummer.Name = "Nummer";
            this.Nummer.ReadOnly = true;
            this.Nummer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nummer.Width = 31;
            // 
            // Naam
            // 
            this.Naam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naam.DataPropertyName = "Name";
            this.Naam.HeaderText = "Naam";
            this.Naam.Name = "Naam";
            this.Naam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Voertuig
            // 
            this.Voertuig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Voertuig.DataPropertyName = "Vehicle";
            this.Voertuig.HeaderText = "Voertuig";
            this.Voertuig.Name = "Voertuig";
            this.Voertuig.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.Visible = false;
            // 
            // TussenstandGroupBox
            // 
            this.TussenstandGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TussenstandGroupBox.Controls.Add(this.StandingsListbox);
            this.TussenstandGroupBox.Location = new System.Drawing.Point(13, 224);
            this.TussenstandGroupBox.Name = "TussenstandGroupBox";
            this.TussenstandGroupBox.Size = new System.Drawing.Size(522, 200);
            this.TussenstandGroupBox.TabIndex = 2;
            this.TussenstandGroupBox.TabStop = false;
            this.TussenstandGroupBox.Text = "Tussenstand";
            // 
            // StandingsListbox
            // 
            this.StandingsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StandingsListbox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandingsListbox.FormattingEnabled = true;
            this.StandingsListbox.ItemHeight = 16;
            this.StandingsListbox.Location = new System.Drawing.Point(3, 16);
            this.StandingsListbox.Name = "StandingsListbox";
            this.StandingsListbox.ScrollAlwaysVisible = true;
            this.StandingsListbox.Size = new System.Drawing.Size(516, 181);
            this.StandingsListbox.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(16, 184);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(72, 32);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Timer";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AfdrukkenButton
            // 
            this.AfdrukkenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AfdrukkenButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfdrukkenButton.Location = new System.Drawing.Point(96, 184);
            this.AfdrukkenButton.Name = "AfdrukkenButton";
            this.AfdrukkenButton.Size = new System.Drawing.Size(96, 32);
            this.AfdrukkenButton.TabIndex = 4;
            this.AfdrukkenButton.Text = "Afdrukken";
            this.AfdrukkenButton.UseVisualStyleBackColor = true;
            this.AfdrukkenButton.Click += new System.EventHandler(this.AfdrukkenButton_Click);
            // 
            // TerugButton
            // 
            this.TerugButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TerugButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerugButton.Location = new System.Drawing.Point(464, 184);
            this.TerugButton.Name = "TerugButton";
            this.TerugButton.Size = new System.Drawing.Size(72, 32);
            this.TerugButton.TabIndex = 5;
            this.TerugButton.Text = "Terug";
            this.TerugButton.UseVisualStyleBackColor = true;
            this.TerugButton.Click += new System.EventHandler(this.TerugButton_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // EvenementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 436);
            this.Controls.Add(this.TerugButton);
            this.Controls.Add(this.AfdrukkenButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TussenstandGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EvenementForm";
            this.Text = "[Evenement Naam + Datum]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TussenstandGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afdrukkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overTimer30ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox TussenstandGroupBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button AfdrukkenButton;
        private System.Windows.Forms.Button TerugButton;
        private System.Windows.Forms.ToolStripMenuItem terugToolStripMenuItem1;
        private System.Windows.Forms.ListBox StandingsListbox;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voertuig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
    }
}