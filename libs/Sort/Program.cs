// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Test test = new Test();

int[] array;

array = Insert.Sort(test.array);
test.Print("插入排序", array);

test.Reset();
array = Shell.Sort(test.array);
test.Print("希尔排序", array);

test.Reset();
array = Merge.Sort(test.array);
test.Print("归并排序", array);

test.Reset();
array = Quick.Sort(test.array, 0, test.array.Length - 1);
test.Print("快速排序", array);

test.Reset();
array = Heap.Sort(test.array);
test.Print("堆排序", array);

public class Test
{
    public int[] array;
    public Test()
    {
        array = new int[]{
            8,7,1,5,4,2,6,3,9
        };
    }
    public void Reset()
    {
        array = new int[]{
            8,7,1,5,4,2,6,3,9
        };
    }
    public void Print(string prefix, int[] values)
    {
        Console.Write(prefix + ": ");
        for (int i = 0; i < values.Length; i++)
        {
            Console.Write(values[i] + " ");
        }
        Console.WriteLine();
    }
}