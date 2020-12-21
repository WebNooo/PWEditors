using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;
using PropertyChanged;
using ReactiveUI;

namespace ECGenerator.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    class MainVM
    {
        public class FolderItem
        {
            public string Name { get; set; }
            public bool Status { get; set; }
        }

        public ObservableCollection<FolderItem> Directories { get; set; }

        public int ProgressVal { get; set; } = 0;

        public int ProgressMax { get; set; } = 100;

        public string FolderPath { get; set; }


        public ICommand SelectFolder => ReactiveCommand.Create(() =>
        {
            var dialog = new FolderBrowserDialog();
            var rDialog = dialog.ShowDialog();

            if (rDialog == DialogResult.OK)
            {
                FolderPath = dialog.SelectedPath;
                Directories = new ObservableCollection<FolderItem>();

                foreach (var path in Directory.GetFiles(FolderPath))
                {
                    var regex = new Regex(@"(PW_[\d].[\d].[\d]_v(\d+).cfg)");
                    if (!regex.IsMatch(path)) continue;

                    var name = regex.Match(path).Groups[1].Value;
                    Directories.Add(new FolderItem {Name = name, Status = false});
                }

                ProgressMax = Directories.Count;
            }
        });

        public ICommand Start => ReactiveCommand.Create(() =>
        {
            if (Directories != null && Directories.Count > 0)
            {
               
                var gen = new Generator();
                var thread = new Thread(() =>
                {
                    foreach (var directory in Directories)
                    {
                        try
                        {
                            gen.Run(FolderPath + "\\" + directory.Name);
                            ProgressVal += 1;
                            directory.Status = true;
                        }
                        catch
                        {
                            //ignored
                        }
                    }
                
                    MessageBox.Show(ProgressVal == ProgressMax
                        ? "Все файлы успешно сгенерированы!"
                        : "При генерации одного или нескольких файлов произошла ошибка!");
                });
                thread.Start();
            }
            else
            {
                MessageBox.Show("Не возможно начать генерацию! Укажите папку где содержиться хотя бы 1 файл конфига!");
            }
        });
    }
}