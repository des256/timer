using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Timer
{
    public partial class ManagerForm : Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bestandToolStripMenuItem;
        private ToolStripMenuItem openenToolStripMenuItem;
        private ToolStripMenuItem nieuwEvenementToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem verwijderenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ListBox EvenementenListbox;
        private Button VerwijderenButton;
        private Button NieuwEvenementButton;
        private Button OpenenButton;
        private ToolStripMenuItem overTimer30ToolStripMenuItem;

        public NieuwEvenementForm nieuwEvenementForm;
        public EvenementForm evenementForm;
        public ToolForm toolForm;
        private Button AfsluitenButton;
        public List<Evenement> evenements = new List<Evenement>();
    
        public ManagerForm()
        {
            InitializeComponent();

            LoadEvenements();
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwEvenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.verwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overTimer30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EvenementenListbox = new System.Windows.Forms.ListBox();
            this.VerwijderenButton = new System.Windows.Forms.Button();
            this.NieuwEvenementButton = new System.Windows.Forms.Button();
            this.OpenenButton = new System.Windows.Forms.Button();
            this.AfsluitenButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openenToolStripMenuItem,
            this.nieuwEvenementToolStripMenuItem,
            this.toolStripSeparator1,
            this.verwijderenToolStripMenuItem,
            this.toolStripSeparator2,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // openenToolStripMenuItem
            // 
            this.openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            this.openenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openenToolStripMenuItem.Text = "Openen";
            this.openenToolStripMenuItem.Click += new System.EventHandler(this.openenToolStripMenuItem_Click);
            // 
            // nieuwEvenementToolStripMenuItem
            // 
            this.nieuwEvenementToolStripMenuItem.Name = "nieuwEvenementToolStripMenuItem";
            this.nieuwEvenementToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nieuwEvenementToolStripMenuItem.Text = "Nieuw Evenement...";
            this.nieuwEvenementToolStripMenuItem.Click += new System.EventHandler(this.nieuwEvenementToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // verwijderenToolStripMenuItem
            // 
            this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.verwijderenToolStripMenuItem.Text = "Verwijderen";
            this.verwijderenToolStripMenuItem.Click += new System.EventHandler(this.verwijderenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
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
            this.overTimer30ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.overTimer30ToolStripMenuItem.Text = "Over Timer 3.0";
            this.overTimer30ToolStripMenuItem.Click += new System.EventHandler(this.overTimer30ToolStripMenuItem_Click);
            // 
            // EvenementenListbox
            // 
            this.EvenementenListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvenementenListbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvenementenListbox.FormattingEnabled = true;
            this.EvenementenListbox.ItemHeight = 18;
            this.EvenementenListbox.Location = new System.Drawing.Point(8, 24);
            this.EvenementenListbox.Name = "EvenementenListbox";
            this.EvenementenListbox.ScrollAlwaysVisible = true;
            this.EvenementenListbox.Size = new System.Drawing.Size(568, 184);
            this.EvenementenListbox.TabIndex = 1;
            this.EvenementenListbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EvenementenListbox_KeyDown);
            this.EvenementenListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EvenementenListbox_MouseDoubleClick);
            // 
            // VerwijderenButton
            // 
            this.VerwijderenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VerwijderenButton.Enabled = false;
            this.VerwijderenButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerwijderenButton.Location = new System.Drawing.Point(288, 216);
            this.VerwijderenButton.Name = "VerwijderenButton";
            this.VerwijderenButton.Size = new System.Drawing.Size(104, 32);
            this.VerwijderenButton.TabIndex = 2;
            this.VerwijderenButton.Text = "Verwijderen";
            this.VerwijderenButton.UseVisualStyleBackColor = true;
            this.VerwijderenButton.Click += new System.EventHandler(this.VerwijderenButton_Click);
            // 
            // NieuwEvenementButton
            // 
            this.NieuwEvenementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NieuwEvenementButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NieuwEvenementButton.Location = new System.Drawing.Point(96, 216);
            this.NieuwEvenementButton.Name = "NieuwEvenementButton";
            this.NieuwEvenementButton.Size = new System.Drawing.Size(184, 32);
            this.NieuwEvenementButton.TabIndex = 3;
            this.NieuwEvenementButton.Text = "Nieuw Evenement...";
            this.NieuwEvenementButton.UseVisualStyleBackColor = true;
            this.NieuwEvenementButton.Click += new System.EventHandler(this.NieuwEvenementButton_Click);
            // 
            // OpenenButton
            // 
            this.OpenenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenenButton.Enabled = false;
            this.OpenenButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenenButton.Location = new System.Drawing.Point(8, 216);
            this.OpenenButton.Name = "OpenenButton";
            this.OpenenButton.Size = new System.Drawing.Size(80, 32);
            this.OpenenButton.TabIndex = 4;
            this.OpenenButton.Text = "Openen";
            this.OpenenButton.UseVisualStyleBackColor = true;
            this.OpenenButton.Click += new System.EventHandler(this.OpenenButton_Click);
            // 
            // AfsluitenButton
            // 
            this.AfsluitenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AfsluitenButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfsluitenButton.Location = new System.Drawing.Point(480, 216);
            this.AfsluitenButton.Name = "AfsluitenButton";
            this.AfsluitenButton.Size = new System.Drawing.Size(96, 32);
            this.AfsluitenButton.TabIndex = 5;
            this.AfsluitenButton.Text = "Afsluiten";
            this.AfsluitenButton.UseVisualStyleBackColor = true;
            this.AfsluitenButton.Click += new System.EventHandler(this.AfsluitenButton_Click);
            // 
            // ManagerForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 257);
            this.Controls.Add(this.AfsluitenButton);
            this.Controls.Add(this.OpenenButton);
            this.Controls.Add(this.NieuwEvenementButton);
            this.Controls.Add(this.VerwijderenButton);
            this.Controls.Add(this.EvenementenListbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.Text = "Timer 3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoadEvenements()
        {
            DirectoryInfo di = new DirectoryInfo(".");
            FileInfo[] fis = di.GetFiles();
            foreach (FileInfo fi in fis)
            {
                try
                {
                    using (XmlReader reader = XmlReader.Create(fi.Name))
                    {
                        while (reader.Read())
                        {
                            if (reader.IsStartElement())
                            {
                                if (reader.Name == "evenement")
                                {
                                    String name = reader.GetAttribute("naam");
                                    if (name != null)
                                        this.evenements.Add(new Evenement(fi.Name));
                                }
                            }
                        }
                        reader.Close();
                    }
                }
                catch (Exception e)
                {
                }
            }
            UpdateList();
        }

        private void NieuwEvenement()
        {
            if (this.nieuwEvenementForm == null)
            {
                this.nieuwEvenementForm = new NieuwEvenementForm(this);
                this.nieuwEvenementForm.ShowDialog();
            }
        }

        public void OpenEvenement(int index)
        {
            this.evenementForm = new EvenementForm(this, this.evenements.ElementAt(index));
            this.evenementForm.ShowDialog();
        }

        public void VerwijderEvenement(int index)
        {
            if (MessageBox.Show("Weet U zeker dat U \"" + this.evenements.ElementAt(index).ToString() + "\" wilt verwijderen?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Evenement evenement = this.evenements.ElementAt(index);
                evenement.Delete();
                this.evenements.RemoveAt(index);
                UpdateList();
            }
        }

        public void UpdateList()
        {
            EvenementenListbox.DataSource = null;
            EvenementenListbox.DataSource = evenements;
            if (evenements.Count() == 0)
            {
                this.OpenenButton.Enabled = false;
                this.VerwijderenButton.Enabled = false;
            }
            else
            {
                this.OpenenButton.Enabled = true;
                this.VerwijderenButton.Enabled = true;
            }
        }

        private void NieuwEvenementButton_Click(object sender, EventArgs e)
        {
            NieuwEvenement();
        }

        private void nieuwEvenementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NieuwEvenement();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManagerForm_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void EvenementenListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = EvenementenListbox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
                OpenEvenement(index);
        }

        private void OpenenButton_Click(object sender, EventArgs e)
        {
            int index = EvenementenListbox.SelectedIndex;
            if(index != System.Windows.Forms.ListBox.NoMatches)
                OpenEvenement(index);
        }

        private void VerwijderenButton_Click(object sender, EventArgs e)
        {
            int index = EvenementenListbox.SelectedIndex;
            if (index != System.Windows.Forms.ListBox.NoMatches)
                VerwijderEvenement(index);
        }

        private void EvenementenListbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int index = EvenementenListbox.SelectedIndex;
                if (index != System.Windows.Forms.ListBox.NoMatches)
                    VerwijderEvenement(index);
            }
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Weet U zeker dat U wilt afsluiten?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void openenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = EvenementenListbox.SelectedIndex;
            if (index != System.Windows.Forms.ListBox.NoMatches)
                OpenEvenement(index);
        }

        private void verwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = EvenementenListbox.SelectedIndex;
            if (index != System.Windows.Forms.ListBox.NoMatches)
                VerwijderEvenement(index);
        }

        private void overTimer30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }

        private void AfsluitenButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
