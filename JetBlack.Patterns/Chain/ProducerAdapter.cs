namespace JetBlack.Patterns.Chain
{
    public class ProducerAdapter<TProduced, TAdapted>
    {
        private readonly IProducer<TProduced> _producer;
        private readonly IAdapter<TProduced, TAdapted> _adapter;

        public ProducerAdapter(IProducer<TProduced> producer, IAdapter<TProduced, TAdapted> adapter)
        {
            _producer = producer;
            _adapter = adapter;
        }

        public TAdapted Run()
        {
            return _adapter.Adapt(_producer.Produce());
        }
    }
}
