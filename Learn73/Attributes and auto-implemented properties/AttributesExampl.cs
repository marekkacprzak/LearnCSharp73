using System;

namespace Learn73.Attributes_and_auto_implemented_properties
{
    public class AttributesExampl
    {
        [Serializable]
        public class Foo 
        {
            [field: NonSerialized]
            public string MySecret { get; set; }
        }
    }
}