
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.test
{
public partial class TbTestMapper
{
    private readonly System.Collections.Generic.Dictionary<int, test.TestMapper> _dataMap;
    private readonly System.Collections.Generic.List<test.TestMapper> _dataList;
    
    public TbTestMapper(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.TestMapper>();
        _dataList = new System.Collections.Generic.List<test.TestMapper>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.TestMapper _v;
            _v = test.TestMapper.DeserializeTestMapper(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.TestMapper> DataMap => _dataMap;
    public System.Collections.Generic.List<test.TestMapper> DataList => _dataList;

    public test.TestMapper GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestMapper Get(int key) => _dataMap[key];
    public test.TestMapper this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

