﻿namespace Nancy.Demo.StatelessAuth
{
    using System.Collections.Generic;
    using Nancy.Security;

    public class DemoUserIdentity : IUserIdentity
    {
        public string UserName { get; set; }

        public IEnumerable<string> Claims { get; set; }
    }
}