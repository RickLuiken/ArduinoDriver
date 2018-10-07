namespace ArduinoDriver.SerialProtocol
{
    public class LedClearRequest : ArduinoRequest
    {
        public LedClearRequest()
            :base(CommandConstants.LedClear)
        {
        }
    }
}
