using System;
using System.Linq;
using System.Threading.Tasks;
using TdLib;

namespace TDLib.Tests
{
    public static class Assert
    {
        public static void NotNull<T>(T instance) where T : class
        {
            if (instance == null) throw new Exception("Assertion failed: null");
        }

        public static void Equal<T>(T[] a, T[] b)
        {
            if (!a.SequenceEqual(b)) throw new Exception($"Assertion failed: {a} != {b}");
        }

        public static void Equal<T>(T a, T b)
        {
            if (!a.Equals(b)) throw new Exception($"Assertion failed: {a} != {b}");
        }
    }

    public class TdClientResultTests
    {
        public async Task Execute_WhenEmptyCallPassed_ReturnsOk()
        {
            using (var client = new TdClient())
            {
                var result = await client.ExecuteAsync(new TdApi.TestCallEmpty());

                Assert.NotNull(result);
            }
        }

        public async Task Execute_WhenStringPassed_ReturnsTheSameString()
        {
            using (var client = new TdClient())
            {
                var arg = "test";
                var result = await client.ExecuteAsync(new TdApi.TestCallString
                {
                    X = arg
                });

                Assert.NotNull(result);
                Assert.NotNull(result.Value);
                Assert.Equal(arg, result.Value);
            }
        }

        public async Task Execute_WhenByteArrayPassed_ReturnsTheSameByteArray()
        {
            using (var client = new TdClient())
            {
                var arg = new byte[] {1, 2, 3};
                var result = await client.ExecuteAsync(new TdApi.TestCallBytes
                {
                    X = arg
                });

                Assert.NotNull(result);
                Assert.NotNull(result.Value);
                Assert.Equal(arg, result.Value);
            }
        }

        public async Task Execute_WhenIntArrayPassed_ReturnsTheSameArray()
        {
            using (var client = new TdClient())
            {
                var arg = new [] {1, 2, 3};
                var result = await client.ExecuteAsync(new TdApi.TestCallVectorInt
                {
                    X = arg
                });

                Assert.NotNull(result);
                Assert.NotNull(result.Value);
                Assert.Equal(arg, result.Value);
            }
        }

        public async Task Execute_WhenStringArrayPassed_ReturnsTheSameArray()
        {
            using (var client = new TdClient())
            {
                var arg = new[] {"foo", "bar"};
                var result = await client.ExecuteAsync(new TdApi.TestCallVectorString
                {
                    X = arg
                });

                Assert.NotNull(result);
                Assert.NotNull(result.Value);
                Assert.Equal(arg, result.Value);
            }
        }

        public static async Task Main()
        {
            var instance = new TdClientResultTests();
            Console.WriteLine("Execute_WhenEmptyCallPassed_ReturnsOk");
            await instance.Execute_WhenEmptyCallPassed_ReturnsOk();

            Console.WriteLine("Execute_WhenStringPassed_ReturnsTheSameString");
            await instance.Execute_WhenStringPassed_ReturnsTheSameString();

            Console.WriteLine("Execute_WhenByteArrayPassed_ReturnsTheSameByteArray");
            await instance.Execute_WhenByteArrayPassed_ReturnsTheSameByteArray();

            Console.WriteLine("Execute_WhenIntArrayPassed_ReturnsTheSameArray");
            await instance.Execute_WhenIntArrayPassed_ReturnsTheSameArray();

            Console.WriteLine("Execute_WhenStringArrayPassed_ReturnsTheSameArray");
            await instance.Execute_WhenStringArrayPassed_ReturnsTheSameArray();
        }
    }
}
