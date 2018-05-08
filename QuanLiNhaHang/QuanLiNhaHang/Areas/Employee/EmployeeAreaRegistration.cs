﻿using System.Web.Mvc;

namespace QuanLiNhaHang.Areas.Employee
{
    public class EmployeeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Employee";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Employee_default",
                "Employee/{controller}/{action}/{id}",
                new { action = "Info", id = UrlParameter.Optional }
            );
        }
    }
}