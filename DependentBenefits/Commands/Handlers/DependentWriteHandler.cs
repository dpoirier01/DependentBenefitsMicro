using MediatR;
using DependentBenefits.Commands.Models;
using DependentBenefits.Commands.Data;

namespace DependentBenefits.Commands.Handlers
{
    public class DependentWriteHandler : IRequestHandler<Dependent>
    {

        private readonly DependentWriteContext _db;

        public DependentWriteHandler(DependentWriteContext db)
        {
            _db = db;
        }

        public void Handle(Dependent employee)
        {
            _db.Add(employee);
            _db.SaveChanges();
        }
    }
}
