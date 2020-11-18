using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class EvenementForm : Form
    {
        private ManagerForm manager;
        private Evenement evenement;
        private int printing_rank;
        private Standings standings;

        public EvenementForm(ManagerForm manager,Evenement evenement)
        {
            this.manager = manager;
            this.evenement = evenement;
            if (this.evenement.Drivers.Count() == 0)
                this.evenement.Drivers.Add(new Driver(1, "", ""));

            InitializeComponent();

            this.Text = this.evenement.ToString();
            this.dataGridView1.DataSource = this.evenement.Drivers;
            UpdateStandings();
        }

        private void Start()
        {
            manager.toolForm = new ToolForm(manager,this.evenement,this);
            manager.toolForm.Show();
        }

        private void Afdrukken()
        {
            printDialog.Document = printDocument;
            this.printing_rank = 1;
            if(printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int count = 0;
            String text = null;
            float left = e.MarginBounds.Left;
            Font arial = new Font("Arial", 9);
            Font arial_bold = new Font("Arial", 9, FontStyle.Bold);
            Font arial_italic = new Font("Arial", 9, FontStyle.Italic);
            Font arial_big = new Font("Arial", 15);
            SolidBrush brush = new SolidBrush(Color.Black);
            int lpp = (int)e.MarginBounds.Height / (int)arial.GetHeight(e.Graphics);
            float y = e.MarginBounds.Top;
            float x = e.MarginBounds.Left;

            if (printing_rank == 1)
            {
                // print title
                e.Graphics.DrawString(this.evenement.Name + " (" + this.evenement.Date + ")", arial_big, brush, x, y);
                y += arial_big.GetHeight(e.Graphics);
                y += 10;
            }

            // print headers
            e.Graphics.DrawString("Pos.", arial_italic, brush, x, y);
            x += 30;
            e.Graphics.DrawString("Nr.", arial_italic, brush, x, y);
            x += 30;
            e.Graphics.DrawString("Naam", arial_italic, brush, x, y);
            x += 150;
            e.Graphics.DrawString("Voertuig", arial_italic, brush, x, y);
            x += 150;
            e.Graphics.DrawString("Toptijd", arial_italic, brush, x, y);
            x += 60;
            e.Graphics.DrawString("Alle tijden", arial_italic, brush, x, y);
            y += arial.GetHeight(e.Graphics);
            y += 5;

            // print data
            while((y < e.MarginBounds.Bottom) && (printing_rank <= this.standings.Entries.Count))
            {
                x = e.MarginBounds.Left;
                EntrySet entryset = this.standings.Entries.ElementAt(printing_rank - 1);
                e.Graphics.DrawString(String.Format("{0,3:d}:",printing_rank),arial,brush,x,y);
                x += 30;
                e.Graphics.DrawString(String.Format("{0,3}.",entryset.Driver.Number),arial,brush,x,y);
                x += 30;
                e.Graphics.DrawString(entryset.Driver.Name,arial,brush,x,y);
                x += 150;
                e.Graphics.DrawString(entryset.Driver.Vehicle,arial,brush,x,y);
                x += 150;
                e.Graphics.DrawString(entryset.Fastest.Msec,arial_bold,brush,x,y);
                x += 60;
                foreach(Entry entry in entryset.Entries)
                {
                    if(entry.Msec == entryset.Fastest.Msec)
                        e.Graphics.DrawString(entry.Msec,arial_bold,brush,x,y);
                    else
                        e.Graphics.DrawString(entry.Msec, arial, brush, x, y);
                    x += 50;
                    if(x > e.MarginBounds.Right)
                        break;
                }
                printing_rank++;
                y += arial.GetHeight(e.Graphics);
            }

            // If there are more lines, print another page.
            if (printing_rank < this.standings.Entries.Count)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
            brush.Dispose();
        }

        public void UpdateStandings(Standings newstandings = null)
        {
            if (newstandings == null)
            {
                standings = new Standings(this.evenement);
                StandingsListbox.DataSource = standings.List;
            }
            else
            {
                standings = newstandings;
                StandingsListbox.DataSource = standings.List;
            }
            StandingsListbox.Invalidate();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void TerugButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void terugToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startSprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void afdrukkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afdrukken();
        }

        private void AfdrukkenButton_Click(object sender, EventArgs e)
        {
            Afdrukken();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.evenement.Save();
            UpdateStandings();
        }

        private void dataGridView1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            this.evenement.Drivers.Add(new Driver(this.evenement.Drivers.Count(), "", ""));
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if(dataGridView1.CurrentRow.Index == this.evenement.Drivers.Count() - 1)
                        this.evenement.Drivers.Add(new Driver(this.evenement.Drivers.Count(), "", ""));
                    break;
            }
        }

        private void overTimer30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }
    }
}
