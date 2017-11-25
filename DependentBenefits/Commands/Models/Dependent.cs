using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependentBenefits.Commands.Models
{
    public class Dependent : IRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Relationship { get; set; }
        public int EmployeeId { get; set; }
    }
}
