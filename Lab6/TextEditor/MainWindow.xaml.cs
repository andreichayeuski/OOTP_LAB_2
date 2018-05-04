using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls.Primitives;
using System.Windows.Resources;
//using Forms = System.Windows.Forms;

namespace TextEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int count_of_window;
        string rofFileName = "rof.txt";

        public MainWindow()
        {
            InitializeComponent();
            if (count_of_window != 0)
            {
                this.Title += "(" + count_of_window++ + ")";
            }
            else
            {
                count_of_window++;
            }

            Uri iconUri = new Uri(@"D:\Документы\Университет\4 семестр\ООТП\Лабораторные\Lab6\TextEditor\Resourse\icon.ico", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);

            this.MainText.AutoWordSelection = true;
            this.FontTypes.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);

            this.MainText.AllowDrop = true;
            this.MainText.Drop += MainText_Drop;
            this.MainText.PreviewDragOver += MainText_PreviewDragOver;

            this.infTxt.Text = "Language: " + MainText.Language.IetfLanguageTag.ToString() + "; ";

            RefreshRecentFilesListInMenu();
        }

        private void MainText_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }

        private void MainText_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null)
                {
                    foreach (string dropfilePath in files)
                    {
                        var textRange = new TextRange(this.MainText.Document.ContentStart, this.MainText.Document.ContentEnd);
                        try
                        {
                            this.Title = dropfilePath.ToString();
                            TabItem tabItem = new TabItem
                            {
                                Header = dropfilePath
                            };
                            RichTextBox richText = new RichTextBox();
                            richText.AppendText(System.IO.File.ReadAllText(dropfilePath));
                            tabItem.Content = richText;
                            tabItem.AllowDrop = true;
                            Tab_Control.SelectedIndex = count++;
                            Tab_Control.AllowDrop = true;
                            if (this.count == 0)
                            {
                                Tab_Control.Items[count] = tabItem;
                            }
                            else
                            {
                                Tab_Control.Items.Add(tabItem);
                            }

                            RefreshRecentFilesList(dropfilePath);
                            RefreshRecentFilesListInMenu();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error you have a mistake in your code: " + ex.Message);
                        }
                    }
                }
            }
        }

        #region Menu

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void NewWind_Click(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                new MainWindow().Show();
            }
            catch (Exception)
            {
                MessageBox.Show("error 404");
            }
        }

        int count = 0;
        private void OpenFile()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    FileName = "text.txt",
                    InitialDirectory = @"D:\"
                };
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Text files (*.txt)|*.txt|Rich text files (*.rtf)|*.rtf|XAML files (*.xaml)|*.xaml|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == true)
                {
                    TabItem tabItem = new TabItem();
                    tabItem.Header = openFileDialog.FileName;
                    RichTextBox richTextBox = new RichTextBox();
                    tabItem.Content = richTextBox;
                    tabItem.AllowDrop = true;
                    TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        switch (System.IO.Path.GetExtension(openFileDialog.FileName).ToLower())
                        {
                            case ".rtf":
                                textRange.Load(fs, DataFormats.Rtf);
                                break;
                            case ".txt":
                                textRange.Load(fs, DataFormats.Text);
                                break;
                            default:
                                textRange.Load(fs, DataFormats.Xaml);
                                break;
                        }
                    }
                    RefreshRecentFilesList(openFileDialog.FileName);
                    RefreshRecentFilesListInMenu();
                    if (count < 10)
                    {
                        if (this.count == 0)
                        {
                            Tab_Control.Items[count] = tabItem;
                        }
                        else
                        {
                            Tab_Control.Items.Add(tabItem);
                        }
                        Tab_Control.SelectedIndex = count++;
                    }
                    else
                    {
                        MessageBox.Show("Превышено максимально кол-во вкладок");
                    }
                    this.Title = "Text Editor (" + openFileDialog.FileName + ") ";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " Open error");
            }
        }
        private void OpenFile_Click(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFile();
        }
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void LoadFile(string fileName)
        {
            try
            {
                TextRange doc = new TextRange(this.MainText.Document.ContentStart, this.MainText.Document.ContentEnd);
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    if (System.IO.Path.GetExtension(fileName) == ".txt")
                    {
                        doc.Load(fs, DataFormats.Text);
                    }
                    else
                    {
                        doc.Load(fs, DataFormats.Rtf);
                    }
                }

                Title = fileName;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void RefreshRecentFilesList(string fileName)       // обновить список последних файлов в файле rof
        {
            List<string> files = GetRecentFilesList();
            try
            {
                if (!files.Contains(fileName))      // если это новый файл
                {
                    using (StreamWriter sw = new StreamWriter(rofFileName, true, Encoding.UTF8))
                    {
                        sw.WriteLine(fileName);
                    }
                }
                else
                {
                    //files.Remove(fileName);
                    files.Add(fileName);
                    using (StreamWriter sw = new StreamWriter(rofFileName, false, Encoding.UTF8))
                    {
                        foreach (string i in files)
                        {
                            sw.WriteLine(i);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private List<string> GetRecentFilesList()       // считать из файла rof имена последних файлов
        {
            List<string> files = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(rofFileName, Encoding.UTF8))
                {
                    string fileName;
                    for (int i = 0; (fileName = sr.ReadLine()) != null; i++)
                    {
                        if (!files.Contains(fileName))
                        {
                            files.Add(fileName);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            return files;
        }

        private void RefreshRecentFilesListInMenu()
        {
            if (!System.IO.File.Exists(rofFileName))
            {
                FileStream fs = System.IO.File.Create(rofFileName);
                fs.Close();
            }

            List<string> files = GetRecentFilesList();
            files.Reverse();

            recentFiles.Items.Clear();
            for (int i = 0; i < files.Count; i++)
            {
                MenuItem newItem = new MenuItem();
                newItem.Header = files[i];
                newItem.Click += LoadRecentFile;
                if (!recentFiles.Items.Contains(newItem))
                {
                    recentFiles.Items.Add(newItem);
                }
            }
        }

        private void LoadRecentFile(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            string res = item.Header.ToString();
            LoadFile(res);
            RefreshRecentFilesList(res);
            RefreshRecentFilesListInMenu();
        }

        private void SaveFile()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = "My text.txt",
                    InitialDirectory = @"D:\"
                };
                saveFileDialog.Filter = "My text files (*.txt)|*.txt|My rich text files(*.rtf)|*.rtf|My XAML files (*.xaml)|*.xaml| All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == true)
                {
                    TextRange textRange = new TextRange(this.MainText.Document.ContentStart, this.MainText.Document.ContentEnd);
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        switch (System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower())
                        {
                            case ".rtf":
                                textRange.Save(fs, DataFormats.Rtf);
                                break;
                            case ".txt":
                                textRange.Save(fs, DataFormats.Text);
                                break;
                            default:
                                textRange.Save(fs, DataFormats.Xaml);
                                break;
                        }

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Save error");
            }
        }
        private void SaveFile_Click(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFile();
        }
        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }
        #endregion

        #region Language
        private void SetRussian_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Resources = new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/Resourse/lang_RU.xaml")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void SetEnglish_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Resources = new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/Resourse/lang_EN.xaml")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }
        #endregion

        #region Theme
        private void SelectTheme(object sender, RoutedEventArgs e)
        {
            Uri uri = null;
            bool isTheme = false;
            ListBoxItem lbi = (ListBoxItem)sender;

            switch (lbi.Name)
            {
                case "Lime":
                    {
                        uri = new Uri("/Theme/ThemeLime.xaml", UriKind.Relative);
                        Lime.IsSelected = false;
                        isTheme = true;
                        break;
                    }
                case "Tomato":
                    {
                        uri = new Uri("/Theme/ThemeTomato.xaml", UriKind.Relative);
                        Tomato.IsSelected = false;
                        isTheme = true;
                        break;
                    }
                case "Orange":
                    {
                        uri = new Uri("/Theme/ThemeOrange.xaml", UriKind.Relative);
                        Orange.IsSelected = false;
                        isTheme = true;
                        break;
                    }
                default:
                    break;
            }
            if (isTheme)
            {
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
        }

        #endregion

        private void OnChangeFontFamily(object sender, SelectionChangedEventArgs e)
        {
            if (this.FontTypes.SelectedItem != null)
            {
                this.MainText.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, this.FontTypes.SelectedItem);
            }
            this.MainText.Focus();
        }

        private void FontUpdating(object sender, RoutedEventArgs e)
        {
            object temp = MainText.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = MainText.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = MainText.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));
            temp = this.MainText.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            this.FontTypes.SelectedItem = temp;
        }

        /*Информация о тексте*/
        private string GetLen(RichTextBox rtb)
        {
            int count_of_symbols = 0, count_of_lines = 0;

            var textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            foreach (char c in textRange.Text)
            {
                if (!c.Equals('\n') && (int)c != 13)
                {
                    count_of_symbols++;
                }
                else if (c.Equals('\n'))
                {
                    count_of_lines++;
                }
            }
            return "count of symbols " + count_of_symbols + ", count of lines " + count_of_lines;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            this.informText.Text = GetLen(this.MainText);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(this.rofFileName);
            fileInfo.Delete();
            fileInfo.Create();
        }
    }
}