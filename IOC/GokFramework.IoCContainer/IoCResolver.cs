using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace GokFramework.IoCContainer
{
    public class IoCResolver
    {
        #region Constructor
        private static object objLock = new object();
        private static IoCResolver m_IoCResolver;
        public static IoCResolver getInstance
        {
            get
            {
                if (m_IoCResolver == null)
                {
                    lock (objLock)
                    {
                        if (m_IoCResolver == null)
                            m_IoCResolver = new IoCResolver();
                    }
                }

                return m_IoCResolver;
            }
            set { m_IoCResolver = value; }
        }

        #endregion

        /// <summary>
        /// Injection of control
        /// </summary>
        /// <typeparam name="TSource">Injection yapılacak class type.</typeparam>
        /// <typeparam name="TDestination">Injection edilecek class type.</typeparam>
        /// <returns></returns>
        public void Resolve<TSource, TDestination>()
        {
            object dependencyForInstance, implementedByInstance;
            dependencyForInstance = Activator.CreateInstance(typeof(TSource));
            implementedByInstance = Activator.CreateInstance(typeof(TDestination));

            foreach (var pi in dependencyForInstance.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                var piList = implementedByInstance.GetType().GetInterfaces().Where(x => x.Name.Equals(pi.FieldType.Name)).ToList();
                if (piList.Count > 0)
                { pi.SetValue(dependencyForInstance, implementedByInstance); break; }
            }
        }
    }
}