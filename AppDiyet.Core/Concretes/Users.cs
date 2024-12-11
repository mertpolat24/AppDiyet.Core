using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Abstract;
using AppDiyet.Core.Enums;

namespace AppDiyet.Core.Concretes
{
    public class Users : BaseEntity
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private int _age;
        private double _lenght;
        private double _weight;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Contains("@") && value.Contains("mail.com"))
                {
                    _email = value;
                }
                else
                    throw new Exception("Lütfen Geçerli bir Email giriniz");
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length >= 10 && value.Any(char.IsUpper) && value.Any(ch => !char.IsLetterOrDigit(ch)) && value.Any(char.IsDigit))
                {
                    _password = value;
                }
                else
                    throw new Exception("Şifre en az 10 karakterli, 1 büyük harf, 1 adet rakam ve 1 özel karakter içermelidir!");
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value.ToUpper();
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value.ToUpper();
            }
        }
        public double Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (value >= 100.00 && value <= 250.00)
                    _lenght = value;
                else
                    throw new Exception("Boyunuz 100 cm ile 250cm arasında olmalıdır!");

            }
        }
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value >= 40 && value <= 300)
                    _weight = value;
                else
                    throw new Exception("Kilonuz en az 40, en fazla 300 olmalıdır. ");
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set

            {
                if (value >= 18 && value <= 65)
                {
                    _age = value;
                }
            }
        }
        public Gender Gender { get; set; }
        public Purpose Purpose { get; set; }
        public Activities Activities { get; set; }
        public int MealsCount { get; set; }
        public double TargetWeight { get; set; }
        public string ImagePath { get; set; }
        public ICollection<Meals> Meals { get; set; }

    }
}
