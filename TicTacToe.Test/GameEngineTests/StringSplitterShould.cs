using Xunit;

namespace TicTacToe.Test
{
    public class StringSplitterShould
    {
        [Fact]
        public void ReturnXValue()
        {
            var stringSplitter = new StringSplitter();
            var result = stringSplitter.GetX("2,3");
            Assert.Equal(2,result);
        }

        [Fact]
        public void ReturnYValue()
        {
            var stringSplitter = new StringSplitter();
            var result = stringSplitter.GetY("3,2");
            Assert.Equal(2,result);
        }
        
    }
}