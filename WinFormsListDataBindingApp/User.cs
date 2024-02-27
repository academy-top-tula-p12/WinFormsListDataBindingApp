using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsListDataBindingApp
{
    internal class User
    {
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Admin {  get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} ({BirthDate.ToShortDateString()})";
        }
    }
}
