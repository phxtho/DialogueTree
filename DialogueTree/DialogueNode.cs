using System;
using System.Collections.Generic;
using Graph;

namespace DialogueTree
{
    public class DialogueNode : Vertex<string>
    {

        DialogueNode() { }

        DialogueNode(string text)
        {
            data = text;
        }
    }
}
