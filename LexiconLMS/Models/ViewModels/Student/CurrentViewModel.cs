﻿using LexiconLMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconLMS.Models.ViewModels.Student
{
    public class CurrentViewModel
    {
        public Entities.Activity Activity { get; set; }
        public Course Course { get; set; }

       
        public ICollection<CurrentAssignmentsViewModel> Assignments { get; set; }
        public Module Module { get; set; }
    }
}
