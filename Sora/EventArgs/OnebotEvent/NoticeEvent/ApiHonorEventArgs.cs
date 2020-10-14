using Newtonsoft.Json;
using Sora.Converter;
using Sora.Enumeration.ApiEnum;

namespace Sora.EventArgs.OnebotEvent.NoticeEvent
{
    /// <summary>
    /// 群成员荣誉变更事件
    /// </summary>
    internal sealed class ApiHonorEventArgs : BaseNotifyEventArgs
    {
        /// <summary>
        /// 荣誉类型
        /// </summary>
        [JsonConverter(typeof(EnumDescriptionConverter))]
        [JsonProperty(PropertyName = "honor_type")]
        internal HonorType HonorType { get; set; }
    }
}