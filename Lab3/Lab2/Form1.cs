using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Lab2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Crewman_Position.Items.AddRange(Crewman.list_of_positions);
            this.Airplane_Type.Items.AddRange(Airplane.types);
        }

        public List<Crewman> list_of_crewmans = new List<Crewman>();
        public List<Airplane> list_of_airplanes = new List<Airplane>();

        private void Crewman_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Crewman_FirstName.Text.Equals(String.Empty) || this.Crewman_SecondName.Text.Equals(String.Empty) || this.Crewman_Position.Text.Equals(String.Empty) || (this.Crewman_Sex_Male.Checked == false && this.Crewman_Sex_Female.Checked == false))
                {
                    MessageBox.Show("information isn't found");
                }
                else
                {
                    Crewman crewman = new Crewman(this.Crewman_FirstName.Text, this.Crewman_SecondName.Text, this.Crewman_Position.Text,
            this.Crewman_Sex_Male.Checked == true ? this.Crewman_Sex_Male.Text : this.Crewman_Sex_Female.Text,
            Convert.ToInt32(this.Crewman_Age.Value), Convert.ToInt32(this.Crewman_Experience.Value));

                    list_of_crewmans.Add(crewman);
                    this.Crewman_List.Items.Add(crewman);
                    this.Airplane_Crew.Items.Add(crewman);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Airplane_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Airplane_Crew.Text.Equals(String.Empty) || this.Airplane_ID.Text.Equals(String.Empty) || this.Airplane_Model.Text.Equals(String.Empty) || this.Airplane_Type.Text.Equals(String.Empty))
                {
                    MessageBox.Show("information isn't found");
                }
                else
                {
                    int year, capac;
                    if ((capac = Convert.ToInt32(this.Airplane_LoadCarryingCapacity.Text)) < 0 || capac > 10000000 || (year = Convert.ToInt32(this.Airplane_YearOfConstruction.Text)) > 2018 || year < 1960)
                    {
                        MessageBox.Show("error: check digital information");
                    }
                    else
                    {
                        List<Crewman> list = new List<Crewman>(this.Airplane_Crew.CheckedIndices.Count);
                        foreach (Crewman cr in this.Airplane_Crew.CheckedItems)
                        {
                            list.Add(cr);
                        }
                        Airplane airplane = new Airplane(this.Airplane_ID.Text, this.Airplane_Type.Text, (Company)this.Airplane_Model.SelectedItem, list,
                            (int)this.Airplane_Space.Value, Convert.ToInt32(this.Airplane_YearOfConstruction.Text),
                            Convert.ToInt32(this.Airplane_LoadCarryingCapacity.Text), this.Airplane_DateOfMaintenance.SelectionStart.Date.ToString());
                        list_of_airplanes.Add(airplane);
                        this.Airplane_List.Items.Add(airplane);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Входная строка имела неверный формат.")
                {
                    MessageBox.Show("error: check digital information");
                }
                else
                {
                    MessageBox.Show("error: " + ex.Message);
                }
            }
        }

        private void Company_Add_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                bool check = false;
                if (this.Company_Type_Cargo.Checked)
                {
                    list.Add(this.Company_Type_Cargo.Text);
                    check = true;
                }
                if (this.Company_Type_Passenger.Checked)
                {
                    list.Add(this.Company_Type_Passenger.Text);
                    check = true;
                }
                if (this.Company_Type_Military.Checked)
                {
                    list.Add(this.Company_Type_Military.Text);
                    check = true;
                }
                int year;
                if (this.Company_Country.Text.Equals(String.Empty) || this.Company_Name.Text.Equals(String.Empty) || (year = Convert.ToInt32(this.Company_Year.Text)) > 2018 || year < 1900 || !check)
                {
                    MessageBox.Show("error: check information");
                }
                else
                {
                    Company company = new Company(this.Company_Name.Text, this.Company_Country.Text, Convert.ToInt32(this.Company_Year.Text), list);
                    this.Company_List.Items.Add(company.ShowAllInformation());
                    this.Airplane_Model.Items.Add(company);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Crewman_Clear_Click(object sender, EventArgs e)
        {
            this.Crewman_FirstName.Clear();
            this.Crewman_SecondName.Clear();
            this.Crewman_Sex_Female.Checked = this.Crewman_Sex_Male.Checked = false;
            this.Crewman_Age.Value = this.Crewman_Age.Minimum;
            this.Crewman_Experience.Value = 0;
            this.Crewman_Position.Text = String.Empty;
        }

        private void Company_Clear_Click(object sender, EventArgs e)
        {
            this.Company_Country.Clear();
            this.Company_Name.Clear();
            this.Company_Year.Clear();
            this.Company_Type_Cargo.Checked = this.Company_Type_Military.Checked = this.Company_Type_Passenger.Checked = false;
        }

        private void Airplane_Clear_Click(object sender, EventArgs e)
        {
            this.Airplane_YearOfConstruction.Clear();
            foreach (int i in this.Airplane_Crew.CheckedIndices)
            {
                this.Airplane_Crew.SetItemChecked(i, false);
            }
            this.Airplane_Crew.ClearSelected();
            this.Airplane_DateOfMaintenance.SelectionStart = this.Airplane_DateOfMaintenance.TodayDate;
            this.Airplane_ID.Clear();
            this.Airplane_LoadCarryingCapacity.Clear();
            this.Airplane_Model.Text = String.Empty;
            this.Airplane_Space.Value = this.Airplane_Space.Minimum;
            this.Airplane_Type.Text = String.Empty;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Save_Dialog.FileName = "serialization.xml";
            this.Save_Dialog.InitialDirectory = "D:\\Документы\\Университет\\4 семестр\\ООТП\\Лабораторные\\Lab2";
            this.Save_Dialog.ShowDialog();

            if (list_of_airplanes.Count != 0)
            {
                using (FileStream fs = new FileStream(this.Save_Dialog.FileName, FileMode.OpenOrCreate))
                {
                    if (this.Save_Dialog.FileName.Contains(".json"))
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Airplane>));
                        jsonSerializer.WriteObject(fs, list_of_airplanes);
                    }
                    else if (this.Save_Dialog.FileName.Contains(".xml"))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Airplane>));
                        xmlSerializer.Serialize(fs, list_of_airplanes);
                    }
                    else
                    {
                        throw new Exception("uncorrect extension");
                    }
                }
            }
            else
            {
                MessageBox.Show("list is empty");
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            try
            {
                this.Open_Dialog.FileName = "serialization.xml";
                this.Open_Dialog.InitialDirectory = "D:\\Документы\\Университет\\4 семестр\\ООТП\\Лабораторные\\Lab2";
                this.Open_Dialog.ShowDialog();

                List<Airplane> lst;
                using (FileStream fs = new FileStream(this.Open_Dialog.FileName, FileMode.Open))
                {
                    if (this.Open_Dialog.FileName.Contains(".json"))
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Airplane>));
                        lst = (List<Airplane>)jsonSerializer.ReadObject(fs);
                    }
                    else if (this.Open_Dialog.FileName.Contains(".xml"))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Airplane>));
                        lst = (List<Airplane>)xmlSerializer.Deserialize(fs);
                    }
                    else
                    {
                        throw new Exception("uncorrect extension");
                    }
                }
                if (lst.Count != 0)
                {
                    foreach (Airplane a in lst)
                    {
                        list_of_airplanes.Add(a);
                        this.Airplane_List.Items.Add(a);
                    }
                }
                else
                {
                    MessageBox.Show("collection is empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(list_of_airplanes);

            form2.ShowDialog();
        }
    }
}