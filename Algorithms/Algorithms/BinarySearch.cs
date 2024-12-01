namespace Algorithms;

public class BinarySearch
{
    public int Search(int[] array, int target)
    {
        int low = 0;    
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int order = array[mid];

            if (order == target)
            {
                return mid;
            }

            if (order > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
                
        } 
        return -1;
    }
}