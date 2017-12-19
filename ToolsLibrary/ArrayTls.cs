using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class ArrayTls
    {
        public int[] Arr { get; set; }
        public ArrayTls(int[] Arr)
        {
            this.Arr = Arr;
        }
        private int FirstSeriesCount()
        {
            int count = 1;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] == Arr[0])
                    count++;
                else
                    break;
            }
            return count;
        }
        private int LastSeriesCount()
        {
            int count = 1;
            for (int i = Arr.Length - 2; i >= 0; i--)
            {
                if (Arr[i] == Arr[Arr.Length - 1])
                    count++;
                else
                    break;
            }
            return count;
        }
        private bool FindSeriesK(int k, out int index, out int count)
        {
            int series = 1;
            index = 0;
            count = 1;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] == Arr[index])
                    count++;
                else
                {
                    if (series == k)
                        return true;
                    series++;
                    index = i;
                    count = 1;
                }
            }
            if (series == k)
                return true;
            return false;
        }
        public int[] SwapFirstAndK(int k)
        {
            if (FindSeriesK(k, out int index, out int Kcount))
            {
                if (index == 0)
                    return Arr;
                int Fcount = FirstSeriesCount();
                int[] ArrNew = new int[Arr.Length];
                Array.Copy(Arr, index, ArrNew, 0, Kcount);
                Array.Copy(Arr, Fcount, ArrNew, Kcount, index - Fcount);
                Array.Copy(Arr, 0, ArrNew, Kcount + index - Fcount, Fcount);
                Array.Copy(Arr, Kcount + index, ArrNew, Kcount + index, Arr.Length - Kcount - index);
                return ArrNew;
            }
            else
                return Arr;
        }
        public int[] SwapLastAndK(int k)
        {
            if (FindSeriesK(k, out int index, out int Kcount))
            {
                if (index + Kcount == Arr.Length)
                    return Arr;
                int Lcount = LastSeriesCount();
                int[] ArrNew = new int[Arr.Length];
                Array.Copy(Arr, ArrNew, index);
                Array.Copy(Arr, Arr.Length - Lcount, ArrNew, index, Lcount);
                Array.Copy(Arr, index + Kcount, ArrNew, index + Lcount, Arr.Length - Lcount - index - Kcount);
                Array.Copy(Arr, index, ArrNew, Arr.Length - Kcount, Kcount);
                return ArrNew;
            }
            else
                return Arr;
        }
        private int AltSeqCount(int index)
        {
            int a = Arr[index];
            int b = Arr[index + 1];
            int count = 2;
            for (int i = index+2; i < Arr.Length; i++)
            {
                switch ((i-index)%2)
                {
                    case 0:
                        if (Arr[i] == a)
                            count++;
                        else
                            return count;
                        break;
                    case 1:
                        if (Arr[i] == b)
                            count++;
                        else
                            return count;
                        break;
                }
            }
            return count;
        }
        public void Find2LastMaxAltSeq(out int Index, out int count )
        {
            Index = 0;
            int NextIndex = 0;
            count = 0;
            int tmp = 0;
            for (int i = 0; i < Arr.Length - 1;)
            {
                tmp = AltSeqCount(i);
                if(tmp == count)
                {
                    Index = NextIndex;
                    NextIndex = i;
                }
                if(tmp > count)
                {
                    count = tmp;
                    NextIndex = i;
                    Index = i;
                }
                i += tmp - 1;
            }
        }
        public int[] Find2LastMaxAltSeq()
        {
            Find2LastMaxAltSeq(out int Index, out int Count);
            return GetSubArray(Index, Count);
        }
        public int[] GetSubArray(int Index, int Count)
        {
            int[] ArrNew = new int[Count];
            Array.Copy(Arr, Index, ArrNew, 0, Count);
            return ArrNew;
        }
    }
}
