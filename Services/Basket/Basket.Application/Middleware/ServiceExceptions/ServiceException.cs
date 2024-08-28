﻿using Basket.Application.Middleware.ServiceExceptions;

namespace Basket.Application.Middleware.Exceptions
{
    public class ServiceException : Exception
    {
        public ServiceErrorType Type { get; set; }

        public ServiceException(ServiceErrorType type)
        {
            Type = type;
        }

        public ServiceException(ServiceErrorType type, string? message) : base(message)
        {
            Type = type;
        }

        public ServiceException(ServiceErrorType type, string? message, Exception? innerException) : base(message, innerException)
        {
            Type = type;
        }
    }
}
