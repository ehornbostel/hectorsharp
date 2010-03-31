/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Apache.Cassandra060
{

  [Serializable]
  public partial class ColumnPath : TBase
  {
    private string column_family;
    private byte[] super_column;
    private byte[] column;

    public string Column_family
    {
      get
      {
        return column_family;
      }
      set
      {
        __isset.column_family = true;
        this.column_family = value;
      }
    }

    public byte[] Super_column
    {
      get
      {
        return super_column;
      }
      set
      {
        __isset.super_column = true;
        this.super_column = value;
      }
    }

    public byte[] Column
    {
      get
      {
        return column;
      }
      set
      {
        __isset.column = true;
        this.column = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool column_family;
      public bool super_column;
      public bool column;
    }

    public ColumnPath() {
    }

    public void Read (TProtocol iprot)
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
          case 3:
            if (field.Type == TType.String) {
              this.column_family = iprot.ReadString();
              this.__isset.column_family = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              this.super_column = iprot.ReadBinary();
              this.__isset.super_column = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              this.column = iprot.ReadBinary();
              this.__isset.column = true;
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ColumnPath");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.column_family != null && __isset.column_family) {
        field.Name = "column_family";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.column_family);
        oprot.WriteFieldEnd();
      }
      if (this.super_column != null && __isset.super_column) {
        field.Name = "super_column";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.super_column);
        oprot.WriteFieldEnd();
      }
      if (this.column != null && __isset.column) {
        field.Name = "column";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.column);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ColumnPath(");
      sb.Append("column_family: ");
      sb.Append(this.column_family);
      sb.Append(",super_column: ");
      sb.Append(this.super_column);
      sb.Append(",column: ");
      sb.Append(this.column);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
