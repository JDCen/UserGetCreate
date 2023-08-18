using System.Text.Json;
using UserGetCreate.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Net.Http;
using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;

namespace HttpClienteConsola
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://localhost:7170/api/users";
            var jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            using (var httpClient = new HttpClient())
            {

                //Puede cambiar los input según corresponda
                var user3 = new Users() { UserName = "usuario1", Email = "usuario1@example.com", Password = "contraseña1" };
                var response = await httpClient.PostAsJsonAsync(url, user3);


                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    var apiErrors = Utilities.ExtraerErroresDelWebAPI(body);

                    foreach (var errorText in apiErrors)
                    {
                        Console.WriteLine($"-{errorText.Key}");
                        foreach (var error in errorText.Value)
                        {
                            Console.WriteLine($"  {error}");
                        }
                    }

                }

                var users = JsonSerializer.Deserialize<List<Users>>(
                await httpClient.GetStringAsync(url), jsonSerializerOptions);

                //using var respuesta = await httpClient.GetAsync(url);

                //switch (response.StatusCode)
                //{
                //    case System.Net.HttpStatusCode.Continue:
                //        break;
                //    case System.Net.HttpStatusCode.SwitchingProtocols:
                //        break;
                //    case System.Net.HttpStatusCode.Processing:
                //        break;
                //    case System.Net.HttpStatusCode.EarlyHints:
                //        break;
                //    case System.Net.HttpStatusCode.OK:
                //        var respuestaString = await response.Content.ReadAsStringAsync();
                //        var respuestaString2 = await httpClient.GetStringAsync(url);
                //        var listadoPersonas = JsonSerializer.Deserialize<List<Users>>(respuestaString,
                //            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                //        break;
                //    case System.Net.HttpStatusCode.Created:
                //        break;
                //    case System.Net.HttpStatusCode.Accepted:
                //        break;
                //    case System.Net.HttpStatusCode.NonAuthoritativeInformation:
                //        break;
                //    case System.Net.HttpStatusCode.NoContent:
                //        break;
                //    case System.Net.HttpStatusCode.ResetContent:
                //        break;
                //    case System.Net.HttpStatusCode.PartialContent:
                //        break;
                //    case System.Net.HttpStatusCode.MultiStatus:
                //        break;
                //    case System.Net.HttpStatusCode.AlreadyReported:
                //        break;
                //    case System.Net.HttpStatusCode.IMUsed:
                //        break;
                //    case System.Net.HttpStatusCode.Ambiguous:
                //        break;
                //    case System.Net.HttpStatusCode.Moved:
                //        break;
                //    case System.Net.HttpStatusCode.Found:
                //        break;
                //    case System.Net.HttpStatusCode.RedirectMethod:
                //        break;
                //    case System.Net.HttpStatusCode.NotModified:
                //        break;
                //    case System.Net.HttpStatusCode.UseProxy:
                //        break;
                //    case System.Net.HttpStatusCode.Unused:
                //        break;
                //    case System.Net.HttpStatusCode.RedirectKeepVerb:
                //        break;
                //    case System.Net.HttpStatusCode.PermanentRedirect:
                //        break;
                //    case System.Net.HttpStatusCode.BadRequest:
                //        break;
                //    case System.Net.HttpStatusCode.Unauthorized:
                //        break;
                //    case System.Net.HttpStatusCode.PaymentRequired:
                //        break;
                //    case System.Net.HttpStatusCode.Forbidden:
                //        break;
                //    case System.Net.HttpStatusCode.NotFound:
                //        Console.WriteLine("Recurso no encontrado");
                //        break;
                //    case System.Net.HttpStatusCode.MethodNotAllowed:
                //        break;
                //    case System.Net.HttpStatusCode.NotAcceptable:
                //        break;
                //    case System.Net.HttpStatusCode.ProxyAuthenticationRequired:
                //        break;
                //    case System.Net.HttpStatusCode.RequestTimeout:
                //        break;
                //    case System.Net.HttpStatusCode.Conflict:
                //        break;
                //    case System.Net.HttpStatusCode.Gone:
                //        break;
                //    case System.Net.HttpStatusCode.LengthRequired:
                //        break;
                //    case System.Net.HttpStatusCode.PreconditionFailed:
                //        break;
                //    case System.Net.HttpStatusCode.RequestEntityTooLarge:
                //        break;
                //    case System.Net.HttpStatusCode.RequestUriTooLong:
                //        break;
                //    case System.Net.HttpStatusCode.UnsupportedMediaType:
                //        break;
                //    case System.Net.HttpStatusCode.RequestedRangeNotSatisfiable:
                //        break;
                //    case System.Net.HttpStatusCode.ExpectationFailed:
                //        break;
                //    case System.Net.HttpStatusCode.MisdirectedRequest:
                //        break;
                //    case System.Net.HttpStatusCode.UnprocessableEntity:
                //        break;
                //    case System.Net.HttpStatusCode.Locked:
                //        break;
                //    case System.Net.HttpStatusCode.FailedDependency:
                //        break;
                //    case System.Net.HttpStatusCode.UpgradeRequired:
                //        break;
                //    case System.Net.HttpStatusCode.PreconditionRequired:
                //        break;
                //    case System.Net.HttpStatusCode.TooManyRequests:
                //        break;
                //    case System.Net.HttpStatusCode.RequestHeaderFieldsTooLarge:
                //        break;
                //    case System.Net.HttpStatusCode.UnavailableForLegalReasons:
                //        break;
                //    case System.Net.HttpStatusCode.InternalServerError:
                //        break;
                //    case System.Net.HttpStatusCode.NotImplemented:
                //        break;
                //    case System.Net.HttpStatusCode.BadGateway:
                //        break;
                //    case System.Net.HttpStatusCode.ServiceUnavailable:
                //        break;
                //    case System.Net.HttpStatusCode.GatewayTimeout:
                //        break;
                //    case System.Net.HttpStatusCode.HttpVersionNotSupported:
                //        break;
                //    case System.Net.HttpStatusCode.VariantAlsoNegotiates:
                //        break;
                //    case System.Net.HttpStatusCode.InsufficientStorage:
                //        break;
                //    case System.Net.HttpStatusCode.LoopDetected:
                //        break;
                //    case System.Net.HttpStatusCode.NotExtended:
                //        break;
                //    case System.Net.HttpStatusCode.NetworkAuthenticationRequired:
                //        break;
                //    default:
                //        break;
                //}

            }




        }

    }
}