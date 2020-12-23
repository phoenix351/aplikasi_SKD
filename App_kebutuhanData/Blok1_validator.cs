using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_kebutuhanData
{
    class Blok1_validator : AbstractValidator<Blok1Model>
    {
        public Blok1_validator()
        {
            RuleFor(b1 => b1.nama).NotEmpty();
            
        }
    }
}
