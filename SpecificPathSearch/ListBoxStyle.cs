//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace SpecificPathSearch
//{
//    class ListBoxStyle
//    {
//        private ListBox listBox;

//        public ListBoxStyle(ListBox listBox)
//        {
//            this.listBox = listBox;
//            listBox.DrawMode = DrawMode.OwnerDrawFixed;  // 將listbox設定成可以自己重繪
//            this.listBox.DrawItem += new DrawItemEventHandler(listBox_DrawItem);
//            this.listBox.DataSource = array;
//        }

//        public ListBox GetListBox()
//        {
//            return listBox;
//        }
//    }

    
//public void listBox_DrawItem(object sender, DrawItemEventArgs e)
//{
//    ListBox list = (ListBox)sender;

//    // Draw the background of the ListBox control for each item.
//    e.DrawBackground();
//    // Define the default color of the brush as black.
//    Brush myBrush = Brushes.Black;

//    // Determine the color of the brush to draw each item based 
//    // on the index of the item to draw.
//    switch (e.Index)
//    {
//        case 0:
//            myBrush = Brushes.Red;
//            break;
//        case 1:
//            myBrush = Brushes.Orange;
//            break;
//        case 2:
//            myBrush = Brushes.Purple;
//            break;
//    }

//    // Draw the current item text based on the current Font 
//    // and the custom brush settings.
//    e.Graphics.DrawString(list.Items[e.Index].ToString(),
//        e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
//    // If the ListBox has focus, draw a focus rectangle around the selected item.
//    e.DrawFocusRectangle();
//}
//}
