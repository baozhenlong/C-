// 插入排序
// 排序开始前，首先认为第一个元素在排序区中，其他所有元素在未排序区中
// 排序开始后，每次从未排序区中取出第一个元素，用于和排序区的元素比较（从后往前）
// 满足条件（较大或较小），则排序区中元素往后移动一个位置
// 待排序区元素都比较完后，在当前排序索引之后插入元素
// 直到未排序区清空

public static class Insert
{
    public static int[] Sort(int[] array)
    {
        // i = 1 默认第一个元素在排序区
        for (int i = 1; i < array.Length; i++)
        {
            // 取出排序区的最后一个元素索引
            int sortIndex = i - 1;
            // 取出未排序区的第一个元素
            int target = array[i];
            int temp = array[sortIndex];
            while (temp > target)
            {
                // 满足条件，排序区中元素往后移动一个位置
                array[sortIndex + 1] = temp;
                // 排序索引往前移
                sortIndex -= 1;
                if (sortIndex < 0)
                {
                    break;
                }
                temp = array[sortIndex];
            }
            // 待排序区元素都比较完后，在当前排序索引之后插入元素
            array[sortIndex + 1] = target;
        }
        return array;
    }
}