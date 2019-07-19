using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplic
{
    class Employee
    {
        //Поля
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSsn;

        //Свойства
        //Способ 1
        //public string GetName()
        //{
        //    return empName;
        //}

        //public void SetName(string name)
        //{
        //    if (name.Length >= 15)
        //    {
        //        Console.WriteLine("Ошибка! Длина имени должна быть не более 15 символов.");
        //    }
        //    else
        //        empName = name;
        //}
        //Способ 2
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Ошибка! Длина имени должна быть не более 15 символов.");
                else empName = value;
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSsn; }
        }

        //Конструкторы
        public Employee() { }
        public Employee(string name, int id)
            : this(name, 0, id, 0, "") { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "") { }

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
            empSsn = ssn;
        }

        //Методы
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Имя сотрудника: {Name}");
            Console.WriteLine($"Номер индетификационной карты: {ID}");
            Console.WriteLine($"Текущая выплата: {Pay}");

            if (Age >= 1)
            {
                Console.WriteLine($"Возраст сотрудника: {Age}");
            }

            if (SocialSecurityNumber != "")
            {
                Console.WriteLine($"SSN: {SocialSecurityNumber}");
            }
        }
    }
}
