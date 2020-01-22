using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_Blazor.Client.Helpers
{
    public static class IJSRuntimeHelper
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
            return await jSRuntime.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask LogMessage(this IJSRuntime js, string message)
        {
             await js.InvokeVoidAsync("my_function", message);
        }
    }
}
