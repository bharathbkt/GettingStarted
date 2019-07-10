using System;

namespace GettingStarted.Entities
{
    public class Class1
    {
        public int intField1 { get; set; }
        public int intField2 { get; set; }
        public string stringField1 { get; set; }
        public string stringField2 { get; set; }

        public override string ToString()
        {
            return "intField1: " + intField1.ToString() + "; intField2: " + intField2.ToString() + "; stringField1: " + stringField1 + "; stringField2: " + stringField1 + ";";
        }
    }
}
