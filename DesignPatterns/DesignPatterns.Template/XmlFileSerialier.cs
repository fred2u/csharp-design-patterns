using System;
using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns.Template
{
    internal class XmlFileSerialier : FileSerializer
    {
        protected override byte[] GetBytes(params Person[] people)
        {
            if (people == null) throw new ArgumentNullException(nameof(people));

            using (var stream = new MemoryStream())
            {
                var serializer = new XmlSerializer(people.GetType());
                serializer.Serialize(stream, people);

                return stream.ToArray();
            }
        }
    }
}