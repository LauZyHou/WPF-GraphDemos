using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasBinding._VM.Canvas_ItemsControl
{
    public class MyItem_VM : NetworkNodeBase_VM
    {
        private string name;

        public MyItem_VM(string name)
        {
            this.name = name;
            this.X = 100;
            this.Y = 200;
        }

        public string Name { get => name; set => name = value; }
    }
}
