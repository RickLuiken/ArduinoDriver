namespace ArduinoDriver.SerialProtocol
{
    public class LedSetRequest : ArduinoRequest
    {
        public LedSetRequest(byte pinToWrite, ushort valueToWrite)
            :base(CommandConstants.LedSet)
        {
            Bytes.Add(pinToWrite);
            Bytes.Add((byte)(valueToWrite >> 4));
            Bytes.Add((byte)(valueToWrite & 0xe));
        }
    }
}
