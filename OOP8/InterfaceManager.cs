using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace OOP8
{
    public class InterfaceManager
    {
        public static Font StandartFont = new Font("Arial", 10, FontStyle.Bold);
        public Button CreateButton(string Text, int width, int height, int sizew, int sizeh)
        {
            Button button = new Button();
            button.Text = Text;
            button.Location = new Point(width, height);
            button.Size = new Size(sizew, sizeh);
            return button;
        }
        public Label CreateLabel(string Text, int width, int height)
        {
            Label label = new Label();
            label.Font = StandartFont;
            label.Text = Text;
            label.Location = new Point(width, height);
            label.AutoSize = true;
            return label;
        }
        public TextBox CreateTextBox(string Text, int width, int height, int sizew, int sizeh)
        {
            TextBox textBox = new TextBox();
            textBox.Font = StandartFont;
            textBox.Text = Text;
            textBox.Location = new Point(width, height);
            textBox.Size = new Size(sizew, sizeh);
            return textBox;
        }
    }
}
