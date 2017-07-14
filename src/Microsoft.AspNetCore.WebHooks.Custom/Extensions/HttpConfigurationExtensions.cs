// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel;
using Microsoft.AspNetCore.WebHooks.Common.Config;
using Microsoft.Extensions.DependencyInjection;

namespace System.Web.Http
{
    /// <summary>
    /// Extension methods for <see cref="IServiceCollection"/>.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class HttpConfigurationExtensions
    {
        /// <summary>
        ///  Initializes support for adding custom WebHook support to your ASP.NET project. The functionality 
        ///  enables users to manage WebHook subscribers, and to send WebHooks to subscribers with matching 
        ///  registrations.
        /// </summary>
        /// <param name="serviceCollection"></param>
        public static void InitializeCustomWebHooks(this IServiceCollection serviceCollection)
        {
            WebHooksConfig.Initialize(serviceCollection);
        }
    }
}
