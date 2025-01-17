// 归并排序（递归 + 合并）

// 分为两部分
// 1. 基本排序规则：左右元素进行比较，依次放入新数组，一侧没有了，另一侧直接放入新数组
// 2. 递归平分数组：不停地进行分割，长度小于 2 停止

public static class Merge
{
    // 基本排序规则
    private static int[] MergeFuc(int[] left, int[] right)
    {
        int[] array = new int[left.Length + right.Length];
        int leftIndex = 0;
        int rightIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (leftIndex >= left.Length)
            {
                // 左侧放完了
                array[i] = right[rightIndex];
                rightIndex += 1;
            }
            else if (rightIndex >= right.Length)
            {
                // 右侧放完了
                array[i] = left[leftIndex];
                leftIndex += 1;
            }
            else if (left[leftIndex] < right[rightIndex])
            {
                array[i] = left[leftIndex];
                leftIndex += 1;
            }
            else
            {
                array[i] = right[rightIndex];
                rightIndex += 1;
            }
        }
        return array;
    }

    public static int[] Sort(int[] array)
    {
        if (array.Length < 2)
        {
            return array;
        }
        // 递归平分数组
        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];
        for (var i = 0; i < array.Length; i++)
        {
            if (i < middle)
            {
                left[i] = array[i];
            }
            else
            {
                right[i - middle] = array[i];
            }
        }
        return MergeFuc(Sort(left), Sort(right));
    }
}