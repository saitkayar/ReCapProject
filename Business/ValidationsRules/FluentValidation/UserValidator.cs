﻿using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationsRules.FluentValidation
{
    public  class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            
        }
    }

}
