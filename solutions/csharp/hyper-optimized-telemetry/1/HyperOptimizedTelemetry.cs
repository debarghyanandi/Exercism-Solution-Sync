
using System;

public static class TelemetryBuffer
{
    private const int BufferSize = 9;

    public static byte[] ToBuffer(long reading)
    {
        int byteCount;
        bool signed;
        byte[] data;

        if (reading >= ushort.MinValue && reading <= ushort.MaxValue)
        {
            byteCount = 2; signed = false;
            data = BitConverter.GetBytes((ushort)reading);
        }
        else if (reading >= short.MinValue && reading <= short.MaxValue)
        {
            byteCount = 2; signed = true;
            data = BitConverter.GetBytes((short)reading);
        }
        else if (reading >= int.MinValue && reading <= int.MaxValue)
        {
            byteCount = 4; signed = true;
            data = BitConverter.GetBytes((int)reading);
        }
        else if (reading >= uint.MinValue && reading <= uint.MaxValue)
        {
            byteCount = 4; signed = false;
            data = BitConverter.GetBytes((uint)reading);
        }
        else
        {
            byteCount = 8; signed = true;
            data = BitConverter.GetBytes(reading);
        }

        byte[] result = new byte[BufferSize];
        result[0] = signed ? (byte)(256 - byteCount) : (byte)byteCount;
        Array.Copy(data, 0, result, 1, data.Length);
        return result;
    }
        
    public static long FromBuffer(byte[] buffer)
    {
        byte prefix = buffer[0];
        int byteCount = prefix <= 8? prefix : 256 - prefix;
        bool signed = prefix >  8;

        switch (byteCount)
        {
            case 2:
                return signed 
                    ? BitConverter.ToInt16(buffer, 1)
                    : BitConverter.ToUInt16(buffer, 1);
                    
            case 4:
                return signed 
                    ? BitConverter.ToInt32(buffer, 1)
                    : BitConverter.ToUInt32(buffer, 1);

            case 8:
                return signed 
                    ? BitConverter.ToInt64(buffer, 1)
                    : (long)BitConverter.ToUInt64(buffer, 1);

                default:
                return 0;
        }


        
    }
}