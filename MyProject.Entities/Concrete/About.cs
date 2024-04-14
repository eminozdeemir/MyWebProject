using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete
{
    public class About : IEntity
    {
        public int AboutId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Description { get; set; } 
        public int Age { get; set; }
        public string FirstEmail { get; set; } 
        public string SecondEmail { get; set; } 
        public string Phone { get; set; } 
        public string Address { get; set; } 
        public string SoftwareArea { get; set; }
    }
}
