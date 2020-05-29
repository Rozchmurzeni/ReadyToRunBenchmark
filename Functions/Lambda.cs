using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Dependencies;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace Functions
{
    public class Lambda
    {
        public async Task InvokeAsync()
        {
            var usage = new DependencyUsage();
            await usage.DoSomeWorkAsync();
        }
    }
}
