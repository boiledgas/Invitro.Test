namespace Test.Invitro.Task.Task2
{
    public class Test
    {
        public string Id { get; set; }

        public long? Count { get; set; }

        public string Name { get; set; }

        public int? Number { get; set; }

        public bool ShouldSerializeCount() => Count.HasValue;

        public bool ShouldSerializeNumber() => Number.HasValue;
    }
}
