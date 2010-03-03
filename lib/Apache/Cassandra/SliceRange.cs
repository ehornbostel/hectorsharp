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
namespace Apache.Cassandra
{

    [Serializable]
    public partial class SliceRange : TBase
    {
        byte[] start;
        byte[] finish;
        bool reversed;
        int count;

        #region ctor
        public SliceRange()
        {
            this.reversed = false;
            this.count = 100;
        }

        public SliceRange(byte[] start, byte[] finish, bool reversed, int count)
        {
            this.start = start;
            this.finish = finish;
            this.reversed = reversed;
            this.count = count;
        }
        #endregion
        
        public byte[] Start
        {
            get
            {
                return start;
            }
            set
            {
                __isset.start = true;
                this.start = value;
            }
        }

        public byte[] Finish
        {
            get
            {
                return finish;
            }
            set
            {
                __isset.finish = true;
                this.finish = value;
            }
        }

        public bool Reversed
        {
            get
            {
                return reversed;
            }
            set
            {
                __isset.reversed = true;
                this.reversed = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                __isset.count = true;
                this.count = value;
            }
        }


        public Isset __isset;
        [Serializable]
        public struct Isset
        {
            public bool start;
            public bool finish;
            public bool reversed;
            public bool count;
        }




        public void Read(TProtocol iprot)
        {
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.String)
                        {
                            this.start = iprot.ReadBinary();
                            this.__isset.start = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 2:
                        if (field.Type == TType.String)
                        {
                            this.finish = iprot.ReadBinary();
                            this.__isset.finish = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 3:
                        if (field.Type == TType.Bool)
                        {
                            this.reversed = iprot.ReadBool();
                            this.__isset.reversed = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 4:
                        if (field.Type == TType.I32)
                        {
                            this.count = iprot.ReadI32();
                            this.__isset.count = true;
                        }
                        else
                        {
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

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("SliceRange");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            if (this.start != null && __isset.start)
            {
                field.Name = "start";
                field.Type = TType.String;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                oprot.WriteBinary(this.start);
                oprot.WriteFieldEnd();
            }
            if (this.finish != null && __isset.finish)
            {
                field.Name = "finish";
                field.Type = TType.String;
                field.ID = 2;
                oprot.WriteFieldBegin(field);
                oprot.WriteBinary(this.finish);
                oprot.WriteFieldEnd();
            }
            if (__isset.reversed)
            {
                field.Name = "reversed";
                field.Type = TType.Bool;
                field.ID = 3;
                oprot.WriteFieldBegin(field);
                oprot.WriteBool(this.reversed);
                oprot.WriteFieldEnd();
            }
            if (__isset.count)
            {
                field.Name = "count";
                field.Type = TType.I32;
                field.ID = 4;
                oprot.WriteFieldBegin(field);
                oprot.WriteI32(this.count);
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            return string.Format("SliceRange(start: {0},finish: {1},reversed: {2},count: {3})", 
            this.start,this.finish,this.reversed,this.count);
        }

    }

}
