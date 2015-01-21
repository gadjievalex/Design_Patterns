
namespace BuilderPattern
{
    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartB();
        }
    }
}
