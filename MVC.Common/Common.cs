using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC.Common
{
    public static class Common
    {
        public enum EmployeeStatus
        {
            [Description("Active")]
            Active,
            [Description("Pending")]
            Pending,
            [Description("Deleted")]
            Deleted,
            [Description("OnVacation")]
            OnVacation,
            [Description("20F")]
            CustomStatus
        }

        public static string GetDescription<T>(this T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            if (!(fieldInfo is null))
            {
                var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : value.ToString();
            }

            return value.ToString();
        }
    }
}