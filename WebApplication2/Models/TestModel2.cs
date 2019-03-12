using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class TestModel2
    {
        public string Id { get; set; }
        public TestSubmodel SubModel { get; set; }

        public TestSubmodel2 SubModel2 { get; set; }
    }

    public class TestSubmodel2
    {
        public string SubId { get; set; }

        public TestSubSubModel SubSubModel { get; set; }
    }
}
