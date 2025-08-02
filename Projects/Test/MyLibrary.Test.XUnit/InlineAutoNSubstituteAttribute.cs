using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.Xunit2;

namespace MyLibrary.Test.XUnit;

public sealed class InlineAutoNSubstituteAttribute
        : AutoDataAttribute
{
    public InlineAutoNSubstituteAttribute()
            : base(() => new Fixture().Customize(new AutoNSubstituteCustomization()))
    {

    }
}
