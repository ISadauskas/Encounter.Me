// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;

namespace EncounterMeAPI.Filters
{
    public class ApiExceptionFilter : IExceptionFilter
    {

        public void OnException (ExceptionContext context)
        {
            Log.Error($"{context.Exception}");

            context.Result = new ContentResult
            {
                StatusCode = 400,
                Content = context.Exception.Message
            };
        }
    }
}
