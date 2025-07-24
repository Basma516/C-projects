using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_Sharp
{
    public class TextEditor
    {
        string Content { get; set; }

        public TextEditor(string content) 
        {
            Content = content;
        }
        public TextEditor ToUpper() {
            Content = Content.ToUpper();
            return this;
        }
        public TextEditor ToLower()
        {
            Content = Content.ToLower();
            return this;
        }
        public TextEditor AddExclamation()
        {
            Content += "!";
            return this;
        }
        public TextEditor ReplaceSpacesWithDash()
        {
            Content =Content.Replace(" ", "-");
            return this;
        }
        public void print()
        {
            Console.WriteLine(Content);
        }
    }
}
