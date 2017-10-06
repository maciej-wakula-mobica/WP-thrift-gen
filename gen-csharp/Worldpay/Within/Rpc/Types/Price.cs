/**
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Worldpay.Within.Rpc.Types
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Price : TBase
  {

    public int? Id { get; set; }

    public string Description { get; set; }

    public PricePerUnit PricePerUnit { get; set; }

    public int? UnitId { get; set; }

    public string UnitDescription { get; set; }

    public Price() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32) {
                Id = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Description = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                PricePerUnit = new PricePerUnit();
                PricePerUnit.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I32) {
                UnitId = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                UnitDescription = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("Price");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Id != null) {
          field.Name = "id";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Id.Value);
          oprot.WriteFieldEnd();
        }
        if (Description != null) {
          field.Name = "description";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Description);
          oprot.WriteFieldEnd();
        }
        if (PricePerUnit != null) {
          field.Name = "pricePerUnit";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          PricePerUnit.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (UnitId != null) {
          field.Name = "unitId";
          field.Type = TType.I32;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(UnitId.Value);
          oprot.WriteFieldEnd();
        }
        if (UnitDescription != null) {
          field.Name = "unitDescription";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(UnitDescription);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Price(");
      bool __first = true;
      if (Id != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Description != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Description: ");
        __sb.Append(Description);
      }
      if (PricePerUnit != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PricePerUnit: ");
        __sb.Append(PricePerUnit== null ? "<null>" : PricePerUnit.ToString());
      }
      if (UnitId != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UnitId: ");
        __sb.Append(UnitId);
      }
      if (UnitDescription != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UnitDescription: ");
        __sb.Append(UnitDescription);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
