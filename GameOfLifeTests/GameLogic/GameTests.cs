using FluentAssertions;
using GameOfLife.GameLogic;

namespace GameOfLifeTests.GameLogic
{
    public class GameTests
    {
        [Fact]
        public void GetNextGeneration_ForGridWith4DeadCells_Returns4DeadCells()
        {
            //arrange
            var uut = new Game();
            var gen1 = @"2 2
..
..";
            var gen2 = gen1;

            //act
            var result = uut.CalculateNextGeneration(gen1);

            //assert
            result.Should().BeEquivalentTo(gen2);

        }

        [Fact]
        public void GetNextGeneration_ForGridWith6DeadCells2By3_Returns6DeadCells()
        {
            //arrange
            var uut = new Game();
            var gen1 = @"2 3
...
...";
            var gen2 = gen1;

            //act
            var result = uut.CalculateNextGeneration(gen1);

            //assert
            result.Should().BeEquivalentTo(gen2);

        }


        [Fact]
        public void GetNextGeneration_ForGridWith9DeadCells_Returns9DeadCells()
        {
            //arrange
            var uut = new Game();
            var gen1 = @"3 3
...
...
...";
            var gen2 = gen1;

            //act
            var result = uut.CalculateNextGeneration(gen1);

            //assert
            result.Should().BeEquivalentTo(gen2);

        }


        [Fact]
        public void GetNextGeneration_For3by3GridWith2LifeCells_ShouldReturn2Lifeeturns9DeadCells()
        {
            //arrange
            var uut = new Game();
            var gen1 = @"3 3
*..
..*
*..";
            var gen2 = @"3 3
...
.*.
...";

            //act
            var result = uut.CalculateNextGeneration(gen1);

            //assert
            result.Should().BeEquivalentTo(gen2);

        }


    }
}
