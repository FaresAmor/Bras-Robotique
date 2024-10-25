using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace bras_tpe
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort1; // Déclaration de la variable serialPort1

        private int variableEntiere = 0;
        private int variableEntiere2 = 0;
        private int variableEntiere3 = 10;
        private int variableEntiere4 = 0;

        public Form1()
        {
            InitializeComponent();
            serialPort1 = new SerialPort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuration des barres de défilement
            ConfigureScrollBar(hScrollBar1,0,184,5,1);
            ConfigureScrollBar(hScrollBar2, 0, 184, 5, 1);
            ConfigureScrollBar(vScrollBar1, 0, 184, 5, 1);
            ConfigureScrollBar(vScrollBar2, 0, 184, 5, 1);

            // Remplir la liste déroulante avec les ports COM disponibles sur le système
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            // Mise à jour des étiquettes avec les valeurs par défaut
            UpdateLabels();
        }

        // Fonction pour configurer les barres de défilement
        private void ConfigureScrollBar(ScrollBar scrollBar,int min1 ,int max1,int L,int S)
        {
            scrollBar.Minimum = min1;
            scrollBar.Maximum = max1;
            scrollBar.LargeChange = L;
            scrollBar.SmallChange = S;
        }

        // Fonction pour mettre à jour les étiquettes avec les valeurs actuelles
        private void UpdateLabels()
        {
            label1.Text = "Servo du Base " + variableEntiere.ToString();
            label2.Text = "Servo du Pince " + variableEntiere2.ToString();
            label3.Text = "Servo A " + variableEntiere3.ToString();
            label4.Text = "Servo B " + variableEntiere4.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            variableEntiere2 = hScrollBar2.Value;
            label2.Text = "Servo du pince " + variableEntiere2.ToString();
            SendDataToArduino();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            variableEntiere = hScrollBar1.Value;
            label1.Text = "Servo du Base " + variableEntiere.ToString();
            SendDataToArduino();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            variableEntiere3 = vScrollBar1.Value;
            label3.Text = "Servo A " + variableEntiere3.ToString();
            SendDataToArduino();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            variableEntiere4 = vScrollBar2.Value;
            label4.Text = "Servo B " + variableEntiere4.ToString();
            SendDataToArduino();
        }

        private void SendDataToArduino()
        {
            try
            {
                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                serialPort1.BaudRate = 9600;
                serialPort1.Open();

                if (serialPort1.IsOpen)
                {
                    string dataToSend = $"{variableEntiere},{variableEntiere2},{variableEntiere3},{variableEntiere4}";
                    serialPort1.WriteLine(dataToSend);
                }
                else
                {
                    MessageBox.Show("Failed to open serial port.", "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close(); // Fermer le port série une fois l'envoi terminé ou en cas d'erreur
                }
            }
        }

    
    }
}
