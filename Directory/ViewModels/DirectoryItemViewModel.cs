using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;

namespace TotalComrade
{
    public class DirectoryItemViewModel : BaseViewModel
    {
        public DirectoryItemViewModel(string fullPath, DirectoryItemType itemType)
        {
            this.FullPath = fullPath;
            this.Type = itemType;
            this.ExpandCommand = new RelayCommand(Expand);
            this.SelectCommand = new RelayCommand(ShowDetails);
            this.ClearChildren();
        }

        public string FullPath { get; set; }
        public string Name { get { return this.Type == DirectoryItemType.Drive ? this.FullPath : DirectoryStructure.GetFileFolderName(this.FullPath); } }
        public DirectoryItemType Type { get; set; }
        public ObservableCollection<DirectoryItemViewModel> Children { get; set; }
        public bool CanExpand { get { return this.Type != DirectoryItemType.File; } }
        public int FileSize { get; set; }


        public ICommand ExpandCommand { get; set; }
        public ICommand DoubleClickCommand { get; set; }
        public ICommand SelectCommand { get; set; }

        public string ImageName => Type == DirectoryItemType.Drive ? "drive" : (Type == DirectoryItemType.File ? "file" : "folder");
        //public string ImageName => Type == DirectoryItemType.Drive ? "drive" : (Type == DirectoryItemType.File ? "file" : (IsExpanded ? "folder-open" : "folder-closed"));

        public bool IsExpanded
        {
            get
            {
                return this.Children?.Count(f => f != null) > 0;
            }
            set
            {
                if (value)
                    Expand();
                else
                    this.ClearChildren();
            }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get
            {
                return this._isSelected;
            }
            set
            {
                this._isSelected = value;
                MessageBox.Show("sadf");
            }
        }

        /*public bool IsDoubleClicked
        {
            get
            {
                return this.Type == DirectoryItemType.File;
            }
            set
            {
                if (value)
                    DoubleClicked();

            }   
        }
        private void DoubleClicked()
        {
            MessageBox.Show("xyz");
        }*/

        private void ShowDetails()
        {
            MessageBox.Show("Pokaż ditajlsy");
        }

        

        private void ClearChildren()
        {
            this.Children = new ObservableCollection<DirectoryItemViewModel>();
            if (this.Type != DirectoryItemType.File)
                this.Children.Add(null);
        }

        private void Expand()
        {
            if (this.Type == DirectoryItemType.File)
                return;

            this.Children = new ObservableCollection<DirectoryItemViewModel>(DirectoryStructure.GetDirectoryContents(this.FullPath).Select(content => new DirectoryItemViewModel(content.FullPath, content.Type)));
        }
    }
}
