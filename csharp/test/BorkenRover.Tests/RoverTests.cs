namespace BrokenRover.Tests
{
    public class RoverTest
    {

        [Fact]
        public void SetX()
        {
        }

        [Fact]
        public void SetY()
        {
        }

        [Fact]
        public void SetOrientation()
        {
            Rover rover = new Rover();
            rover.SetOrientation("NORTH");
            Assert.Equal("NORTH", rover.GetOrientation());
        }

        [Fact]
        public void process()
        {
            var r = new Rover();
            r.SetX(2);
            r.SetY(3);
            r.SetOrientation("NORTH");

            r.process("LFFLFFF");

            Assert.Equal(0, r.GetX());
            Assert.Equal(0, r.GetY());
            Assert.Equal("SOUTH", r.GetOrientation());
        }

        [Fact]
        void Boundaries()
        {
            var r = new Rover();
            r.SetX(2);
            r.SetY(3);
            r.SetOrientation("NORTH");

            r.process("LFFFLFFFF");

            Assert.Equal(0, r.GetX());
            Assert.Equal(0, r.GetY());
            Assert.Equal("SOUTH", r.GetOrientation());
        }
    }
}