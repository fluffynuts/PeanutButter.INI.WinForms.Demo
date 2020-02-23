using System;
using System.Drawing;
using System.Windows.Forms;

namespace IniExample
{
    // borrowed from: http://www.blackbeltcoder.com/Articles/controls/creating-a-color-picker-with-an-owner-draw-combobox
    // -> because it works quite well and there's no native winforms control for a drop-down color-picker
    public partial class ColorPicker : ComboBox
    {
        public ColorPicker()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawFixed;
            DrawItem += OnDrawItem;
        }

        // Draw list item
        protected void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                // Get this color
                ColorInfo color = (ColorInfo) Items[e.Index];

                // Fill background
                e.DrawBackground();

                // Draw color box
                Rectangle rect = new Rectangle();
                rect.X = e.Bounds.X + 2;
                rect.Y = e.Bounds.Y + 2;
                rect.Width = 18;
                rect.Height = e.Bounds.Height - 5;
                e.Graphics.FillRectangle(new SolidBrush(color.Color), rect);
                e.Graphics.DrawRectangle(SystemPens.WindowText, rect);

                // Write color name
                Brush brush;
                if ((e.State & DrawItemState.Selected) != DrawItemState.None)
                    brush = SystemBrushes.HighlightText;
                else
                    brush = SystemBrushes.WindowText;
                e.Graphics.DrawString(color.Name, Font, brush,
                    e.Bounds.X + rect.X + rect.Width + 2,
                    e.Bounds.Y + ((e.Bounds.Height - Font.Height) / 2));

                // Draw the focus rectangle if appropriate
                if ((e.State & DrawItemState.NoFocusRect) == DrawItemState.None)
                    e.DrawFocusRectangle();
            }
        }

        /// <summary>
        /// Gets or sets the currently selected item.
        /// </summary>
        public new ColorInfo SelectedItem
        {
            get { return (ColorInfo) base.SelectedItem; }
            set { base.SelectedItem = value; }
        }

        /// <summary>
        /// Gets the text of the selected item, or sets the selection to
        /// the item with the specified text.
        /// </summary>
        public new string SelectedText
        {
            get
            {
                if (SelectedIndex >= 0)
                    return SelectedItem.Name;
                return String.Empty;
            }
            set
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    if (((ColorInfo) Items[i]).Name == value)
                    {
                        SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the value of the selected item, or sets the selection to
        /// the item with the specified value.
        /// </summary>
        public new Color SelectedValue
        {
            get
            {
                if (SelectedIndex >= 0)
                    return SelectedItem.Color;
                return Color.White;
            }
            set
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    if (((ColorInfo) Items[i]).Color == value)
                    {
                        SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}