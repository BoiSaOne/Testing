using System.Text.Json.Serialization;

namespace Web.Testing.ViewModels
{
    public class AuthViewModel<T>
    {
        public T? Data { get; set; }
        public string? MessageError { get; set; }
        public bool Success { get; set; }
    }
}
