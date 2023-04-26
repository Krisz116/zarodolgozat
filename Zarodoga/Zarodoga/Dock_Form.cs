﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarodoga
{
   
    public partial class Dock_Form : Form
    {
        Database database = new Database();
        static public MySqlCommand cmd = Database.cmd;
        static public MySqlConnection connection = Database.connection;
        public Dock_Form()
        {
            InitializeComponent();
        }
        public void dockUpdate()
        {
            listBoxDiakok.Items.Clear();
            foreach (dock item in database.getAllDock())
            {
                listBoxDiakok.Items.Add(item);
            }
        }
        public void egydock()
        {
            listBoxDiakok.Items.Clear();
            foreach (dock item in database.getAllDock())
            {
                if (item.Diak_ID1.Contains(textBox_ig_szam.Text))
                    listBoxDiakok.Items.Add(item);
            }
        }

        private void Dock_Form_Load(object sender, EventArgs e)
        {
            dockUpdate();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            database.Dock_Inser();
            dockUpdate();


        }

        private void button_torol_Click(object sender, EventArgs e)
        {
            database.Dock_Delete();
            dockUpdate();

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            database.Dock_Update();
            dockUpdate();

        }

        private void button_keres_Click(object sender, EventArgs e)
        {
            egydock();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDiakok.SelectedItem is dock kivalasztott_dock)
            {
                textBox_ig_szam.Text = kivalasztott_dock.Diak_ID1;
                textBox_nev.Text = kivalasztott_dock.Nev1;
                comboBox_dock_nev.Text = kivalasztott_dock.Dock_Nev1;
                
            }

        }

        private void button_keresestorlese_Click(object sender, EventArgs e)
        {
            textBox_ig_szam.Text = "";
            textBox_nev.Text = "";
            comboBox_dock_nev.Text = "";
            dockUpdate();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Program.Dock_Form.Close();
        }

        private void button_frissit_Click(object sender, EventArgs e)
        {
            dockUpdate();
        }

        private void comboBox_dock_nev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
