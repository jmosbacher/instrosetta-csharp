// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: instrosetta/interfaces/electronics/simple_switch.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Instrosetta.Interfaces.Electronics.SimpleSwitch.V1 {
  public static partial class SimpleSwitch
  {
    static readonly string __ServiceName = "instrosetta.interfaces.electronics.simple_switch.v1.SimpleSwitch";

    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_InitializeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_InitializeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_ShutdownRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_ShutdownResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_FlipRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_FlipResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_GetStateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_GetStateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_SetStateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse> __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_SetStateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse> __Method_Initialize = new grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Initialize",
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_InitializeRequest,
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_InitializeResponse);

    static readonly grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse> __Method_Shutdown = new grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Shutdown",
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_ShutdownRequest,
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_ShutdownResponse);

    static readonly grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse> __Method_Flip = new grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Flip",
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_FlipRequest,
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_FlipResponse);

    static readonly grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse> __Method_GetState = new grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetState",
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_GetStateRequest,
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_GetStateResponse);

    static readonly grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse> __Method_SetState = new grpc::Method<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetState",
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_SetStateRequest,
        __Marshaller_instrosetta_interfaces_electronics_simple_switch_v1_SetStateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SimpleSwitchReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SimpleSwitch</summary>
    public abstract partial class SimpleSwitchBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse> Initialize(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse> Shutdown(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse> Flip(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse> GetState(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse> SetState(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SimpleSwitch</summary>
    public partial class SimpleSwitchClient : grpc::ClientBase<SimpleSwitchClient>
    {
      /// <summary>Creates a new client for SimpleSwitch</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SimpleSwitchClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SimpleSwitch that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SimpleSwitchClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SimpleSwitchClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SimpleSwitchClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse Initialize(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Initialize(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse Initialize(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Initialize, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse> InitializeAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InitializeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse> InitializeAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Initialize, null, options, request);
      }
      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse Shutdown(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Shutdown(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse Shutdown(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Shutdown, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse> ShutdownAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ShutdownAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse> ShutdownAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Shutdown, null, options, request);
      }
      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse Flip(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Flip(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse Flip(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Flip, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse> FlipAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FlipAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse> FlipAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Flip, null, options, request);
      }
      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse GetState(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetState(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse GetState(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetState, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse> GetStateAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse> GetStateAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetState, null, options, request);
      }
      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse SetState(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetState(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse SetState(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetState, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse> SetStateAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetStateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse> SetStateAsync(global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetState, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SimpleSwitchClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SimpleSwitchClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SimpleSwitchBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Initialize, serviceImpl.Initialize)
          .AddMethod(__Method_Shutdown, serviceImpl.Shutdown)
          .AddMethod(__Method_Flip, serviceImpl.Flip)
          .AddMethod(__Method_GetState, serviceImpl.GetState)
          .AddMethod(__Method_SetState, serviceImpl.SetState).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SimpleSwitchBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Initialize, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.InitializeResponse>(serviceImpl.Initialize));
      serviceBinder.AddMethod(__Method_Shutdown, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.ShutdownResponse>(serviceImpl.Shutdown));
      serviceBinder.AddMethod(__Method_Flip, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.FlipResponse>(serviceImpl.Flip));
      serviceBinder.AddMethod(__Method_GetState, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.GetStateResponse>(serviceImpl.GetState));
      serviceBinder.AddMethod(__Method_SetState, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateRequest, global::Instrosetta.Interfaces.Electronics.SimpleSwitch.V1.SetStateResponse>(serviceImpl.SetState));
    }

  }
}
#endregion
