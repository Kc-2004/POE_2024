using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControldeCitas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }       

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(nameTextBox.Text))
            {
                e.Cancel = true;
                validationErrorProvider.SetError(nameTextBox, "El nombre no debe estar vacio");
                nameErrorLabel.Text = "El nombre no debe estar vacio";
                nameTextBox.Focus();
            }
            else
            {
                e.Cancel = false;
                nameErrorLabel.Text = "";
                validationErrorProvider.SetError(nameTextBox, "");
            }
        }

      

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ageTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(ageTextBox.Text))
            {
                e.Cancel = true;
                validationErrorProvider.SetError(ageTextBox, "La edad no debe estar vacia");
                ageErrorLabel.Text = "La edad no debe estar vacia";
                ageTextBox.Focus();
            }
            else if( !int.TryParse(ageTextBox.Text, out int age))
            {
            e.Cancel= true;
            validationErrorProvider.SetError(ageTextBox, "La edad debe ser un numero valido");
             ageErrorLabel.Text = "La edad debe ser un numero valido";
             ageTextBox.Focus();
            }
            else
            {
                e.Cancel = false;
                validationErrorProvider.SetError(ageTextBox, "");
                ageErrorLabel.Text = string.Empty;
            }
        }

        private void appointmentDatePicker_Validating(object sender, CancelEventArgs e)
        {
            if (appointmentDatePicker.Value.DayOfWeek== DayOfWeek.Sunday ||
                appointmentDatePicker.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                e.Cancel = true;
                validationErrorProvider.SetError(appointmentDatePicker, " No agendamos citas en fin de semana");
                appointmentErrrorLabel.Text = "No agendar cita en fin de semana";
            }
            else
            {
                e.Cancel = false;
                validationErrorProvider.SetError(appointmentDatePicker, "");
                appointmentErrrorLabel.Text = "";
            }
            
        }
    }
}
