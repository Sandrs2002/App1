using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;

namespace App1
{	
	public partial class File_Page : ContentPage
	{
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public File_Page ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            UpdateFileList();
        }
        private void UpdateFileList()
        {
            fileList.ItemsSource = Directory.GetFiles(folderPath).Select(f => Path.GetFileName(f));
            fileList.SelectedItem = null;
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            string fileName = FileNameEntry.Text;
            if (String.IsNullOrEmpty(fileName))
            {
                return;
            }
            if(File.Exists(Path.Combine(folderPath, fileName)))
            {
                bool isRewrited = await DisplayAlert("Kinnitus", "File exists, are we writing it over?", "Yes", "No");
                if (isRewrited == false) return;
            }
            File.WriteAllText(Path.Combine(folderPath, fileName), TextEditor.Text);
            UpdateFileList();
        }

        void FileList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }
            string fileName = (string)e.SelectedItem;
            TextEditor.Text = File.ReadAllText(Path.Combine(folderPath, fileName));
            FileNameEntry.Text = fileName;
            fileList.SelectedItem = null;
        }

        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            string fileName = (string)((MenuItem)sender).BindingContext;
            File.Delete(Path.Combine(folderPath, fileName));
            UpdateFileList();
        }

        void ToList_Clicked(System.Object sender, System.EventArgs e)
        {
            string fileName = (string)((MenuItem)sender).BindingContext;
            List<string> sequel = File.ReadLines(Path.Combine(folderPath, fileName)).ToList();
            list.ItemsSource = sequel;
        }
    }
}

