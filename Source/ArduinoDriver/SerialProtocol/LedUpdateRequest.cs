namespace ArduinoDriver.SerialProtocol
{
    public class LedUpdateRequest : ArduinoRequest
    {
        public LedUpdateRequest()
            :base(CommandConstants.LedUpdate)
        { 
        }
    }
}
