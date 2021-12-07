using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public class File
    {
        public static int nextID = 1;
        public int ID { get;}
        public string Name { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }

        public File(string name, int size, string type, string content)
        {
            Name = name;
            Content = content;
            Size = size;
            Type = type;
            ID = nextID;
            nextID++;
        }


        public override string ToString()
        {
            return $"{String.Format("{0,-18}", Name)}   {Type}   {Size}mb";
        }
    }
}
