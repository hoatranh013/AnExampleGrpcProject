// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/production.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServiceApplication {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Productioner
  {
    static readonly string __ServiceName = "production.Productioner";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServiceApplication.ProductionRequest> __Marshaller_production_ProductionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceApplication.ProductionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServiceApplication.ProductionResponse> __Marshaller_production_ProductionResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceApplication.ProductionResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServiceApplication.NullRequest> __Marshaller_production_NullRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceApplication.NullRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse> __Method_CreateProduct = new grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateProduct",
        __Marshaller_production_ProductionRequest,
        __Marshaller_production_ProductionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse> __Method_UpdateProduct = new grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProduct",
        __Marshaller_production_ProductionRequest,
        __Marshaller_production_ProductionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse> __Method_DeleteProduct = new grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteProduct",
        __Marshaller_production_ProductionRequest,
        __Marshaller_production_ProductionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse> __Method_GetProduct = new grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProduct",
        __Marshaller_production_ProductionRequest,
        __Marshaller_production_ProductionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceApplication.NullRequest, global::GrpcServiceApplication.ProductionResponse> __Method_GetProductByAll = new grpc::Method<global::GrpcServiceApplication.NullRequest, global::GrpcServiceApplication.ProductionResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetProductByAll",
        __Marshaller_production_NullRequest,
        __Marshaller_production_ProductionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse> __Method_CreateProductBatch = new grpc::Method<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "CreateProductBatch",
        __Marshaller_production_ProductionRequest,
        __Marshaller_production_ProductionResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServiceApplication.ProductionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Productioner</summary>
    [grpc::BindServiceMethod(typeof(Productioner), "BindService")]
    public abstract partial class ProductionerBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServiceApplication.ProductionResponse> CreateProduct(global::GrpcServiceApplication.ProductionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServiceApplication.ProductionResponse> UpdateProduct(global::GrpcServiceApplication.ProductionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServiceApplication.ProductionResponse> DeleteProduct(global::GrpcServiceApplication.ProductionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServiceApplication.ProductionResponse> GetProduct(global::GrpcServiceApplication.ProductionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetProductByAll(global::GrpcServiceApplication.NullRequest request, grpc::IServerStreamWriter<global::GrpcServiceApplication.ProductionResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServiceApplication.ProductionResponse> CreateProductBatch(grpc::IAsyncStreamReader<global::GrpcServiceApplication.ProductionRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductionerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateProduct, serviceImpl.CreateProduct)
          .AddMethod(__Method_UpdateProduct, serviceImpl.UpdateProduct)
          .AddMethod(__Method_DeleteProduct, serviceImpl.DeleteProduct)
          .AddMethod(__Method_GetProduct, serviceImpl.GetProduct)
          .AddMethod(__Method_GetProductByAll, serviceImpl.GetProductByAll)
          .AddMethod(__Method_CreateProductBatch, serviceImpl.CreateProductBatch).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductionerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(serviceImpl.CreateProduct));
      serviceBinder.AddMethod(__Method_UpdateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(serviceImpl.UpdateProduct));
      serviceBinder.AddMethod(__Method_DeleteProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(serviceImpl.DeleteProduct));
      serviceBinder.AddMethod(__Method_GetProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(serviceImpl.GetProduct));
      serviceBinder.AddMethod(__Method_GetProductByAll, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcServiceApplication.NullRequest, global::GrpcServiceApplication.ProductionResponse>(serviceImpl.GetProductByAll));
      serviceBinder.AddMethod(__Method_CreateProductBatch, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::GrpcServiceApplication.ProductionRequest, global::GrpcServiceApplication.ProductionResponse>(serviceImpl.CreateProductBatch));
    }

  }
}
#endregion
