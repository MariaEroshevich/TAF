using NUnit.Framework.Internal;
using static NUnit.Framework.TestContext;

namespace Epam.TestAutomation.Core.ContextHelper
{
    public static class ContextVariableHelper
    {
        public static void SetValueToContext(string key, object value)
        {
            TestExecutionContext.CurrentContext.CurrentTest.Properties.Set(key, value);
        }

        public static T GetValueFromContext<T>(string key)
        {
            return (T)CurrentContext.Test.Properties.Get(key);
        }

        public static bool IsValueExist(string key)
        {
            return CurrentContext.Test.Properties.ContainsKey(key);
        }
    }
}
