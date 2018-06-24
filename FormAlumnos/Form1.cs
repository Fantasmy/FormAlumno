using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormAlumnos
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos = new List<Alumno>(); //Alumno clase creada
        string filePath = "alumnos.json";

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); // created variable log

        public Form1()
        {
            InitializeComponent(); //arranca programa
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                try
                { 
                string jsonContent = File.ReadAllText(filePath); // loads alumnos list
                alumnos = JsonConvert.DeserializeObject<List<Alumno>>(jsonContent); // deserialize into object of objects
                }

                catch (Exception ex)
                {

                    log.Error("load error: " + ex.StackTrace);

                }
            }

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var alumno = new Alumno()
            {
                Nombre = nameBox.Text,
                Apellido = surnameBox.Text,
                DNI = dniBox.Text,
                Id = idBox.Text,
            };

            try // in case something goes wrong with the serialization (object doesn't match or exists)

            {
                alumnos.Add(alumno);
                // Serialize Alumno to JSON String
                string Json = JsonConvert.SerializeObject(alumnos, Formatting.Indented);
                // Save into alumno.json file
                File.WriteAllText(filePath, Json);
                StringBuilder msg = new StringBuilder();
                msg.Append(filePath);
                msg.Append("Creado correctamente");
                //   infoText.Text = msg.ToString(); <- if you add a label or popup

                log.Debug("alumno creado correctamente " + JsonConvert.SerializeObject(alumno));
                
            }   

            catch (Exception ex)
            {

                log.Error("error creando alumno: " + ex.StackTrace);

               // Console.WriteLine("error: " + ex.StackTrace); // Follows trace error
            }
        }
    }
}
