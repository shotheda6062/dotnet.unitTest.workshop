﻿using System;
namespace UnitTest.WorkShop.Model
{
	public class EmployeeInfo
	{
        public string EmployeeID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public double hourlyRate { get; set; }

        public void ReturnsForAnyArgs<T>()
        {
            throw new NotImplementedException();
        }
    }
}

