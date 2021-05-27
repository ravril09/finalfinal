using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }



        public ComboBoxItem(string text, string value)
        {
            this.Text = text;
            this.Value = value;
        }
    }
}
