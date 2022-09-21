// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/calculators/core/packet_cloner_calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/calculators/core/packet_cloner_calculator.proto</summary>
  public static partial class PacketClonerCalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/calculators/core/packet_cloner_calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PacketClonerCalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjltZWRpYXBpcGUvY2FsY3VsYXRvcnMvY29yZS9wYWNrZXRfY2xvbmVyX2Nh",
            "bGN1bGF0b3IucHJvdG8SCW1lZGlhcGlwZRokbWVkaWFwaXBlL2ZyYW1ld29y",
            "ay9jYWxjdWxhdG9yLnByb3RvIukBCh1QYWNrZXRDbG9uZXJDYWxjdWxhdG9y",
            "T3B0aW9ucxIzCiRvdXRwdXRfb25seV93aGVuX2FsbF9pbnB1dHNfcmVjZWl2",
            "ZWQYASABKAg6BWZhbHNlEjsKLG91dHB1dF9wYWNrZXRzX29ubHlfd2hlbl9h",
            "bGxfaW5wdXRzX3JlY2VpdmVkGAIgASgIOgVmYWxzZTJWCgNleHQSHC5tZWRp",
            "YXBpcGUuQ2FsY3VsYXRvck9wdGlvbnMYlaa4eyABKAsyKC5tZWRpYXBpcGUu",
            "UGFja2V0Q2xvbmVyQ2FsY3VsYXRvck9wdGlvbnNCDKICCU1lZGlhUGlwZQ=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.PacketClonerCalculatorOptions), global::Mediapipe.PacketClonerCalculatorOptions.Parser, new[]{ "OutputOnlyWhenAllInputsReceived", "OutputPacketsOnlyWhenAllInputsReceived" }, null, null, new pb::Extension[] { global::Mediapipe.PacketClonerCalculatorOptions.Extensions.Ext }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PacketClonerCalculatorOptions : pb::IMessage<PacketClonerCalculatorOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PacketClonerCalculatorOptions> _parser = new pb::MessageParser<PacketClonerCalculatorOptions>(() => new PacketClonerCalculatorOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PacketClonerCalculatorOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.PacketClonerCalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PacketClonerCalculatorOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PacketClonerCalculatorOptions(PacketClonerCalculatorOptions other) : this() {
      _hasBits0 = other._hasBits0;
      outputOnlyWhenAllInputsReceived_ = other.outputOnlyWhenAllInputsReceived_;
      outputPacketsOnlyWhenAllInputsReceived_ = other.outputPacketsOnlyWhenAllInputsReceived_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PacketClonerCalculatorOptions Clone() {
      return new PacketClonerCalculatorOptions(this);
    }

    /// <summary>Field number for the "output_only_when_all_inputs_received" field.</summary>
    public const int OutputOnlyWhenAllInputsReceivedFieldNumber = 1;
    private readonly static bool OutputOnlyWhenAllInputsReceivedDefaultValue = false;

    private bool outputOnlyWhenAllInputsReceived_;
    /// <summary>
    /// When true, this calculator will drop received TICK packets if any input
    /// stream hasn't received a packet yet.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OutputOnlyWhenAllInputsReceived {
      get { if ((_hasBits0 & 1) != 0) { return outputOnlyWhenAllInputsReceived_; } else { return OutputOnlyWhenAllInputsReceivedDefaultValue; } }
      set {
        _hasBits0 |= 1;
        outputOnlyWhenAllInputsReceived_ = value;
      }
    }
    /// <summary>Gets whether the "output_only_when_all_inputs_received" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOutputOnlyWhenAllInputsReceived {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "output_only_when_all_inputs_received" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOutputOnlyWhenAllInputsReceived() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "output_packets_only_when_all_inputs_received" field.</summary>
    public const int OutputPacketsOnlyWhenAllInputsReceivedFieldNumber = 2;
    private readonly static bool OutputPacketsOnlyWhenAllInputsReceivedDefaultValue = false;

    private bool outputPacketsOnlyWhenAllInputsReceived_;
    /// <summary>
    /// Similar with above, but also transmit empty packet for all streams before
    /// all inputs are received.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OutputPacketsOnlyWhenAllInputsReceived {
      get { if ((_hasBits0 & 2) != 0) { return outputPacketsOnlyWhenAllInputsReceived_; } else { return OutputPacketsOnlyWhenAllInputsReceivedDefaultValue; } }
      set {
        _hasBits0 |= 2;
        outputPacketsOnlyWhenAllInputsReceived_ = value;
      }
    }
    /// <summary>Gets whether the "output_packets_only_when_all_inputs_received" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOutputPacketsOnlyWhenAllInputsReceived {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "output_packets_only_when_all_inputs_received" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOutputPacketsOnlyWhenAllInputsReceived() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PacketClonerCalculatorOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PacketClonerCalculatorOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OutputOnlyWhenAllInputsReceived != other.OutputOnlyWhenAllInputsReceived) return false;
      if (OutputPacketsOnlyWhenAllInputsReceived != other.OutputPacketsOnlyWhenAllInputsReceived) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasOutputOnlyWhenAllInputsReceived) hash ^= OutputOnlyWhenAllInputsReceived.GetHashCode();
      if (HasOutputPacketsOnlyWhenAllInputsReceived) hash ^= OutputPacketsOnlyWhenAllInputsReceived.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasOutputOnlyWhenAllInputsReceived) {
        output.WriteRawTag(8);
        output.WriteBool(OutputOnlyWhenAllInputsReceived);
      }
      if (HasOutputPacketsOnlyWhenAllInputsReceived) {
        output.WriteRawTag(16);
        output.WriteBool(OutputPacketsOnlyWhenAllInputsReceived);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasOutputOnlyWhenAllInputsReceived) {
        output.WriteRawTag(8);
        output.WriteBool(OutputOnlyWhenAllInputsReceived);
      }
      if (HasOutputPacketsOnlyWhenAllInputsReceived) {
        output.WriteRawTag(16);
        output.WriteBool(OutputPacketsOnlyWhenAllInputsReceived);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasOutputOnlyWhenAllInputsReceived) {
        size += 1 + 1;
      }
      if (HasOutputPacketsOnlyWhenAllInputsReceived) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PacketClonerCalculatorOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasOutputOnlyWhenAllInputsReceived) {
        OutputOnlyWhenAllInputsReceived = other.OutputOnlyWhenAllInputsReceived;
      }
      if (other.HasOutputPacketsOnlyWhenAllInputsReceived) {
        OutputPacketsOnlyWhenAllInputsReceived = other.OutputPacketsOnlyWhenAllInputsReceived;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            OutputOnlyWhenAllInputsReceived = input.ReadBool();
            break;
          }
          case 16: {
            OutputPacketsOnlyWhenAllInputsReceived = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            OutputOnlyWhenAllInputsReceived = input.ReadBool();
            break;
          }
          case 16: {
            OutputPacketsOnlyWhenAllInputsReceived = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the PacketClonerCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.PacketClonerCalculatorOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.PacketClonerCalculatorOptions>(258872085, pb::FieldCodec.ForMessage(2070976682, global::Mediapipe.PacketClonerCalculatorOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
