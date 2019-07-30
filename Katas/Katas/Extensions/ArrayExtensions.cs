namespace Katas.Extensions
{
    public static class ArrayExtensions
    {
        public static bool IsNullOrEmpty<T>(this T[] array) => array == null || array.Length == 0 ? true : false;
    }
}
