namespace ArduinoDriver.SerialProtocol
{
    class LedSetResponse : ArduinoResponse
    {
        public int tlcPinWritten { get; private set; }
        public int valueWritten { get; private set; }

        public LedSetResponse(byte pinWritten, byte upperValue, byte lowerValue) {
            tlcPinWritten = pinWritten;
            valueWritten = (upperValue << 4) + lowerValue;
        }  
    }
}
