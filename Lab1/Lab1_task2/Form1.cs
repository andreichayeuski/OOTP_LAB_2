using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Student> collection;

        private void Generation_Click(object sender, EventArgs e)
        {
            try
            {
                Collection_Original.Items.Clear();
                int count;
                if (Count.Text == "" || (count = Convert.ToInt32(Count.Text)) == 0)
                {
                    MessageBox.Show("collection is empty");
                    this.collection = null;
                }
                else
                {
                    collection = new List<Student>(count);
                    Student st;
                    for (int i = 0; i < count; i++)
                    {
                        st = new Student();
                        collection.Add(st);
                    }
                    foreach (Student s in collection)
                    {
                        Collection_Original.Items.Add(s.name + " , " + s.kurs + " kurs, " + s.group + " group;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Sort_Ascending_Click(object sender, EventArgs e)
        {
            try
            {
                Collection_Sorted.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                    collection.Sort();
                    foreach (Student s in collection)
                    {
                        Collection_Sorted.Items.Add(s.name + " , " + s.kurs + " kurs, " + s.group + " group;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Sort_Descending_Click(object sender, EventArgs e)
        {
            try
            {
                Collection_Sorted.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                    Student st = new Student();
                    collection.Sort(0, collection.Count, st);
                    foreach (Student s in collection)
                    {
                        Collection_Sorted.Items.Add(s.name + " , " + s.kurs + " kurs, " + s.group + " group;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Query_First_Click(object sender, EventArgs e)
        {
            try
            {
                Collection_Result.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    if (form2.kurs > 0)
                    {
                        var query = from st in collection
                                    where st.kurs == form2.kurs
                                    select st;
                        foreach (Student s in query)
                        {
                            Collection_Result.Items.Add(s.name + " , " + s.kurs + " kurs, " + s.group + " group;");
                        }
                    }
                    else
                    {
                        MessageBox.Show("you don't write kurs number");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Query_Second_Click(object sender, EventArgs e)
        {
            try
            {
                Collection_Result.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    var query = from st in collection
                                where st.name == form3.name
                                select st;
                    short count = 0;
                    foreach (Student s in query)
                    {
                        count++;
                        Collection_Result.Items.Add(s.name + " , " + s.kurs + " kurs, " + s.group + " group;");
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("this name isn't found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Query_Third_Click(object sender, EventArgs e)
        {
            try
            {
                Collection_Result.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("collection is empty");
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    if (form2.kurs > 0)
                    {
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                        var query = from st in collection
                                    where st.kurs == form2.kurs && st.name == form3.name
                                    select st;
                        short count = 0;
                        foreach (Student s in query)
                        {
                            count++;
                            Collection_Result.Items.Add(s.name + " , " + s.kurs + " kurs, " + s.group + " group;");
                        }
                        if (count == 0)
                        {
                            MessageBox.Show("this name isn't found");
                        }
                    }
                    else
                    {
                        MessageBox.Show("you don't write kurs number");
                        throw new Exception("please, try again and write number of kurs");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
