// 快速排序（边排序边拆分）
// 选取基准值（一般取第一个元素）
// 产生左右标识（最左边索引和最右边索引）和游标
// 左右比基准，移动游标并换位，直到左右游标相等，放回基准值，并拆分数组继续上述步骤

public static class Quick
{
    public static int[] Sort(int[] array, int left, int right)
    {
        // 递归结束条件
        if (left >= right)
        {
            return array;
        }
        // 记录基准值、左右游标
        int temp = array[left];
        int tempLeft = left;
        int tempRight = right;
        // 左右游标相等时，无需交换
        while (tempLeft != tempRight)
        {
            // 比较交换
            // 移动右侧游标
            while (tempLeft < tempRight && array[tempRight] > temp)
            {
                tempRight -= 1;
            }
            // 找到比基准值小的值，并交换位置
            array[tempLeft] = array[tempRight];
            // 移动左侧游标
            while (tempLeft < tempRight && array[tempLeft] < temp)
            {
                tempLeft += 1;
            }
            // 找到比基准值大的值，并交换位置
            array[tempRight] = array[tempLeft];
        }
        // 放置基准值，此时左右游标一定相等
        array[tempLeft] = temp;

        // 递归
        Sort(array, left, tempRight - 1);
        Sort(array, tempLeft + 1, right);
        return array;
    }
}