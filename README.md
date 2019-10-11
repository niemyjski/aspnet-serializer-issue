# aspnet-serializer-issue

## https://github.com/aspnet/AspNetCore/issues/14855

Post to controller with ` curl -d '{"organizationId":"value1", "scopes":["value2"]}' -H "Content-Type: application/json" -X POST http://localhost:5000/token`

```
System.InvalidCastException: Unable to cast object of type 'System.Collections.Generic.HashSet`1[System.String]' to type 'System.Collections.IList'.
   at System.Text.Json.JsonSerializer.ApplyObjectToEnumerable(Object value, ReadStack& state, Utf8JsonReader& reader, Boolean setPropertyDirectly)
   at System.Text.Json.JsonSerializer.HandleEndArray(JsonSerializerOptions options, Utf8JsonReader& reader, ReadStack& state)
   at System.Text.Json.JsonSerializer.ReadCore(JsonSerializerOptions options, Utf8JsonReader& reader, ReadStack& readStack)
   at System.Text.Json.JsonSerializer.ReadCore(JsonReaderState& readerState, Boolean isFinalBlock, ReadOnlySpan`1 buffer, JsonSerializerOptions options, ReadStack& readStack)
   at System.Text.Json.JsonSerializer.ReadAsync[TValue](Stream utf8Json, Type returnType, JsonSerializerOptions options, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter.ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
   at Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter.ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
   at Microsoft.AspNetCore.Mvc.ModelBinding.Binders.BodyModelBinder.BindModelAsync(ModelBindingContext bindingContext)
   at Microsoft.AspNetCore.Mvc.ModelBinding.ParameterBinder.BindModelAsync(ActionContext actionContext, IModelBinder modelBinder, IValueProvider valueProvider, ParameterDescriptor parameter, ModelMetadata metadata, Object value)
   at Microsoft.AspNetCore.Mvc.Controllers.ControllerBinderDelegateProvider.<>c__DisplayClass0_0.<<CreateBinderDelegate>g__Bind|0>d.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Logged|17_1(ResourceInvoker invoker)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware.Invoke(HttpContext context)

HEADERS
=======
Cache-Control: no-cache
Connection: keep-alive
Content-Type: application/json
Accept: */*
Accept-Encoding: gzip, deflate
Host: localhost:5000
Referer: http://localhost:5000/token
User-Agent: PostmanRuntime/7.17.1
Content-Length: 48
Postman-Token: 375ff808-cd03-4250-812f-229426d40ec8
```