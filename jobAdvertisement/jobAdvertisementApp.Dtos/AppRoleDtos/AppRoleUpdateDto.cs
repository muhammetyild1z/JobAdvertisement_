﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jobAdvertisementApp.Dtos.Interfaces;

namespace jobAdvertisementApp.Dtos.AppRoleDtos
{
    public class AppRoleUpdateDto : IUpdateDto
    {
        public int Id { get; set; }

        public string Definition { get; set; }
    }
}
