using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace NuGetProject.UnitTests
{
    public class MyClass_Tests
    {
        [Theory, ClassData( typeof( TestAddData ) )]
        public void Add( int a, int b, int expected )
        {
            MyClass c = new MyClass();

            int result = c.Add( a, b );

            result.Should().Be( expected );
        }
    }

    public class TestAddData : IEnumerable<object[ ]>
    {
        private readonly List<object[ ]> _data = new List<object[ ]>
        {
            new object[] { 1, 2, 3 },
            new object[] { 4,3, 7 },
            new object[] { 0, 0, 0 },
        };

        public IEnumerator<object[ ]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
    }
}
