using Mod02Act01.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod02Act01.ViewModel
{
    internal class TaskViewModel
    {
        public TaskModel TaskModelSet { get; set; }
        public TaskViewModel()
        {
            TaskModelSet = new TaskModel()
            {
                Subjectcode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,
            };
        }
    }
}
