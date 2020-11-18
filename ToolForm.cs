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
    public partial class ToolForm : Form
    {
        private ManagerForm manager;
        private Evenement evenement;
        private EvenementForm evenementform;
        private Stopwatch[] stopwatch;
        private int oldest_stopwatch,blink_time;
        private System.Windows.Forms.PictureBox[] pictureboxes;
        private System.Drawing.Color[] stopwatchcolors;
        private System.Drawing.Brush[] stopwatchbrushes;

        public ToolForm(ManagerForm manager,Evenement evenement,EvenementForm evenementform)
        {
            InitializeComponent();
            this.manager = manager;
            this.evenement = evenement;
            this.evenementform = evenementform;
            this.stopwatch = new[] { new Stopwatch(this.label12), new Stopwatch(this.label4), new Stopwatch(this.label2), new Stopwatch(this.label6), new Stopwatch(this.label8), new Stopwatch(this.label10) };
            this.pictureboxes = new[] { this.pictureBox1, this.pictureBox3, this.pictureBox2, this.pictureBox4, this.pictureBox5, this.pictureBox6 };
            this.stopwatchcolors = new[] { Color.FromArgb(192,0,0), Color.FromArgb(0,192,0), Color.FromArgb(0,0,192), Color.FromArgb(0,192,192), Color.FromArgb(192,0,192), Color.FromArgb(192,192,0) };
            this.stopwatchbrushes = new[] { new SolidBrush(stopwatchcolors[0]), new SolidBrush(stopwatchcolors[1]), new SolidBrush(stopwatchcolors[2]), new SolidBrush(stopwatchcolors[3]), new SolidBrush(stopwatchcolors[4]), new SolidBrush(stopwatchcolors[5]) };
            this.oldest_stopwatch = -1;
            this.dataGridView1.DataSource = this.evenement.Entries;
            this.dataGridView1.Invalidate();
            if (this.dataGridView1.RowCount != 0)
                this.dataGridView1.CurrentCell = this.dataGridView1[2, 0];
            UpdateStandings();
            for(int i = 0; i < 6; i++)
                pictureboxes[i].BackColor = stopwatchcolors[i];
        }

        private void ToolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void AppendTime(int n)
        {
            this.evenement.AppendTime(n, stopwatch[n].GetTime());
            this.dataGridView1.CurrentCell = this.dataGridView1[1, evenement.Last - 1];
            this.dataGridView1.Invalidate();
        }

        private void UpdateStandings()
        {
            Standings standings = new Standings(this.evenement);
            StandingsListbox.DataSource = standings.List;
            StandingsListbox.Invalidate();
            evenementform.UpdateStandings(standings);
        }

        private void ToolForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F1:
                    if (stopwatch[0].IsRunning())
                    {
                        stopwatch[0].Stop();
                        AppendTime(0);
                    }
                    else
                        stopwatch[0].Start();
                    break;

                case Keys.F2:
                    stopwatch[0].StopReset();
                    break;

                case Keys.F3:
                    if (stopwatch[1].IsRunning())
                    {
                        stopwatch[1].Stop();
                        AppendTime(1);
                    }
                    else
                        stopwatch[1].Start();
                    break;

                case Keys.F4:
                    stopwatch[1].StopReset();
                    break;

                case Keys.F5:
                    if (stopwatch[2].IsRunning())
                    {
                        stopwatch[2].Stop();
                        AppendTime(2);
                    }
                    else
                        stopwatch[2].Start();
                    break;

                case Keys.F6:
                    stopwatch[2].StopReset();
                    break;

                case Keys.F7:
                    if (stopwatch[3].IsRunning())
                    {
                        stopwatch[3].Stop();
                        AppendTime(3);
                    }
                    else
                        stopwatch[3].Start();
                    break;

                case Keys.F8:
                    stopwatch[3].StopReset();
                    break;

                case Keys.F9:
                    if (stopwatch[4].IsRunning())
                    {
                        stopwatch[4].Stop();
                        AppendTime(4);
                    }
                    else
                        stopwatch[4].Start();
                    break;

                case Keys.F10:
                    stopwatch[4].StopReset();
                    break;

                case Keys.F11:
                    if (stopwatch[5].IsRunning())
                    {
                        stopwatch[5].Stop();
                        AppendTime(5);
                    }
                    else
                        stopwatch[5].Start();
                    break;

                case Keys.F12:
                    stopwatch[5].StopReset();
                    break;

                default:
                    return;
            }
            e.SuppressKeyPress = true;
        }

        private void TerugButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // step through the stopwatches
            for (int i = 0; i < 6; i++)
                stopwatch[i].Step();

            // mark the running stopwatch with the oldest time
            int oldest = -1;
            int new_oldest_stopwatch = -1;
            for(int i = 0; i < 6; i++)
                if(stopwatch[i].IsRunning())
                    if((oldest == -1) || (oldest < stopwatch[i].GetTime()))
                    {
                        oldest = stopwatch[i].GetTime();
                        new_oldest_stopwatch = i;
                    }

            if (new_oldest_stopwatch == -1)
            {
                if (oldest_stopwatch != -1)
                    pictureboxes[oldest_stopwatch].BackColor = stopwatchcolors[oldest_stopwatch];  // stop blinking
            }
            else
            {
                if (oldest_stopwatch != new_oldest_stopwatch)
                    if(oldest_stopwatch != -1)
                        pictureboxes[oldest_stopwatch].BackColor = stopwatchcolors[oldest_stopwatch];  // stop blinking the old one
                blink_time--;
                if ((blink_time > 0) && (blink_time <= 20))
                    pictureboxes[new_oldest_stopwatch].BackColor = System.Drawing.SystemColors.Control;
                else
                {
                    pictureboxes[new_oldest_stopwatch].BackColor = stopwatchcolors[new_oldest_stopwatch];
                    if (blink_time <= 0)
                        blink_time = 40;
                }
            }
            oldest_stopwatch = new_oldest_stopwatch;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex == -1)
                switch (e.ColumnIndex)
                {
                    case 0:
                        e.PaintBackground(e.ClipBounds, true);
                        break;

                    case 1:
                        e.PaintBackground(e.ClipBounds, true);
                        e.Graphics.DrawString("Nr.", dataGridView1.ColumnHeadersDefaultCellStyle.Font, System.Drawing.SystemBrushes.ControlText, new PointF(e.CellBounds.Left, e.CellBounds.Top));
                        break;

                    case 2:
                        e.PaintBackground(e.ClipBounds, true);
                        e.Graphics.DrawString("Tijd", dataGridView1.ColumnHeadersDefaultCellStyle.Font, System.Drawing.SystemBrushes.ControlText, new PointF(e.CellBounds.Left, e.CellBounds.Top));
                        break;

                    case 3:
                        e.PaintBackground(e.ClipBounds, true);
                        e.Graphics.DrawString("Naam", dataGridView1.ColumnHeadersDefaultCellStyle.Font, System.Drawing.SystemBrushes.ControlText, new PointF(e.CellBounds.Left, e.CellBounds.Top));
                        break;

                    case 4:
                        e.PaintBackground(e.ClipBounds, true);
                        e.Graphics.DrawString("Voertuig", dataGridView1.ColumnHeadersDefaultCellStyle.Font, System.Drawing.SystemBrushes.ControlText, new PointF(e.CellBounds.Left, e.CellBounds.Top));
                        break;

                    case 5:
                        e.PaintBackground(e.ClipBounds, true);
                        break;
                }
            else if (e.RowIndex >= this.evenement.Entries.Count())
                e.Graphics.FillRectangle(System.Drawing.SystemBrushes.Control, e.CellBounds);
            else
                switch (e.ColumnIndex)
                {
                    case 0: // SW
                        if(this.evenement.Entries.ElementAt(e.RowIndex).Value == 0)
                            e.Graphics.FillRectangle(System.Drawing.SystemBrushes.Control, e.CellBounds);
                        else
                            e.Graphics.FillRectangle(stopwatchbrushes[this.evenement.Entries.ElementAt(e.RowIndex).Stopwatch], e.CellBounds);
                        break;

                    case 1: // Nr.
                        e.PaintBackground(e.ClipBounds, true);
                        if(this.evenement.Entries.ElementAt(e.RowIndex).Number > -1)
                            e.Graphics.DrawString(this.evenement.Entries.ElementAt(e.RowIndex).Number.ToString(), dataGridView1.DefaultCellStyle.Font, System.Drawing.SystemBrushes.ControlText, new PointF(e.CellBounds.Left, e.CellBounds.Top));
                        break;

                    case 2: // Tijd
                        e.PaintBackground(e.ClipBounds, true);
                        if (this.evenement.Entries.ElementAt(e.RowIndex).Value != 0)
                        {
                            if (this.evenement.Entries.ElementAt(e.RowIndex).Value < 10000)
                                e.Graphics.DrawString(this.evenement.Entries.ElementAt(e.RowIndex).Msec.ToString(), dataGridView1.DefaultCellStyle.Font, new SolidBrush(Color.Red), new PointF(e.CellBounds.Left, e.CellBounds.Top));
                            else
                                e.Graphics.DrawString(this.evenement.Entries.ElementAt(e.RowIndex).Msec.ToString(), dataGridView1.DefaultCellStyle.Font, System.Drawing.SystemBrushes.ControlText, new PointF(e.CellBounds.Left, e.CellBounds.Top));
                        }
                        break;

                    case 3: // Naam
                        e.PaintBackground(e.ClipBounds, true);
                        String name = this.evenement.Entries.ElementAt(e.RowIndex).Name;
                        if(name != null)
                            e.Graphics.DrawString(name.ToString(), dataGridView1.RowsDefaultCellStyle.Font, System.Drawing.SystemBrushes.ControlText, new PointF(e.CellBounds.Left, e.CellBounds.Top));
                        break;

                    case 4: // Voertuig
                        e.PaintBackground(e.ClipBounds, true);
                        String vehicle = this.evenement.Entries.ElementAt(e.RowIndex).Vehicle;
                        if(vehicle != null)
                            e.Graphics.DrawString(vehicle.ToString(), dataGridView1.RowsDefaultCellStyle.Font, System.Drawing.SystemBrushes.ControlText, new PointF(e.CellBounds.Left, e.CellBounds.Top));
                        break;
                }
            e.Handled = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if ((e.ColumnIndex == 1) && (e.RowIndex > -1))
            {
                int output;
                if (!int.TryParse(e.FormattedValue.ToString(), out output))
                    output = -1;
                this.evenement.Entries.ElementAt(e.RowIndex).Number = output;
                this.evenement.Save();
                dataGridView1.InvalidateRow(e.RowIndex);
                UpdateStandings();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                        dataGridView1[k, i].Style.BackColor = System.Drawing.Color.White;
                int number = this.evenement.Entries.ElementAt(e.RowIndex).Number;
                if(number != -1)
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        if (this.evenement.Entries.ElementAt(i).Number == number)
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                                dataGridView1[k, i].Style.BackColor = System.Drawing.Color.Yellow;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.CurrentCell != null)
                {
                    int i = dataGridView1.CurrentCell.RowIndex;
                    evenement.Entries.ElementAt(i).Number = -1;
                    dataGridView1.Invalidate();
                    UpdateStandings();
                }
            }

            if (e.KeyCode == Keys.Tab)
                e.SuppressKeyPress = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // force to number column
            if (dataGridView1.CurrentCell == null)
            {
                if (dataGridView1.Rows.Count > 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
            }
            else
                if (dataGridView1.CurrentCell.ColumnIndex != 1)
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1];

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
