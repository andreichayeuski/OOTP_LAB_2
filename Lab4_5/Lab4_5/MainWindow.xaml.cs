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
using Microsoft.Win32;
using System.IO;

namespace Lab4_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int count_of_windows = 0;
        public MainWindow()
        {
            InitializeComponent();
            if (count_of_windows != 0)
            {
                this.Title += " (" + count_of_windows++ + ") ";
            }
            else
            {
                count_of_windows++;
            }
            this.FontSizeTextBox.Text = this.Font_Size.Value.ToString();
            MainText.AllowDrop = true;
            Uri iconUri = new Uri("D:\\Документы\\Университет\\4 семестр\\ООТП\\Лабораторные\\Lab4_5\\Lab4_5\\resources\\icon.ico", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
            MainText.AddHandler(RichTextBox.DragOverEvent, new DragEventHandler(DragItem), true);
            MainText.AddHandler(RichTextBox.DropEvent, new DragEventHandler(DropItem), true);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = "text.txt",
                    InitialDirectory = "D:\\Документы\\Университет\\4 семестр\\ООТП\\Лабораторные\\Lab4_5"
                };
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == true)
                {
                    TextRange textRange = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".rtf")
                            textRange.Save(fs, DataFormats.Rtf);
                        else if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".txt")
                            textRange.Save(fs, DataFormats.Text);
                        else
                            textRange.Save(fs, DataFormats.Xaml);
                    }
                }
                else
                {
                    throw new Exception("uncorrect extension");
                }
            }
            catch
            {
                MessageBox.Show("save error");
            }
        }

        private void Font_Size_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                if (Font_Size.IsFocused && Font_Size.Value > 0)
                {
                    ChangeFontSize();
                    this.FontSizeTextBox.Text = this.Font_Size.Value.ToString();
                    ((Slider)sender).SelectionEnd = e.NewValue;
                }
                else if (Font_Size.Value == 0)
                {
                    MessageBox.Show("error: font size doesn't be negative");
                    Font_Size.Value = 12;
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    FileName = "text.txt",
                    InitialDirectory = "D:\\Документы\\Университет\\4 семестр\\ООТП\\Лабораторные\\Lab4_5"
                };
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == true)
                {
                    TextRange textRange = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        if (Path.GetExtension(openFileDialog.FileName).ToLower() == ".rtf")
                            textRange.Load(fs, DataFormats.Rtf);
                        else if (Path.GetExtension(openFileDialog.FileName).ToLower() == ".txt")
                            textRange.Load(fs, DataFormats.Text);
                        else
                            textRange.Load(fs, DataFormats.Xaml);
                    }
                    this.Title = "Text Editor (" + openFileDialog.FileName + ") ";
                }
                else
                {
                    throw new Exception("uncorrect extension");
                }
            }
            catch
            {
                MessageBox.Show("open error");
            }
        }

        private void FontTypes_GotFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FontTypes.IsFocused)
                {
                    switch (FontTypes.SelectedIndex)
                    {
                        case 0:
                            {
                                TextRange tr = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
                                tr.ApplyPropertyValue(FontFamilyProperty, "Arial");
                                break;
                            }
                        case 1:
                            {
                                TextRange tr = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
                                tr.ApplyPropertyValue(FontFamilyProperty, "Times New Roman");
                                break;
                            }
                        case 2:
                            {
                                TextRange tr = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
                                tr.ApplyPropertyValue(FontFamilyProperty, "Calibri");
                                break;
                            }
                        case 3:
                            {
                                TextRange tr = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
                                tr.ApplyPropertyValue(FontFamilyProperty, "Segoe UI");
                                break;
                            }
                        case 4:
                            {
                                TextRange tr = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
                                tr.ApplyPropertyValue(FontFamilyProperty, "Tahoma");
                                break;
                            }
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Font_Size_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip = Font_Size.Value.ToString();
        }

        private void Font_Size_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Font_Size.IsFocused)
            {
                ToolTip = Font_Size.Value.ToString();
            }
        }

        private void ChangeFontSize()
        {
            TextRange tr = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, Font_Size.Value);
        }

        private void FontSizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double value;
                if (this.FontSizeTextBox.Text.Equals(String.Empty))
                {
                    Font_Size.Value = 12;
                    this.FontSizeTextBox.Text = Font_Size.Value.ToString();
                    throw new Exception("please, write a size");
                }
                if ((value = Convert.ToDouble(this.FontSizeTextBox.Text)) < 0 && value > 100)
                {
                    MessageBox.Show("error: font size is uncorrect");
                }
                else
                {
                    this.Font_Size.Value = Convert.ToDouble(this.FontSizeTextBox.Text);
                    ChangeFontSize();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void DragItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = false;
        }

        private void DropItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (System.IO.File.Exists(docPath[0]))
                    {
                        try
                        {
                            TextRange range = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
                            FileStream fStream = new FileStream(docPath[0], FileMode.OpenOrCreate);
                            range.Load(fStream, DataFormats.Rtf);
                            fStream.Close();
                            this.Title = "Text Editor (" + docPath[0] + ") ";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("File could not be opened. Make sure the file is a text file.");
                        }
                    }
                }
            }
        }

        private void NewWind(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private void SetRussian(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Resources = new ResourceDictionary()
                {
                    Source = new
                        Uri("pack://application:,,,/resources/langRU.xaml")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void SetEnglish(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Resources = new ResourceDictionary()
                {
                    Source = new
                    Uri("pack://application:,,,/resources/langEN.xaml")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Bold_Unchecked(object sender, RoutedEventArgs e)
        {
            MainText.FontWeight = FontWeights.Normal;
        }

        private void Italic_Unchecked(object sender, RoutedEventArgs e)
        {
            MainText.FontStyle = FontStyles.Normal;
        }

        private void UnderLine_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private string GetLength(RichTextBox rtb)
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
            Log.Text = GetLength(MainText);
        }
    }
}
