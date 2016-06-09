using System;

namespace DesignPatterns.Template
{
    // Serializable attribute and public scope required for XML serialization
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}