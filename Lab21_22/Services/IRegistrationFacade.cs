using Lab21_22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21_22.Services
{
    public interface IRegistrationFacade
    {
        public RegistrationDetailsViewModel Map(RegistrationViewModel model);
    }
}
