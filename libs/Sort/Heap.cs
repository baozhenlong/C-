// 堆排序

// 构建二叉树
// 规则：
// 1. 最大非叶子节点索引（Length/2 - 1）
// 2. 父节点下标为 i，左节点下标为 2i+1，右节点下标为 2i+2

// 从最大非叶子节点开始比较，将最大值移到堆顶
// 比较堆顶和节点，把堆顶不停往后移动

public static class Heap
{
    public static int[] Sort(int[] array)
    {
        // 将最大值移到堆顶
        Prepare(array);
        for (var i = array.Length - 1; i > 0; i--)
        {
            // 比较堆顶和节点，把堆顶不停往后移动
            (array[0], array[i]) = (array[i], array[0]);
            Compare(array, 0, i);
        }
        return array;
    }

    // 父节点和左右叶子节点比较
    private static void Compare(int[] array, int parentIndex, int arrayLength)
    {
        // 计算子节点索引
        int leftIndex = 2 * parentIndex + 1;
        int rightIndex = leftIndex + 1;
        // 用于记录较大数的索引
        int maxIndex = parentIndex;
        // 比较左节点
        if (leftIndex < arrayLength && array[leftIndex] > array[maxIndex])
        {
            maxIndex = leftIndex;
        }
        // 比较右节点
        if (rightIndex < arrayLength && array[rightIndex] > array[maxIndex])
        {
            maxIndex = rightIndex;
        }
        if (maxIndex != parentIndex)
        {
            // 交换值
            (array[parentIndex], array[maxIndex]) = (array[maxIndex], array[parentIndex]);
            // 通过递归，看是否影响了叶子节点的关系
            Compare(array, maxIndex, arrayLength);
        }
    }

    // 将最大值移到堆顶
    private static void Prepare(int[] array)
    {
        for (int i = array.Length / 2 - 1; i >= 0; i--)
        {
            Compare(array, i, array.Length);
        }
    }
}