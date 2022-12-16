using System;
using Microsoft.AspNetCore.Mvc;

namespace Exceptions
{
    [Route("~/broken")]
    public class ExampleController
    {
        public string Get(int id)
        {
            throw new ArgumentNullException();
        }
    }
}
