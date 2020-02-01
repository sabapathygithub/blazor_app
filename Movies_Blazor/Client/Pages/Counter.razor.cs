using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Movies_Blazor.Client.Shared.MainLayout;

namespace Movies_Blazor.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [Inject]
        public SingletonService Singleton { get; set; }
        [Inject]
        public TransientService Transient { get; set; }
        [Inject]
        public IJSRuntime JS { get; set; }
        [CascadingParameter]
        public AppState AppState { get; set; }

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            Singleton.Value++;
            Transient.Value++;
            currentCountStatic++;
            await JS.InvokeVoidAsync("dotnetStaticInvocation");
        }

        public async Task IncrementCountJavaScript()
        {
            await JS.InvokeVoidAsync("dotnetInstanceInvocation",
                DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
