using Lab8.Entity;
using System;
using System.Linq;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using Microsoft.VisualBasic;

namespace Lab8
{
    public partial class MainWindow : Window
    {
        BookContext db = new BookContext();

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                Outputfunc();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Inputfunc()
        {
            try
            {
                Book book = new Book { Title = this.Book_Title.Text, Author = this.Book_Author.Text };
                this.db.MyBooks.Add(book);
                this.db.SaveChanges();
                Outputfunc();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Outputfunc()
        {
            try
            {
                var output = from b in this.db.MyBooks
                             select b;
                this.Output.DataContext = output.ToList();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Updfunc()
        {
            try
            {
                Book _id = (Book)this.Output.SelectedValue;
                int www = _id.Id;

                var output = (from c in this.db.MyBooks
                              where c.Id == www
                              select c).Single<Book>();
                string UserAnswer = Interaction.InputBox("Введите название поля и измененный вариант поля", "", "");
                string[] type = UserAnswer.Split(' ');
                switch (type[0])
                {
                    case "Author":
                    case "Автор":
                        {
                            output.Author = type[1];
                            break;
                        }
                    case "Title":
                    case "Название":
                        {
                            output.Title = type[1];
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Неверный ввод названия столбца ");
                            break;
                        }
                };
                this.db.SaveChanges();
                Outputfunc();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Dltfunc()
        {
            try
            {
                string UserAnswer = Interaction.InputBox("Введите Id поля, которое хотите удалить или ALL, если хотите удалить все.", "", "");
                switch (Int32.TryParse(UserAnswer, out int dltid))
                {
                    case true:
                        var w = (from d in this.db.MyBooks
                                 where d.Id == dltid
                                 select d).ToList<Book>();
                        this.db.MyBooks.Remove(w.First());
                        this.db.SaveChanges();
                        break;

                    case false:
                        switch (UserAnswer)
                        {
                            case "All":

                                var w_ = (from d in this.db.MyBooks
                                          select d).ToList<Book>();
                                foreach (Book books in w_)
                                {
                                    this.db.MyBooks.Remove(books);
                                    this.db.SaveChanges();
                                }
                                break;
                            default: break;
                        }
                        break;
                }
                Outputfunc();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Insert_btn_Click(object sender, RoutedEventArgs e)
        {
            Inputfunc();
        }

        private void Output_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Updfunc();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            Dltfunc();
        }

        private void Sort_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
