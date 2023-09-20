using System.Text.Json.Serialization;

namespace Basket.Application.Dtos
{
    public abstract class BaseDto<T> where T : class
    {
        public BaseDto()
        {
            error = new Error();
        }

        public int page { get; set; }

        public int pageSize { get; set; }

        public int totalItems { get; set; }

        public int totalPages { get; set; }

        public Error error { get; set; }
    }

    public class Error
    {
        public Error()
        {
            message = string.Empty;
        }

        public string? message { get; set; }
    }
}
