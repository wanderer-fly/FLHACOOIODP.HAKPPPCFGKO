using System.Buffers.Binary;
using System.Security.Cryptography;
using System.Text;
using FBEVJKGADQD.Common.OPLZFFRUAJP.NSAHOEBGVFP;

namespace FBEVJKGADQD.Common.OPLZFFRUAJP;
public static class FHFWWIHCNVD
{
    public static byte[] ZNYPCCYFNHY { get; }
    public static byte[] JKJUVVAHADS { get; }
    public static byte[] XGVQVUDGBVC { get; }

    static FHFWWIHCNVD()
    {
        ZNYPCCYFNHY = File.ReadAllBytes("assets/security/initial_key.bin");
        JKJUVVAHADS = File.ReadAllBytes("assets/security/initial_key.ec2b");
        XGVQVUDGBVC = File.ReadAllBytes("assets/security/client_public_key.der");
    }

    public static byte[] HHMACIKPGVA(ulong seed)
    {
        byte[] key = GC.AllocateUninitializedArray<byte>(0x1000);
        Span<byte> keySpan = key.AsSpan();

        TCAXAGEEPDY mt = new(seed);
        mt.Int63();

        for (int i = 0; i < 0x1000; i += 8)
        {
            BinaryPrimitives.WriteUInt64BigEndian(keySpan[i..], mt.Int63());
        }

        return key;
    }

    public static byte[] JRENKFLHPQK(ReadOnlySpan<byte> data)
    {
        using RSA cipher = RSA.Create();
        cipher.ImportSubjectPublicKeyInfo(XGVQVUDGBVC, out _);

        const int chunkSize = 256 - 11;
        int dataLength = data.Length;

        int numChunks = dataLength / chunkSize;
        if ((dataLength - chunkSize * numChunks) % chunkSize != 0) ++numChunks;

        if (numChunks < 2)
        {
            return cipher.Encrypt(data, RSAEncryptionPadding.Pkcs1);
        }

        using MemoryStream stream = new();
        for (int i = 0; i < numChunks; i++)
        {
            ReadOnlySpan<byte> chunk = data.Slice(i * chunkSize, Math.Min(dataLength, chunkSize));
            stream.Write(cipher.Encrypt(chunk, RSAEncryptionPadding.Pkcs1));

            dataLength -= chunkSize;
        }

        return stream.ToArray();
    }

    public static byte[] ZCNQFTFYYPC(string data, ReadOnlySpan<byte> key)
    {
        byte[] result = Encoding.UTF8.GetBytes(data);
        ZCNQFTFYYPC(result, key);

        return result;
    }

    public static void ZCNQFTFYYPC(Span<byte> data, ReadOnlySpan<byte> key)
    {
        for (int i = 0; i < data.Length; i++)
        {
            data[i] ^= key[i % key.Length];
        }
    }
}
