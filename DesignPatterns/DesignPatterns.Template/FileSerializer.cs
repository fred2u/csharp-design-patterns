using System;
using System.IO;

namespace DesignPatterns.Template
{
    internal abstract class FileSerializer
    {
        public void Save(string path, params Person[] people)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));
            if (people == null) throw new ArgumentNullException(nameof(people));

            File.WriteAllBytes(path, GetBytes(people));
        }

        protected abstract byte[] GetBytes(params Person[] people);
    }
}