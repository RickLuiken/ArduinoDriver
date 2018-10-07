namespace ArduinoDriver.SerialProtocol
{
    class LedUpdateRequest : ArduinoRequest
    {
        public LedUpdateRequest()
            :base(CommandConstants.LedUpdate)
        { 
        }
    }
}
