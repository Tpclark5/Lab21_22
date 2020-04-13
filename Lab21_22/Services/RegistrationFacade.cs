using Lab21_22.Models;

namespace Lab21_22.Services
{
    public class RegistrationFacade : IRegistrationFacade
    {
        public RegistrationDetailsViewModel Map(RegistrationViewModel model)
        {
            var viewModel = new RegistrationDetailsViewModel();
            viewModel.FirstName = model.FirstName;
            viewModel.LastName = model.LastName;
            viewModel.Username = model.Username;
            viewModel.PhoneNumber = model.PhoneNumber;
            viewModel.EmailAddress = model.EmailAddress;
            viewModel.Password = model.Password;
            return viewModel;
        }
    }
}
