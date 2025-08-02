using MyLibrary.Core.Domain.Common.Abstractions;

namespace MyLibrary.Test.XUnit.TestData.Models;

public sealed record TestContract : BaseContract<string>
{
    public TestContract()
    {
    }

    public TestContract(BaseContract<string> original) : base(original)
    {
    }

    public TestContract(string id) : base(id)
    {
    }
}
