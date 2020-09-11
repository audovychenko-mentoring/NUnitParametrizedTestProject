using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitParametrizedTestProject
{
    public enum Environment
    {
        QA,
        Production,
        Development,
    }

    public class Settings
    {
        public static string QAUrl { get { return "https://www.facebook.com"; } }

        public static string ProductionUrl { get { return "https://www.gmail.com"; } }

        public static string DevelopmentUrl { get { return "https://ya.ru/"; } }
    }
}
