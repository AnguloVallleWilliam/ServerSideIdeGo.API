﻿using IdeoGo.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoGo.API.Resources
{
    public class ProjectScheduleResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
