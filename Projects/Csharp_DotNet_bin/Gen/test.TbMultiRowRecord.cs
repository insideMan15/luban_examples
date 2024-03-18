
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public partial class TbMultiRowRecord
{
    private readonly System.Collections.Generic.Dictionary<int, test.MultiRowRecord> _dataMap;
    private readonly System.Collections.Generic.List<test.MultiRowRecord> _dataList;
    
    public TbMultiRowRecord(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.MultiRowRecord>();
        _dataList = new System.Collections.Generic.List<test.MultiRowRecord>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.MultiRowRecord _v;
            _v = test.MultiRowRecord.DeserializeMultiRowRecord(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.MultiRowRecord> DataMap => _dataMap;
    public System.Collections.Generic.List<test.MultiRowRecord> DataList => _dataList;

    public test.MultiRowRecord GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.MultiRowRecord Get(int key) => _dataMap[key];
    public test.MultiRowRecord this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

