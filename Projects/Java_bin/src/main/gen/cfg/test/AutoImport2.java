
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class AutoImport2 extends AbstractBean {
    public AutoImport2(ByteBuf _buf) { 
        id = _buf.readInt();
        x1 = _buf.readBool();
        x5 = _buf.readLong();
        x6 = _buf.readFloat();
        x8 = _buf.readInt();
        x10 = _buf.readString();
        x13 = _buf.readInt();
        x132 = _buf.readInt();
        x14 = cfg.test.DemoDynamic.deserialize(_buf);
        x15 = cfg.test.Shape.deserialize(_buf);
        v2 = cfg.vec2.deserialize(_buf);
        t1 = _buf.readLong();
        {int __n0 = Math.min(_buf.readSize(), _buf.size());k1 = new int[__n0];for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { int __e0;__e0 = _buf.readInt(); k1[__i0] = __e0;}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());k2 = new int[__n0];for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { int __e0;__e0 = _buf.readInt(); k2[__i0] = __e0;}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());k8 = new java.util.HashMap<Integer, Integer>(__n0 * 3 / 2);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { Integer __k0;  __k0 = _buf.readInt(); Integer __v0;  __v0 = _buf.readInt();     k8.put(__k0, __v0);}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());k9 = new java.util.ArrayList<cfg.test.DemoE2>(__n0);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { cfg.test.DemoE2 __e0;  __e0 = cfg.test.DemoE2.deserialize(_buf); k9.add(__e0);}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());k10 = new java.util.ArrayList<cfg.vec3>(__n0);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { cfg.vec3 __e0;  __e0 = cfg.vec3.deserialize(_buf); k10.add(__e0);}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());k11 = new java.util.ArrayList<cfg.vec4>(__n0);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { cfg.vec4 __e0;  __e0 = cfg.vec4.deserialize(_buf); k11.add(__e0);}}
        if(_buf.readBool()){ v11 = cfg.vec3.deserialize(_buf); } else { v11 = null; }
    }

    public static AutoImport2 deserialize(ByteBuf _buf) {
            return new cfg.test.AutoImport2(_buf);
    }

    /**
     * 这是id
     */
    public final int id;
    /**
     * 字段x1
     */
    public final boolean x1;
    public final long x5;
    public final float x6;
    public final int x8;
    public final String x10;
    public final int x13;
    public final int x132;
    public final cfg.test.DemoDynamic x14;
    public final cfg.test.Shape x15;
    public final cfg.vec2 v2;
    public final long t1;
    public final int[] k1;
    public final int[] k2;
    public final java.util.HashMap<Integer, Integer> k8;
    public final java.util.ArrayList<cfg.test.DemoE2> k9;
    public final java.util.ArrayList<cfg.vec3> k10;
    public final java.util.ArrayList<cfg.vec4> k11;
    public final cfg.vec3 v11;

    public static final int __ID__ = 417472770;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "x1:" + x1 + ","
        + "x5:" + x5 + ","
        + "x6:" + x6 + ","
        + "x8:" + x8 + ","
        + "x10:" + x10 + ","
        + "x13:" + x13 + ","
        + "x132:" + x132 + ","
        + "x14:" + x14 + ","
        + "x15:" + x15 + ","
        + "v2:" + v2 + ","
        + "t1:" + t1 + ","
        + "k1:" + k1 + ","
        + "k2:" + k2 + ","
        + "k8:" + k8 + ","
        + "k9:" + k9 + ","
        + "k10:" + k10 + ","
        + "k11:" + k11 + ","
        + "v11:" + v11 + ","
        + "}";
    }
}
