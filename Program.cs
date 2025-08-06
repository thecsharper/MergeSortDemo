public class MergeSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;
        MergeSortHelper(arr, 0, arr.Length - 1);
    }

    private static void MergeSortHelper(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSortHelper(arr, left, mid);
            MergeSortHelper(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }

        while (i <= mid)
            temp[k++] = arr[i++];
        while (j <= right)
            temp[k++] = arr[j++];

        for (i = 0; i < temp.Length; i++)
            arr[left + i] = temp[i];
    }

    public static void Main()
    {
        var arr = new int[] { 5, 7, 10, 3, 4 };
        var solution = new MergeSort();
        Sort(arr);

        // Output: 3, 4, 5, 7, 10
        Console.WriteLine($"Sorted array: {string.Join(", ", arr)}");
    }
}
