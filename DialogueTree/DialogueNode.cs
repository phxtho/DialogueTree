using System;
using System.Collections.Generic;

namespace DialogueTree
{
    public class DialogueNode
    {
        public int nodeId;

        public string _text;

        //public List<T> options;

        DialogueNode() { }

        DialogueNode(string text)
        {
            _text = text;
        }
    }
}
