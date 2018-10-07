namespace ArduinoDriver.SerialProtocol
{
    class LedClearRequest : ArduinoRequest
    {
        public LedClearRequest()
            :base(CommandConstants.LedClear)
        {
        }
    }
}
