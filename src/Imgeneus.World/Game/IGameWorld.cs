﻿using Imgeneus.Database.Constants;
using Imgeneus.Network.Packets.Game;
using Imgeneus.World.Game.Monster;
using Imgeneus.World.Game.Player;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Imgeneus.World.Game
{
    /// <summary>
    /// The virtual representation of game world.
    /// </summary>
    public interface IGameWorld
    {
        /// <summary>
        /// Connected players. Key is character id, value is character.
        /// </summary>
        ConcurrentDictionary<int, Character> Players { get; }

        /// <summary>
        /// Loads player into game world.
        /// </summary>
        /// <param name="characterId">id of character in databse</param>
        /// <param name="client">TCP connection with client</param>
        /// <returns>character, that is loaded into game world</returns>
        Character LoadPlayer(int characterId, WorldClient client);

        /// <summary>
        /// Loads player into map and send notification other players.
        /// </summary>
        void LoadPlayerInMap(int characterId);

        /// <summary>
        /// Removes player from game world.
        /// </summary>
        void RemovePlayer(int characterId);
    }
}
