using DependentBenefits.Commands.Models;
using MediatR;
using Nancy;
using Nancy.ModelBinding;

namespace DependentBenefits.Service
{
    public class DependentModule : NancyModule
    {
        private readonly IMediator _mediator;

        public DependentModule(IMediator mediator)
        {
            _mediator = mediator;

            Post("/enroll", args =>
            {
                var dependentModel = this.Bind<AddNewDependent>();
                SaveNewDependent(dependentModel);
                return "Success";
            });
        }


        public void SaveNewDependent(AddNewDependent employee)
        {
            _mediator.Send(employee);
        }
    }
}
