﻿using System;

namespace InsuranceAgency.Struct
{
    public class Employee
    {
        public int ID { get; }
        public string FullName { get; }
        public DateTime Birthday { get; }
        public string Telephone { get; }
        public string Passport { get; }
        public string Login { get; }
        public string Password { get; }
        public bool Admin { get; }
        public bool Works { get; }


        public Employee(string fullName, DateTime birthday, string telephone, string passport, string login, string password, bool admin, bool works)
        {
            FullName = fullName;
            Birthday = birthday;
            Telephone = telephone;
            Passport = passport;
            Login = login;
            Password = password;
            Admin = admin;
            Works = works;
        }
        public Employee(int id, string fullName, DateTime birthday, string telephone, string passport, string login, string password, bool admin, bool works)
        {
            ID = id;
            FullName = fullName;
            Birthday = birthday;
            Telephone = telephone;
            Passport = passport;
            Login = login;
            Password = password;
            Admin = admin;
            Works = works;
        }
    }
}
