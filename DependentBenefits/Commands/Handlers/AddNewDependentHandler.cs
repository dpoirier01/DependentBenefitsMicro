using MediatR;
using DependentBenefits.Commands.Models;
using DependentBenefits.Commands.Data;
using AutoMapper;

namespace DependentBenefits.Commands.Handlers
{
    public class AddNewDependentHandler : IRequestHandler<AddNewDependent>
    {

        private readonly DependentContext _db;
        private readonly IMapper _mapper;

        public AddNewDependentHandler(DependentContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public void Handle(AddNewDependent dependent)
        {
            var addNewDependent = _mapper.Map<AddNewDependent, Dependent>(dependent);

            _db.Add(addNewDependent);
            _db.SaveChanges();
        }
    }
}
