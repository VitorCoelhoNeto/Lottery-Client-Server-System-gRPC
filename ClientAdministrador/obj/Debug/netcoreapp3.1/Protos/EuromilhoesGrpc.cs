// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/euromilhoes.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Server {
  public static partial class Euromilhoes
  {
    static readonly string __ServiceName = "Euromilhoes";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::Server.PedidoAposta> __Marshaller_PedidoAposta = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.PedidoAposta.Parser));
    static readonly grpc::Marshaller<global::Server.ResultadoPedido> __Marshaller_ResultadoPedido = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.ResultadoPedido.Parser));
    static readonly grpc::Marshaller<global::Server.PedidoListarApostas> __Marshaller_PedidoListarApostas = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.PedidoListarApostas.Parser));
    static readonly grpc::Marshaller<global::Server.ListaDeApostas> __Marshaller_ListaDeApostas = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.ListaDeApostas.Parser));
    static readonly grpc::Marshaller<global::Server.PedidoListarUtilizadores> __Marshaller_PedidoListarUtilizadores = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.PedidoListarUtilizadores.Parser));
    static readonly grpc::Marshaller<global::Server.ListaUtilizadores> __Marshaller_ListaUtilizadores = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.ListaUtilizadores.Parser));
    static readonly grpc::Marshaller<global::Server.PedidoArquivarApostas> __Marshaller_PedidoArquivarApostas = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.PedidoArquivarApostas.Parser));
    static readonly grpc::Marshaller<global::Server.PedidoSubmeterChaveVencedora> __Marshaller_PedidoSubmeterChaveVencedora = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.PedidoSubmeterChaveVencedora.Parser));
    static readonly grpc::Marshaller<global::Server.PedidoListarApostasVencedoras> __Marshaller_PedidoListarApostasVencedoras = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.PedidoListarApostasVencedoras.Parser));
    static readonly grpc::Marshaller<global::Server.ResultadoListarApostasVencedoras> __Marshaller_ResultadoListarApostasVencedoras = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.ResultadoListarApostasVencedoras.Parser));

    static readonly grpc::Method<global::Server.PedidoAposta, global::Server.ResultadoPedido> __Method_RegistarAposta = new grpc::Method<global::Server.PedidoAposta, global::Server.ResultadoPedido>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegistarAposta",
        __Marshaller_PedidoAposta,
        __Marshaller_ResultadoPedido);

    static readonly grpc::Method<global::Server.PedidoListarApostas, global::Server.ListaDeApostas> __Method_ListarApostas = new grpc::Method<global::Server.PedidoListarApostas, global::Server.ListaDeApostas>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListarApostas",
        __Marshaller_PedidoListarApostas,
        __Marshaller_ListaDeApostas);

    static readonly grpc::Method<global::Server.PedidoListarUtilizadores, global::Server.ListaUtilizadores> __Method_ListarUtilizadores = new grpc::Method<global::Server.PedidoListarUtilizadores, global::Server.ListaUtilizadores>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListarUtilizadores",
        __Marshaller_PedidoListarUtilizadores,
        __Marshaller_ListaUtilizadores);

    static readonly grpc::Method<global::Server.PedidoArquivarApostas, global::Server.ResultadoPedido> __Method_ArquivarApostas = new grpc::Method<global::Server.PedidoArquivarApostas, global::Server.ResultadoPedido>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ArquivarApostas",
        __Marshaller_PedidoArquivarApostas,
        __Marshaller_ResultadoPedido);

    static readonly grpc::Method<global::Server.PedidoSubmeterChaveVencedora, global::Server.ResultadoPedido> __Method_SubmeterChaveVencedora = new grpc::Method<global::Server.PedidoSubmeterChaveVencedora, global::Server.ResultadoPedido>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmeterChaveVencedora",
        __Marshaller_PedidoSubmeterChaveVencedora,
        __Marshaller_ResultadoPedido);

    static readonly grpc::Method<global::Server.PedidoListarApostasVencedoras, global::Server.ResultadoListarApostasVencedoras> __Method_ListarApostasVencedoras = new grpc::Method<global::Server.PedidoListarApostasVencedoras, global::Server.ResultadoListarApostasVencedoras>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListarApostasVencedoras",
        __Marshaller_PedidoListarApostasVencedoras,
        __Marshaller_ResultadoListarApostasVencedoras);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Server.EuromilhoesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Euromilhoes</summary>
    public partial class EuromilhoesClient : grpc::ClientBase<EuromilhoesClient>
    {
      /// <summary>Creates a new client for Euromilhoes</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public EuromilhoesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Euromilhoes that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public EuromilhoesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected EuromilhoesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected EuromilhoesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Server.ResultadoPedido RegistarAposta(global::Server.PedidoAposta request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegistarAposta(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Server.ResultadoPedido RegistarAposta(global::Server.PedidoAposta request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RegistarAposta, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ResultadoPedido> RegistarApostaAsync(global::Server.PedidoAposta request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegistarApostaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ResultadoPedido> RegistarApostaAsync(global::Server.PedidoAposta request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RegistarAposta, null, options, request);
      }
      public virtual global::Server.ListaDeApostas ListarApostas(global::Server.PedidoListarApostas request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListarApostas(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Server.ListaDeApostas ListarApostas(global::Server.PedidoListarApostas request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListarApostas, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ListaDeApostas> ListarApostasAsync(global::Server.PedidoListarApostas request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListarApostasAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ListaDeApostas> ListarApostasAsync(global::Server.PedidoListarApostas request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListarApostas, null, options, request);
      }
      public virtual global::Server.ListaUtilizadores ListarUtilizadores(global::Server.PedidoListarUtilizadores request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListarUtilizadores(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Server.ListaUtilizadores ListarUtilizadores(global::Server.PedidoListarUtilizadores request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListarUtilizadores, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ListaUtilizadores> ListarUtilizadoresAsync(global::Server.PedidoListarUtilizadores request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListarUtilizadoresAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ListaUtilizadores> ListarUtilizadoresAsync(global::Server.PedidoListarUtilizadores request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListarUtilizadores, null, options, request);
      }
      public virtual global::Server.ResultadoPedido ArquivarApostas(global::Server.PedidoArquivarApostas request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ArquivarApostas(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Server.ResultadoPedido ArquivarApostas(global::Server.PedidoArquivarApostas request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ArquivarApostas, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ResultadoPedido> ArquivarApostasAsync(global::Server.PedidoArquivarApostas request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ArquivarApostasAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ResultadoPedido> ArquivarApostasAsync(global::Server.PedidoArquivarApostas request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ArquivarApostas, null, options, request);
      }
      public virtual global::Server.ResultadoPedido SubmeterChaveVencedora(global::Server.PedidoSubmeterChaveVencedora request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmeterChaveVencedora(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Server.ResultadoPedido SubmeterChaveVencedora(global::Server.PedidoSubmeterChaveVencedora request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmeterChaveVencedora, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ResultadoPedido> SubmeterChaveVencedoraAsync(global::Server.PedidoSubmeterChaveVencedora request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmeterChaveVencedoraAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ResultadoPedido> SubmeterChaveVencedoraAsync(global::Server.PedidoSubmeterChaveVencedora request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmeterChaveVencedora, null, options, request);
      }
      public virtual global::Server.ResultadoListarApostasVencedoras ListarApostasVencedoras(global::Server.PedidoListarApostasVencedoras request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListarApostasVencedoras(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Server.ResultadoListarApostasVencedoras ListarApostasVencedoras(global::Server.PedidoListarApostasVencedoras request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListarApostasVencedoras, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ResultadoListarApostasVencedoras> ListarApostasVencedorasAsync(global::Server.PedidoListarApostasVencedoras request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListarApostasVencedorasAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ResultadoListarApostasVencedoras> ListarApostasVencedorasAsync(global::Server.PedidoListarApostasVencedoras request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListarApostasVencedoras, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override EuromilhoesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new EuromilhoesClient(configuration);
      }
    }

  }
}
#endregion
