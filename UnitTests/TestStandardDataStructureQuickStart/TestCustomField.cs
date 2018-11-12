using Microsoft.VisualStudio.TestTools.UnitTesting;
using StandardDataStructureQuickStart.Data;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace TestStandardDataStructureQuickStart
{
    [TestClass]
    public class TestCustomField
    {
        [TestMethod]
        public void TestSerializeCustomField()
        {
            ICustomField customField = new CustomField("TEST","TESTVALUE");

            //Create a stream to serialize the object to.  
            MemoryStream ms = new MemoryStream();

            // Serializer the User object to the stream.  
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CustomField));
            ser.WriteObject(ms, customField);
            byte[] json = ms.ToArray();
            ms.Close();
            var jsonResult = Encoding.UTF8.GetString(json, 0, json.Length);

        }
    }
}
