using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasMileageTracker
{
    public partial class Form1 : Form
    {
        String server = "localhost";
        String database = "gasmileage";
        String uid = "root";
        String password = "";
        string connectionString;
        MySqlConnection connection;
        double milesDriven;
        double fuelConsumed;
        double newMPG;
        

        public Form1()
        {
            InitializeComponent();
            // connectToDatabase("initialize");
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

            //Initialize Combo Box Values
            //List<String> initialValues = new List<String>();
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select vehicle from mileageinfo";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString();
                vehicleComboBox.Items.Add(thisrow);
                //initialValues.Add(thisrow);
            }
            connection.Close();
        }

        private void addVehicle(object sender, EventArgs e)
        {
            if (!vehicleComboBox.Text.Equals("") && !vehicleComboBox.Items.Contains(vehicleComboBox.Text))
            {
                vehicleComboBox.Items.Add(vehicleComboBox.Text);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO mileageinfo (vehicle) VALUES ('" + vehicleComboBox.Text + "')";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                averageMPGLabel.Text = "0";
            }
            else
            {
                AddVehicleErrorForm form = new AddVehicleErrorForm();
                form.Show();
            }
        }

        private void addTrip(object sender, EventArgs e)
        {
            if (!milesDrivenTextbox.Text.Equals("") && !fuelTextbox.Text.Equals(""))
            {
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;

                command.CommandText = "SELECT milesDriven FROM mileageinfo WHERE vehicle='" + vehicleComboBox.SelectedItem + "'";
                connection.Open();
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        thisrow += Reader.GetValue(i);
                    double.TryParse(thisrow, out milesDriven);
                }
                Reader.Close();
                command.CommandText = "SELECT amountGas FROM mileageinfo WHERE vehicle='" + vehicleComboBox.SelectedItem + "'";
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        thisrow += Reader.GetValue(i);
                    double.TryParse(thisrow, out fuelConsumed);
                }
                connection.Close();

                milesDriven += double.Parse(milesDrivenTextbox.Text);
                fuelConsumed += double.Parse(fuelTextbox.Text);
                newMPG = milesDriven / fuelConsumed;
                newMPG = (int)newMPG + 0.5;
                averageMPGLabel.Text = newMPG.ToString();
                updateTableMPG();
            }
            else
            {
                // Show empty error box
            }
        }

        private void updateInfo(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
           
            command.CommandText = "SELECT mpg FROM mileageinfo WHERE vehicle='" + vehicleComboBox.SelectedItem + "'";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString();
                averageMPGLabel.Text = thisrow;
            }
            connection.Close();
            
        }

        private void updateTableMPG()
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE mileageinfo SET milesDriven='" + milesDriven.ToString() 
                                    + "', amountGas='" + fuelConsumed.ToString() 
                                    + "', mpg='" + newMPG.ToString() +"' WHERE vehicle = '" +
                                    vehicleComboBox.SelectedItem + "'";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void updateMPG()
        {

        }
    }
}
