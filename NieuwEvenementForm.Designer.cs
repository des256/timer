namespace Timer
{
    partial class NieuwEvenementForm
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
            this.DatumPicker = new System.Windows.Forms.DateTimePicker();
            this.NaamTextBox = new System.Windows.Forms.TextBox();
            this.SlalomRadioButton = new System.Windows.Forms.RadioButton();
            this.SprintRadioButton = new System.Windows.Forms.RadioButton();
            this.DoorgaanButton = new System.Windows.Forms.Button();
            this.AnnulerenButton = new System.Windows.Forms.Button();
            this.DatumLabel = new System.Windows.Forms.Label();
            this.NaamLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.HoofdlijstLabel = new System.Windows.Forms.Label();
            this.HoofdlijstComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DatumPicker
            // 
            this.DatumPicker.Location = new System.Drawing.Point(72, 12);
            this.DatumPicker.Name = "DatumPicker";
            this.DatumPicker.Size = new System.Drawing.Size(200, 20);
            this.DatumPicker.TabIndex = 0;
            // 
            // NaamTextBox
            // 
            this.NaamTextBox.Location = new System.Drawing.Point(72, 40);
            this.NaamTextBox.Name = "NaamTextBox";
            this.NaamTextBox.Size = new System.Drawing.Size(200, 20);
            this.NaamTextBox.TabIndex = 1;
            // 
            // SlalomRadioButton
            // 
            this.SlalomRadioButton.AutoSize = true;
            this.SlalomRadioButton.Checked = true;
            this.SlalomRadioButton.Location = new System.Drawing.Point(72, 88);
            this.SlalomRadioButton.Name = "SlalomRadioButton";
            this.SlalomRadioButton.Size = new System.Drawing.Size(56, 17);
            this.SlalomRadioButton.TabIndex = 2;
            this.SlalomRadioButton.TabStop = true;
            this.SlalomRadioButton.Text = "Slalom";
            this.SlalomRadioButton.UseVisualStyleBackColor = true;
            // 
            // SprintRadioButton
            // 
            this.SprintRadioButton.AutoSize = true;
            this.SprintRadioButton.Location = new System.Drawing.Point(128, 88);
            this.SprintRadioButton.Name = "SprintRadioButton";
            this.SprintRadioButton.Size = new System.Drawing.Size(52, 17);
            this.SprintRadioButton.TabIndex = 3;
            this.SprintRadioButton.Text = "Sprint";
            this.SprintRadioButton.UseVisualStyleBackColor = true;
            // 
            // DoorgaanButton
            // 
            this.DoorgaanButton.Location = new System.Drawing.Point(288, 112);
            this.DoorgaanButton.Name = "DoorgaanButton";
            this.DoorgaanButton.Size = new System.Drawing.Size(75, 23);
            this.DoorgaanButton.TabIndex = 4;
            this.DoorgaanButton.Text = "Doorgaan";
            this.DoorgaanButton.UseVisualStyleBackColor = true;
            this.DoorgaanButton.Click += new System.EventHandler(this.DoorgaanButton_Click);
            // 
            // AnnulerenButton
            // 
            this.AnnulerenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnnulerenButton.Location = new System.Drawing.Point(368, 112);
            this.AnnulerenButton.Name = "AnnulerenButton";
            this.AnnulerenButton.Size = new System.Drawing.Size(75, 23);
            this.AnnulerenButton.TabIndex = 5;
            this.AnnulerenButton.Text = "Annuleren";
            this.AnnulerenButton.UseVisualStyleBackColor = true;
            this.AnnulerenButton.Click += new System.EventHandler(this.AnnulerenButton_Click);
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.Location = new System.Drawing.Point(31, 12);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(38, 13);
            this.DatumLabel.TabIndex = 6;
            this.DatumLabel.Text = "Datum";
            // 
            // NaamLabel
            // 
            this.NaamLabel.AutoSize = true;
            this.NaamLabel.Location = new System.Drawing.Point(34, 39);
            this.NaamLabel.Name = "NaamLabel";
            this.NaamLabel.Size = new System.Drawing.Size(35, 13);
            this.NaamLabel.TabIndex = 7;
            this.NaamLabel.Text = "Naam";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(32, 88);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 8;
            this.TypeLabel.Text = "Type";
            // 
            // HoofdlijstLabel
            // 
            this.HoofdlijstLabel.AutoSize = true;
            this.HoofdlijstLabel.Location = new System.Drawing.Point(16, 64);
            this.HoofdlijstLabel.Name = "HoofdlijstLabel";
            this.HoofdlijstLabel.Size = new System.Drawing.Size(50, 13);
            this.HoofdlijstLabel.TabIndex = 9;
            this.HoofdlijstLabel.Text = "Hoofdlijst";
            this.HoofdlijstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HoofdlijstComboBox
            // 
            this.HoofdlijstComboBox.FormattingEnabled = true;
            this.HoofdlijstComboBox.Location = new System.Drawing.Point(72, 64);
            this.HoofdlijstComboBox.Name = "HoofdlijstComboBox";
            this.HoofdlijstComboBox.Size = new System.Drawing.Size(368, 21);
            this.HoofdlijstComboBox.TabIndex = 10;
            // 
            // NieuwEvenementForm
            // 
            this.AcceptButton = this.DoorgaanButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AnnulerenButton;
            this.ClientSize = new System.Drawing.Size(450, 144);
            this.Controls.Add(this.HoofdlijstComboBox);
            this.Controls.Add(this.HoofdlijstLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NaamLabel);
            this.Controls.Add(this.DatumLabel);
            this.Controls.Add(this.AnnulerenButton);
            this.Controls.Add(this.DoorgaanButton);
            this.Controls.Add(this.SprintRadioButton);
            this.Controls.Add(this.SlalomRadioButton);
            this.Controls.Add(this.NaamTextBox);
            this.Controls.Add(this.DatumPicker);
            this.Name = "NieuwEvenementForm";
            this.Text = "Nieuw Evenement...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatumPicker;
        private System.Windows.Forms.TextBox NaamTextBox;
        private System.Windows.Forms.RadioButton SlalomRadioButton;
        private System.Windows.Forms.RadioButton SprintRadioButton;
        private System.Windows.Forms.Button DoorgaanButton;
        private System.Windows.Forms.Button AnnulerenButton;
        private System.Windows.Forms.Label DatumLabel;
        private System.Windows.Forms.Label NaamLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label HoofdlijstLabel;
        private System.Windows.Forms.ComboBox HoofdlijstComboBox;
    }
}