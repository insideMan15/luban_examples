
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
public abstract partial class ItemBase : Luban.BeanBase
{
    public ItemBase(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        Name = _buf.GetProperty("name").GetString();
        Desc = _buf.GetProperty("desc").GetString();
    }

    public static ItemBase DeserializeItemBase(JsonElement _buf)
    {
        switch (_buf.GetProperty("$type").GetString())
        {
            case "Item": return new test.Item(_buf);
            case "Equipment": return new test.Equipment(_buf);
            case "Decorator": return new test.Decorator(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly int Id;
    public readonly string Name;
    public readonly string Desc;
   

    public virtual void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "desc:" + Desc + ","
        + "}";
    }
}

}
