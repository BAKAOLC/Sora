using System;
using Sora.Entities;
using Sora.Enumeration.EventParamsType;
using Sora.Server.OnebotEvent.NoticeEvent;

namespace Sora.EventArgs.SoraEvent
{
    /// <summary>
    /// 精华消息变动事件参数
    /// </summary>
    public class EssenceChangeEventArgs : BaseSoraEventArgs
    {
        #region 属性
        /// <summary>
        /// 消息ID
        /// </summary>
        public long MessageId { get; internal set; }

        /// <summary>
        /// 精华设置者
        /// </summary>
        public User Operator { get; internal set; }

        /// <summary>
        /// 消息发送者
        /// </summary>
        public User Sender { get; internal set; }

        /// <summary>
        /// 消息发送者
        /// </summary>
        public Group SourceGroup { get; internal set; }

        /// <summary>
        /// 精华变动类型
        /// </summary>
        public EssenceChangeType EssenceChangeType { get; internal set; }
        #endregion

        #region 构造函数
        internal EssenceChangeEventArgs(Guid connectionGuid, string eventName,
                                        ApiEssenceChangeEventArgs essenceChangeEvent) : base(connectionGuid, eventName,
            essenceChangeEvent.SelfID, essenceChangeEvent.Time)
        {
            MessageId         = essenceChangeEvent.MessageId;
            Operator          = new User(connectionGuid, essenceChangeEvent.OperatorId);
            Sender            = new User(connectionGuid, essenceChangeEvent.SenderId);
            SourceGroup       = new Group(connectionGuid, essenceChangeEvent.GroupId);
            EssenceChangeType = essenceChangeEvent.EssenceChangeType;
        }
        #endregion
    }
}
