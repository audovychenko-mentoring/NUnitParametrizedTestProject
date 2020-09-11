using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitParametrizedTestProject
{
    public class BaseTest
    {
        private Dictionary<Environment, string> PossibleEnvironments
        {
            get
            {
                return new Dictionary<Environment, string>()
                {
                    { Environment.QA, Settings.QAUrl },
                    { Environment.Production, Settings.ProductionUrl },
                    { Environment.Development, Settings.DevelopmentUrl},
                };
            }
        }

        public Environment CurrentEnvironment { get; set; }

        protected string CurrentEnvironmentURL
        {
            get 
            {
                string url;
                if (PossibleEnvironments.TryGetValue(CurrentEnvironment, out url))
                {
                    return url;
                }
                throw new InvalidOperationException(string.Format("({0}) is not valid", CurrentEnvironment));
            }
        }

        public BaseTest(Environment environment)
        {
            CurrentEnvironment = environment;
        }

        public BaseTest()
        { 
        }
    } 
}
