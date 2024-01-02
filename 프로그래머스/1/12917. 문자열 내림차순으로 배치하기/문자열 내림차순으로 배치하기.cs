using System;

public class Solution {
    public string solution(string s) {
        char[] charArray = s.ToCharArray();
        MergeSort(charArray, 0, charArray.Length - 1);

        return new string(charArray);
    }

    static void MergeSort(char[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }

    static void Merge(char[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        char[] leftArr = new char[n1];
        char[] rightArr = new char[n2];

        Array.Copy(arr, left, leftArr, 0, n1);
        Array.Copy(arr, mid + 1, rightArr, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (leftArr[i] >= rightArr[j])
            {
                arr[k++] = leftArr[i++];
            }
            else
            {
                arr[k++] = rightArr[j++];
            }
        }

        while (i < n1)
        {
            arr[k++] = leftArr[i++];
        }

        while (j < n2)
        {
            arr[k++] = rightArr[j++];
        }
    }
}