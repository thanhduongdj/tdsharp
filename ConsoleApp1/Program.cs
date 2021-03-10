using System;
using System.Linq;
using System.Threading.Tasks;
using TdLib;

namespace TDLib.Tests
{
    public static class Program
    {
        private static async Task RunTdClientDisposeTests()
        {
            var instance = new TdClientDisposeTests();

            Console.WriteLine("Dispose_WhenCalled_DoesNotThrowException");
            await instance.Dispose_WhenCalled_DoesNotThrowException();

            Console.WriteLine("Dispose_WhenCalledTwice_DoesNotThrowException");
            await instance.Dispose_WhenCalledTwice_DoesNotThrowException();

            Console.WriteLine("Dispose_WhenCalledOnDifferentClients_DoesNotThrowException");
            await instance.Dispose_WhenCalledOnDifferentClients_DoesNotThrowException();
        }

        private static async Task RunTdClientErrorTests()
        {
            var instance = new TdClientErrorTests();

            Console.WriteLine("Execute_WhenErrorExpected_ThrowsTdException");
            await instance.Execute_WhenErrorExpected_ThrowsTdException();
        }

        private static async Task RunTdClientResultTests()
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

        public static async Task Main()
        {
            Console.WriteLine("# RunTdClientDisposeTests");
            await RunTdClientDisposeTests();

            Console.WriteLine("# RunTdClientErrorTests");
            await RunTdClientErrorTests();

            Console.WriteLine("# RunTdClientResultTests");
            await RunTdClientResultTests();
        }
    }
}
