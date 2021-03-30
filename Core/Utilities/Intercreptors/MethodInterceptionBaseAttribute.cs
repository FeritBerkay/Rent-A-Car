using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Intercreptors
{
    // Bu Class ve methodlarda multiple olarak kullanılabilir.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
