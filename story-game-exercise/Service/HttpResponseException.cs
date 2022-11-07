using System.Net;
using System.Runtime.Serialization;

namespace story_game_exercise.Service
{
    // FINISH FROM ARTTICLE
    // https://learn.microsoft.com/cs-cz/aspnet/web-api/overview/error-handling/exception-handling

    [Serializable]
    internal class HttpResponseException : Exception
    {
        private HttpStatusCode notFound;

        public HttpResponseException()
        {
        }

        public HttpResponseException(HttpStatusCode notFound)
        {
            this.notFound = notFound;
        }

        public HttpResponseException(string? message) : base(message)
        {
        }

        public HttpResponseException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected HttpResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}