using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Uygulaması
{
    public class Heap
    {
        public HeapDugumu[] heapArray;
        public int MaxSize;
        public int CurrentSize;

        public Heap(int deger)
        {
            this.MaxSize = deger;
            CurrentSize = 0;
            heapArray = new HeapDugumu[MaxSize];

        }
        public Heap()
        {
            CurrentSize = 0;
        }

        public void DiziOlustur(int boyut)
        {
            this.MaxSize = boyut;
            heapArray = new HeapDugumu[MaxSize];
        }
        public bool IsEmpty()
        {
            return CurrentSize == 0;
        }
        public bool Insert(Urun Prototip)
        {
            if (CurrentSize == MaxSize)
                return false;
            HeapDugumu temp = new HeapDugumu();
            temp.Data = Prototip;
            heapArray[CurrentSize] = temp;
            MoveToUp(CurrentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && heapArray[parent].Data.SatisFiyati > bottom.Data.SatisFiyati)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu RemoveMin() // Remove maximum value HeapDugumu
        {
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--CurrentSize];
            MoveToDown(0);
            return root;
        }

        public void MoveToDown(int index)
        {
            int SmallerChild;
            HeapDugumu top = heapArray[index];
            while (index < CurrentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < CurrentSize && heapArray[leftChild].Data.SatisFiyati < heapArray[rightChild].Data.SatisFiyati)
                    SmallerChild = leftChild;
                else
                    SmallerChild = rightChild;
                if (top.Data.SatisFiyati <= heapArray[SmallerChild].Data.SatisFiyati)
                    break;
                heapArray[index] = heapArray[SmallerChild];
                index = SmallerChild;
            }
            heapArray[index] = top;
        }

        public string DisplayHeap()
        {
            string str = "";
            for(int i=0; i < heapArray.Length; i++)
            {
                str += heapArray[i].Data.Marka + " " + heapArray[i].Data.Model + " " + heapArray[i].Data.SatisFiyati+"    "+Environment.NewLine;

            }

            return str;
        }

    }
}
