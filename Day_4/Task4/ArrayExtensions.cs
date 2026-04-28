public static class ArrayExtensions
{
    // Расширяющий метод для int[]
    public static int[] GetUnique(this int[] array)
    {
        // Используем HashSet, так как он автоматически хранит только уникальные значения
        HashSet<int> uniqueElements = new HashSet<int>(array);

        // Преобразуем коллекцию обратно в массив
        int[] result = new int[uniqueElements.Count];
        uniqueElements.CopyTo(result);

        return result;
    }
}
