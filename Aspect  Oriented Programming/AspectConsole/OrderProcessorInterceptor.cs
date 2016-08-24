using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace AspectConsole
{
    public class OrderProcessorInterceptor:IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Interceptor was triggered.");
            if (invocation.Method.ReturnType == typeof (Boolean) &&
                invocation.Arguments != null &&
                invocation.Arguments.Any() && 
                invocation.Arguments[0] is Order)
            {

                Console.WriteLine("ProcessOrder method was intercepted");
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                invocation.Proceed();
            }
        }
    }
}
