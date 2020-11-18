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
    public partial class NieuwEvenementForm : Form
    {
        private ManagerForm manager;

        public NieuwEvenementForm(ManagerForm manager)
        {
            this.manager = manager;
            InitializeComponent();
            HoofdlijstComboBox.Items.Add("lege lijst");
            foreach (Evenement evenement in manager.evenements)
                HoofdlijstComboBox.Items.Add("van " + evenement.ToString());
            HoofdlijstComboBox.SelectedIndex = 0;
        }

        private void DoorgaanButton_Click(object sender, EventArgs e)
        {
            // validate form
            if (NaamTextBox.Text.Length == 0)
            {
                MessageBox.Show("Voer een geldige naam in voor dit evenement.", "Probleem", MessageBoxButtons.OK);
                return;
            }

            // create filename for evenement
            String filename = DatumPicker.Value.Year.ToString("D4") + DatumPicker.Value.Month.ToString("D2") + DatumPicker.Value.Day.ToString("D2") + "_" + NaamTextBox.Text;
            String stripped_filename = "";
            foreach(char c in filename)
                if(((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')) || ((c >= '0') && (c <= '9')))
                    stripped_filename += c;
            stripped_filename += ".xml";

            // create evenement
            Evenement evenement = new Evenement(stripped_filename, DatumPicker.Value, NaamTextBox.Text, (SlalomRadioButton.Checked?Evenement.Type.SLALOM:Evenement.Type.SPRINT));
            if (HoofdlijstComboBox.SelectedIndex > 0)
                evenement.CloneDrivers(manager.evenements[HoofdlijstComboBox.SelectedIndex - 1].Drivers);
            manager.evenements.Add(evenement);
            manager.UpdateList();

            // close this window
            this.Hide();
            this.Close();
            manager.nieuwEvenementForm = null;

            // open the evenement form
            manager.OpenEvenement(manager.evenements.Count() - 1);
        }

        private void AnnulerenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
