﻿using System.Drawing;
using LibNbt.Tags;

namespace OpenMinecraft.Entities
{
    public class Zombie:LivingEntity
    {

		private static Image icon = new Bitmap("mobs/zombie.png");
        public Zombie()
        {
        }
        public Zombie(NbtCompound c)
            :base(c)
        {
        }

        public NbtCompound ToNBT()
        {
            NbtCompound c = base.ToNBT();
            return c;
        }
        public override string ToString()
        {
            return "Zombie";
        }

        public override string GetID()
        {
            return "Zombie";
        }

        public override Image Image
        {
            get
            {
                return icon;
            }
        }
    }
}
