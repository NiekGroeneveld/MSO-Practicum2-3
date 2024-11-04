using Learn2CodeV2;
using MSO_P2;

namespace PositionTests.Tests
{
    public class FindPositionInList
    {
        [Fact]
        public void PositionFound()
        {
            List<Position> positions = new List<Position>();
            Position position = new Position(1, 2);
            positions.Add(position);

            Position position2 = new Position(1, 2);

            bool found = positions.Contains(position2);
            Assert.True(found);     
        }
    }
}