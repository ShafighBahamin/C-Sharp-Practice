private static void MergeSort(int[] nums, int beg, int end)
    {
        if (beg < end)
        {
            int mid = (beg + end) / 2;
            MergeSort(nums, beg, mid);
            MergeSort(nums, mid + 1, end);
            Merge(nums, beg, mid, end);
        }
    }

    private static void Merge(int[] nums, int beg, int mid, int end)
    {
        int i = 0;
        int k = 0;
        int f_idx = beg;
        int s_idx = mid + 1;
        int[] list = new int[end - beg + 1];
        while (f_idx <= mid && s_idx <= end)
        {
            if (nums[f_idx] <= nums[s_idx])
            {
                list[i] = nums[f_idx];
                i++;
                f_idx++;
            }
            else
            {
                list[i] = nums[s_idx];
                i++;
                s_idx++;
            }
        }
        while (s_idx <= end)
        {
            list[i] = nums[s_idx];
            i++;
            s_idx++;
        }
        while (f_idx <= mid)
        {
            list[i] = nums[f_idx];
            i++;
            f_idx++;
        }
        for (i = beg; i <= end; i++)
        {
            nums[i] = list[k];
            k++;
        }
    }
