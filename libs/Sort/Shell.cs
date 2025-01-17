// 希尔排序（插入排序的升级版）
// 通过步长将整个待排序序列分割成为若干个子序列，分别进行插入排序

// 确定步长
// 规则：每次步长变化都是 / 2
// 一开始的步长就是数组的长度 / 2

public static class Shell
{
    public static int[] Sort(int[] array)
    {
        // 确定步长
        for (int step = array.Length / 2; step > 0; step /= 2)
        {
            // i = step 默认第一个元素在步长位置
            for (int i = step; i < array.Length; i++)
            {
                // 取出排序区的最后一个元素索引
                int sortIndex = i - step;
                // 取出未排序区的第一个元素
                int target = array[i];
                int temp = array[sortIndex];
                while (temp > target)
                {
                    // 满足条件，排序区中元素往后移动一个位置
                    array[sortIndex + step] = temp;
                    // 排序索引往前移
                    sortIndex -= step;
                    if (sortIndex < 0)
                    {
                        break;
                    }
                    temp = array[sortIndex];
                }
                // 待排序区元素都比较完后，在当前排序索引之后插入元素
                array[sortIndex + step] = target;
            }
        }
        return array;
    }
}