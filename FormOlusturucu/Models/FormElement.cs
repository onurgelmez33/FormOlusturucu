using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormOlusturucu.Models
{
    public class FormElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InputType { get; set; }
        public string Placeholder { get; set; }
        public string Value { get; set; }
        public string ValueType { get; set; }
        public string Options { get; set; }
    }
}