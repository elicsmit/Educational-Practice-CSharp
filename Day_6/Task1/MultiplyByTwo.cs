public class MultiplyByTwo
{
    public List<int> Process(List<int> numbers)
    {
        return numbers.Select(n => n * 2).ToList();
    }
}
