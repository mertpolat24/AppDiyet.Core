﻿using AppDiyet.Core.Concretes;
using AppDiyet.Repo.Abstarcts;
using AppDiyet.Repo.Concretes;
using AppDiyet.Repo.Context;
using AppDiyet.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Service.Services
{
    internal class UserService : IUserService
    {
        IUsersRepo repo = new UserRepo(new AppDbContext());
        public double CalculateCalories(int id)
        {
            return repo.CalculateCalories(id);
        }

        public double CalculateProteins(int id)
        {
            return repo.CalculateProteins(id);
        }

        public bool Create(string firstName, string lastName, string email, string password, int age, double lenght, double weight)
        {
            var userEmail = repo.GetByEmail(email);
            if (userEmail is null)
            {
                Users users = new Users()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Password = password,
                    Age = age,
                    Lenght = lenght,
                    Weight = weight
                };
                return repo.Create(users);
            }
            else
            {
                throw new Exception("Bu email ile kayıtlı olan bir kullanıcı mevcut!");
            }
           
        }

        public double DailyCaloriesLimit(int id)
        {
            return repo.DailyCaloriesLimit(id);
        }

        public bool Delete(int id)
        {
            var user = repo.GetById(id);
            return repo.Delete(user);
            
        }

        public List<Users> GetAll()
        {
            return repo.GetAll().ToList();
        }

        public double GetByCalories(int id)
        {
            return repo.GetByCalories(id);
        }

        public Users GetByEmail(string email)
        {
            return repo.GetByEmail(email);
        }

        public Users GetById(int id)
        {
            return repo.GetById(id);
        }

        public List<Meals> GetByMeals(int id)
        {
            return repo.GetByMeals(id);
        }

        public List<Users> GetByName(int id)
        {
            return repo.GetByName(id);
        }

        public double GetByProteins(int id)
        {
            return repo.GetByProteins(id);
        }

        public double GetByWeight(int id)
        {
            return repo.GetByWeight(id);
        }

        public double RemainingCalories(int id)
        {
            return repo.RemainingCalories(id);
        }

        public bool Update(int id, string email, string password, int age, double lenght, double weight)
        {
            var user = repo.GetById(id);
            if (user is not null)
            {
                user.Email = email;
                user.Password = password;
                user.Age = age;
                user.Weight = weight;
                user.Lenght = lenght;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}