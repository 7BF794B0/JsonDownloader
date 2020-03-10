using System;

namespace JsonDownloader.Exceptions
{
    class RuntimeException : Exception
    {
        public RuntimeException(string message) : base(message) { }
    }
}
