function my_function(message) {
    console.log("From utilities : " + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("Movies_Blazor.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript :" + result);
        });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}