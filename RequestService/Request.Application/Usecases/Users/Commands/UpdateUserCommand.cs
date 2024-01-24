﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wood.Domain.Dtos.UsersCreateDto;

namespace Wood.Application.Usecases.Users.Commands
{
    public class UpdateUserCommand : UsercreateDto, IRequest<int>
    {
        public int Id { get; set; }
    }
}
