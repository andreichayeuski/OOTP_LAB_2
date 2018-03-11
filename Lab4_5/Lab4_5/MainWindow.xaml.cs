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
        public MainWindow()
        {
            InitializeComponent();
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
                    TextRange tr = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);

                    tr.ApplyPropertyValue(FontSizeProperty, Font_Size.Value);
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
    }
}
