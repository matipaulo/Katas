using Katas.Extensions;
using System.Linq;

namespace Katas
{
    /// <summary>
    /// Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.
    /// Rules for a smiling face:
    /// -Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
    /// -A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
    /// -Every smiling face must have a smiling mouth that should be marked with either ) or D.
    /// No additional characters are allowed except for those mentioned.
    /// Valid smiley face examples:
    /// :) :D ;-D :~)
    /// Invalid smiley faces:
    /// ;( :&gt; :} :] 
    /// 
    /// </summary>
    public static class Smileys
    {
        private static readonly char[] ValidEyes = new[] {':', ';'};
        private static readonly char[] ValidNoses = new[] {'-', '~'};
        private static readonly char[] ValidMouths = new[] {')', 'D'};

        public static int CountSmileys(string[] smileys)
        {
            if (smileys.IsNullOrEmpty())
                return 0;

            var count = 0;
            foreach (var smiley in smileys)
            {
                var smileyChars = smiley.ToCharArray();
                if (smileyChars.Any(x => ValidEyes.Contains(x)) && smileyChars.Any(x => ValidMouths.Contains(x)))
                {
                    var possibleNoses = smileyChars.Where(x => !ValidEyes.Contains(x) && !ValidMouths.Contains(x)).ToList();
                    if (possibleNoses.Count == 0 || possibleNoses.Any(x => ValidNoses.Contains(x)))
                        count += 1;
                }
            }

            return count;
        }
    }
}
