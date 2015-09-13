namespace JetBlack.Patterns.Chain
{
    public interface IConsumer<in TInput>
    {
        void Consume(TInput input);
    }
}
