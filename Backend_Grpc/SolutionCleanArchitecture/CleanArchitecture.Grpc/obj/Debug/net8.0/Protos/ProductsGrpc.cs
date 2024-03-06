// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/products.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CleanArchitecture.Grpc {
  public static partial class ProductsService
  {
    static readonly string __ServiceName = "products.ProductsService";

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
    static readonly grpc::Marshaller<global::CleanArchitecture.Grpc.Empty> __Marshaller_products_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CleanArchitecture.Grpc.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CleanArchitecture.Grpc.Products> __Marshaller_products_Products = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CleanArchitecture.Grpc.Products.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CleanArchitecture.Grpc.ProductRowIdFilter> __Marshaller_products_ProductRowIdFilter = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CleanArchitecture.Grpc.ProductRowIdFilter.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::CleanArchitecture.Grpc.Product> __Marshaller_products_Product = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::CleanArchitecture.Grpc.Product.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CleanArchitecture.Grpc.Empty, global::CleanArchitecture.Grpc.Products> __Method_GetAll = new grpc::Method<global::CleanArchitecture.Grpc.Empty, global::CleanArchitecture.Grpc.Products>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_products_Empty,
        __Marshaller_products_Products);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CleanArchitecture.Grpc.ProductRowIdFilter, global::CleanArchitecture.Grpc.Product> __Method_GetById = new grpc::Method<global::CleanArchitecture.Grpc.ProductRowIdFilter, global::CleanArchitecture.Grpc.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetById",
        __Marshaller_products_ProductRowIdFilter,
        __Marshaller_products_Product);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CleanArchitecture.Grpc.Product, global::CleanArchitecture.Grpc.Product> __Method_Post = new grpc::Method<global::CleanArchitecture.Grpc.Product, global::CleanArchitecture.Grpc.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Post",
        __Marshaller_products_Product,
        __Marshaller_products_Product);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CleanArchitecture.Grpc.Product, global::CleanArchitecture.Grpc.Empty> __Method_Put = new grpc::Method<global::CleanArchitecture.Grpc.Product, global::CleanArchitecture.Grpc.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Put",
        __Marshaller_products_Product,
        __Marshaller_products_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::CleanArchitecture.Grpc.ProductRowIdFilter, global::CleanArchitecture.Grpc.Empty> __Method_Delete = new grpc::Method<global::CleanArchitecture.Grpc.ProductRowIdFilter, global::CleanArchitecture.Grpc.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_products_ProductRowIdFilter,
        __Marshaller_products_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CleanArchitecture.Grpc.ProductsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductsService</summary>
    [grpc::BindServiceMethod(typeof(ProductsService), "BindService")]
    public abstract partial class ProductsServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CleanArchitecture.Grpc.Products> GetAll(global::CleanArchitecture.Grpc.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CleanArchitecture.Grpc.Product> GetById(global::CleanArchitecture.Grpc.ProductRowIdFilter request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CleanArchitecture.Grpc.Product> Post(global::CleanArchitecture.Grpc.Product request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CleanArchitecture.Grpc.Empty> Put(global::CleanArchitecture.Grpc.Product request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::CleanArchitecture.Grpc.Empty> Delete(global::CleanArchitecture.Grpc.ProductRowIdFilter request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_GetById, serviceImpl.GetById)
          .AddMethod(__Method_Post, serviceImpl.Post)
          .AddMethod(__Method_Put, serviceImpl.Put)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CleanArchitecture.Grpc.Empty, global::CleanArchitecture.Grpc.Products>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_GetById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CleanArchitecture.Grpc.ProductRowIdFilter, global::CleanArchitecture.Grpc.Product>(serviceImpl.GetById));
      serviceBinder.AddMethod(__Method_Post, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CleanArchitecture.Grpc.Product, global::CleanArchitecture.Grpc.Product>(serviceImpl.Post));
      serviceBinder.AddMethod(__Method_Put, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CleanArchitecture.Grpc.Product, global::CleanArchitecture.Grpc.Empty>(serviceImpl.Put));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CleanArchitecture.Grpc.ProductRowIdFilter, global::CleanArchitecture.Grpc.Empty>(serviceImpl.Delete));
    }

  }
}
#endregion
