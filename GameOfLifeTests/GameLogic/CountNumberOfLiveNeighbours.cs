using GameOfLife.GameLogic;
using FluentAssertions;

namespace GameOfLifeTests.GameLogic
{
    public class CountNumberOfLiveNeighbours
    {
        [Fact]
        public void GetCountOfLiveNeighbours_CellWithThreeNeighbours_ShouldReturnCountOf3()
        {
            //Arrange
            var uut = new Game();
            var expectedCount = 3;
            var gen1 = @"3 3
*..
..*
*..";
            //Act
            var result = uut.GetCountOfLiveNeighbours(1, 1, gen1);

            //Assert
            Assert.True(expectedCount == result);
        }

        [Fact]
        public void GetCountOfLiveNeighbours_CellWithOneNeighbour_ShouldReturnCountOf1()
        {
            //Arrange
            var uut = new Game();
            var expectedCount = 1;
            var gen1 = @"3 3
*..
...
...";
            //Act
            var result = uut.GetCountOfLiveNeighbours(1, 1, gen1);

            //Assert
            Assert.True(expectedCount == result);
        }

    }
}
