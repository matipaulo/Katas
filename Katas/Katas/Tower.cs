using System.Collections.Generic;

namespace Katas
{
    /// <summary>
    /// for example, a tower of 3 floors looks like below
    /// 
    /// [
    /// '  *  ', 
    /// ' *** ', 
    /// '*****'
    /// ]
    /// and a tower of 6 floors looks like below
    /// 
    /// [
    /// '     *     ', 
    /// '    ***    ', 
    /// '   *****   ', 
    /// '  *******  ', 
    /// ' ********* ', 
    /// '***********'
    /// ]
    /// </summary>
    public static class Tower
    {
        public static string[] TowerBuilder(int floors)
        {
            if (floors == 0)
                return new string[0];

            var tower = new List<string>();
            for (var i = 0; i < floors; i++)
            {
                var floor = string.Empty;
                var asterisk = ((2 * floors) - 1) - (i * 2);
                floor = floor.PadLeft(asterisk, '*');

                var left = floor.PadLeft(asterisk + i);
                tower.Add(left.PadRight(left.Length + i));
            }

            tower.Reverse(0, tower.Count);

            return tower.ToArray();
        }
    }
}
