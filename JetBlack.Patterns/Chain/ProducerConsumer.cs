namespace JetBlack.Patterns.Chain
{
    public class ProducerConsumer<T>
    {
        private readonly IProducer<T> _producer;
        private readonly IConsumer<T> _consumer;

        public ProducerConsumer(IProducer<T> producer, IConsumer<T> consumer)
        {
            _producer = producer;
            _consumer = consumer;
        }

        public void Run()
        {
            _consumer.Consume(_producer.Produce());
        }
    }

    public class ProducerConsumer<TSource, TDestination>
    {
        private readonly IProducer<TSource> _producer;
        private readonly IAdapter<TSource, TDestination> _adapter;
        private readonly IConsumer<TDestination> _consumer;

        public ProducerConsumer(IProducer<TSource> producer, IAdapter<TSource, TDestination> adapter, IConsumer<TDestination> consumer)
        {
            _producer = producer;
            _adapter = adapter;
            _consumer = consumer;
        }

        public void Run()
        {
            _consumer.Consume(_adapter.Adapt(_producer.Produce()));
        }
    }
}
