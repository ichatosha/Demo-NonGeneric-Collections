using System.Collections;

namespace Demo
{
    internal class Program
    {
        

        public static int SummaryList(ArrayList arrayList)
        {
            int sum = 0;
            if (arrayList != null)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    sum += (int)arrayList[i]; // casting from object to int 

                }

            }

            return sum;
        }
            


        static void Main(string[] args)
        {

            #region NonGeneric Collection Array List.
            ArrayList arrayList = new ArrayList();


            Console.WriteLine($"Count : {arrayList.Count} , capacity : {arrayList.Capacity}");


            arrayList.Add( 1 );
            Console.WriteLine($"Count : {arrayList.Count} , capacity : {arrayList.Capacity}");

            arrayList.Add(2);
            arrayList.AddRange(new int[] {6,7});
            Console.WriteLine($"Count : {arrayList.Count} , capacity : {arrayList.Capacity}");

            arrayList.Add(9);
            // crate new array of heap with doyuble size
            // take old elements and add the new elements to new array


            ArrayList arraylist1    = new ArrayList(5) { 1,2,3,4,5};
            Console.WriteLine($"Count : {arrayList.Count} , capacity : {arrayList.Capacity}");


            //create new array with double size of old array : 
            arraylist1.Add(6);
            Console.WriteLine($"Count : {arrayList.Count} , capacity : {arrayList.Capacity}");



            int result = SummaryList(arraylist1);

            #endregion


            #region Generics Collections List

            //List => arraylist new version with generics
            List <int> Numbers = new List<int>();
            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.AddRange(new int[] { 3, 4 });

            // after adding new elemebnt will create new array with double size of old one
            Numbers.Add(5);

            // trim => delete unusage bytes 
            // create new array with size  = count of last elements 
            Numbers.TrimExcess();












            #endregion

            #region List Methods 
            List<int> num =new List <int>(5) { 1,2,3,4,5};



            num.Add(6);
            num.AddRange(new int[] { 1,2,4,5});
            
            foreach (int i in num)
                Console.WriteLine(i);


            num.Insert(0,1);


            num.InsertRange(4,new int[] { 9,10});


            num.BinarySearch(3);
            Console.WriteLine(num.BinarySearch(2));

            // remove all elements
            num.Clear();    

            num.Contains(1);


            int[] array = new int[5];
            num.CopyTo(array);
            


            //make thre capcaity the size you want: 
            num.EnsureCapacity(5);


            #endregion

            #region LinkedList
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);

            // to add element after first element oin linked list :
            LinkedListNode<int> afterOne = list.Find(1);            
            list.AddAfter(afterOne, 5);
            list.AddAfter(list.Find(1), 4);

            // to add element before last element in loinked list : 
            LinkedListNode<int> beforeLast = list.Find(2);
            list.AddBefore(beforeLast, 10);
            list.AddBefore(list.Find(2), 4);

            #endregion

            #region Stack [FILO]

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            foreach (int i in stack)
            {
                Console.WriteLine(i); // 3 2 1
            }

            stack.Peek(); // 3

            stack.Pop(); // 3
            stack.Pop(); // 2
            stack.Pop(); // 1
            stack.Pop(); // Empty stack
            #endregion


            #region Queue [FIFO] GENERIC

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(queue.Peek());

            // remove and return the begging in the queue : => 1 first element in queue
            queue.Dequeue();

            queue.Dequeue();    // 2
            queue.Dequeue();    // 3 
            queue.Dequeue();    // 4
            queue.Dequeue();    // EMpty queue 
            #endregion
        }
    }
}