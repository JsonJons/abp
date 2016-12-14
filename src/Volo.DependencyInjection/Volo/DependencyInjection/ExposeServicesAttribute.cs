﻿using System;

namespace Volo.DependencyInjection
{
    public class ExposeServicesAttribute : Attribute, IExposedServiceTypesProvider
    {
        public Type[] ExposedServiceTypes { get; }

        public ExposeServicesAttribute(params Type[] exposedServiceTypes)
        {
            ExposedServiceTypes = exposedServiceTypes ?? new Type[0];
        }

        public Type[] GetExposedServiceTypes()
        {
            return ExposedServiceTypes;
        }
    }
}