using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClienteConsola
{
    public class Utilities
    {
        public static Dictionary<string, List<string>> ExtraerErroresDelWebAPI(string json)
        {
            var response = new Dictionary<string, List<string>>();

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
            var errorsJsonElement = jsonElement.GetProperty("errors");
            foreach (var campoConErrores in errorsJsonElement.EnumerateObject())
            {
                var campo = campoConErrores.Name;
                var errores = new List<string>();
                foreach (var errorKind in campoConErrores.Value.EnumerateArray())
                {
                    var error = errorKind.GetString();
                    errores.Add(error);
                }
                response.Add(campo, errores);
            }

            return response;
        }
    }
}
