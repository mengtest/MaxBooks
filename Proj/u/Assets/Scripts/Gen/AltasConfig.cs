// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gen/xls2proto/AltasConfig.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace X.Res {

  /// <summary>Holder for reflection information generated from gen/xls2proto/AltasConfig.proto</summary>
  public static partial class AltasConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for gen/xls2proto/AltasConfig.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AltasConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9nZW4veGxzMnByb3RvL0FsdGFzQ29uZmlnLnByb3RvEgVYLlJlcyJICgtB",
            "bHRhc0NvbmZpZxIQCghsZXZlbF9pZBgBIAEoDRISCgphbHRhc19uYW1lGAIg",
            "ASgJEhMKC2FsdGFzX25hbWUyGAMgASgJIjYKEUFsdGFzQ29uZmlnX0FSUkFZ",
            "EiEKBWl0ZW1zGAEgAygLMhIuWC5SZXMuQWx0YXNDb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::X.Res.AltasConfig), global::X.Res.AltasConfig.Parser, new[]{ "LevelId", "AltasName", "AltasName2" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::X.Res.AltasConfig_ARRAY), global::X.Res.AltasConfig_ARRAY.Parser, new[]{ "Items" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AltasConfig : pb::IMessage<AltasConfig> {
    private static readonly pb::MessageParser<AltasConfig> _parser = new pb::MessageParser<AltasConfig>(() => new AltasConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AltasConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::X.Res.AltasConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AltasConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AltasConfig(AltasConfig other) : this() {
      levelId_ = other.levelId_;
      altasName_ = other.altasName_;
      altasName2_ = other.altasName2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AltasConfig Clone() {
      return new AltasConfig(this);
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 1;
    private uint levelId_;
    /// <summary>
    ///* �ؿ�ID 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "altas_name" field.</summary>
    public const int AltasNameFieldNumber = 2;
    private string altasName_ = "";
    /// <summary>
    ///* ͼ������ 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AltasName {
      get { return altasName_; }
      set {
        altasName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "altas_name2" field.</summary>
    public const int AltasName2FieldNumber = 3;
    private string altasName2_ = "";
    /// <summary>
    ///* ͼ������2 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AltasName2 {
      get { return altasName2_; }
      set {
        altasName2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AltasConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AltasConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LevelId != other.LevelId) return false;
      if (AltasName != other.AltasName) return false;
      if (AltasName2 != other.AltasName2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (AltasName.Length != 0) hash ^= AltasName.GetHashCode();
      if (AltasName2.Length != 0) hash ^= AltasName2.GetHashCode();
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
      if (LevelId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LevelId);
      }
      if (AltasName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AltasName);
      }
      if (AltasName2.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AltasName2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (AltasName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AltasName);
      }
      if (AltasName2.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AltasName2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AltasConfig other) {
      if (other == null) {
        return;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.AltasName.Length != 0) {
        AltasName = other.AltasName;
      }
      if (other.AltasName2.Length != 0) {
        AltasName2 = other.AltasName2;
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 18: {
            AltasName = input.ReadString();
            break;
          }
          case 26: {
            AltasName2 = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AltasConfig_ARRAY : pb::IMessage<AltasConfig_ARRAY> {
    private static readonly pb::MessageParser<AltasConfig_ARRAY> _parser = new pb::MessageParser<AltasConfig_ARRAY>(() => new AltasConfig_ARRAY());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AltasConfig_ARRAY> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::X.Res.AltasConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AltasConfig_ARRAY() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AltasConfig_ARRAY(AltasConfig_ARRAY other) : this() {
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AltasConfig_ARRAY Clone() {
      return new AltasConfig_ARRAY(this);
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::X.Res.AltasConfig> _repeated_items_codec
        = pb::FieldCodec.ForMessage(10, global::X.Res.AltasConfig.Parser);
    private readonly pbc::RepeatedField<global::X.Res.AltasConfig> items_ = new pbc::RepeatedField<global::X.Res.AltasConfig>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::X.Res.AltasConfig> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AltasConfig_ARRAY);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AltasConfig_ARRAY other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!items_.Equals(other.items_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= items_.GetHashCode();
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
      items_.WriteTo(output, _repeated_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += items_.CalculateSize(_repeated_items_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AltasConfig_ARRAY other) {
      if (other == null) {
        return;
      }
      items_.Add(other.items_);
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
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code