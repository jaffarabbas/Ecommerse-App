﻿namespace CustomMiddlewareCollection.GlobalExceptionHandler.Exceptions
{
    public class UnAuthorizedAccessException : Exception
    {
        public UnAuthorizedAccessException(string msg) : base(msg) { }
    }
}
