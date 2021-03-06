﻿
using Imgeneus.Database.Preload;

namespace Imgeneus.World.Game.Player
{
    public class Gem
    {
        private readonly IDatabasePreloader _databasePreloader;

        public int TypeId { get; private set; }

        public Gem(IDatabasePreloader databasePreloader, int typeId)
        {
            _databasePreloader = databasePreloader;
            TypeId = typeId;

            // 30 type is always lapis.
            var item = _databasePreloader.Items[(30, (byte)TypeId)];
            Str = item.ConstStr;
            Dex = item.ConstDex;
            Rec = item.ConstRec;
            Int = item.ConstInt;
            Luc = item.ConstLuc;
            Wis = item.ConstWis;
            HP = item.ConstHP;
            MP = item.ConstMP;
            SP = item.ConstSP;
            AttackSpeed = item.AttackTime;
            MoveSpeed = item.Speed;
        }

        public ushort Str { get; }

        public ushort Dex { get; }

        public ushort Rec { get; }

        public ushort Int { get; }

        public ushort Luc { get; }

        public ushort Wis { get; }

        public ushort HP { get; }

        public ushort MP { get; }

        public ushort SP { get; }

        public byte AttackSpeed { get; }

        public byte MoveSpeed { get; }
    }
}
