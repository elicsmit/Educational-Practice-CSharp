public class FilterEvenNumbers
{
    public List<int> Process(List<int> numbers)
    {
        return numbers.Where(n => n % 2 == 0).ToList();
    }
}
