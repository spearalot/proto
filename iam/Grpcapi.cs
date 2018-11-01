// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: iam/grpcapi.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SKF.Enlight.API.IAM {

  /// <summary>Holder for reflection information generated from iam/grpcapi.proto</summary>
  public static partial class GrpcapiReflection {

    #region Descriptor
    /// <summary>File descriptor for iam/grpcapi.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GrpcapiReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFpYW0vZ3JwY2FwaS5wcm90bxIHZ3JwY2FwaRoTY29tbW9uL2NvbW1vbi5w",
            "cm90byItChpHZXRIaWVyYXJjaHlSZWxhdGlvbnNJbnB1dBIPCgd1c2VyX2lk",
            "GAEgASgJIi8KG0dldEhpZXJhcmNoeVJlbGF0aW9uc091dHB1dBIQCghub2Rl",
            "X2lkcxgBIAMoCSI8ChhDaGVja0F1dGhlbnRpY2F0aW9uSW5wdXQSDQoFdG9r",
            "ZW4YASABKAkSEQoJbWV0aG9kQXJuGAIgASgJIkwKFEdldEV2ZW50UmVjb3Jk",
            "c0lucHV0Eg0KBXNpbmNlGAEgASgDEiUKBWxpbWl0GAIgASgLMhYuY29tbW9u",
            "LlByaW1pdGl2ZUludDMyIigKFUdldEV2ZW50UmVjb3Jkc091dHB1dBIPCgdy",
            "ZWNvcmRzGAEgASgMIoUBCgRVc2VyEgoKAmlkGAEgASgJEg0KBWVtYWlsGAIg",
            "ASgJEhYKDmV1bGFBZ3JlZWREYXRlGAMgASgJEhEKCXZhbGlkRXVsYRgEIAEo",
            "CRIQCgh1c2VybmFtZRgFIAEoCRISCgp1c2VyU3RhdHVzGAYgASgJEhEKCXVz",
            "ZXJSb2xlcxgHIAEoCTK/AgoDSUFNEjMKCERlZXBQaW5nEgwuY29tbW9uLlZv",
            "aWQaFy5jb21tb24uUHJpbWl0aXZlU3RyaW5nIgASSQoTQ2hlY2tBdXRoZW50",
            "aWNhdGlvbhIhLmdycGNhcGkuQ2hlY2tBdXRoZW50aWNhdGlvbklucHV0Gg0u",
            "Z3JwY2FwaS5Vc2VyIgASZAoVR2V0SGllcmFyY2h5UmVsYXRpb25zEiMuZ3Jw",
            "Y2FwaS5HZXRIaWVyYXJjaHlSZWxhdGlvbnNJbnB1dBokLmdycGNhcGkuR2V0",
            "SGllcmFyY2h5UmVsYXRpb25zT3V0cHV0IgASUgoPR2V0RXZlbnRSZWNvcmRz",
            "Eh0uZ3JwY2FwaS5HZXRFdmVudFJlY29yZHNJbnB1dBoeLmdycGNhcGkuR2V0",
            "RXZlbnRSZWNvcmRzT3V0cHV0IgBCFqoCE1NLRi5FbmxpZ2h0LkFQSS5JQU1i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::SKF.Enlight.API.Common.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput), global::SKF.Enlight.API.IAM.GetHierarchyRelationsInput.Parser, new[]{ "UserId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput), global::SKF.Enlight.API.IAM.GetHierarchyRelationsOutput.Parser, new[]{ "NodeIds" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SKF.Enlight.API.IAM.CheckAuthenticationInput), global::SKF.Enlight.API.IAM.CheckAuthenticationInput.Parser, new[]{ "Token", "MethodArn" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SKF.Enlight.API.IAM.GetEventRecordsInput), global::SKF.Enlight.API.IAM.GetEventRecordsInput.Parser, new[]{ "Since", "Limit" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SKF.Enlight.API.IAM.GetEventRecordsOutput), global::SKF.Enlight.API.IAM.GetEventRecordsOutput.Parser, new[]{ "Records" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SKF.Enlight.API.IAM.User), global::SKF.Enlight.API.IAM.User.Parser, new[]{ "Id", "Email", "EulaAgreedDate", "ValidEula", "Username", "UserStatus", "UserRoles" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Input &amp; output messages
  /// </summary>
  public sealed partial class GetHierarchyRelationsInput : pb::IMessage<GetHierarchyRelationsInput> {
    private static readonly pb::MessageParser<GetHierarchyRelationsInput> _parser = new pb::MessageParser<GetHierarchyRelationsInput>(() => new GetHierarchyRelationsInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetHierarchyRelationsInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SKF.Enlight.API.IAM.GrpcapiReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHierarchyRelationsInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHierarchyRelationsInput(GetHierarchyRelationsInput other) : this() {
      userId_ = other.userId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHierarchyRelationsInput Clone() {
      return new GetHierarchyRelationsInput(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetHierarchyRelationsInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetHierarchyRelationsInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetHierarchyRelationsInput other) {
      if (other == null) {
        return;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetHierarchyRelationsOutput : pb::IMessage<GetHierarchyRelationsOutput> {
    private static readonly pb::MessageParser<GetHierarchyRelationsOutput> _parser = new pb::MessageParser<GetHierarchyRelationsOutput>(() => new GetHierarchyRelationsOutput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetHierarchyRelationsOutput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SKF.Enlight.API.IAM.GrpcapiReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHierarchyRelationsOutput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHierarchyRelationsOutput(GetHierarchyRelationsOutput other) : this() {
      nodeIds_ = other.nodeIds_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHierarchyRelationsOutput Clone() {
      return new GetHierarchyRelationsOutput(this);
    }

    /// <summary>Field number for the "node_ids" field.</summary>
    public const int NodeIdsFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_nodeIds_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> nodeIds_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> NodeIds {
      get { return nodeIds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetHierarchyRelationsOutput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetHierarchyRelationsOutput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!nodeIds_.Equals(other.nodeIds_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= nodeIds_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      nodeIds_.WriteTo(output, _repeated_nodeIds_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += nodeIds_.CalculateSize(_repeated_nodeIds_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetHierarchyRelationsOutput other) {
      if (other == null) {
        return;
      }
      nodeIds_.Add(other.nodeIds_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            nodeIds_.AddEntriesFrom(input, _repeated_nodeIds_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CheckAuthenticationInput : pb::IMessage<CheckAuthenticationInput> {
    private static readonly pb::MessageParser<CheckAuthenticationInput> _parser = new pb::MessageParser<CheckAuthenticationInput>(() => new CheckAuthenticationInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CheckAuthenticationInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SKF.Enlight.API.IAM.GrpcapiReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckAuthenticationInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckAuthenticationInput(CheckAuthenticationInput other) : this() {
      token_ = other.token_;
      methodArn_ = other.methodArn_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckAuthenticationInput Clone() {
      return new CheckAuthenticationInput(this);
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 1;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "methodArn" field.</summary>
    public const int MethodArnFieldNumber = 2;
    private string methodArn_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MethodArn {
      get { return methodArn_; }
      set {
        methodArn_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CheckAuthenticationInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CheckAuthenticationInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Token != other.Token) return false;
      if (MethodArn != other.MethodArn) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (MethodArn.Length != 0) hash ^= MethodArn.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Token.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Token);
      }
      if (MethodArn.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MethodArn);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (MethodArn.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MethodArn);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CheckAuthenticationInput other) {
      if (other == null) {
        return;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.MethodArn.Length != 0) {
        MethodArn = other.MethodArn;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Token = input.ReadString();
            break;
          }
          case 18: {
            MethodArn = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetEventRecordsInput : pb::IMessage<GetEventRecordsInput> {
    private static readonly pb::MessageParser<GetEventRecordsInput> _parser = new pb::MessageParser<GetEventRecordsInput>(() => new GetEventRecordsInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetEventRecordsInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SKF.Enlight.API.IAM.GrpcapiReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEventRecordsInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEventRecordsInput(GetEventRecordsInput other) : this() {
      since_ = other.since_;
      limit_ = other.limit_ != null ? other.limit_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEventRecordsInput Clone() {
      return new GetEventRecordsInput(this);
    }

    /// <summary>Field number for the "since" field.</summary>
    public const int SinceFieldNumber = 1;
    private long since_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Since {
      get { return since_; }
      set {
        since_ = value;
      }
    }

    /// <summary>Field number for the "limit" field.</summary>
    public const int LimitFieldNumber = 2;
    private global::SKF.Enlight.API.Common.PrimitiveInt32 limit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::SKF.Enlight.API.Common.PrimitiveInt32 Limit {
      get { return limit_; }
      set {
        limit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetEventRecordsInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetEventRecordsInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Since != other.Since) return false;
      if (!object.Equals(Limit, other.Limit)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Since != 0L) hash ^= Since.GetHashCode();
      if (limit_ != null) hash ^= Limit.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Since != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Since);
      }
      if (limit_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Limit);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Since != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Since);
      }
      if (limit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Limit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetEventRecordsInput other) {
      if (other == null) {
        return;
      }
      if (other.Since != 0L) {
        Since = other.Since;
      }
      if (other.limit_ != null) {
        if (limit_ == null) {
          limit_ = new global::SKF.Enlight.API.Common.PrimitiveInt32();
        }
        Limit.MergeFrom(other.Limit);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Since = input.ReadInt64();
            break;
          }
          case 18: {
            if (limit_ == null) {
              limit_ = new global::SKF.Enlight.API.Common.PrimitiveInt32();
            }
            input.ReadMessage(limit_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetEventRecordsOutput : pb::IMessage<GetEventRecordsOutput> {
    private static readonly pb::MessageParser<GetEventRecordsOutput> _parser = new pb::MessageParser<GetEventRecordsOutput>(() => new GetEventRecordsOutput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetEventRecordsOutput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SKF.Enlight.API.IAM.GrpcapiReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEventRecordsOutput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEventRecordsOutput(GetEventRecordsOutput other) : this() {
      records_ = other.records_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEventRecordsOutput Clone() {
      return new GetEventRecordsOutput(this);
    }

    /// <summary>Field number for the "records" field.</summary>
    public const int RecordsFieldNumber = 1;
    private pb::ByteString records_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Records {
      get { return records_; }
      set {
        records_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetEventRecordsOutput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetEventRecordsOutput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Records != other.Records) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Records.Length != 0) hash ^= Records.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Records.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Records);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Records.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Records);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetEventRecordsOutput other) {
      if (other == null) {
        return;
      }
      if (other.Records.Length != 0) {
        Records = other.Records;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Records = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class User : pb::IMessage<User> {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SKF.Enlight.API.IAM.GrpcapiReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User(User other) : this() {
      id_ = other.id_;
      email_ = other.email_;
      eulaAgreedDate_ = other.eulaAgreedDate_;
      validEula_ = other.validEula_;
      username_ = other.username_;
      userStatus_ = other.userStatus_;
      userRoles_ = other.userRoles_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 2;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "eulaAgreedDate" field.</summary>
    public const int EulaAgreedDateFieldNumber = 3;
    private string eulaAgreedDate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EulaAgreedDate {
      get { return eulaAgreedDate_; }
      set {
        eulaAgreedDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "validEula" field.</summary>
    public const int ValidEulaFieldNumber = 4;
    private string validEula_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ValidEula {
      get { return validEula_; }
      set {
        validEula_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 5;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "userStatus" field.</summary>
    public const int UserStatusFieldNumber = 6;
    private string userStatus_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserStatus {
      get { return userStatus_; }
      set {
        userStatus_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "userRoles" field.</summary>
    public const int UserRolesFieldNumber = 7;
    private string userRoles_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserRoles {
      get { return userRoles_; }
      set {
        userRoles_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Email != other.Email) return false;
      if (EulaAgreedDate != other.EulaAgreedDate) return false;
      if (ValidEula != other.ValidEula) return false;
      if (Username != other.Username) return false;
      if (UserStatus != other.UserStatus) return false;
      if (UserRoles != other.UserRoles) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (EulaAgreedDate.Length != 0) hash ^= EulaAgreedDate.GetHashCode();
      if (ValidEula.Length != 0) hash ^= ValidEula.GetHashCode();
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (UserStatus.Length != 0) hash ^= UserStatus.GetHashCode();
      if (UserRoles.Length != 0) hash ^= UserRoles.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (EulaAgreedDate.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(EulaAgreedDate);
      }
      if (ValidEula.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ValidEula);
      }
      if (Username.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Username);
      }
      if (UserStatus.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(UserStatus);
      }
      if (UserRoles.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(UserRoles);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (EulaAgreedDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EulaAgreedDate);
      }
      if (ValidEula.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ValidEula);
      }
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (UserStatus.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserStatus);
      }
      if (UserRoles.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserRoles);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.EulaAgreedDate.Length != 0) {
        EulaAgreedDate = other.EulaAgreedDate;
      }
      if (other.ValidEula.Length != 0) {
        ValidEula = other.ValidEula;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.UserStatus.Length != 0) {
        UserStatus = other.UserStatus;
      }
      if (other.UserRoles.Length != 0) {
        UserRoles = other.UserRoles;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Email = input.ReadString();
            break;
          }
          case 26: {
            EulaAgreedDate = input.ReadString();
            break;
          }
          case 34: {
            ValidEula = input.ReadString();
            break;
          }
          case 42: {
            Username = input.ReadString();
            break;
          }
          case 50: {
            UserStatus = input.ReadString();
            break;
          }
          case 58: {
            UserRoles = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code