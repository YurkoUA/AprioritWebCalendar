﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace AprioritWebCalendar.Infrastructure.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum member)
        {
            if (member == null)
            {
                return string.Empty;
            }

            try
            {
                return member.GetType()
                    .GetMember(member.ToString())
                    .FirstOrDefault()
                    .GetCustomAttribute<DisplayAttribute>()
                    .Name;
            }
            catch
            {
                return member.ToString();
            }
        }
    }

}
