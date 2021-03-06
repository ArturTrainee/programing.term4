﻿using Lab4.Entities;
using System;
using System.Windows.Forms;

namespace Lab4.Forms
{
    public partial class LocationInfoForm : Form
    {
        private Location location;

        internal Location NewLocation
        {
            get
            {
                return location;
            }
        }

        public LocationInfoForm()
        {
            InitializeComponent();
            location = new Location();
        }

        public LocationInfoForm(Location location)
        {
            InitializeComponent();
            this.location = location;
            nameTextBox.Text = location.Name;
            addessTextBox.Text = location.Address;
            rentalPriceTextBox.Text = location.RentalPrice.ToString();
            freeSeatsAmountTextBox.Text = location.FreeSeatsAmount.ToString();
            orchestraPriceTextBox.Text = Entities.Location.OrchestraPrice.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                location.Name = nameTextBox.Text;
                location.Address = addessTextBox.Text;
                location.RentalPrice = int.Parse(rentalPriceTextBox.Text);
                location.FreeSeatsAmount = int.Parse(freeSeatsAmountTextBox.Text);
                Entities.Location.OrchestraPrice = int.Parse(orchestraPriceTextBox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EditLocationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show("Close the window?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(Messages.CHANGES_CANCELED);
                }
                else e.Cancel = true;
            }
        }
    }
}
