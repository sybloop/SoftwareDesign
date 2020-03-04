using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentCreator
{
    class HTMLParagraph : IHTMLElement
    {
        private string text;

        // constructor
        public HTMLParagraph(string textIn)
        {
            text = textIn;
        }

        
        // paragraphs in HTML are denoted by "<p>...</p>"
        public string GetString()
        {
            return "<p>\n" + text + "\n</p>\n\n";
        }
    }
}
