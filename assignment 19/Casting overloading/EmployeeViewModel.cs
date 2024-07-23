using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19.Casting_overloading
{
    // view model : the class that  will be rendered by views[HTML]
    internal class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //overloding casting
        public static /*EmployeeViewModel*/ explicit operator EmployeeViewModel(Employee emp)
        {
            string[]? Names = emp?.FullName?.Split(' ');
            return new EmployeeViewModel()
            {
                FirstName = Names?.Length > 0 ? Names[0] : string.Empty,
                LastName = Names?.Length > 0 ? Names[1] : string.Empty,
                Email = emp?.Email ?? string.Empty
            };
        }
    }
}
