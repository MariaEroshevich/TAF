using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace Epam.TestAutomation.Tests.BDD.Utils
{
    public static class ContextVariableHelper
    {
        public static void SetValueToContext(string key, object value) =>
            TestExecutionContext.CurrentContext.CurrentTest.Properties.Set(key, value);

        public static T GetValueFromContext<T>(string key) =>
            (T)NUnit.Framework.TestContext.CurrentContext.Test.Properties.Get(key);

        public static bool IsValueExists(string key) =>
            NUnit.Framework.TestContext.CurrentContext.Test.Properties.ContainsKey(key);
    }
}
