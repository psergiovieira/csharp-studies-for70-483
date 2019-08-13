using System.Dynamic;

namespace myFirstApp
{
    public class SampleObject : DynamicObject
    {
        public string MyProperty { get; set; }
        public SampleObject()
        {
            MyProperty = "teste";
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = binder.Name;
            return true;
        }
    }
}