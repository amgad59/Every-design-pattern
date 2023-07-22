using Adapter_Pattern.Generic_Value_Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Generic_Value_Adapter
{
    public class Vector<TSelf,T,D>
        where D : IInteger, new()
        where TSelf : Vector<TSelf, T, D>, new() 
    {
        protected T[] Data;
        public Vector() {
            Data = new T[new D().Value];
        }
        public Vector(params T[] values)
        {
            var requiredSize = new D().Value;
            Data = new T[requiredSize];
            var providedSize = values.Length;
            int MinSize = Math.Min(requiredSize, providedSize);
            for (int i = 0; i < MinSize; ++i)
            {
                Data[i] = values[i];
            }
        }
        public static TSelf Create(params T[] values)
        {
            var result = new TSelf();
            var requiredSize = new D().Value;
            result.Data = new T[requiredSize];
            var providedSize = values.Length;
            int MinSize = Math.Min(requiredSize, providedSize);
            for (int i = 0; i < MinSize; ++i)
            {
                result.Data[i] = values[i];
            }
            return result;
        }
        public T this[int index]
        {
            get => Data[index];
            set => Data[index] = value;
        }
        public T X
        {
            get => Data[0];
            set => Data[0] = value;
        }
    }
}
