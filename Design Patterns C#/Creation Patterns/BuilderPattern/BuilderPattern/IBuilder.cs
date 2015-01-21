
namespace BuilderPattern
{
    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();

        Product GetResult();
    }
}
