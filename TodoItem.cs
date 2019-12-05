﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorTest.Shared
{
    public class TodoItem : ComponentBase
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        protected IList<TodoItem> todos = new List<TodoItem>();
        protected string newTodo;

        protected void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }
    }
}
