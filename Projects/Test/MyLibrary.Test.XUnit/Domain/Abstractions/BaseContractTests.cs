using MyLibrary.Core.Domain.Common.Models;
using MyLibrary.Test.XUnit.TestData.Models;

namespace MyLibrary.Test.XUnit.Domain.Abstractions;

public class BaseContractTests
{
    [Theory]
    [InlineAutoNSubstitute]
    public void SetId_IsAlreadySet_Throws(
        string id,
        TestContract sut)
    {
        // Arrange
        sut.SetId(id);

        // Act
        var act = () => sut.SetId(id);

        // Assert
        var result = Assert.Throws<ArgumentException>(nameof(id), act);

        Assert.Equal("Id is already set. (Parameter 'id')", result.Message);
    }

    [Theory]
    [InlineAutoNSubstitute]
    public void SetId_IsNotSet_SetsId(
        string id,
        TestContract sut)
    {
        // Arrange, Act
        sut.SetId(id);

        // Assert
        Assert.NotNull(sut.Id);

        Assert.Equal(id, sut.Id);
    }

    [Theory]
    [InlineAutoNSubstitute]
    public void SetCreatedInfo_IsAlreadySet_Throws(
        EventDetails eventDetails,
        TestContract sut)
    {
        // Arrange
        sut.SetCreatedInfo(eventDetails);

        // Act
        var act = () => sut.SetCreatedInfo(eventDetails);

        // Assert
        var result = Assert.Throws<ArgumentException>(nameof(eventDetails), act);

        Assert.Equal("Created information is already set. (Parameter 'eventDetails')", result.Message);
    }

    [Theory]
    [InlineAutoNSubstitute]
    public void SetCreatedInfo_IsNotSet_SetsCreatedInfo(
        EventDetails eventDetails,
        TestContract sut)
    {
        // Arrange, Act
        sut.SetCreatedInfo(eventDetails);

        // Assert
        Assert.NotNull(sut.Created);

        Assert.Equal(eventDetails, sut.Created);
    }

    [Theory]
    [InlineAutoNSubstitute]
    public void SetLastModifiedInfo_EventDetailsHasTimestampBeforeCurrentTimestamp_Throws(
        EventDetails currentLastModifiedDetails,
        TestContract sut)
    {
        // Arrange
        sut.SetLastModifiedInfo(currentLastModifiedDetails);

        EventDetails eventDetails = currentLastModifiedDetails with
        {
            Timestamp = currentLastModifiedDetails.Timestamp?.AddMinutes(-1)
        };

        // Act
        var act = () => sut.SetLastModifiedInfo(eventDetails);

        // Assert
        var result = Assert.Throws<ArgumentException>(nameof(eventDetails), act);

        Assert.Equal(
            "Last modified information must have a later dateTime than the current last modified time. (Parameter 'eventDetails')",
            result.Message);
    }

    [Theory]
    [InlineAutoNSubstitute]
    public void SetLastModifiedInfo_EventDetailsHasSameTimestamp_Throws(
        EventDetails currentLastModifiedDetails,
        TestContract sut)
    {
        // Arrange
        sut.SetLastModifiedInfo(currentLastModifiedDetails);

        EventDetails eventDetails = currentLastModifiedDetails with
        {
            Timestamp = currentLastModifiedDetails.Timestamp
        };

        // Act
        var act = () => sut.SetLastModifiedInfo(eventDetails);

        // Assert
        var result = Assert.Throws<ArgumentException>(nameof(eventDetails), act);

        Assert.Equal(
            "Last modified information must have a later dateTime than the current last modified time. (Parameter 'eventDetails')",
            result.Message);
    }


    [Theory]
    [InlineAutoNSubstitute]
    public void SetLastModifiedInfo_IsNotSet_SetsLastModifiedInfo(
        EventDetails eventDetails,
        TestContract sut)
    {
        // Arrange, Act
        sut.SetLastModifiedInfo(eventDetails);

        // Assert
        Assert.NotNull(sut.LastModified);

        Assert.Equal(eventDetails, sut.LastModified);
    }
}
