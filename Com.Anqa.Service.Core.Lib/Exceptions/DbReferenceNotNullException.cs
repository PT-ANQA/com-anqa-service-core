﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Core.Lib.Exceptions
{
    class DbReferenceNotNullException : Exception
    {
        public DbReferenceNotNullException()
        {
        }

        public DbReferenceNotNullException(string message) : base(message)
        {
        }
    }
}
