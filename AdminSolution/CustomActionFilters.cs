using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Azure.KeyVault.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AdminSolution
{
    public class CustomActionFilters : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {

            var errors = actionContext.ModelState
                 .Where(e => e.Value.Errors.Count > 0)
                 .Select(e => new 
                 {
                     Message = e.Value.Errors.First().ErrorMessage
                 }).ToArray();

            var modelState = actionContext.ModelState;

            if (!modelState.IsValid)
            {
                actionContext.Result = new BadRequestObjectResult(new {
                    Content = errors
                });

            }

            base.OnActionExecuting(actionContext);
        }
    }

    
}
