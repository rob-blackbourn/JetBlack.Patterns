namespace JetBlack.Patterns.Chain
{
    public class AdapterConsumer<TInput, TAdapted>
    {
        private readonly IAdapter<TInput, TAdapted> _adapter;
        private readonly IConsumer<TAdapted> _consumer;

        public AdapterConsumer(IAdapter<TInput, TAdapted> adapter, IConsumer<TAdapted> consumer)
        {
            _adapter = adapter;
            _consumer = consumer;
        }

        public void Run(TInput input)
        {
            _consumer.Consume(_adapter.Adapt(input));
        }
    }
}
