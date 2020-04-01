using JsonDownloader.Interfaces;

namespace JsonDownloader.Entities
{
    class StatusCodeImplementation : IStatusCode
    {
        public int Code { get; private set; }

        public StatusCodeImplementation(int code)
        {
            Code = code;
        }

        public int GetStatusCode()
        {
            return Code;
        }
    }
}
