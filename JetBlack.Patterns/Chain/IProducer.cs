namespace JetBlack.Patterns.Chain
{
    public interface IProducer<out TOutput>
    {
        TOutput Produce();
    }
}
