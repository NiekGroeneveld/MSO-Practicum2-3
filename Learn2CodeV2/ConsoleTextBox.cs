using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public class ConsoleTextBox : TextBox
{
    public ConsoleTextBox()
    {
        // Set default properties
        this.Multiline = true;
        this.ScrollBars = ScrollBars.Vertical;
        this.ReadOnly = true;
        this.BackColor = Color.Black;
        this.ForeColor = Color.LightGreen;
        this.Font = new Font("Consolas", 10F, FontStyle.Regular);
        this.WordWrap = true;
    }


    // Method to append text without timestamp
    public void WriteLine(string text)
    {
        this.AppendText($"{text}{Environment.NewLine}");
        this.ScrollToBottom();
    }


    // Automatically scroll to bottom when new text is added
    private void ScrollToBottom()
    {
        this.SelectionStart = this.TextLength;
        this.ScrollToCaret();
    }
}
