using System;
using System.Text;
using Newtonsoft.Json;

namespace DesignPatterns.Template
{
    internal class JsonFileSerializer : FileSerializer
    {
        protected override byte[] GetBytes(params Person[] people)
        {
            if (people == null) throw new ArgumentNullException(nameof(people));

            var json = JsonConvert.SerializeObject(people);

            return Encoding.UTF8.GetBytes(json);
        }
    }
}