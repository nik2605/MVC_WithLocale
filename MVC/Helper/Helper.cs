using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace MVC.Helper
{
    public class Helper
    {
        protected static CultureInfo En = new CultureInfo("en-US");
        protected static CultureInfo Fr = new CultureInfo("fr-CA");
        public static CultureInfo Culture;

        Helper()
        {
            En = new CultureInfo("en-US");
            Fr = new CultureInfo("fr-CA");
        }


        public static int Lang
        {
            get
            {
                if (Culture != null)
                {
                    switch (Culture.Name.ToLower())
                    {
                        case "fr-ca":
                            return 1;
                        default:
                            return 0;
                    }
                }

                return 0;
            }
        }

        public static CultureInfo LangCultureInfo
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name.ToLower())
                {
                    case "fr-ca":
                        return Fr;
                    default:
                        return En;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static int CurrentCulture
        {
            set
            {
                switch (value)
                {
                    case 1:
                        Culture = Fr;
                        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = Fr;
                        break;
                    default:
                        Culture = En;
                        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = En;
                        break;
                }
            }
        }


    }
}