namespace JetBlack.Patterns.Chain
{
    public interface IAdapter<in TInput, out TOutput>
    {
        TOutput Adapt(TInput input);
    }
}
