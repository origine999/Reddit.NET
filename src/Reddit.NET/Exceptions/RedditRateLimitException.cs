﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.NET.Exceptions
{
    public class RedditRateLimitException : Exception
    {
        public RedditRateLimitException(string message, Exception inner)
            : base(message, inner) { }

        public RedditRateLimitException(string message)
            : base(message) { }

        public RedditRateLimitException() { }
    }
}
