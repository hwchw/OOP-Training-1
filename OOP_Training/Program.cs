﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP_Training.SOLID;
using OOP_Training.SOLID.LeastKnowledge;
using OOP_Training.SOLID.LiskovSubstitution;

namespace OOP_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  LiskovSubstitution

            Duck duck = DuckFactory.GetDuck(DuckType.Muscovy);
            duck.Move();
            duck.Quark();
            while (duck.Weight < 10)
            {
                duck.Eat();
            }

            #endregion

            #region LeastKnowledge

            var badStaff = new UnfriendlyStaff();
            Doctor doctor = badStaff.GetAvailableDoctor(DateTime.Today);
            doctor.BookTimeByPhone(DateTime.Today);

            var goodStaff = new FriendlyStaff();
            goodStaff.BookDoctor(DateTime.Today);

            #endregion


            Console.ReadKey();
        }
    }
}
