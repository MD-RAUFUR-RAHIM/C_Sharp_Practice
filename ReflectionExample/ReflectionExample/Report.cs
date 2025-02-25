using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    public class Report : IPlugin
    {
        private string _name;
        public Report(string name)
        {
            _name = name;
        }
        public void Start()
        {
            Console.WriteLine($"Running Report: {_name}");
        }
    }
}
