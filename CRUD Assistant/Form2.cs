using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Assistant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    FormAcademico.Visible = true;
                    FormAlumnos.Visible = false;
                    FormGrupos.Visible = false;
                    break;
                case 1:
                    FormAcademico.Visible = false;
                    FormAlumnos.Visible = false;
                    FormGrupos.Visible = true;
                    break;
                case 2:
                    FormAcademico.Visible = false;
                    FormAlumnos.Visible = true;
                    FormGrupos.Visible = false;
                    break;
                default:
                    FormAcademico.Visible = false;
                    FormAlumnos.Visible = false;
                    FormGrupos.Visible = false;
                    break;
            }
        }
    }
}
