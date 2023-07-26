﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.Proxy_Pattern_2
{
    public class Creatures
    {
        private readonly int size;
        private byte[] age;
        private int[] x, y;
        public Creatures(int size)
        {
            this.size = size;
            age = new byte[size];
            x = new int[size];
            y = new int[size];
        }
        public struct CreatureProxy
        {
            private readonly Creatures creatures;
            private readonly int index;
            public CreatureProxy(Creatures creatures, int index)
            {
                this.creatures = creatures;
                this.index = index;
            }
            public ref byte Age => ref creatures.age[index];
            public ref int x => ref creatures.x[index];
            public ref int y => ref creatures.y[index];
        }
        public IEnumerator<CreatureProxy> GetEnumerator()
        {
            for(int i = 0;i<size;i++)
            {
                yield return new CreatureProxy(this, i);
            }
        }
    }
}
