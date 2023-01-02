# Varaani C# coding challenge - intermediate

## API Implementation Information

I have installed the swagger and made it the startup URL so that we can test the API methods. There are two API methods.

- `/api/v1/log/{start}/{end}` is the HTTPGET method, which takes the start and end time of the log and returns the logs that occured in between start and end both inclusive. if start or end value would be less than 1 or end value would be greater than start value, it would give the error.
- `/api/v1/log` is the HTTPPOST method, which takes the logRequest object that includes timestamp, severity and message. timestamp should be greater than 0 and message shouldn't be empty or null otherwise API would give an error.

Apart from the API methods, I have added some unit tests which validates the basic requests for both get log and add log method.

## Task

Implement an in-memory logging service that allows you to retrieve the entries in a specified date range.
Unlike a real-world logging service, it shouldn't persist the log entries on disk, otherwise care about
running out of memory, or accept them via any other means than local method calls. But otherwise imagine that it's
a service that accepts log entries from e.g. 10 servers.

The API to implement is documented in `logger/Logger.cs`

## Constraints

- Your app must run with .NET Core SDK 3.1.x
- You can use any external libraries if they make the code more clear, faster, or better in some sense

## Testing

We have our own set of unit tests that we'll run against your code. But we would like you to make your own set of
unit tests. There is a test skeleton in `test-logger/LoggerTest.cs`.
You can run the tests: `dotnet test test-logger\test-logger.csproj`.
