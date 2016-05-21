namespace ValidationByDecoratorSamples
{
    public abstract class ServiceResult
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }
}