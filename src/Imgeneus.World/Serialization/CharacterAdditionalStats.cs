﻿using BinarySerialization;
using Imgeneus.Network.Serialization;
using Imgeneus.World.Game.Player;

namespace Imgeneus.World.Serialization
{
    public class CharacterAdditionalStats : BaseSerializable
    {
        [FieldOrder(0)]
        public int Strength { get; }

        [FieldOrder(1)]
        public int Rec { get; }

        [FieldOrder(2)]
        public int Intelligence { get; }

        [FieldOrder(3)]
        public int Wisdom { get; }

        [FieldOrder(4)]
        public int Dexterity { get; }

        [FieldOrder(5)]
        public int Luck { get; }

        [FieldOrder(6)]
        public uint MinAttack { get => 7; }

        [FieldOrder(7)]
        public uint MaxAttack { get => 8; }

        [FieldOrder(8)]
        public uint MinMagicAttack { get => 9; }

        [FieldOrder(9)]
        public uint MaxMagicAttack { get => 10; }

        [FieldOrder(10)]
        public uint Defense { get => 11; }

        [FieldOrder(11)]
        public uint Resistance { get => 12; }

        public CharacterAdditionalStats(Character character)
        {
            Strength = character.ExtraStr;
            Rec = character.ExtraRec;
            Intelligence = character.ExtralInt;
            Wisdom = character.ExtraWis;
            Dexterity = character.ExtraDex;
            Luck = character.ExtraLuc;
        }
    }
}
