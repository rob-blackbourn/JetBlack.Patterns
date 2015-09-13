namespace JetBlack.Patterns.Chain
{
    public class AdapterAdapter<TInput, TIntermediate, TOutput> : IAdapter<TInput, TOutput>
    {
        private readonly IAdapter<TInput, TIntermediate> _inputAdapter;
        private readonly IAdapter<TIntermediate, TOutput> _outputAdapter;

        public AdapterAdapter(IAdapter<TInput, TIntermediate> inputAdapter, IAdapter<TIntermediate, TOutput> outputAdapter)
        {
            _inputAdapter = inputAdapter;
            _outputAdapter = outputAdapter;
        }

        public TOutput Adapt(TInput input)
        {
            return _outputAdapter.Adapt(_inputAdapter.Adapt(input));
        }
    }
}
