using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class TestModel
    {
        public string Id { get; set; }
        public TestSubmodel SubModel {get; set; }

        public TestSubmodel SubModel2 { get; set; }
    }

    public class TestSubmodel
    {
        public string SubId { get; set; }

        public TestSubSubModel SubSubModel { get; set; }
    }


    public class TestSubSubModel
    {
        public string SubSubId { get; set; }
        public double SubSubDouble { get; set; }

    }
}
