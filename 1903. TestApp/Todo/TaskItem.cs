﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1903._TestApp.Todo
{
    public class TaskItem
    {
        public TaskItem(string title, DateTime dueDate)
        {
            this.Title = title;
            this.DueDate = dueDate;
            this.IsCompleted = false;
        }

        public string Title { get; }

        public DateTime DueDate { get; }

        public bool IsCompleted { get; set; }
    }

}
