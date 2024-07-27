using System;

namespace princSegregacionInterfaz
{
    public class Document
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public Document(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
