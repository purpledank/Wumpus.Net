﻿using Wumpus.Entities;
using Voltaic.Serialization;

namespace Wumpus.Events
{
    /// <summary> xxx </summary>
    public class GuildBanEvent
    {
        /// <summary> xxx </summary>
        [ModelProperty("guild_id")]
        public ulong GuildId { get; set; }
        /// <summary> xxx </summary>
        [ModelProperty("user")]
        public User User { get; set; }
    }
}