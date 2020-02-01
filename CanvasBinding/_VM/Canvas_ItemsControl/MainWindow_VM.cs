using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CanvasBinding._VM.Canvas_ItemsControl
{
    public class MainWindow_VM
    {
        private ObservableCollection<MyItem_VM> itemList = new ObservableCollection<MyItem_VM>();

        public MainWindow_VM()
        {
            itemList.Add(new MyItem_VM("123"));
        }

        public ObservableCollection<MyItem_VM> ItemList { get => itemList; set => itemList = value; }
    }
}
