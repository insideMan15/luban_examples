
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.test
{

public sealed partial class TestUeType : Luban.BeanBase
{
    public TestUeType(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        X1 = (bool)_obj.GetValue("x1");
        X2 = (byte)_obj.GetValue("x2");
        X3 = (short)_obj.GetValue("x3");
        X4 = (int)_obj.GetValue("x4");
        X5 = (long)_obj.GetValue("x5");
        X6 = (float)_obj.GetValue("x6");
        X10 = (string)_obj.GetValue("x10");
        X12 = test.DemoType1.DeserializeDemoType1(_obj.GetValue("x12"));
        X13 = (test.ETestUeType)(int)_obj.GetValue("x13");
        T1 = (long)_obj.GetValue("t1");
        { var __json0 = _obj.GetValue("k1"); int _n0 = (__json0 as JArray).Count; K1 = new int[_n0]; int __index0=0; foreach(JToken __e0 in __json0) { int __v0;  __v0 = (int)__e0;  K1[__index0++] = __v0; }   }
        { var __json0 = _obj.GetValue("k2"); K2 = new System.Collections.Generic.List<int>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { int __v0;  __v0 = (int)__e0;  K2.Add(__v0); }   }
        { var __json0 = _obj.GetValue("k5"); K5 = new System.Collections.Generic.HashSet<int>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { int __v0;  __v0 = (int)__e0;  K5.Add(__v0); }   }
        { var __json0 = _obj.GetValue("k8"); K8 = new System.Collections.Generic.Dictionary<int, int>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { int _k0;  _k0 = (int)__e0[0]; int _v0;  _v0 = (int)__e0[1];  K8.Add(_k0, _v0); }   }
        { var __json0 = _obj.GetValue("k9"); K9 = new System.Collections.Generic.List<test.DemoE2>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { test.DemoE2 __v0;  __v0 = test.DemoE2.DeserializeDemoE2(__e0);  K9.Add(__v0); }   }
    }

    public static TestUeType DeserializeTestUeType(JToken _buf)
    {
        return new test.TestUeType(_buf);
    }

    public readonly bool X1;
    public readonly byte X2;
    public readonly short X3;
    public readonly int X4;
    public readonly long X5;
    public readonly float X6;
    public readonly string X10;
    public readonly test.DemoType1 X12;
    public readonly test.ETestUeType X13;
    public readonly long T1;
    public readonly int[] K1;
    public readonly System.Collections.Generic.List<int> K2;
    public readonly System.Collections.Generic.HashSet<int> K5;
    public readonly System.Collections.Generic.Dictionary<int, int> K8;
    public readonly System.Collections.Generic.List<test.DemoE2> K9;


    public const int __ID__ = 381013016;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        X12?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "x1:" + X1 + ","
        + "x2:" + X2 + ","
        + "x3:" + X3 + ","
        + "x4:" + X4 + ","
        + "x5:" + X5 + ","
        + "x6:" + X6 + ","
        + "x10:" + X10 + ","
        + "x12:" + X12 + ","
        + "x13:" + X13 + ","
        + "t1:" + T1 + ","
        + "k1:" + Luban.StringUtil.CollectionToString(K1) + ","
        + "k2:" + Luban.StringUtil.CollectionToString(K2) + ","
        + "k5:" + Luban.StringUtil.CollectionToString(K5) + ","
        + "k8:" + Luban.StringUtil.CollectionToString(K8) + ","
        + "k9:" + Luban.StringUtil.CollectionToString(K9) + ","
        + "}";
    }
}
}
