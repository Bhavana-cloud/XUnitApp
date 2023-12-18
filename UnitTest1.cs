using System.Text.RegularExpressions;

namespace XUnitApp
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Category A","Group 1")]
        public void Test_Add()
        {
            //arrange
            int a = 100;
            int b = 200;

            //act
            var res=Add(a, b );
            //assert
            Assert.Equal( 300, res );
        }
        [Theory]
        [InlineData(100,200,300)]
        [InlineData(200,-200,0)]
        [Trait("Category B","Group 2")]
        public void test_add_with_multiple_inputs(int a ,int b,int expect)
        {
            //action
            var actual=Add(a, b);
            //assert
            Assert.Equal(expect, actual);
        }
        public int Add(int n1,int n2)
        {
            return n1 + n2;
        }
    }
}