

namespace Learn2CodeV2
{
    public class Metrics
    {
        public int CommandsAmount = 0;
        public int NestingLevel = 0;
        public int RepeatAmount = 0;

        public override string ToString()
        {
            return $"The number of commands is: {CommandsAmount}, " +
                   $"the maximum nesting level is: {NestingLevel}, and " +
                   $"the number of repeat commands is {RepeatAmount}";
        }
    }
}
