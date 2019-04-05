using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proyecto0005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DriveInfo[] u = DriveInfo.GetDrives();
            foreach (DriveInfo unidad in u)
            {
                try
                {
                    listBox1.Items.Add(unidad);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de lectura" + ex.Message);
                    //MessageBox.Show("Error de lectura"+);
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string unidades = listBox1.SelectedIndex.ToString();
            listBox2.Items.Add(unidades);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            String unidades = listBox1.SelectedItem.ToString();
            DriveInfo d = new DriveInfo(unidades);
            listBox2.Items.Add("Disco:" + d.Name + "\n");

            if (d.IsReady)
            {
                listBox2.Items.Add("Espacio ocupado (GB): " + (d.TotalSize - d.AvailableFreeSpace)
                    / 1024 / 1024 / 1024 + "\n");
                listBox2.Items.Add("Espacio ocupado (GB): " + (d.TotalFreeSpace - d.AvailableFreeSpace)
                      / 1024 / 1024 / 1024 + "\n");
                listBox2.Items.Add("Espacio total (GB): " + (d.TotalSize - d.AvailableFreeSpace)
                      / 1024 / 1024 / 1024 + "\n");
            }
            listBox2.Items.Add("tipo de disco utilizado" + d.DriveType.ToString() + "\n");
            treeView1.Nodes.Clear();
            if(d.IsReady)
            {
                DirectoryInfo dir = DirectoryInfo(unidades);
                treeView1.Nodes.
            }
        }

      
        {

        }
    }
}