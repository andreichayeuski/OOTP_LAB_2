using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2(List<Airplane> list)
        {
            InitializeComponent();
            this.Type_Listbox.Items.AddRange(Airplane.types);
            this.list = list;
        }

        public string type = String.Empty;
        public string company = String.Empty;
        public int space = -1;
        public int capacity = -1;
        private List<Airplane> list;

        public Form2()
        {
            InitializeComponent();
            this.Type_Listbox.Items.AddRange(Airplane.types);
        }

        private void GoToDefault()
        {
            this.type = this.company = String.Empty;
            this.capacity = this.space = -1;
            this.search = true;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            this.Type_Listbox.Text = String.Empty;
            this.Company_textBox.Text = String.Empty;
            this.Space_textBox.Text = String.Empty;
            this.Capacity_textBox.Text = String.Empty;
            this.SearchResult_List.Items.Clear();
        }

        private void Type_Listbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void Company_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void Capacity_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private bool search = true;

        private void Search(IEnumerable<Airplane> list)
        {
            try
            {
                SearchResult_List.Items.Clear();
                bool wasCheck = false;
                List<Airplane> query = new List<Airplane>(list.Count<Airplane>());
                if (!this.type.Equals(String.Empty))
                {
                    wasCheck = true;
                    var result = from airplane in list
                                 where airplane.type == this.type
                                 select airplane;
                    if (result.Count<Airplane>() == 0)
                    {
                        this.search = false;
                    }
                    else
                    {
                        foreach (Airplane a in result)
                        {
                            query.Add(a);
                        }
                    }
                }
                if (!this.company.Equals(String.Empty) && this.search)
                {
                    var result = from airplane in wasCheck ? query : list
                                 where airplane.model.name == this.company
                                 select airplane;
                    wasCheck = true;
                    if (result.Count<Airplane>() == 0)
                    {
                        this.search = false;
                    }
                    else if (this.search)
                    {
                        query = new List<Airplane>(result.Count<Airplane>());
                        foreach (Airplane a in result)
                        {
                            if (!query.Contains(a))
                            {
                                query.Add(a);
                            }
                        }
                    }
                }
                if (this.space != -1 && this.search)
                {
                    var result = from airplane in wasCheck ? query : list
                                 where airplane.count_of_spaces == this.space
                                 select airplane;
                    wasCheck = true;
                    if (result.Count<Airplane>() == 0)
                    {
                        this.search = false;
                    }
                    else if (this.search)
                    {
                        query = new List<Airplane>(result.Count<Airplane>());
                        foreach (Airplane a in result)
                        {
                            if (!query.Contains(a))
                            {
                                query.Add(a);
                            }
                        }

                    }
                }
                if (this.capacity != -1 && this.search)
                {
                    var result = from airplane in wasCheck ? query : list
                                 where airplane.capacity == this.capacity
                                 select airplane;
                    wasCheck = true;
                    if (result.Count<Airplane>() == 0)
                    {
                        this.search = false;
                    }
                    else if (this.search)
                    {
                        query = new List<Airplane>(result.Count<Airplane>());
                        foreach (Airplane a in result)
                        {
                            if (!query.Contains(a))
                            {
                                query.Add(a);
                            }
                        }
                    }
                }
                if (query.Count != 0 && this.search)
                {
                    foreach (Airplane a in query)
                    {
                        this.SearchResult_List.Items.Add(a);
                    }
                }
                else
                {
                    MessageBox.Show("no matches found");
                }
                this.GoToDefault();
                query.Clear();
            }
            catch
            {
                MessageBox.Show("Test");
            }
            }

        private void Search_button_Click(object sender, EventArgs e)
        {
            this.SearchResult_List.Items.Clear();
            try
            {
                bool flag = false;
                int capac;
                if (!this.Capacity_textBox.Text.Equals(String.Empty) && (capac = Convert.ToInt32(this.Capacity_textBox.Text)) > -1 && capac < 10000000)
                {
                    this.capacity = capac;
                    flag = true;
                }
                if (!this.Type_Listbox.Text.Equals(String.Empty))
                {
                    flag = true;
                    this.type = this.Type_Listbox.Text;
                }
                int space;
                if (!this.Space_textBox.Text.Equals(String.Empty) && (space = Convert.ToInt32(this.Space_textBox.Text)) > -1 && space < 201)
                {
                    flag = true;
                    this.space = space;
                }
                if (!this.Company_textBox.Text.Equals(String.Empty))
                {
                    flag = true;
                    this.company = this.Company_textBox.Text;
                }
                if (!flag)
                {
                    MessageBox.Show("no criteries for search");
                    return;
                }

                this.Search(this.list);
                this.GoToDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }
    }
}
