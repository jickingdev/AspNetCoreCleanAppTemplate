﻿using CleanApp.Application.Abstractions;
using CleanApp.Application.Services;
using CleanApp.Application.Validators;
using CleanApp.Data.EF.Repositories;
using CleanApp.Domain.Abstractions;
using CleanApp.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //.Application
            services.AddScoped<ITodoService, TodoService>();

            //.Domain | .Data
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            //.Application/Validators
            services.AddTransient<IValidator<TodoItem>, TodoItemValidator>();
        }
    }
}
