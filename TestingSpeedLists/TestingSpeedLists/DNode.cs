using System;
using System.Collections.Generic;
using System.Text;

namespace TestingSpeedLists
{
    public class DNode
    {
        private int[] array;

        public DNode() { }
        public DNode(int value)
        {
            Value = value;
        }

        public DNode(int[] array)
        {
            this.array = array;
        }

        public int Value;
        public DNode Prev, Next;
    }
}
